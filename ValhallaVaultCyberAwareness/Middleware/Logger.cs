using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

namespace ValhallaVaultCyberAwareness.Middleware
{

    public class Logger
    {

        private readonly ILogger<Logger> _logger;

        private readonly RequestDelegate _next;



        public Logger(RequestDelegate next, ILogger<Logger> logger)
        {
            _next = next;

            _logger = logger;


        }


        public async Task InvokeAsync(HttpContext context, ValhallaUow uow)
        {

            if (context.Request.Path == "/adminoverview")
            {
                _logger.LogInformation($"Admin viewed user results at {DateTime.UtcNow.ToLongTimeString()}");



                LoggerModel adminlog = new()
                {
                    user = context.User.Identity.Name,
                    dateTimeAccessed = DateTime.UtcNow,
                    Page = context.Request.Path
                };
                await uow.LogRepo.AddAsync(adminlog);
            }
            else if (context.Request.Path == "/Home" || context.Request.Path == "/" || context.Request.Path == "")
            {


                _logger.LogInformation($"{context.Request.Path} visited at {DateTime.UtcNow.ToLongTimeString()} by {context.User.Identity.Name}");

                LoggerModel log = new()
                {
                    user = context.User.Identity.Name,
                    dateTimeAccessed = DateTime.UtcNow,
                    Page = context.Request.Path
                };

                await uow.LogRepo.AddAsync(log);
            }
            await _next(context);


        }

    }
}
