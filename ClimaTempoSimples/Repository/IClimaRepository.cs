using ClimaTempoSimples.Models;
using System.Collections.Generic;

namespace ClimaTempoSimples.Repository
{
    public interface IClimaRepository
    {
        IEnumerable<PrevisaoClima> ObterClima(int cidadeID);
        IEnumerable<PrevisaoClima> ObterCidadesQuentes();
        IEnumerable<PrevisaoClima> ObterCidadesFrias();
    }
}
