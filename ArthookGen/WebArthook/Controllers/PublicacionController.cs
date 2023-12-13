using ArthookGen.ApplicationCore.CEN.Arthook;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.Infraestructure.Repository.Arthook;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using WebArthhook.Controllers;
using WebArthook.Assemblers;
using WebArthook.Models;


namespace WebArthook.Controllers
{
    public class PublicacionController : BasicController
    {

        private readonly IWebHostEnvironment _webhost;

    public PublicacionController (IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }
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
        public  async Task <ActionResult> Create(PublicacionViewModel pubv)
        {
            string filename = "", path = "";
            if(pubv.Fichero!=null && pubv.Fichero.Length > 0)
            {
                filename = Path.GetFileName(pubv.Fichero.FileName).Trim();

                string directory = _webhost.WebRootPath + "/Images";
                path = Path.Combine((directory), filename);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                using (var stream = System.IO.File.Create(path))
                {
                    await pubv.Fichero.CopyToAsync(stream); 
                }
            }
            try
            {
                filename = "/Images/" + filename;
                PublicacionRepository pubrepo = new PublicacionRepository();
                PublicacionCEN pubcen = new PublicacionCEN(pubrepo);
                UsuarioViewModel usuario = HttpContext.Session.Get<UsuarioViewModel>("usuario");
                pubcen.New_(pubv.TipoProducto, pubv.Descripcion, pubv.Titulo, pubv.TipoPublicacion, usuario.id,filename);
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
                pubcen.Modify(id, pub.TipoProducto, pub.Descripcion, pub.Titulo, pub.TipoPublicacion,pub.Imagen);
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
