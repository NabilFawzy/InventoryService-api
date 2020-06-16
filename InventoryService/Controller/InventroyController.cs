using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;
using InventoryService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controller
{
    [Route("v1/")]
    [ApiController]
    public class InventroyController : ControllerBase
    {
        private readonly IInventroyServices _services;

        public InventroyController(IInventroyServices services)
        {
            this._services = services;
        }




        [HttpPost]
        [Route("AddInventroy")]
        public  ActionResult<InventroyItems> AddInventroy([FromBody]InventroyItems items)
        {
            var inventroyItems = _services.AddInventroyItems(items);
            if (inventroyItems == null) return NotFound();
            return inventroyItems;
        }

        [HttpGet]
        [Route("GetInventroy")]
        public ActionResult<Dictionary<string,InventroyItems>> GetInventroy()
        {
            var inventroyItems = _services.GetInventroyItems();
            if (inventroyItems.Count == 0) return NotFound();
            return inventroyItems;

        }
    }
}