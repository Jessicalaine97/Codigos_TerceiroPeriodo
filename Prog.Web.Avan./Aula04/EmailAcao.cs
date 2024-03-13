using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04
{
    public class EmailAcao : PessoaAcao<string>
    {
        public string Texto { get; set; } = "";

        public override string ExecutarAcao(PessoaFisica obj)
        {
            return String.Format(Texto, obj.Nome);
        }

        public override string ExecutarAcao(PessoaJuridica obj)
        {
            return String.Format(Texto, obj.Contato);
        }
    }
}