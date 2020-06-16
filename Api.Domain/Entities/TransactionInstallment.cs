using System;

namespace Api.Domain.Entities
{
    public class TransactionInstallment : BaseEntity
    {
        /// <summary>
        /// Chave Estrangeira: Id da Transação (Transaction.Id)
        /// </summary>
        public int IdTransaction { get; set; }

        /// <summary>
        /// Número da parcela
        /// </summary>
        public int NumberOfInstallment { get; set; }

        /// <summary>
        /// Valor bruto
        /// </summary>
        public decimal GrossValue { get; set; }

        //Valor líquido
        public decimal NetValue { get; set; }

        /// <summary>
        /// Data de previsão de recebimento
        /// </summary>
        public DateTime EstimatedReceiptDate { get; set; }

        /// <summary>
        /// Data em que realmente foi recebido
        /// </summary>
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Recibido, sim ou não
        /// </summary>
        public bool IsReceived { get; set; } = false;
    }
}
