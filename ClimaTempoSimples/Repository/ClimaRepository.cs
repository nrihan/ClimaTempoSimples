using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using ClimaTempoSimples.Dao;
using ClimaTempoSimples.Models;

namespace ClimaTempoSimples.Repository
{
    public class ClimaRepository : IClimaRepository
    {
        protected readonly EFContext Db;
        protected readonly DateTime DataHoje;
        protected readonly DateTime ProximaSemana;

        public ClimaRepository(EFContext db)
        {
            Db = db;
            DataHoje = DateTime.Now;
            ProximaSemana = DateTime.Now.AddDays(8);
        }
        public IEnumerable<PrevisaoClima> ObterClima(int cidadeID)
        {
   
            var previsaoClima = Db.PrevisaoClimas.Where(p => p.CidadeID == cidadeID && DbFunctions.TruncateTime(p.DataPrevisao) > DataHoje.Date && DbFunctions.TruncateTime(p.DataPrevisao) < ProximaSemana.Date);
            return previsaoClima.ToList();
        }

        public IEnumerable<PrevisaoClima> ObterCidadesQuentes()
        {
            var previsaoClima = Db.PrevisaoClimas.Where(p => DbFunctions.TruncateTime(p.DataPrevisao) == DataHoje.Date).OrderByDescending(p => p.TemperaturaMaxima).Take(3);
            return previsaoClima.ToList();
        }

        public IEnumerable<PrevisaoClima> ObterCidadesFrias()
        {
            var previsaoClima = Db.PrevisaoClimas.Where(p => DbFunctions.TruncateTime(p.DataPrevisao) == DataHoje.Date).OrderBy(p => p.TemperaturaMinima).Take(3);       
            return previsaoClima.ToList();
        }

    }

  
}