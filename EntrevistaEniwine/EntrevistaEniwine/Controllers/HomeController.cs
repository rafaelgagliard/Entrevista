using EntrevistaEniwine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntrevistaEniwine.Controllers
{
    public class HomeController : Controller
    {
        private EntrevistaContext ctx = new EntrevistaContext();
        public int suspeitoReal { get; set; }

        public ActionResult Index()
        {
            Random randNum = new Random();

            ViewModelAssassino model = new ViewModelAssassino();

            model.suspeitoReal = randNum.Next(1, ctx.Suspeitos.Count());
            model.localReal = randNum.Next(1, ctx.Locais.Count());
            model.armaReal = randNum.Next(1, ctx.Armas.Count());

            model.Armas = ctx.Armas.Select(c => new SelectListItem() { Value = c.id.ToString(), Text = c.descricao }).ToList();
            model.Locais = ctx.Locais.Select(c => new SelectListItem() { Value = c.id.ToString(), Text = c.descricao }).ToList();
            model.Suspeitos = ctx.Suspeitos.Select(c => new SelectListItem() { Value = c.id.ToString(), Text = c.descricao }).ToList();

            return View(model);
        }

        public ActionResult VerificaSuspeito(ViewModelAssassino model)
        {
            if (model.suspeitoSelecionado != model.suspeitoReal)
                return Json("1");
            if (model.localSelecionado != model.localReal)
                return Json("2");
            if (model.armaSelecionada != model.armaReal)
                return Json("3");

            return Json("0");
        }
    }
}