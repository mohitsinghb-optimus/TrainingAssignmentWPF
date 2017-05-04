
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TrainingAssignmentWPF.Utility
{
    public static class Service
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IList<T> list)
        {
            var observableCollection = new ObservableCollection<T>();

            foreach(var item in list)
            {
                observableCollection.Add(item);
            }

            return observableCollection;
        }
    }
}
