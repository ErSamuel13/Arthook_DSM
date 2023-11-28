using ArthookGen.ApplicationCore.CEN.Arthook;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.Infraestructure.Repository.Arthook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebArthhook.Controllers;
using WebArthook.Assemblers;
using WebArthook.Models;

namespace WebArthook.Controllers
{
    public class ValoracionUsuarioController : BasicController
    {
        // GET: ValoracionUsuarioController
        public ActionResult Index()
        {
            SessionInitialize();
           ValoracionUsuarioRepository valrepo = new ValoracionUsuarioRepository(session);
            ValoracionUsuarioCEN valcen = new ValoracionUsuarioCEN(valrepo);
            IList<ValoracionUsuarioEN> listEn = valcen.ReadAll(0, -1);
            IEnumerable<ValoracionUsuarioViewModel> listView = new ValoracionUsuarioAssembler().ConvertirListEnToViewModel(listEn).ToList();
            SessionClose();
            return View(listView);
        }

        // GET: ValoracionUsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValoracionUsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValoracionUsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValoracionUsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValoracionUsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValoracionUsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValoracionUsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
