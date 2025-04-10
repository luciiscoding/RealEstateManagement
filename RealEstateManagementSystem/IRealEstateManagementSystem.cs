using Domain.Entities;

namespace Domain.Repositories
{
    public interface IRealEstateManagementSystem
{
    Task<IEnumerable<Property>> GetProperties();
        Task<Property> GetProperty(Guid id);
        Task<Property> CreateProperty(Property property);
        Task<Property> UpdateProperty(Guid id, Property property);
        Task<Property> DeleteProperty(Guid id);
        Task<IEnumerable<Client>> GetClients();
        Task<Client> GetClient(Guid id);
        Task<Client> CreateClient(Client client);
        Task<Client> UpdateClient(Guid id, Client client);
        Task<Client> DeleteClient(Guid id);
        Task<IEnumerable<Property>> GetPropertiesByClient(Guid clientId);
        Task<Property> GetPropertyByClient(Guid clientId, Guid propertyId);
       
    }
}
