namespace FiltersUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.configTabControl = new System.Windows.Forms.TabControl();
            this.generalConfigPage = new System.Windows.Forms.TabPage();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.startFilteringButton = new System.Windows.Forms.Button();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.whiteListPage = new System.Windows.Forms.TabPage();
            this.whiteFilterListControl = new FiltersUI.FilterListControl();
            this.blackListTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filterListControl1 = new FiltersUI.FilterListControl();
            this.blackListControl = new FiltersUI.FilterListControl();
            this.configTabControl.SuspendLayout();
            this.generalConfigPage.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.whiteListPage.SuspendLayout();
            this.blackListTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configTabControl
            // 
            this.configTabControl.Controls.Add(this.generalConfigPage);
            this.configTabControl.Controls.Add(this.whiteListPage);
            this.configTabControl.Controls.Add(this.blackListTabPage);
            this.configTabControl.Controls.Add(this.tabPage1);
            this.configTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTabControl.Location = new System.Drawing.Point(0, 0);
            this.configTabControl.Name = "configTabControl";
            this.configTabControl.SelectedIndex = 0;
            this.configTabControl.Size = new System.Drawing.Size(724, 425);
            this.configTabControl.TabIndex = 0;
            // 
            // generalConfigPage
            // 
            this.generalConfigPage.Controls.Add(this.filesGroupBox);
            this.generalConfigPage.Location = new System.Drawing.Point(4, 22);
            this.generalConfigPage.Name = "generalConfigPage";
            this.generalConfigPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalConfigPage.Size = new System.Drawing.Size(716, 399);
            this.generalConfigPage.TabIndex = 0;
            this.generalConfigPage.Text = "Options";
            this.generalConfigPage.UseVisualStyleBackColor = true;
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.startFilteringButton);
            this.filesGroupBox.Controls.Add(this.browseOutputButton);
            this.filesGroupBox.Controls.Add(this.browseInputButton);
            this.filesGroupBox.Controls.Add(this.label2);
            this.filesGroupBox.Controls.Add(this.label1);
            this.filesGroupBox.Controls.Add(this.outputFileTextBox);
            this.filesGroupBox.Controls.Add(this.inputFileTextBox);
            this.filesGroupBox.Location = new System.Drawing.Point(3, 6);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(334, 180);
            this.filesGroupBox.TabIndex = 0;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "I/O Settings";
            // 
            // startFilteringButton
            // 
            this.startFilteringButton.Location = new System.Drawing.Point(91, 118);
            this.startFilteringButton.Name = "startFilteringButton";
            this.startFilteringButton.Size = new System.Drawing.Size(163, 23);
            this.startFilteringButton.TabIndex = 6;
            this.startFilteringButton.Text = "Just do it!";
            this.startFilteringButton.UseVisualStyleBackColor = true;
            this.startFilteringButton.Click += new System.EventHandler(this.startFilteringButton_Click);
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Location = new System.Drawing.Point(207, 44);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(75, 20);
            this.browseOutputButton.TabIndex = 5;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // browseInputButton
            // 
            this.browseInputButton.Location = new System.Drawing.Point(207, 18);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(75, 20);
            this.browseInputButton.TabIndex = 4;
            this.browseInputButton.Text = "Browse";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File:";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(80, 44);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.ReadOnly = true;
            this.outputFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputFileTextBox.TabIndex = 1;
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(80, 18);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.ReadOnly = true;
            this.inputFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputFileTextBox.TabIndex = 0;
            // 
            // whiteListPage
            // 
            this.whiteListPage.Controls.Add(this.whiteFilterListControl);
            this.whiteListPage.Location = new System.Drawing.Point(4, 22);
            this.whiteListPage.Name = "whiteListPage";
            this.whiteListPage.Padding = new System.Windows.Forms.Padding(3);
            this.whiteListPage.Size = new System.Drawing.Size(716, 399);
            this.whiteListPage.TabIndex = 1;
            this.whiteListPage.Text = "White list";
            this.whiteListPage.UseVisualStyleBackColor = true;
            // 
            // whiteFilterListControl
            // 
            this.whiteFilterListControl.FilePath = "";
            this.whiteFilterListControl.FilterItems = null;
            this.whiteFilterListControl.FilterName = "";
            this.whiteFilterListControl.Location = new System.Drawing.Point(0, 6);
            this.whiteFilterListControl.Name = "whiteFilterListControl";
            this.whiteFilterListControl.Size = new System.Drawing.Size(713, 358);
            this.whiteFilterListControl.TabIndex = 0;
            // 
            // blackListTabPage
            // 
            this.blackListTabPage.Controls.Add(this.blackListControl);
            this.blackListTabPage.Location = new System.Drawing.Point(4, 22);
            this.blackListTabPage.Name = "blackListTabPage";
            this.blackListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blackListTabPage.Size = new System.Drawing.Size(716, 399);
            this.blackListTabPage.TabIndex = 2;
            this.blackListTabPage.Text = "Black List";
            this.blackListTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterListControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 399);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filterListControl1
            // 
            this.filterListControl1.FilePath = "";
            this.filterListControl1.FilterItems = ((System.Collections.Generic.List<string>)(resources.GetObject("filterListControl1.FilterItems")));
            this.filterListControl1.FilterName = "";
            this.filterListControl1.Location = new System.Drawing.Point(1, 7);
            this.filterListControl1.Name = "filterListControl1";
            this.filterListControl1.Size = new System.Drawing.Size(712, 384);
            this.filterListControl1.TabIndex = 0;
            // 
            // blackListControl
            // 
            this.blackListControl.FilePath = "";
            this.blackListControl.FilterItems = null;
            this.blackListControl.FilterName = "";
            this.blackListControl.Location = new System.Drawing.Point(3, 6);
            this.blackListControl.Name = "blackListControl";
            this.blackListControl.Size = new System.Drawing.Size(713, 358);
            this.blackListControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 425);
            this.Controls.Add(this.configTabControl);
            this.Name = "MainForm";
            this.Text = "Filters";
            this.configTabControl.ResumeLayout(false);
            this.generalConfigPage.ResumeLayout(false);
            this.filesGroupBox.ResumeLayout(false);
            this.filesGroupBox.PerformLayout();
            this.whiteListPage.ResumeLayout(false);
            this.blackListTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage whiteListPage;
        private System.Windows.Forms.TabPage generalConfigPage;
        private System.Windows.Forms.TabControl configTabControl;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.Button startFilteringButton;
        private System.Windows.Forms.TabPage blackListTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private FilterListControl filterListControl1;
        private FilterListControl whiteFilterListControl;
        private FilterListControl blackListControl;
    }
}

