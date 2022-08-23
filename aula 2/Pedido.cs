using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2
{
    internal class Pedido
    {
        int numero;
        int quantidade;
        double total;

        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int setNumero()
        {
         return this.numero;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public int setQuantidade()
        {
            return this.quantidade;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }
        public double setTotal()
        {
            return this.total;
        }
    }
}
