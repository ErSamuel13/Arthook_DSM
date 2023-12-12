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
    public class ValoracionPublicacionController : BasicController
    {
        // GET: ValoracionPublicacionController
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

        // GET: ValoracionPublicacionController/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            ValoracionPublicacionRepository pubRepo = new ValoracionPublicacionRepository(session);
            ValoracionPublicacionCEN pubCEN = new ValoracionPublicacionCEN(pubRepo);

            ValoracionPublicacionEN pubEN = pubCEN.ReadOID(id);
            ValoracionPublicacionViewModel artView = new ValoracionPublicacionAssembler().ConvertirENToViewModel(pubEN);

            SessionClose();
            return View(artView);
        }

        // GET: ValoracionPublicacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValoracionPublicacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValoracionPublicacionViewModel pubv)
        {
            try
            {
                ValoracionPublicacionRepository pubrepo = new ValoracionPublicacionRepository();
                ValoracionPublicacionCEN pubcen = new ValoracionPublicacionCEN(pubrepo);
                pubcen.New_(pubv.Puntuacion, pubv.Comentario, pubv.Usuario.Id, pubv.Publicacion.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValoracionPublicacionController/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            ValoracionPublicacionRepository pubrepo = new ValoracionPublicacionRepository(session);
            ValoracionPublicacionCEN pubcen = new ValoracionPublicacionCEN(pubrepo);

            ValoracionPublicacionEN puben = pubcen.ReadOID(id);
            ValoracionPublicacionViewModel pubView = new ValoracionPublicacionAssembler().ConvertirENToViewModel(puben);
            SessionClose();
            return View(pubView);
        }

        // POST: ValoracionPublicacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ValoracionPublicacionViewModel pub)
        {
            try
            {
                ValoracionPublicacionRepository pubrepo = new ValoracionPublicacionRepository();
                ValoracionPublicacionCEN pubcen = new ValoracionPublicacionCEN(pubrepo);
                pubcen.Modify(id, pub.Puntuacion, pub.Comentario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValoracionPublicacionController/Delete/5
        public ActionResult Delete(int id)
        {
            ValoracionPublicacionRepository pubrepo = new ValoracionPublicacionRepository();
            ValoracionPublicacionCEN pubcen = new ValoracionPublicacionCEN(pubrepo);
            pubcen.Destroy(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: ValoracionPublicacionController/Delete/5
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
