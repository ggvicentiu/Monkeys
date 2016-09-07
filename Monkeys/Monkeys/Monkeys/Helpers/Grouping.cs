using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Monkeys.ViewModels
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public Grouping(object key, IEnumerable<T> items)
        {
            Key = (K) key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}