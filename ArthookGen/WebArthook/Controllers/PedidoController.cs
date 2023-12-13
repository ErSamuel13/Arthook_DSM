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
    public class PedidoController : BasicController
    {
        // GET: PedidoController
        public ActionResult Index()
        {
            SessionInitialize();
            PedidoRepository pedidoRepository = new PedidoRepository(session);
            PedidoCEN pedidoCen = new PedidoCEN(pedidoRepository);

            IList<PedidoEN> pedidosEn= pedidoCen.ReadAll(0, -1);
            IEnumerable<PedidoViewModel> listaPedidos = new PedidoAsembler().convertirListEnViewModel(pedidosEn).ToList();

            SessionClose();
            return View(listaPedidos);
        }

        // GET: PedidoController/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            PedidoRepository pedidoRepository = new PedidoRepository(session);
            PedidoCEN pedidoCEN = new PedidoCEN(pedidoRepository);

            PedidoEN pedidoEN = pedidoCEN.ReadOID(id);

            PedidoViewModel pedidoViewModel = new PedidoAsembler().convertirEnViewModel(pedidoEN);

            SessionClose();

            return View(pedidoViewModel);
        }

        // GET: PedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoViewModel pedidoViewModel)
        {
            try
            {
                PedidoRepository pedidoRepository = new PedidoRepository();
                PedidoCEN pedidoCEN = new PedidoCEN(pedidoRepository);
                UsuarioViewModel usuario = HttpContext.Session.Get<UsuarioViewModel>("usuario");
                pedidoCEN.New_(pedidoViewModel.fecha, pedidoViewModel.estado, usuario.id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            PedidoRepository pedidoRepository = new PedidoRepository(session);
            PedidoCEN pedidoCEN = new PedidoCEN(pedidoRepository);

            PedidoEN pedidoEN = pedidoCEN.ReadOID(id);

            PedidoViewModel pedidoViewModel = new PedidoAsembler().convertirEnViewModel(pedidoEN);

            SessionClose();

            return View(pedidoViewModel);
        }

        // POST: PedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, PedidoViewModel pedidoViewModel)
        {
            try
            {
                PedidoRepository pedidoRepository = new PedidoRepository();
                PedidoCEN pedidoCEN = new PedidoCEN(pedidoRepository);
                pedidoCEN.Modify(id, pedidoViewModel.fecha, pedidoViewModel.estado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            PedidoRepository pedidoRepository = new PedidoRepository();
            PedidoCEN pedidoCEN = new PedidoCEN(pedidoRepository);

            pedidoCEN.Destroy(id);

            return RedirectToAction(nameof(Index));
        }

        // POST: PedidoController/Delete/5
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
