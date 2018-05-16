using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntrevistaEniwine.Models
{
    public class ViewModelAssassino
    {
        public List<SelectListItem> Armas { get; set; }
        public List<SelectListItem> Locais { get; set; }
        public List<SelectListItem> Suspeitos { get; set; }

        public int armaReal { get; set; }
        public int localReal { get; set; }
        public int suspeitoReal{ get; set; }

        public int armaSelecionada { get; set; }
        public int localSelecionado { get; set; }
        public int suspeitoSelecionado { get; set; }
    }
}