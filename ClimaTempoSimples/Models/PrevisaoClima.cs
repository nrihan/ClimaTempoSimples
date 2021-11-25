using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Models
{
    public class PrevisaoClima
    {
        public int PrevisaoClimaID { get; set; }

        [StringLength(15)]
        [Required]
        public string Clima { get; set; }

        [Required]
        public decimal TemperaturaMaxima { get; set; }

        [Required]
        public decimal TemperaturaMinima { get; set; }

        [Required]
        public DateTime DataPrevisao { get; set; }

        [Required]
        public int CidadeID { get; set; }

        [ForeignKey("CidadeID")]
        public virtual Cidade Cidade { get; set; }
    }
}