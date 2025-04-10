using System;

namespace Application.DTOs
{
	public class ClientDTO
	{
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}