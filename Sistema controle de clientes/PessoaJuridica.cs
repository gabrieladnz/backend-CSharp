using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    // indicando que é uma subclasse
    public class PessoaJuridica : Clientes
    {
        // encapsulamento
        public string cnpj {get; set;}
        public string ie {get; set;}
        // override = método reescrito contendo o mesmo nome | Polimorfismo
        public override void pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}