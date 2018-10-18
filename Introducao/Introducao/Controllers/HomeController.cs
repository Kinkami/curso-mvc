using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Fer",
                Tipo = "Mestre Ursal"
            };
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            ViewBag.PessoaId = pessoa.PessoaId;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Tipo = pessoa.Tipo;

            return View(pessoa);
        }


        public ActionResult Contatos()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["PessoaId"] = form["PessoaId"];
        //    ViewData["Nome"] = form["Nome"]; 
        //    ViewData["Tipo"] = form["Tipo"]; 
        //    return View();
        //}


        [HttpPost]
        public ActionResult Lista(Pessoa p)
        {
            ViewData["PessoaId"] = p.PessoaId;
            ViewData["Nome"] = p.Nome;
            ViewData["Tipo"] = p.Tipo;
            return View();
        }



    }
}