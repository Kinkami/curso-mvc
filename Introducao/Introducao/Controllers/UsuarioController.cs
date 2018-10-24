using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        
        public ActionResult Usuario()
        {
            var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario user)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", user);
            }
            return View(user);
        }

        public ActionResult Resultado(Usuario user)
        {
            return View(user);
        }



    }
}