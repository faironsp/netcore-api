namespace Api.Domain.Entities
{
    public class BankingDomicile : BaseEntity
    {
        public int IdBank { get; set; }

        public int IdCustomer { get; set; }

        /// <summary>
        /// É conta poupança?
        /// </summary>
        public bool IsSavingsAccount { get; set; } = false;

        public string Agency { get; set; }

        public string AgencyDigit { get; set; }

        public string AccountNumber { get; set; }

        public string AccountNumberDigit { get; set; }

        /// <summary>
        /// Pessoa Física ou Jurídica
        /// True = Pessoa Jurídica
        /// False = Pessoa Física
        /// </summary>
        public bool IsLegalPerson { get; set; } = true;

        public string HolderName { get; set; }

        public string HouderDocument { get; set; }
    }
}