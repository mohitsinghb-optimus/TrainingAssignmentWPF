using GalaSoft.MvvmLight.Ioc;
using System.Windows;
using TrainingAssignmentWPF.ViewModel;

namespace TrainingAssignmentWPF.View
{
    public partial class MainPage : Window
    {
        public MainPageVM MainPageVM { get; set; } =
              SimpleIoc.Default.GetInstance<MainPageVM>();

        public MainPage()
        {
            InitializeComponent();
            this.DataContext = MainPageVM;
        }
    }
}
