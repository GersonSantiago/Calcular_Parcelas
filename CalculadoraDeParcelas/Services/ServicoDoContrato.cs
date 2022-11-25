using CalculadoraDeParcelas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeParcelas.Services
{
    internal class ServicoDoContrato
    {
        private IServicoDePagamentoOnline _servicoDePagamentoOnline;

        public ServicoDoContrato(IServicoDePagamentoOnline servicoDePagamentoOnline)
        {
            _servicoDePagamentoOnline = servicoDePagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double ValorInicial = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double valorAtualizado = ValorInicial + _servicoDePagamentoOnline.TaxaDeJuros(ValorInicial, meses);
                double valor = valorAtualizado + _servicoDePagamentoOnline.TaxaDePagamento(valorAtualizado);
                contrato.AddParcelas(new Parcela(data, valor));
            }
        }
    }
}
