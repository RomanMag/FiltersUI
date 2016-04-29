using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersUI.Controller
{
    public class FilterViewController : IFilterViewController
    {
        public void AttachView(IFilterView view)
        {
            view.ConfigFileSelected += View_ConfigFileSelected;
            view.ItemAdded += View_ItemAdded;
            view.ItemRemoved += View_ItemRemoved;
        }

        private void View_ItemRemoved(IFilterView sender, int removedItem)
        {
            List<string> currentItems = sender.FilterItems;
            currentItems.RemoveAt(removedItem);
            using (StreamWriter writer = new StreamWriter(sender.FilePath))
            {
                foreach (var item in currentItems)
                {
                    writer.WriteLine(item);
                }
            }
            sender.FilterItems = currentItems;
        }

        private void View_ItemAdded(IFilterView sender, string newItem)
        {
            List<string> currentItems = sender.FilterItems;
            currentItems.Add(newItem);
            using (StreamWriter writer = new StreamWriter(sender.FilePath))
            {                
                foreach (var item in currentItems)
                {
                    writer.WriteLine(item);
                }
            }
            sender.FilterItems = currentItems;
        }



        private void View_ConfigFileSelected(IFilterView sender, string pathToFile)
        {
            List<string> filterItems = new List<string>();
            using (StreamReader reader = new StreamReader(pathToFile))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    filterItems.Add(line);
                }
            }

            sender.FilterItems = filterItems;
        }
    }
}
