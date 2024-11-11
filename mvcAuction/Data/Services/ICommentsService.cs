using mvcAuction.Models;

namespace mvcAuction.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
