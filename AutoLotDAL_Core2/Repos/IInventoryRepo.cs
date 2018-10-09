using AutoLotDAL_Core2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoLotDAL_Core2.Repos
{
    public interface IInventoryRepo : IRepo<Inventory>
    {
        List<Inventory> Search(string searchString);
        List<Inventory> GetPinkCars();
        List<Inventory> GetRelatedData();
    }
}
