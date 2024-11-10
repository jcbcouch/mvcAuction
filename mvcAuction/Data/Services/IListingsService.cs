using mvcAuction.Models;

namespace mvcAuction.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
    }
}
