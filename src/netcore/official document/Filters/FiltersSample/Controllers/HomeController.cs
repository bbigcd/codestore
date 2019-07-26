using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltersSample.Models;
using FiltersSample.Filters;
using System.Globalization;

namespace FiltersSample.Controllers
{
    public class HomeController : Controller
    {
        [ServiceFilter(typeof(AddHeaderResultServiceFilter))]
        public IActionResult Index()
        {
            return View();
        }

        [AddHeader("Author", "Steve Smith @ardalis")]
        public IActionResult Hello(string name)
        {
            return Content($"Hello {name}");
        }

        [TypeFilter(typeof(LogConstantFilter),
           Arguments = new object[] { "Method 'Hi' called" })]
        public IActionResult Hi(string name)
        {
            return Content($"Hi {name}");
        }

        [Route("{culture}/[controller]/[action]")]
        [MiddlewareFilter(typeof(LocalizationPipeline))]
        public IActionResult CultureFromRouteData()
        {
            return Content($"CurrentCulture:{CultureInfo.CurrentCulture.Name},"
                   + $"CurrentUICulture:{CultureInfo.CurrentUICulture.Name}");
        }

        [SampleActionFilter]
        public IActionResult FilterTest()
        {
            return Content($"From FilterTest");
        }

        [TypeFilter(typeof(SampleActionFilterAttribute))]
        public IActionResult TypeFilterTest()
        {
            return Content($"From ServiceFilterTest");
        }


        // ServiceFilter must be registered in ConfigureServices or
        // System.InvalidOperationException: No service for type '<filter>' has been registered.
        // Is thrown.
        [ServiceFilter(typeof(SampleActionFilterAttribute))]
        public IActionResult ServiceFilterTest()
        {
            return Content($"From ServiceFilterTest");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
