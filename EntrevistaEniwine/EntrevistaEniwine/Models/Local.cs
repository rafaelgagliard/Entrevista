using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntrevistaEniwine.Models
{
    [Table("Local")]
    public class Local
    {
        [Key]
        public int id { get; set; }

        [MaxLength(250)]
        public string descricao { get; set; }
    }
}