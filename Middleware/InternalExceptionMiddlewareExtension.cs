namespace TemplateRestAPI.Middleware
{
    public static class InternalExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseInternalExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<InternalExceptionMiddleware>();
        }

        
    }
}
