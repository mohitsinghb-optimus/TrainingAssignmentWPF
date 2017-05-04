using System;
using System.Collections.Generic;
using Training.DataLayer.IDataService;
using Training.EntityLayer;

namespace Training.DataLayer.DataService
{
    public class FoodDataService : IFoodDataService
    {
        private List<FoodItem> _foodItems;

        public FoodDataService()
        {
            _foodItems = new List<FoodItem>();
            PopulateFoodItems();
        }

        public List<FoodItem> GetAllFoodItems()
        {
            return _foodItems;
        }




        private void PopulateFoodItems()
        {
            _foodItems.AddRange(new List<FoodItem>
            {
                new FoodItem
                {
                    CategoryName = "Morning",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/1.jpg"),
                    ItemId = 1,
                    Prices = "7.00",
                    ProductName = "Sample Breakfast"
                },
                new FoodItem
                {
                     CategoryName = "Evening",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/2.jpg"),
                    ItemId = 2,
                    Prices = "8.00",
                    ProductName = "Sample Breakfast"
                },
                new FoodItem
                {
                     CategoryName = "Lunch",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/3.jpg"),
                    ItemId = 3,
                    Prices = "34.00",
                    ProductName = "Sample Lunch"
                },
                new FoodItem
                {
                     CategoryName = "Morning",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/4.jpg"),
                    ItemId = 4,
                    Prices = "56.00",
                    ProductName = "Sample Breakfast"
                },
                new FoodItem
                {
                     CategoryName = "Morning",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/5.jpg"),
                    ItemId = 5,
                    Prices = "36.00",
                    ProductName = "Sample Breakfast"
                },
                new FoodItem
                {
                     CategoryName = "Morning",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/6.jpg"),
                    ItemId = 6,
                    Prices = "4.00",
                    ProductName = "Sample Breakfast"
                },
                new FoodItem
                {
                     CategoryName = "Morning",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/3.jpg"),
                    ItemId = 7,
                    Prices = "4.00",
                    ProductName = "Sample Breakfast"
                },
                new FoodItem
                {
                     CategoryName = "Morning",
                    ImageSource = new Uri("pack://application:,,,/TrainingAssignmentWPF;component/Assets/8.jpg"),
                    ItemId = 8,
                    Prices = "4.00",
                    ProductName = "Sample Breakfast"
                }
            });
        }
    }
}
