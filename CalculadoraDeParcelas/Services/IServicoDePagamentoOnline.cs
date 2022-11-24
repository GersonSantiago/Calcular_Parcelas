using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeParcelas.Services
{
    internal interface IServicoDePagamentoOnline
    {
        public double TaxaDePagamento(double valor);
        public double TaxaDeJuros(double valor, int meses);
    }
}
