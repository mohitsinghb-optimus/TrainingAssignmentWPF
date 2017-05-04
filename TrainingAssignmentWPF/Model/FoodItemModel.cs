using GalaSoft.MvvmLight;
using System;
using System.ComponentModel;

namespace TrainingAssignmentWPF.Model
{
    public class FoodItemModel : ObservableObject, IDataErrorInfo
    {
        private int _itemId;
        private string _categoryName;
        private string _productName;
        private string _prices;
        private Uri _imageSource;

        public Uri ImageSource
        {
            get { return _imageSource; }
            set { Set(nameof(ImageSource), ref _imageSource, value); }
        }


        public string Prices
        {
            get { return _prices; }
            set { Set(nameof(Prices), ref _prices, value); }
        }


        public string ProductName
        {
            get { return _productName; }
            set { Set(nameof(ProductName), ref _productName, value); }
        }

        public string CategoryName
        {
            get { return _categoryName; }
            set { Set(nameof(CategoryName), ref _categoryName, value); }
        }


        public int ItemId
        {
            get { return _itemId; }
            set { Set(nameof(ItemId), ref _itemId, value); }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName.Equals(nameof(Prices)))
                {
                    decimal value = 0M;

                    if(!decimal.TryParse(Prices, out value))
                    {
                        return "Enter Only Integer";
                    }
                }

                return null;
            }
        }
    }
}
