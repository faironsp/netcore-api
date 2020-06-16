using System;

namespace Api.Domain.Entities
{
    public class User : BaseEntity
    {
        public enum SchoolLevel
        {
            Infantil = 1,
            Fundamental = 2,
            Médio = 3,
            Superior = 4
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }

        public SchoolLevel Schooling { get; set; }
    }
}