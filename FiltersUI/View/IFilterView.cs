using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersUI
{
    public delegate void FilterItemAddedEventHandler(IFilterView sender, string newItem);
    public delegate void FilterItemRemovedEventHandler(IFilterView sender, int removedItem);
    public delegate void ConfigFileSelectedEventHandler(IFilterView sender, string pathToFile);

    public interface IFilterView
    {
        event FilterItemAddedEventHandler ItemAdded;
        event FilterItemRemovedEventHandler ItemRemoved;
        event ConfigFileSelectedEventHandler ConfigFileSelected;

        List<string> FilterItems { set; get; }
        string FilterName { set; get; }
        string FilePath { set; get; }
    }
}
