using ApiCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCode.Services
{
    public interface IInventoryInterface
    {
        List<InventoryItems> GetAllInventoryItems();
        InventoryItems AddInventoryItem(InventoryItems item);
    }
}
