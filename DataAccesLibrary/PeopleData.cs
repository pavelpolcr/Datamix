using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPortalItemsData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PortlItem>> GetPortalItems()
        {
            string sql = "select * from dbo.PortalItems";

            return _db.LoadData<PortlItem, dynamic>(sql, new { });
        }

        public Task InsertPortalItem(PortlItem person)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
                           values (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, person);
        }
    }
}
