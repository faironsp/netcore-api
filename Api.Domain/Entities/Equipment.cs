namespace Api.Domain.Entities
{
    public class Equipment : BaseEntity
    {
        public int IdAcquirer { get; set; }

        public int IdManufacturer { get; set; }

        public int IdModel { get; set; }

        public int IsCustomer { get; set; }

        public string SerialNumber { get; set; }

        public bool IsActive { get; set; } = true;
    }
}