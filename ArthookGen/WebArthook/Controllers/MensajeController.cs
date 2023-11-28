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
    public class MensajeController : BasicController
    {
        // GET: MensajeController
        public ActionResult Index()
        {
            SessionInitialize();
            MensajeRepository mensajerepo = new MensajeRepository();
            MensajeCEN mensajecen = new MensajeCEN(mensajerepo);
            IList<MensajeEN> listEn = mensajecen.ReadAll(0, -1);
            IEnumerable<MensajeViewModel> listView = new MensajeAssembler().ConvertirListEnToViewModel(listEn).ToList();
            SessionClose();
            return View(listView);
        }

        // GET: MensajeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MensajeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MensajeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MensajeViewModel men)
        {
            try
            {
                MensajeRepository mensajerepo = new MensajeRepository();
                MensajeCEN mensajecen = new MensajeCEN(mensajerepo);
                mensajecen.New_(men.fecha, men.contenido, men.emisor, men.receptor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MensajeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MensajeController/Edit/5
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

        // GET: MensajeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MensajeController/Delete/5
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
