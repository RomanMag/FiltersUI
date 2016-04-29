using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersUI
{
    public interface IFilter
    {
        string ConfigFile { set; get; }

        List<string> GetFilteringItems();

        void Init();
    }
}
