using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Services
{
    public interface IInventroyServices
    {

         InventroyItems AddInventroyItems(InventroyItems items);
         Dictionary<string, InventroyItems> GetInventroyItems();
    }
}
