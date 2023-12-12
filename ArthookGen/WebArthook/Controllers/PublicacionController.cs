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
    public class PublicacionController : BasicController
    {
        // GET: PublicacionController
        public ActionResult Index(int parametro)
        {
            SessionInitialize();
            PublicacionRepository pubRepo = new PublicacionRepository(session);
            PublicacionCEN pubCen = new PublicacionCEN(pubRepo);

            IList<PublicacionEN> listEN = pubCen.ReadAll(0, 100);

            IEnumerable<PublicacionViewModel> listPub = new PublicacionAssembler().ConvertirListENToViewModel(listEN).ToList();
            SessionClose(); 

            return View(listPub);
        }

        // GET: PublicacionController/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            PublicacionRepository pubRepo = new PublicacionRepository(session);
            PublicacionCEN pubCEN = new PublicacionCEN(pubRepo);

            PublicacionEN pubEN = pubCEN.ReadOID(id);
            PublicacionViewModel artView = new PublicacionAssembler().ConvertirENToViewModel(pubEN);

            SessionClose();
            return View(artView);
        }

        // GET: PublicacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PublicacionViewModel pubv)
        {
            try
            {
                PublicacionRepository pubrepo = new PublicacionRepository();
                PublicacionCEN pubcen = new PublicacionCEN(pubrepo);
                pubcen.New_(pubv.TipoProducto, pubv.Descripcion, pubv.Titulo, pubv.TipoPublicacion, pubv.Usuario.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PublicacionController/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            PublicacionRepository pubrepo = new PublicacionRepository(session);
            PublicacionCEN pubcen = new PublicacionCEN(pubrepo);

            PublicacionEN puben = pubcen.ReadOID(id);
            PublicacionViewModel pubView = new PublicacionAssembler().ConvertirENToViewModel(puben);
            SessionClose();
            return View(pubView);
        }

        // POST: PublicacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PublicacionViewModel pub)
        {
            try
            {
                PublicacionRepository pubrepo = new PublicacionRepository();
                PublicacionCEN pubcen = new PublicacionCEN(pubrepo);
                pubcen.Modify(id, pub.TipoProducto, pub.Descripcion, pub.Titulo, pub.TipoPublicacion);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PublicacionController/Delete/5
        public ActionResult Delete(int id)
        {
            PublicacionRepository pubrepo = new PublicacionRepository();
            PublicacionCEN pubcen = new PublicacionCEN(pubrepo);
            pubcen.Destroy(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: PublicacionController/Delete/5
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
