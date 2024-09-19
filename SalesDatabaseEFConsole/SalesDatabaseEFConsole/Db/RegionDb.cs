using SalesDatabaseEFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SalesDatabaseEFConsole.Db
{
    internal class RegionDb : DAO<Region>
    {
        private salesdbContext DbContext = new salesdbContext();

        // CRUD Methods
        // Get
        public List<Region> GetRegion()
        {
            return DbContext.Regions.ToList();
        }


        // Find
        public Region FindRegions(int id)
        {
            return DbContext.Regions.Where(r => r.Id == id).FirstOrDefault();
        }
        
        // Add
        public void AddRegion(Region region)
        {
            DbContext.Regions.Add(region);
            DbContext.SaveChanges();
        }
        
        
        // Update
        public void UpdateRegion(Region region)
        {
            DbContext.SaveChanges();
        }
        
        // Remove
        public void RemoveRegion(Region region)
        {
            DbContext.Regions.Remove(region);
            DbContext.SaveChanges();
        }




    }
}
