using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arthook_web.Assemblers;
using Arthook_web.Models;
using ArthookGen.ApplicationCore.CEN.Arthook;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.Infraestructure.Repository.Arthook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Arthook_web.Controllers
{
    public class ValoracionPublicacionController : BasicController
    {
        // GET: HomeController1
        public ActionResult Index(int parametro)
        {
            SessionInitialize();
            ValoracionPublicacionRepository pubRepo = new ValoracionPublicacionRepository(session);
            ValoracionPublicacionCEN pubCen = new ValoracionPublicacionCEN(pubRepo);

            IList<ValoracionPublicacionEN> listEN = pubCen.ReadAll(0, 100);

            IEnumerable<ValoracionPublicacionViewModel> listPub = new ValoracionPublicacionAssembler().ConvertirListENToViewModel(listEN).ToList();
            SessionClose();

            return View(listPub);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
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

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
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

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
