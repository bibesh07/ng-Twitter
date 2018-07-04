using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ng_Twitter
{


    public class ErrorHandlingMiddleware : IFilterMetadata
    {
        private static IConfiguration Configuration { get; set; }
        
        public ErrorHandlingMiddleware(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next) => this.next = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var errorId = string.Format("{0:X}", Guid.NewGuid().GetHashCode());
            var errorCode = HttpStatusCode.InternalServerError;

            ReportError(exception);

            var result = JsonConvert.SerializeObject(new
            {
                error = exception.Message,
                referenceId = errorId
            });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)errorCode;
            return context.Response.WriteAsync(result);

        }

        private static void ReportError(Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.InnerException?.Message);
        }

    }
}