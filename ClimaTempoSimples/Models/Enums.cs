using System;


namespace ClimaTempoSimples.Models
{
    public static class Enums
    {
        public enum TipoClima
        {
            Chuvoso = 1,
            Ensolarado = 2,
            Nublado = 3
        }

        public enum DiasDaSemana
        {
            Domingo = DayOfWeek.Sunday,
            Segunda = DayOfWeek.Monday,
            Terça = DayOfWeek.Tuesday,
            Quarta = DayOfWeek.Wednesday,
            Quinta = DayOfWeek.Thursday,
            Sexta = DayOfWeek.Friday,
            Sábado = DayOfWeek.Saturday
        }

    }
}