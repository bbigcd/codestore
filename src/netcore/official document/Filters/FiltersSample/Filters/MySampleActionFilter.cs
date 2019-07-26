using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersSample.Filters
{
    public class MySampleActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            Console.WriteLine("MySampleActionFilter - after the action executes");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            Console.WriteLine("MySampleActionFilter - before the action executes");
        }
    }
}