using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class PessoaJuridica
    {
        public string cnpj;
        public string ie;
        // override = método reescrito contendo o mesmo nome | Polimorfismo
        public override void pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}