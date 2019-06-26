using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Diary.Web.Models;
using Diary.CQRS.Reporting;
using Diary.CQRS.Commands;
using Diary.CQRS.Exceptions;
using Diary.CQRS.Messaging;

namespace Diary.Web.Controllers
{
    public class HomeController : Controller
    {
        private static ICommandBus _commandBus;
        private static IReportDatabase _reportDatabase;

        public HomeController(ICommandBus commandBus, IReportDatabase reportDatabase)
        {
            _commandBus = commandBus;
            _reportDatabase = reportDatabase;
        }

        public IActionResult Index()
        {
            var model = _reportDatabase.GetItems();
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Delete(Guid id)
        {
            var item = _reportDatabase.GetById(id);
            _commandBus.Send(new DeleteItemCommand(item.Id, item.Version));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(DiaryItemDto item)
        {
            _commandBus.Send(new CreateItemCommand(Guid.NewGuid(), item.Title, item.Description, item.From, item.To, -1));

            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var item = _reportDatabase.GetById(id);
            var model = new DiaryItemDto()
            {
                Description = item.Description,
                From = item.From,
                Id = item.Id,
                Title = item.Title,
                To = item.To,
                Version = item.Version
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(DiaryItemDto item)
        {
            try
            {
                _commandBus.Send(new ChangeItemCommand(item.Id, item.Title, item.Description, item.From, item.To, item.Version));
            }
            catch (ConcurrencyException err)
            {

                ViewBag.error = err.Message;
                ModelState.AddModelError("", err.Message);
                return View();
            }

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
