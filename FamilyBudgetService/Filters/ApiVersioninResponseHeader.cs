using Microsoft.AspNetCore.Mvc.Filters;

namespace FamilyBudgetService.Api.Filters
{
    public class ApiVersionInResponseHeader : Attribute, IAlwaysRunResultFilter
    {
        private readonly string _apiVersion;
        public ApiVersionInResponseHeader(string apiVersion)
        {
            _apiVersion = apiVersion;
        }

        public void OnResultExecuted(ResultExecutedContext context){}

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("api=version", _apiVersion);
        }
    }
}
