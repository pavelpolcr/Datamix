using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPortalItemsData
    {
        Task<List<PortlItem>> GetPortalItems();
        Task InsertPortalItem(PortlItem person);
    }
}