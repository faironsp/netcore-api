namespace Api.Domain.Entities
{
    public class CustomerHistory : BaseEntity
    {
        public int IdCustomer { get; set; }

        public string Historic { get; set; }
    }
}
