using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCode.Model;

namespace ApiCode.Services
{
    public class InventoryServices : IInventoryInterface
    {
        private readonly List<InventoryItems> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new List<InventoryItems>();
        }
        public List<InventoryItems> GetAllInventoryItems()
        {
            return _inventoryItems;
        }

        public InventoryItems AddInventoryItem(InventoryItems item)
        {
            _inventoryItems.Add(item);
            return item;
        }
    }
}
