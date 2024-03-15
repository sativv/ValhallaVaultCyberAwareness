namespace ValhallaVaultCyberAwareness.Middleware
{
    //Hela denna är code along från youtube
    public class TimingMiddleware(ILogger<TimingMiddleware> logger, RequestDelegate next)
    {
        private readonly ILogger<TimingMiddleware> logger = logger;
        private readonly RequestDelegate next = next;

        public async Task Invoke(HttpContext ctx)
        {
            var start = DateTime.UtcNow;
            await next.Invoke(ctx);
            logger.LogInformation($"Timing: {ctx.Request.Path}: {(DateTime.UtcNow - start).TotalMilliseconds} ms");
        }
    }

    public static class TimingExtensions
    {
        //Det här var för att kunna göra snyggare i program.cs
        public static IApplicationBuilder UseTiming(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TimingMiddleware>();
        }

        //public static void AddTiming(this IServiceCollection services)
        //{
        //    services.AddTransient<ITiming, SomeTiming>();
        //}
    }
}
