using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class Clientes
    {
        // atributos declarados
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }

        // métodos
        // virtual = o método pode ser sobrescrito na classe descendente
        public virtual void pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}