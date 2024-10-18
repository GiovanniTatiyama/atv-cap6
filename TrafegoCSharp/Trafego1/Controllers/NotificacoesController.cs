using Microsoft.AspNetCore.Mvc;
using Trafego1.Models;
using System.Collections.Generic;
using Trafego1.Data.Contexts;
using System.Linq;

namespace Trafego1.Controllers
{
    public class NotificacoesController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public NotificacoesController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            var notificacoes = _databaseContext.Notificacoes.ToList();
            return View(notificacoes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Notificacoes notificacao)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Notificacoes.Add(notificacao);
                _databaseContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notificacao);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var notificacao = _databaseContext.Notificacoes.Find(id);
            if (notificacao == null)
            {
                return NotFound();
            }
            return View(notificacao);
        }

        [HttpPost]
        public IActionResult Edit(Notificacoes notificacao)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Notificacoes.Update(notificacao);
                _databaseContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notificacao);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var notificacao = _databaseContext.Notificacoes.Find(id);
            if (notificacao == null)
            {
                return NotFound();
            }
            return View(notificacao);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var notificacao = _databaseContext.Notificacoes.Find(id);
            if (notificacao == null)
            {
                return NotFound();
            }

            _databaseContext.Notificacoes.Remove(notificacao);
            _databaseContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
