using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Responding_to_Changes_in_ObservableCollection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ObservableCollection<string> names = new ObservableCollection<string>();
            names.CollectionChanged += Names_CollectionChanged;

            names.Add("Ahmed");
            names.Add("Omar");
            names.Insert(0, "Yazen");
            names.Remove("Ahmed");
            names[0] = "Khalid";

            void Names_CollectionChanged(object sender,
                System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        Console.WriteLine($"Added: {string.Join(", ", e.NewItems.Cast<string>())}");
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        Console.WriteLine($"Removed: {string.Join(", ", e.OldItems.Cast<string>())}");
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        Console.WriteLine($"Replaced: {string.Join(", ", e.OldItems.Cast<string>())} with {string.Join(", ", e.NewItems.Cast<string>())}");
                        break;
                }
            }
        }
    }
}