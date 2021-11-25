using System;
using System.Collections.Generic;
using System.Linq;
using ClimaTempoSimples.Dao;
using ClimaTempoSimples.Models;

namespace ClimaTempoSimples.Repository
{
    public class CidadeRepository : ICidadeRepository
    {
        protected readonly EFContext Db;

        public CidadeRepository(EFContext db)
        {
            Db = db;
        }
       
        public IEnumerable<Cidade> ObterCidades()
        {
            List<Cidade> cidades = Db.Cidades.ToList();
            return cidades;
        }
    }


}