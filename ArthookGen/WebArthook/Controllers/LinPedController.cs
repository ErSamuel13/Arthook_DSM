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
    public class LinPedController : BasicController
    {
        // GET: LinPedController
        public ActionResult Index()
        {
            SessionInitialize();
            LinPedRepository LinPedRepository = new LinPedRepository(session);
            LinPedCEN LinPedCen = new LinPedCEN(LinPedRepository);

            IList<LinPedEN> LinPedEn = LinPedCen.ReadAll(0, -1);
            IEnumerable<LinPedViewModel> listaLinPed = new LinPedAsembler().convertirListEnViewModel(LinPedEn).ToList();

            SessionClose();
            return View(listaLinPed);
        }

        // GET: LinPedController/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            LinPedRepository linPedRepository = new LinPedRepository(session);
            LinPedCEN linPedCEN = new LinPedCEN(linPedRepository);
            LinPedEN linPedEN = linPedCEN.ReadOID(id);

            LinPedViewModel linPedViewModel = new LinPedAsembler().convertirEnViewModel(linPedEN);

            SessionClose();
            return View(linPedViewModel);
        }

        // GET: LinPedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LinPedController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LinPedViewModel linPedViewModel)
        {
            try
            {
                LinPedRepository linPedRepository = new LinPedRepository();
                LinPedCEN linPedCEN = new LinPedCEN(linPedRepository);
                //linPedCEN.New_();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LinPedController/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            LinPedRepository linPedRepository = new LinPedRepository(session);
            LinPedCEN linPedCEN = new LinPedCEN(linPedRepository);
            LinPedEN linPedEN = linPedCEN.ReadOID(id);

            LinPedViewModel linPedViewModel = new LinPedAsembler().convertirEnViewModel(linPedEN);

            SessionClose();
            return View();
        }

        // POST: LinPedController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, LinPedViewModel linPedViewModel)
        {
            try
            {
                LinPedRepository linPedRepository = new LinPedRepository(session);
                LinPedCEN linPedCEN = new LinPedCEN(linPedRepository);
                linPedCEN.Modify(id, linPedViewModel.cantidad);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LinPedController/Delete/5
        public ActionResult Delete(int id)
        {
            LinPedRepository linPedRepository = new LinPedRepository(session);
            LinPedCEN linPedCEN = new LinPedCEN(linPedRepository);

            linPedCEN.Destroy(id);
            return View();
        }

        // POST: LinPedController/Delete/5
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
