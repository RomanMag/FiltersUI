using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersUI
{
    public partial class FilterListControl : UserControl, IFilterView
    {

        private string filterName = String.Empty;
        List<string> filterItems;

        public FilterListControl()
        {
            InitializeComponent();
        }

        public string FilePath
        {
            get
            {
                return filterConfigPathTextBox.Text;
            }

            set
            {
                filterConfigPathTextBox.Text = value;
            }
        }

        public string FilterName
        {
            get
            {
                return filterName;
            }

            set
            {
                filterName = value;
                filterSettingsGroupBox.Text = String.Format("{0} Settings", filterName);
            }
        }

        public List<string> FilterItems
        {
            get
            {
                return filterItems;
            }

            set
            {
                filterItems = value;
                FilterItemsListBox.DataSource = null;
                FilterItemsListBox.DataSource = filterItems;
            }
        }

        public event ConfigFileSelectedEventHandler ConfigFileSelected;
        public event FilterItemAddedEventHandler ItemAdded;
        public event FilterItemRemovedEventHandler ItemRemoved;



        private void filterBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filterConfigPathTextBox.Text = fileDialog.FileName;
                OnFileSelected();
            }
        }

        private void OnFileSelected()
        {
            if (ConfigFileSelected != null)
            {
                ConfigFileSelected(this, FilePath);
            }
        }

        private void addFilterItemButton_Click(object sender, EventArgs e)
        {
            OnItemAdded();
        }

        private void OnItemAdded()
        {
            if (ItemAdded != null)
            {
                ItemAdded(this, newFilterItemTextBox.Text);
            }
        }

        private void newFilterItemTextBox_TextChanged(object sender, EventArgs e)
        {
            addFilterItemButton.Enabled = !String.IsNullOrEmpty(newFilterItemTextBox.Text);
       }

        private void FilterItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeFilterItemButton.Enabled = FilterItemsListBox.SelectedIndex!=-1;
        }

        private void removeFilterItemButton_Click(object sender, EventArgs e)
        {
            OnItemRemoved();
        }

        private void OnItemRemoved()
        {
            if (ItemRemoved != null)
            {
                ItemRemoved(this, FilterItemsListBox.SelectedIndex);
            }
        }

    }
}
