using System;
using System.Globalization;

namespace Middleware.Example
{
    public class LoginMiddleware
    {
        private readonly RequestDelegate _next;

        public LoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;
            var schema = request.Scheme;
            var host = request.Host;
            var path = request.Path;
            var queryString = request.QueryString;
            var requestBody = request.Body;

            string result = $"Schema: {schema}, Host: {host}, Path: {path}, QueryString: {queryString}, Body: {requestBody}";

            // Console.WriteLine(result);
            using StreamWriter file = new("Results.txt", append: true);
            await file.WriteLineAsync(result);
            await _next(context);
        }
    }
}


