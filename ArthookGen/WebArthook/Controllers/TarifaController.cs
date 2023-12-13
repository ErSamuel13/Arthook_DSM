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
    public class TarifaController : BasicController
    {
        // GET: TarifaController
        public ActionResult Index()
        {
            SessionInitialize();
            TarifaRepository tarifarepo = new TarifaRepository();
            TarifaCEN tarifacen = new TarifaCEN(tarifarepo);
            IList<TarifaEN> listEn = tarifacen.ReadAll(0, -1);
            IEnumerable<TarifaViewModel> listView = new TarifaAssembler().ConvertirListEnToViewModel(listEn).ToList();
            SessionClose();
            return View(listView);
        }

        // GET: TarifaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TarifaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TarifaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TarifaViewModel tar)
        {
            try
            {
                TarifaRepository tarrepo = new TarifaRepository();
                TarifaCEN tarcen = new TarifaCEN(tarrepo);
                UsuarioViewModel usuario = HttpContext.Session.Get<UsuarioViewModel>("usuario");
                tarcen.New_(tar.precio, tar.descripcion, tar.nombre,usuario.id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TarifaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TarifaController/Edit/5
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

        // GET: TarifaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TarifaController/Delete/5
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
