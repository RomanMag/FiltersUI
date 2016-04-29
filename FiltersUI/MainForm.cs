using FiltersUI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersUI
{
    public partial class MainForm : Form
    {
        IFilterViewController controller;

        public MainForm()
        {
            InitializeComponent();
            //whiteFilterEntriesListView.View = View.Details;
            controller = new FilterViewController();
            controller.AttachView(whiteFilterListControl);
            controller.AttachView(blackListControl);

        }

        private void browseInputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                inputFileTextBox.Text = fileDialog.FileName;
            }
        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                outputFileTextBox.Text = fileDialog.FileName;
            }
        }

        private void startFilteringButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputFileTextBox.Text))
            {
                MessageBox.Show("Please choose input file!");
                return;
            }

            if (String.IsNullOrEmpty(outputFileTextBox.Text))
            {
                MessageBox.Show("Please choose output file");
                return;
            }

            if (inputFileTextBox.Text.Equals(outputFileTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Choose different files!");
            }
        }


    }
}

