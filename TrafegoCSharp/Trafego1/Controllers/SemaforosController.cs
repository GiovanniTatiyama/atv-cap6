using Microsoft.AspNetCore.Mvc;
using Trafego1.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Trafego1.Data.Contexts;

namespace Trafego1.Controllers
{
    public class SemaforosController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private List<Semaforos> semaforos;

        public SemaforosController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            semaforos = databaseContext.Semaforos.ToList();
        }

        public IActionResult Index()
        {
            return View(semaforos);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Semaforos semaforos)
        {
            _databaseContext.Semaforos.Add(semaforos);
            _databaseContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var semaforo = _databaseContext.Semaforos.Find(id);
            if (semaforo == null)
            {
                return NotFound();
            }
            return View(semaforo);
        }

        [HttpPost]
        public IActionResult Edit(Semaforos semaforos)
        {
            try
            {
                var existingSemaforos = _databaseContext.Semaforos.Find(semaforos.SemaforosId);
                if (existingSemaforos == null)
                {
                    return NotFound();
                }

               
                _databaseContext.Entry(existingSemaforos).State = EntityState.Detached;

                
                existingSemaforos.Localizacao = semaforos.Localizacao;
                existingSemaforos.FluxoTrafego = semaforos.FluxoTrafego;

                
                _databaseContext.Semaforos.Update(existingSemaforos);
                _databaseContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                
                return View(semaforos); 
            }
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var semaforo = _databaseContext.Semaforos.Find(id);
            if (semaforo == null)
            {
                return NotFound();
            }
            return View(semaforo);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var semaforo = _databaseContext.Semaforos.Find(id);
            if (semaforo == null)
            {
                return NotFound();
            }
            _databaseContext.Semaforos.Remove(semaforo);
            _databaseContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
