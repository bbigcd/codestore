using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FiltersSample.Models;
using FiltersSample.Filters;

namespace FiltersSample.Controllers
{
    [TypeFilter(typeof(CustomExceptionFilterAttribute))]
    public class FailingController : Controller
    {
        [AddHeader("FailingController", "This shouldn't appear if exception was handled.")]
        public IActionResult Index()
        {
            throw new Exception("Boom!");
        }
    }
}
