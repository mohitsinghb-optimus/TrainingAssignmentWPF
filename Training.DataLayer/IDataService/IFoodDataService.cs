using System.Collections.Generic;
using Training.EntityLayer;

namespace Training.DataLayer.IDataService
{
    public interface IFoodDataService
    {
        List<FoodItem> GetAllFoodItems();
    }
}
