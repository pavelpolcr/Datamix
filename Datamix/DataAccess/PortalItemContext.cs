using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datamix.Model;

namespace Datamix.DataAccess
{
    public class PortalItemContext : DbContext
    {
        public virtual DbSet<PortalItem> tblPortalItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\PAVEL\ONEDRIVE\DOCUMENTS\PORTALITEMS.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                

            }
        }
    }
}
