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

        public HomeController(FakeBus bus, ReadModelFacade readmodel)
        {
            _bus = bus;
            _readmodel = readmodel;
        }

        public IActionResult Index()
        {
            var model = _readmodel.GetInventoryItems();
         
            return View(model);
        }

        public IActionResult Details(Guid id)
        {
            var model = _readmodel.GetInventoryItemDetails(id);
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromForm]AddModel add)
        {
            Console.WriteLine(" 输出:  " + add.Name);
            _bus.Send(new CreateInventoryItem(Guid.NewGuid(), add.Name));

            return RedirectToAction("Index");
        }

         public IActionResult ChangeName(Guid id)
        {
            var mode = _readmodel.GetInventoryItemDetails(id);
            return View(mode);
        }

        [HttpPost]
        public IActionResult ChangeName(Guid id, string name, int version)
        {
            var command = new RenameInventoryItem(id, name, version);
            _bus.Send(command);

            return RedirectToAction("Index");
        }

        public IActionResult Deactivate(Guid id)
        {
            var mode = _readmodel.GetInventoryItemDetails(id);
            return View(mode);
        }

        [HttpPost]
        public IActionResult Deactivate(Guid id, int version)
        {
            _bus.Send(new DeactivateInventoryItem(id, version));
            return RedirectToAction("Index");
        }

        public IActionResult CheckIn(Guid id)
        {
            var mode = _readmodel.GetInventoryItemDetails(id);
            return View(mode);
        }

        [HttpPost]
        public IActionResult CheckIn(Guid id, int number, int version)
        {
            _bus.Send(new CheckInItemsToInventory(id, number, version));
            return RedirectToAction("Index");
        }

        public IActionResult Remove(Guid id)
        {
            var mode = _readmodel.GetInventoryItemDetails(id);
            return View(mode);
        }

        [HttpPost]
        public IActionResult Remove(Guid id, int number, int version)
        {
            _bus.Send(new RemoveItemsFromInventory(id, number, version));
            return RedirectToAction("Index");
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
