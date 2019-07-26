using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltersSample.Models;
using FiltersSample.Filters;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersSample.Controllers
{
    public class TestController : Controller
    {
        [SampleActionFilter]
        public IActionResult FilterTest2()
        {
            return Content($"From FilterTest2");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            base.OnActionExecuted(context);
        }
    }
}
