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
    [AddHeader("Author", "bbigcd")]
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 被过滤器中断，未能设置head，直接被返回了数据
        /// </summary>
        /// <returns></returns>
        [ShortCircuitingResourceFilter]
        public IActionResult SomeResource()
        {
            return Content("Successful access to resource - header is set.");
        }

        [AddHeaderWithFactory]
        public IActionResult HeaderWithFactory()
        {
            return Content("Examine the headers using the F12 developer tools.");
        }
    }
}
