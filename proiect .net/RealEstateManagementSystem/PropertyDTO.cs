using System;

namespace Application.DTOs
{

    public class PropertyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public decimal Price { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public int SquareMeters { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}