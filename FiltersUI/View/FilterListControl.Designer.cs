namespace FiltersUI
{
    partial class FilterListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterSaveButton = new System.Windows.Forms.Button();
            this.addFilterItemButton = new System.Windows.Forms.Button();
            this.newFilterItemTextBox = new System.Windows.Forms.TextBox();
            this.FilterItemsListBox = new System.Windows.Forms.ListBox();
            this.filterSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.filterBrowseButton = new System.Windows.Forms.Button();
            this.blackListConfigLabel = new System.Windows.Forms.Label();
            this.filterConfigPathTextBox = new System.Windows.Forms.TextBox();
            this.removeFilterItemButton = new System.Windows.Forms.Button();
            this.filterSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterSaveButton
            // 
            this.filterSaveButton.Location = new System.Drawing.Point(640, 48);
            this.filterSaveButton.Name = "filterSaveButton";
            this.filterSaveButton.Size = new System.Drawing.Size(70, 23);
            this.filterSaveButton.TabIndex = 15;
            this.filterSaveButton.Text = "Save";
            this.filterSaveButton.UseVisualStyleBackColor = true;
            // 
            // addFilterItemButton
            // 
            this.addFilterItemButton.Enabled = false;
            this.addFilterItemButton.Location = new System.Drawing.Point(640, 10);
            this.addFilterItemButton.Name = "addFilterItemButton";
            this.addFilterItemButton.Size = new System.Drawing.Size(20, 20);
            this.addFilterItemButton.TabIndex = 14;
            this.addFilterItemButton.Text = "+";
            this.addFilterItemButton.UseVisualStyleBackColor = true;
            this.addFilterItemButton.Click += new System.EventHandler(this.addFilterItemButton_Click);
            // 
            // newFilterItemTextBox
            // 
            this.newFilterItemTextBox.Location = new System.Drawing.Point(449, 10);
            this.newFilterItemTextBox.Name = "newFilterItemTextBox";
            this.newFilterItemTextBox.Size = new System.Drawing.Size(174, 20);
            this.newFilterItemTextBox.TabIndex = 13;
            this.newFilterItemTextBox.TextChanged += new System.EventHandler(this.newFilterItemTextBox_TextChanged);
            // 
            // FilterItemsListBox
            // 
            this.FilterItemsListBox.FormattingEnabled = true;
            this.FilterItemsListBox.Location = new System.Drawing.Point(449, 48);
            this.FilterItemsListBox.Name = "FilterItemsListBox";
            this.FilterItemsListBox.Size = new System.Drawing.Size(174, 303);
            this.FilterItemsListBox.TabIndex = 12;
            this.FilterItemsListBox.SelectedIndexChanged += new System.EventHandler(this.FilterItemsListBox_SelectedIndexChanged);
            // 
            // filterSettingsGroupBox
            // 
            this.filterSettingsGroupBox.Controls.Add(this.filterBrowseButton);
            this.filterSettingsGroupBox.Controls.Add(this.blackListConfigLabel);
            this.filterSettingsGroupBox.Controls.Add(this.filterConfigPathTextBox);
            this.filterSettingsGroupBox.Location = new System.Drawing.Point(3, 10);
            this.filterSettingsGroupBox.Name = "filterSettingsGroupBox";
            this.filterSettingsGroupBox.Size = new System.Drawing.Size(353, 135);
            this.filterSettingsGroupBox.TabIndex = 11;
            this.filterSettingsGroupBox.TabStop = false;
            this.filterSettingsGroupBox.Text = "Settings";
            // 
            // filterBrowseButton
            // 
            this.filterBrowseButton.Location = new System.Drawing.Point(213, 19);
            this.filterBrowseButton.Name = "filterBrowseButton";
            this.filterBrowseButton.Size = new System.Drawing.Size(75, 20);
            this.filterBrowseButton.TabIndex = 7;
            this.filterBrowseButton.Text = "Browse";
            this.filterBrowseButton.UseVisualStyleBackColor = true;
            this.filterBrowseButton.Click += new System.EventHandler(this.filterBrowseButton_Click);
            // 
            // blackListConfigLabel
            // 
            this.blackListConfigLabel.AutoSize = true;
            this.blackListConfigLabel.Location = new System.Drawing.Point(6, 22);
            this.blackListConfigLabel.Name = "blackListConfigLabel";
            this.blackListConfigLabel.Size = new System.Drawing.Size(59, 13);
            this.blackListConfigLabel.TabIndex = 6;
            this.blackListConfigLabel.Text = "Config File:";
            // 
            // filterConfigPathTextBox
            // 
            this.filterConfigPathTextBox.Location = new System.Drawing.Point(81, 19);
            this.filterConfigPathTextBox.Name = "filterConfigPathTextBox";
            this.filterConfigPathTextBox.ReadOnly = true;
            this.filterConfigPathTextBox.Size = new System.Drawing.Size(100, 20);
            this.filterConfigPathTextBox.TabIndex = 5;
            // 
            // removeFilterItemButton
            // 
            this.removeFilterItemButton.Enabled = false;
            this.removeFilterItemButton.Location = new System.Drawing.Point(640, 91);
            this.removeFilterItemButton.Name = "removeFilterItemButton";
            this.removeFilterItemButton.Size = new System.Drawing.Size(20, 20);
            this.removeFilterItemButton.TabIndex = 14;
            this.removeFilterItemButton.Text = "-";
            this.removeFilterItemButton.UseVisualStyleBackColor = true;
            this.removeFilterItemButton.Click += new System.EventHandler(this.removeFilterItemButton_Click);
            // 
            // FilterListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterSaveButton);
            this.Controls.Add(this.removeFilterItemButton);
            this.Controls.Add(this.addFilterItemButton);
            this.Controls.Add(this.newFilterItemTextBox);
            this.Controls.Add(this.FilterItemsListBox);
            this.Controls.Add(this.filterSettingsGroupBox);
            this.Name = "FilterListControl";
            this.Size = new System.Drawing.Size(713, 358);
            this.filterSettingsGroupBox.ResumeLayout(false);
            this.filterSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterSaveButton;
        private System.Windows.Forms.Button addFilterItemButton;
        private System.Windows.Forms.TextBox newFilterItemTextBox;
        private System.Windows.Forms.ListBox FilterItemsListBox;
        private System.Windows.Forms.GroupBox filterSettingsGroupBox;
        private System.Windows.Forms.Button filterBrowseButton;
        private System.Windows.Forms.Label blackListConfigLabel;
        private System.Windows.Forms.TextBox filterConfigPathTextBox;
        private System.Windows.Forms.Button removeFilterItemButton;
    }
}
