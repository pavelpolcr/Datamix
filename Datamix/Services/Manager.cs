using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datamix.Model;
using Datamix.DataAccess;


namespace Datamix.Services
{
    public class Manager
    {
        public bool IsEditable { get; set; }
        public string Password { get; private set; }
        public List<PortalItem> AllItems = new List<PortalItem>();
        DataAccess.PortalItemDataAccesLayer Data = new PortalItemDataAccesLayer();
        public Manager()
        {
            AllItems = Data.GetAllPortalItems().ToList();
            Password = "datamix";
            IsEditable = false;
        }
        public void AddNewPortalItem(string name, string desc, string url)
        {
            int nItems;
            int newId=-1;
            PortalItem temp = new PortalItem();
            nItems = AllItems.Count();
            for (int i = 1; i <= nItems+1; i++)
            {
                if (AllItems.Find(it => it.Id == i) is null)
                {
                    newId = i;
                }
            }
            temp.Id = newId;
            temp.Name = name;
            temp.Description = desc;
            temp.Url = url;
            Data.AddPortalItem(temp);
            RefreshItems();

        }
        public void RefreshItems()
        {
            AllItems = Data.GetAllPortalItems().ToList();
        }
        public void SaveAllChanges()
        {
            foreach (PortalItem item in AllItems)
            {
                Data.UpdatePortalItem(item);
            }
        }
        public void DeleteItem(int id)
        {
            Data.DeletePortalItem(id);
            RefreshItems();
        }
    }
}
