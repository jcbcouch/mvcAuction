using mvcAuction.Models;

namespace mvcAuction.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
