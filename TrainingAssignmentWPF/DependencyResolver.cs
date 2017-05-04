using GalaSoft.MvvmLight.Ioc;
using Training.DataLayer.DataService;
using Training.DataLayer.IDataService;
using TrainingAssignmentWPF.ViewModel;

namespace TrainingAssignmentWPF
{
    public class DependencyResolver
    {
        public void RegisterDependency()
        {
            SimpleIoc.Default.Register<MainPageVM>();

            SimpleIoc.Default.Register<IFoodDataService, FoodDataService>();
        }
    }
}
