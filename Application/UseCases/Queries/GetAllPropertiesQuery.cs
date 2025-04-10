using System.Collections.Generic;
using Application.DTOs;
using Application.UseCases.QueryHandlers;
using MediatR;

namespace Application.UseCases.Queries
{
    public class GetAllPropertiesQuery : IRequest<List<PropertyDto>>
    {
    }
}
