using Api.Domain.Enum;
using System;

namespace Api.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid IdCustomer { get; set; }

        public Guid IdFlag { get; set; }

        public Guid IdEquipment { get; set; }

        public Guid IdCharge { get; set; }

        public Modality Modality { get; set; }

        public DateTime DateOfTransaction { get; set; }

        public decimal GrossSaleAmount { get; set; }

        public decimal NetAmountAnticipator { get; set; }

        public decimal NetAmountCustomer { get; set; }

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
