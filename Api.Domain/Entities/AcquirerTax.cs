namespace Api.Domain.Entities
{
    /// <summary>
    /// Taxas de Adquirentes
    /// </summary>
    public class AcquirerTax : BaseEntity
    {
        public int IdAcquirer { get; set; }

        public int IdFlag { get; set; }

        public decimal DebitTax { get; set; }

        public decimal CreditTax1x1x { get; set; }

        public decimal CreditTax2x6x { get; set; }

        public decimal CreditTax7x12 { get; set; }
    }
}
