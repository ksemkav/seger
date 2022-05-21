using Microsoft.AspNetCore.Builder;

namespace Seger.App.Middleware
{
    public static class SignOutLockedUserMiddlewareExtensions
    {
        public static IApplicationBuilder UseSignOutLockedUser(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SignOutLockedUserMiddleware>();
        }
    }
}
