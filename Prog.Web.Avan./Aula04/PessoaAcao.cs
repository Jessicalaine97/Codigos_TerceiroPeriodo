using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04
{
    public abstract class PessoaAcao<T>
    {
        public abstract T ExecutarAcao(PessoaFisica obj);
        public abstract T ExecutarAcao(PessoaJuridica obj);
    }
}
