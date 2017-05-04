using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Training.DataLayer.IDataService;
using Training.EntityLayer;
using TrainingAssignmentWPF.Model;
using System.Linq;
using TrainingAssignmentWPF.Utility;

namespace TrainingAssignmentWPF.ViewModel
{
    public class MainPageVM : ViewModelBase
    {
        private ObservableCollection<FoodItemModel> _foodItems;
        private IFoodDataService _foodDataService;

        public ObservableCollection<FoodItemModel> FoodItems
        {
            get { return _foodItems; }
            set { Set(nameof(FoodItems), ref _foodItems, value); }
        }

        public MainPageVM(IFoodDataService foodDataService)
        {
            _foodDataService = foodDataService;
            FoodItems = new ObservableCollection<FoodItemModel>();
        }

        public void LoadAllData()
        {
            var foodItems = _foodDataService.GetAllFoodItems();
            FoodItems = FoodItemConverter(foodItems).ToObservableCollection() ;
        }

        private List<FoodItemModel> FoodItemConverter(List<FoodItem> foodItem)
        {
            return (from f in foodItem
                   select new FoodItemModel
                   {
                       CategoryName = f.CategoryName,
                       ImageSource = f.ImageSource,
                       ItemId = f.ItemId,
                       Prices = f.Prices,
                       ProductName = f.ProductName
                   }).ToList();
        }
    }
}
