using ClimaTempoSimples.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClimaTempoSimples.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<Dao.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dao.EFContext context)
        {
      
            context.Estados.AddOrUpdate(                 
                new Estado { Nome = "Bahia", UF="BA", EstadoID = 1 },
                new Estado { Nome = "Sergipe", UF = "SE", EstadoID = 2 },
                new Estado { Nome = "Alagoas", UF = "AL", EstadoID = 3 }
            );

            context.Cidades.AddOrUpdate(
                new Cidade {CidadeID = 1 , Nome = "Itabuna", EstadoID = 1},
                new Cidade {CidadeID = 2 , Nome = "Ilhéus", EstadoID = 1},
                new Cidade {CidadeID = 3 , Nome = "Buerarema", EstadoID = 1},
                new Cidade { CidadeID = 4, Nome = "Itacaré", EstadoID = 1 },
                new Cidade { CidadeID = 5, Nome = "Trancoso", EstadoID = 1 },
                new Cidade { CidadeID = 6, Nome = "Salvador", EstadoID = 1 }
            );

            context.PrevisaoClimas.AddOrUpdate(
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Chuvoso.ToString(), PrevisaoClimaID = 1,  TemperaturaMaxima = 21, TemperaturaMinima = 10, DataPrevisao = DateTime.Now },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Chuvoso.ToString(), PrevisaoClimaID = 4, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(1) },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Chuvoso.ToString(), PrevisaoClimaID = 5, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(2) },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Chuvoso.ToString(), PrevisaoClimaID = 6, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(3) },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Nublado.ToString(), PrevisaoClimaID = 7, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(4) },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Chuvoso.ToString(), PrevisaoClimaID = 8, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(5) },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Ensolarado.ToString(), PrevisaoClimaID = 9, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(6) },
               new PrevisaoClima { CidadeID = 1, Clima = Enums.TipoClima.Chuvoso.ToString(), PrevisaoClimaID = 10, TemperaturaMaxima = 20, TemperaturaMinima = 10, DataPrevisao = DateTime.Now.AddDays(7) },
               new PrevisaoClima { CidadeID = 2, Clima = Enums.TipoClima.Nublado.ToString(), PrevisaoClimaID = 2, TemperaturaMaxima = 22, TemperaturaMinima = 12, DataPrevisao = DateTime.Now },
               new PrevisaoClima { CidadeID = 3, Clima = Enums.TipoClima.Ensolarado.ToString(), PrevisaoClimaID = 3, TemperaturaMaxima = 24, TemperaturaMinima = 14, DataPrevisao = DateTime.Now },
               new PrevisaoClima { CidadeID = 4, Clima = Enums.TipoClima.Nublado.ToString(), PrevisaoClimaID = 11, TemperaturaMaxima = 26, TemperaturaMinima = 19, DataPrevisao = DateTime.Now },
               new PrevisaoClima { CidadeID = 5, Clima = Enums.TipoClima.Ensolarado.ToString(), PrevisaoClimaID = 12, TemperaturaMaxima = 30, TemperaturaMinima = 22, DataPrevisao = DateTime.Now },
               new PrevisaoClima { CidadeID = 6, Clima = Enums.TipoClima.Nublado.ToString(), PrevisaoClimaID = 13, TemperaturaMaxima = 33, TemperaturaMinima = 25, DataPrevisao = DateTime.Now },
               new PrevisaoClima { CidadeID = 6, Clima = Enums.TipoClima.Ensolarado.ToString(), PrevisaoClimaID = 14, TemperaturaMaxima = 21, TemperaturaMinima = 15, DataPrevisao = DateTime.Now.AddDays(1) }
           );;
        }
    }
}
