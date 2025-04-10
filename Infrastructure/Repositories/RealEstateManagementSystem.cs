using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class RealEstateManagementSystem : IRealEstateManagementSystem
    {
        private readonly ApplicationDbContext context;
        public RealEstateManagementSystem(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Guid> AddAsync(Property property)
        {
            await context.Properties.AddAsync(property);
            await context.SaveChangesAsync();
            return property.Id;
        }

        public Task<Client> CreateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Property> CreateProperty(Property property)
        {
            throw new NotImplementedException();
        }

        public Task<Client> DeleteClient(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Property> DeleteProperty(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClient(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetClients()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetProperties()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetPropertiesByClient(Guid clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Property> GetProperty(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Property> GetPropertyByClient(Guid clientId, Guid propertyId)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateClient(Guid id, Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Property> UpdateProperty(Guid id, Property property)
        {
            throw new NotImplementedException();
        }
    }
}
