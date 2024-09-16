
namespace WEBAPI.Middleware
{
    public class RoleCheck : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
