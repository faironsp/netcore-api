﻿namespace Api.Domain.Entities
{
    public class Manufacturer : BaseEntity
    {
        public string Name { get; set; }

        public string Logo { get; set; }

        public bool IsActive { get; set; } = true;
    }
}