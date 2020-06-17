namespace Api.Domain.Entities
{
    public class Equipment : BaseEntity
    {
        public int IdAcquirer { get; set; }

        public int IdManufacturer { get; set; }

        public int IdModel { get; set; }

        public int IdCustomer { get; set; }

        public string SerialNumber { get; set; }

        public bool IsActive { get; set; } = true;
    }
}