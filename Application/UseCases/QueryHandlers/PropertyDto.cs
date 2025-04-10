
namespace Application.UseCases.QueryHandlers
{
    public class PropertyDto
    {
        public Guid Id { get; internal set; }
        public string Address { get; internal set; }
        public string Description { get; internal set; }
        public decimal Price { get; internal set; }
        public string Type { get; internal set; }
        public DateTime CreatedAt { get; internal set; }
        public DateTime UpdatedAt { get; internal set; }
    }
}