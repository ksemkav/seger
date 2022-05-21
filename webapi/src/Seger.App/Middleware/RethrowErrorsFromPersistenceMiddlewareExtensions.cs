using Microsoft.AspNetCore.Builder;

namespace Seger.App.Middleware
{
    public static class RethrowErrorsFromPersistenceMiddlewareExtensions
    {
        /// <summary>
        /// Adds a middleware to handle exceptions, including custom ones.
        /// </summary>
        /// <returns>The <see cref="IApplicationBuilder"/> instance.</returns>
        public static IApplicationBuilder UseRethrowErrorsFromPersistence(
            this IApplicationBuilder app
        )
        {
            return app.UseMiddleware<RethrowErrorsFromPersistenceMiddleware>();
        }
    }
}
