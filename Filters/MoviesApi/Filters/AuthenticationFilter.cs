using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MoviesApi.Filters
{
    public class AuthenticationFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string header = context.HttpContext.Request.Headers["Authorization"];
            if (header is null)
            {
                context.Result = new ObjectResult("Authorization header is required.")
                {
                    StatusCode = 401
                };
            }
        }

    }
}
