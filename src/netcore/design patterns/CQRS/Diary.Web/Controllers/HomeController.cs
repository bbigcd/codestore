using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Diary.Web.Models;
using Diary.CQRS;

namespace Diary.Web.Controllers
{
    public class HomeController : Controller
    {
        private FakeBus _bus;
        private ReadModelFacade _readmodel;

        public HomeController()
        {
            _bus = ServiceLocator.Bus;
            _readmodel = new ReadModelFacade();
        }

        public IActionResult Index()
        {
            var model = _readmodel.GetInventoryItems();
         
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
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
