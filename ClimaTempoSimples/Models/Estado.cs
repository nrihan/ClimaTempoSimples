using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    public class Estado
    {
        public int EstadoID { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }
    }
}