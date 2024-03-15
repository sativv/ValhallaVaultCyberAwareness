
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Middleware
{
    public class VisitorCounterMiddleware(ApplicationDbContext dbContext) : IMiddleware
    {
        private readonly ApplicationDbContext dbContext = dbContext;

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //Hämtar värdet i nyckeln VisitorId
            string visitorId = context.Request.Cookies["VisitorId"];

            if (visitorId == null)
            {
                //Vi har en ny användare eller någon som har rensat sina cookies
                await dbContext.Visitors.AddAsync(new VisitorCounterModel());
                await dbContext.SaveChangesAsync();

                //Skapa en cookie som heter VisitorId så den hämtas nästa gång och det inte skapas en ny användare
                context.Response.Cookies.Append("VisitorId", Guid.NewGuid().ToString(), new CookieOptions()
                {
                    Path = "/",
                    HttpOnly = true,
                    Secure = false,
                });
            }

            await next(context);
        }
    }

    public static class VisitorCounterExtensions
    {
        public static IApplicationBuilder UseVisitorCounter(this IApplicationBuilder app)
        {
            return app.UseMiddleware<VisitorCounterMiddleware>();
        }
    }
}
