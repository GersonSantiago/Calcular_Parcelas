namespace CalculadoraDeParcelas.Services
{
    internal class ServicoPaypal : IServicoDePagamentoOnline
    {
        private const double PorcentageDePagamento = 0.02;
        private const double PorcentagemDeJurosMensais = 0.01;

        public double TaxaDeJuros(double valor, int meses)
        {
            return valor * PorcentagemDeJurosMensais * meses;
        }

        public double TaxaDePagamento(double valor)
        {
            return valor * PorcentageDePagamento;
        }
    }
}
