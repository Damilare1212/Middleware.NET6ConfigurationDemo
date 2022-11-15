﻿using MiddlewareNET6Demo.Middleware;

namespace  MiddlewareNET6Demo.Extensions
{
     public static class MiddlewareExtensions
     {
        /// <summary>
        /// Adds the Layout middleware, which does not change processing at all.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        
        public static IApplicationBuilder UseLayoutMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LayoutMiddleware>();
        }

        ///  <summary>
        ///  Adds the Simple Response middleware, which immediately returns a response.
        ///  </summary>
        ///  <param name="builder"></param>
        ///  <returns></returns>
        public static IApplicationBuilder  UseSimpleResponseMiddleware(this IApplicationBuilder builder)
        {
          return builder.UseMiddleware<SimpleResponseMiddleware>();
        }

        /// <summary>
        /// Adds the Logging middleware, which logs the incoming request's path.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }

        /// <summary>
        /// Adds the Culture middleware, which sets the current culture based on the query string.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseCultureMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }

        ///  <summary>
        ///  Adds the time logging middleware, which logs how long it takes for the system to return a response.
        ///  </summary>
        ///  <param name="builder"></param>
        ///  <returns></returns>
        public static IApplicationBuilder UseTimeLoggingMiddlewareI(this IApplicationBuilder builder)
        {
           return builder.UseMiddleware<TimeLoggingMiddleware>();
        }

        ///  <summary>
        ///  Adds the intentional delay middleware, which makes the pipeline pause for 100ms both on request and again on response.
        ///  </summary>
        ///  <param name="builder"></param>
        ///  <returns></returns>
        public static IApplicationBuilder UseIntentionalDelayMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IntentionalDelayMiddleware>();
        }
    }
}
