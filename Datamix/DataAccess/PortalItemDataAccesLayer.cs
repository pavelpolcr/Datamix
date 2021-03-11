using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Datamix.Model;

namespace Datamix.DataAccess
{
    public class PortalItemDataAccesLayer
    {
        PortalItemContext db = new PortalItemContext();
        
        //To Get all employees details   
        public IEnumerable<PortalItem> GetAllPortalItems()
        {
            try
            {
                return db.tblPortalItem.ToList();
                
            }
            catch
            {
                throw ;
            }
        }

        //To Add new employee record     
        public void AddPortalItem(PortalItem portalItem)
        {
            try
            {
                db.tblPortalItem.Add(portalItem);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdatePortalItem(PortalItem portalItem)
        {
            try
            {
                db.Entry(portalItem).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee    
        public PortalItem GetPortalItemData(int id)
        {
            try
            {
                PortalItem portalItem = db.tblPortalItem.Find(id);
                return portalItem;
            }
            catch
            {
                throw new Exception();
            }
        }

        //To Delete the record of a particular employee    
        public void DeletePortalItem(int id)
        {
            try
            {
                PortalItem emp = db.tblPortalItem.Find(id);
                db.tblPortalItem.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}

