namespace Api.Domain.Entities
{
    public class Model : BaseEntity
    {
        public int IdManufacturer { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; } = true;
    }
}