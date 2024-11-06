using MediatR;
using Application.UseCases.Queries;
using Fluent.Infrastructure.FluentModel;
using Domain.Entities;
using System.Data.Entity;


namespace Application.UseCases.QueryHandlers
{
    public class GetAllPropertiesQueryHandler : IRequestHandler<GetAllPropertiesQuery, List<PropertyDto>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllPropertiesQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PropertyDto>> Handle(GetAllPropertiesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Set<Property>()
                .Select(p => new PropertyDto
                {
                    Id = p.Id,
                    Address = p.Address,
                    Description = p.Description,
                    Price = p.Price,
                    Type = p.Type,
                    CreatedAt = p.CreatedAt,
                    UpdatedAt = p.UpdatedAt
                })
                .ToListAsync(cancellationToken);
        }
    }
}
