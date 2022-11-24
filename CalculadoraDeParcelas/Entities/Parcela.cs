﻿using System.Globalization;

namespace CalculadoraDeParcelas.Entities
{
    internal class Parcela
    {
        public DateTime DataDeVencimento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataDeVencimento, double valor)
        {
            DataDeVencimento = dataDeVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
