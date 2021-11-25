using ClimaTempoSimples.Models;
using System.Collections.Generic;

namespace ClimaTempoSimples.Repository
{
    public interface ICidadeRepository
    {
        IEnumerable<Cidade> ObterCidades();

    }


}
