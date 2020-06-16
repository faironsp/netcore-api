using System;

namespace Api.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public int IdPlan { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public decimal DebitTax { get; set; }

        public decimal CreditTax1x { get; set; }

        public decimal CreditTax2x { get; set; }

        public decimal CreditTax3x { get; set; }

        public decimal CreditTax4x { get; set; }

        public decimal CreditTax5x { get; set; }

        public decimal CreditTax6x { get; set; }

        public decimal CreditTax7x { get; set; }

        public decimal CreditTax8x { get; set; }

        public decimal CreditTax9x { get; set; }

        public decimal CreditTax10x { get; set; }

        public decimal CreditTax11x { get; set; }

        public decimal CreditTax12x { get; set; }

        public bool IsActive { get; set; } = true;
    }
}