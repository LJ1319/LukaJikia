using System.Net;

namespace Practice.Middlewares
{
    public class GlobalExceptionHandlingMiddleware
    {
        public static string logPath = @"C:\Users\LJ\source\repos\LukaJikia\Day_34\Practice\Practice\Data\Logs\Logs.txt";

        private readonly RequestDelegate _next;

        public GlobalExceptionHandlingMiddleware(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                await LogAsync(context.Response.StatusCode, e);
            }
        }

        public async Task LogAsync(int httpStatusCode, Exception e)
        {
            var toLog = $"\rLog Entry: {DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}:\n Exception {e} occured with httpStatusCode: {httpStatusCode}. \n";
            await File.AppendAllTextAsync(logPath, toLog);
        }
    }
}
