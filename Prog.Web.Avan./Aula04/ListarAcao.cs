using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04
{
    public class ListarAcao : PessoaAcao<string>
    {
        public override string ExecutarAcao(PessoaFisica obj)
        {
            return $"{obj.Nome} filho(a) de {obj.Filiacao}";
        }

        public override string ExecutarAcao(PessoaJuridica obj)
        {
            return $"{obj.Nome}, contato: {obj.Contato}";
        }
    }
}