using MediatR;

namespace Application.UseCases.Commands
{
    public class CreatePropertyCommand : IRequest<int>
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; } 
    }
}
