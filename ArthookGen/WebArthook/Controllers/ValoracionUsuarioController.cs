﻿using ArthookGen.ApplicationCore.CEN.Arthook;
using ArthookGen.ApplicationCore.CP.Arthook;
using ArthookGen.ApplicationCore.EN.Arthook;
using ArthookGen.Infraestructure.CP;
using ArthookGen.Infraestructure.Repository.Arthook;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            SessionInitialize();
            ValoracionUsuarioRepository usuRepo = new ValoracionUsuarioRepository(session);
            ValoracionUsuarioCEN usuCEN = new ValoracionUsuarioCEN(usuRepo);

            ValoracionUsuarioEN usuEN = usuCEN.ReadOID(id);
            ValoracionUsuarioViewModel usuView = new ValoracionUsuarioAssembler().convertirEnToViewModel(usuEN);

            SessionClose();
            return View(usuView);
        }

        // GET: ValoracionUsuarioController/Create
        public ActionResult Create()
        {
           UsuarioRepository usurepoe = new UsuarioRepository();
           UsuarioCEN usucene = new UsuarioCEN(usurepoe);
           IList<UsuarioEN> listaEmisores = usucene.ReadAll(0,-1);
           IList<SelectListItem> emisorItems = new List<SelectListItem>();

           foreach(UsuarioEN usuen in listaEmisores)
           {
               emisorItems.Add(new SelectListItem { Text = usuen.Nombre, Value = usuen.Id.ToString() });

           }
           ViewData["emisorItems"] = emisorItems;

            UsuarioRepository usurepor = new UsuarioRepository();
            UsuarioCEN usucenr = new UsuarioCEN(usurepor);
            IList<UsuarioEN> listaReceptores = usucenr.ReadAll(0, -1);
            IList<SelectListItem> receptorItems = new List<SelectListItem>();

            foreach (UsuarioEN usuen in listaReceptores)
            {
                receptorItems.Add(new SelectListItem { Text = usuen.Nombre, Value = usuen.Id.ToString() });

            }
            ViewData["receptorItems"] = receptorItems;

            return View();
        }

        // POST: ValoracionUsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValoracionUsuarioViewModel valusuv)
        {
            try
            {
                ValoracionUsuarioRepository usurepo = new ValoracionUsuarioRepository();
                ValoracionUsuarioCP valusuCP = new ValoracionUsuarioCP(new SessionCPNHibernate());
                valusuCP.New_(valusuv.puntuacion, valusuv.emisor, valusuv.receptor);


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
