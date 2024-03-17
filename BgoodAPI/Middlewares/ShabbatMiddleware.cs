namespace BgoodAPI.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next) { 
        _next= next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            DateTime day = DateTime.Now;
            if (day.DayOfWeek.ToString() == "Saturday")
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            else
            {
                await _next(context);
            }
        }
    }
}
