using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersUI.Controller
{
    public interface IFilterViewController
    {
        void AttachView(IFilterView view);
    }
}
