using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using Trafego1.Data.Contexts;
using Trafego1.Models;

namespace Trafego1.Controllers
{
    public class TrafegoController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly ILogger<TrafegoController> _logger;

        public TrafegoController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

        }

        public IActionResult Index()
        {
            var trafegos = _databaseContext.Trafegos.ToList();
            return View(trafegos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Trafego trafego)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Trafegos.Add(trafego);
                _databaseContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trafego);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var trafego = _databaseContext.Trafegos.Find(id);
            if (trafego == null)
            {
                return NotFound();
            }

            return View(trafego);
        }

        [HttpPost]
        public IActionResult Edit(Trafego trafego)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Trafegos.Update(trafego);
                _databaseContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trafego);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var trafego = _databaseContext.Trafegos.Find(id);
            if (trafego == null)
            {
                return NotFound();
            }

            return View(trafego);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Console.Write("entrou");
            try
            {
                var trafego = _databaseContext.Trafegos.Find(id);
                if (trafego == null)
                {
                    return NotFound();
                }

                _databaseContext.Trafegos.Remove(trafego);
                _databaseContext.SaveChanges();

                
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                
                _logger.LogError(ex, "Erro ao tentar deletar o objeto Trafego.");

                
                return RedirectToAction("Index");
            }
        }

    }
}

