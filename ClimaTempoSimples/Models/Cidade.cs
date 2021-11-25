using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    public class Cidade
    {
        public int CidadeID { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        [Required]
        public int EstadoID { get; set; }

        [ForeignKey("EstadoID")]
        public virtual Estado Estado { get; set; }
    }
}