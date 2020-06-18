using System;

namespace Api.Infra.CrossCutting
{
    public class LoanCalculator
    {
        /// <summary>
        /// Função que calcula o valor da prestação de acordo com a tabela price
        /// </summary>
        /// <param name="PV">PV é o valor financiado</param>
        /// <param name="i">i é a taxa  de juros (Ex: Se for 5% então, enviar 0.05)</param>
        /// <param name="n">n é o número de parcelas</param>
        /// <returns>Valor da Prestação</returns>
        public static double CalculaPrestacao(double PV, double i, int n)
        {
            //Calcula a prestação de forma simples, sem incluir a taxa do cartão
            var prestacaoSemTaxaAdmCartao = CalculaPrestacaoPrice(PV, i, n);

            //Calcula o valor da transação
            var valorDaTransacao = (prestacaoSemTaxaAdmCartao * n);

            //Calcula quanto a operadora de cartão vai descontar quando efetuar a transação
            var taxaAdmCartao = valorDaTransacao * RecuperaTaxaAdmCartao(valorDaTransacao);

            //Valor Final
            var prestacaoComTaxaAdmCartao = CalculaPrestacaoPrice(PV + taxaAdmCartao, i, n);

            return prestacaoComTaxaAdmCartao;
        }

        /// <summary>
        /// Função que calcula o valor da prestação de acordo com a tabela price
        /// </summary>
        /// <param name="PV">PV é o valor financiado</param>
        /// <param name="i">i é a taxa  de juros (Ex: Se for 5% então, enviar 0.05)</param>
        /// <param name="n">n é o número de parcelas</param>
        /// <returns>Valor da Prestação</returns>
        private static double CalculaPrestacaoPrice(double PV, double i, int n)
        {
            //Valor da Prestação
            return (PV * i * (Math.Pow((1 + i), n))) / ((Math.Pow((1 + i), n)) - 1);
        }

        /// <summary>
        /// Recupera a taxa adm do cartão na transação
        /// </summary>
        /// <param name="valorDaTransacao"></param>
        /// <returns></returns>
        private static double RecuperaTaxaAdmCartao(double valorDaTransacao)
        {
            //Vou Travar 5% por enquanto
            return 0.05;
        }
    }
}
