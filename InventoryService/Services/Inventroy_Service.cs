using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;

namespace InventoryService.Services
{
    public class Inventroy_Service : IInventroyServices
    {
        private readonly Dictionary<string, InventroyItems> _inventroyItems;

        public Inventroy_Service()
        {
            _inventroyItems = new Dictionary<string, InventroyItems>();
        }

        public  InventroyItems AddInventroyItems(InventroyItems items)
        {
            _inventroyItems.Add(items.name,items);
            return items;
        }

        public Dictionary<string, InventroyItems> GetInventroyItems()
        {
           return _inventroyItems;
        }
    }
}
