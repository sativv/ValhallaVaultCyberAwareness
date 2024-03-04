using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Components;
using ValhallaVaultCyberAwareness.Components.Account;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<ValhallaUow>();
builder.Services.AddScoped<CategoryRepo>();

builder.Services.AddControllers();

builder.Services.AddAuthentication(options =>
	{
		options.DefaultScheme = IdentityConstants.ApplicationScheme;
		options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
	})
	.AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
	.AddRoles<IdentityRole>()
	.AddEntityFrameworkStores<ApplicationDbContext>()
	.AddSignInManager()
	.AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

//Skapa users och roller som ska finnas med från start
using (ServiceProvider serviceProvider = builder.Services.BuildServiceProvider())
{
	var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
	var signInManager = serviceProvider.GetRequiredService<SignInManager<ApplicationUser>>();
	var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
	//Kör en update-database om det inte har gjorts än
	context.Database.Migrate();

	ApplicationUser newAdmin = new()
	{
		UserName = "admin",
		Email = "admin@gmail.com",
		EmailConfirmed = true,

	};
	ApplicationUser newUser = new()
	{
		UserName = "user",
		Email = "user@gmail.com",
		EmailConfirmed = true,
	};
	//GetAwaiter().GetResult() är för att async metoden ska köras synkront
	var admin = signInManager.UserManager.FindByEmailAsync(newAdmin.Email).GetAwaiter().GetResult();
	var user = signInManager.UserManager.FindByEmailAsync(newUser.Email).GetAwaiter().GetResult();

	if (user == null)
	{
		//Skapa en user
		signInManager.UserManager.CreateAsync(newUser, "Password1234!").GetAwaiter().GetResult();
	}

	if (admin == null)
	{
		//Skapa en admin
		signInManager.UserManager.CreateAsync(newAdmin, "Password1234!").GetAwaiter().GetResult();

		//Kolla om adminrollen existerar
		bool adminRoleExists = roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult();

		if (!adminRoleExists)
		{
			//Skapa adminrollen
			IdentityRole adminRole = new() { Name = "Admin" };
			roleManager.CreateAsync(adminRole).GetAwaiter().GetResult();
		}

		//Tilldela adminrollen till den nya användaren
		signInManager.UserManager.AddToRoleAsync(newAdmin, "Admin").GetAwaiter().GetResult();
	}
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.MapControllers();

app.Run();
