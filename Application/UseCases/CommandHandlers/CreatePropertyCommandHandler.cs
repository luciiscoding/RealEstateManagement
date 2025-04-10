using MediatR;
using Application.UseCases.Commands;
using Domain.Entities;
using Fluent.Infrastructure.FluentModel;
using System.Data.Entity.Infrastructure;

namespace Application.UseCases.CommandHandlers
{
    public class CreatePropertyCommandHandler : IRequestHandler<CreatePropertyCommand, int>
    {
        public  ApplicationDbContext _context;

        public CreatePropertyCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePropertyCommand request, CancellationToken cancellationToken)
        {
            if (_context == null)
            {
                throw new InvalidOperationException("Database context is not initialized.");
            }

            var property = new Property
            {
                Address = request.Address,
                Description = request.Description,
                Price = request.Price,
                Type = request.Type,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            _context.Set<Property>().Add(property);
            await _context.SaveChangesAsync(cancellationToken);

            return property.Id.GetHashCode();
        }


    }
    }
