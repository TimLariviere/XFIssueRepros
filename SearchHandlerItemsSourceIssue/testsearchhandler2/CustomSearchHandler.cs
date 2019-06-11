using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace testsearchhandler2
{
    public class CustomSearchHandler : SearchHandler
    {
        private static readonly string[] Values = new[]
        {
            "Abc",
            "Bce",
            "Xyz",
            "Qwe",
            "Rer",
            "Gep",
            "Qdw",
            "545"
        };

        private ObservableCollection<string> _items = new ObservableCollection<string>();

        public CustomSearchHandler()
        {
            ShowsResults = true;
            ItemsSource = _items;
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            var items = Values.Where(v => v.ToLowerInvariant().Contains(newValue.ToLowerInvariant())).ToList();

            for (int i = items.Count; i < _items.Count; i++)
            {
                _items.Remove(_items[i]);
            }

            for (int i = 0; i < items.Count; i++)
            {
                if (i >= _items.Count)
                {
                    _items.Add(items[i]);
                }
                else
                {
                    _items[i] = items[i];
                }
            }
        }
    }
}
