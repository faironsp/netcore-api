using System;
using System.Diagnostics.Contracts;

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

        public string name { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }

        public DateTime birthdate { get; set; }

        public SchoolLevel schooling { get; set; }
    }
}