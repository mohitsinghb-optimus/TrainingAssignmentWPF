using System.Windows;

namespace TrainingAssignmentWPF
{
    public partial class App : Application
    {
        public App()
        {
            new DependencyResolver().RegisterDependency();
        }
    }
}
