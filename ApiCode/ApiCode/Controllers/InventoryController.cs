using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCode.Model;
using ApiCode.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCode.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryInterface _services;

        public InventoryController(IInventoryInterface services)
        {
            _services = services;
        }
        // GET api/values
        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<List<InventoryItems>> GetInentoryItems()
        {
            var inventoryItems = _services.GetAllInventoryItems();
            return inventoryItems;
        }

        [HttpPost]
        [Route("AddInventoryItem")]
       public ActionResult<InventoryItems> AddInventoryItem(InventoryItems item)
        {
            var result = _services.AddInventoryItem(item);
            if (result == null)
                return NotFound();
            return result;
        }
    }
}
