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
    public class UsuarioController : BasicController
    {
        // GET: UsuarioController
        public ActionResult Index()
        {
            SessionInitialize();
            UsuarioRepository usurepo = new UsuarioRepository();
            UsuarioCEN usucen = new UsuarioCEN(usurepo);
            IList<UsuarioEN> listEn = usucen.ReadAll(0, -1);
            IEnumerable<UsuarioViewModel> listView = new UsuarioAssembler().ConvertirListEnToViewModel(listEn).ToList();
            SessionClose();
            return View(listView);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuv)
        {
            try
            {
                UsuarioRepository usurepo = new UsuarioRepository();
                UsuarioCEN usucen = new UsuarioCEN(usurepo);
                usucen.New_(usuv.nombre, usuv.email, usuv.nickname, usuv.TipoUsuario, usuv.password);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
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

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
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
