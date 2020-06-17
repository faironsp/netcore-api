using Api.Domain.Enum;
using System;

namespace Api.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public int IdCustomer { get; set; }

        public int IdFlag { get; set; }

        public int IdEquipment { get; set; }

        public int IdCharge { get; set; }

        public Modality Modality { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public decimal GrossTransactionAmount { get; set; }

        public decimal NetAmountToAnticipator { get; set; }

        public decimal NetAmountToCustomer { get; set; }

        /// <summary>
        /// Taxa aplicada na liquidação com o cliente
        /// </summary>
        public decimal RateAppliedAtLiquidationWithTheCustomer { get; set; }

        /// <summary>
        /// Data de liquidação com o cliente
        /// </summary>
        public DateTime CustomerLiquidationDate { get; set; }

        /// <summary>
        /// Se foi liquidado ou não com o clientes
        /// </summary>
        public bool Liquidated { get; set; } = false;
    }
}
