namespace AdminApp
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitDesctop = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToLoginButton = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuppliesGridView = new System.Windows.Forms.DataGridView();
            this.dateTimeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfItemsInOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserItemsGridView = new System.Windows.Forms.DataGridView();
            this.portionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.supplyToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.reportToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            resources.ApplyResources(this.loadToolStripMenuItem, "loadToolStripMenuItem");
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // ExitButton
            // 
            this.ExitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitDesctop,
            this.ExitToLoginButton});
            this.ExitButton.Name = "ExitButton";
            resources.ApplyResources(this.ExitButton, "ExitButton");
            // 
            // ExitDesctop
            // 
            this.ExitDesctop.Name = "ExitDesctop";
            resources.ApplyResources(this.ExitDesctop, "ExitDesctop");
            this.ExitDesctop.Click += new System.EventHandler(this.ExitDesktop_Click);
            // 
            // ExitToLoginButton
            // 
            this.ExitToLoginButton.Name = "ExitToLoginButton";
            resources.ApplyResources(this.ExitToLoginButton, "ExitToLoginButton");
            this.ExitToLoginButton.Click += new System.EventHandler(this.ExitToLogin_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            resources.ApplyResources(this.itemToolStripMenuItem, "itemToolStripMenuItem");
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.ItemToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // supplyToolStripMenuItem
            // 
            this.supplyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            resources.ApplyResources(this.supplyToolStripMenuItem, "supplyToolStripMenuItem");
            this.supplyToolStripMenuItem.Click += new System.EventHandler(this.SupplyToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            resources.ApplyResources(this.newToolStripMenuItem1, "newToolStripMenuItem1");
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.NewToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            resources.ApplyResources(this.editToolStripMenuItem1, "editToolStripMenuItem1");
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            resources.ApplyResources(this.deleteToolStripMenuItem1, "deleteToolStripMenuItem1");
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            resources.ApplyResources(this.viewHelpToolStripMenuItem, "viewHelpToolStripMenuItem");
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            resources.ApplyResources(this.gitHubToolStripMenuItem, "gitHubToolStripMenuItem");
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            resources.ApplyResources(this.reportToolStripMenuItem, "reportToolStripMenuItem");
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Name = "label3";
            // 
            // ItemsLabel
            // 
            resources.ApplyResources(this.ItemsLabel, "ItemsLabel");
            this.ItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemsLabel.Name = "ItemsLabel";
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.ItemsGridView, "ItemsGridView");
            this.ItemsGridView.AutoGenerateColumns = false;
            this.ItemsGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.Image});
            this.ItemsGridView.DataSource = this.itemBindingSource;
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowHeadersVisible = false;
            this.ItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemsGridView_CellMouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            resources.ApplyResources(this.unitDataGridViewTextBoxColumn, "unitDataGridViewTextBoxColumn");
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            resources.ApplyResources(this.availableDataGridViewTextBoxColumn, "availableDataGridViewTextBoxColumn");
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            this.availableDataGridViewTextBoxColumn.ReadOnly = true;
            this.availableDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.DataPropertyName = "Image";
            resources.ApplyResources(this.Image, "Image");
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.AllowNew = true;
            this.itemBindingSource.DataSource = typeof(MyShop.Item);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // SuppliesGridView
            // 
            this.SuppliesGridView.AllowUserToAddRows = false;
            this.SuppliesGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.SuppliesGridView, "SuppliesGridView");
            this.SuppliesGridView.AutoGenerateColumns = false;
            this.SuppliesGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.SuppliesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeEndDataGridViewTextBoxColumn,
            this.CountOfItemsInOrder});
            this.SuppliesGridView.DataSource = this.supplyBindingSource;
            this.SuppliesGridView.MultiSelect = false;
            this.SuppliesGridView.Name = "SuppliesGridView";
            this.SuppliesGridView.ReadOnly = true;
            this.SuppliesGridView.RowHeadersVisible = false;
            this.SuppliesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppliesGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SuppliesGridView_CellMouseDoubleClick);
            // 
            // dateTimeEndDataGridViewTextBoxColumn
            // 
            this.dateTimeEndDataGridViewTextBoxColumn.DataPropertyName = "DateTimeEnd";
            resources.ApplyResources(this.dateTimeEndDataGridViewTextBoxColumn, "dateTimeEndDataGridViewTextBoxColumn");
            this.dateTimeEndDataGridViewTextBoxColumn.Name = "dateTimeEndDataGridViewTextBoxColumn";
            this.dateTimeEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CountOfItemsInOrder
            // 
            this.CountOfItemsInOrder.DataPropertyName = "Count";
            resources.ApplyResources(this.CountOfItemsInOrder, "CountOfItemsInOrder");
            this.CountOfItemsInOrder.Name = "CountOfItemsInOrder";
            this.CountOfItemsInOrder.ReadOnly = true;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataSource = typeof(MyShop.Supply);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Name = "label7";
            // 
            // UsersGridView
            // 
            this.UsersGridView.AllowUserToAddRows = false;
            this.UsersGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.UsersGridView, "UsersGridView");
            this.UsersGridView.AutoGenerateColumns = false;
            this.UsersGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn});
            this.UsersGridView.DataSource = this.userBindingSource;
            this.UsersGridView.MultiSelect = false;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.ReadOnly = true;
            this.UsersGridView.RowHeadersVisible = false;
            this.UsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGridView.CurrentCellChanged += new System.EventHandler(this.UsersGridView_CurrentCellChanged);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn1, "nameDataGridViewTextBoxColumn1");
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            resources.ApplyResources(this.passwordDataGridViewTextBoxColumn, "passwordDataGridViewTextBoxColumn");
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MyShop.User);
            // 
            // UserItemsGridView
            // 
            this.UserItemsGridView.AllowUserToAddRows = false;
            this.UserItemsGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.UserItemsGridView, "UserItemsGridView");
            this.UserItemsGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.UserItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserItemsGridView.MultiSelect = false;
            this.UserItemsGridView.Name = "UserItemsGridView";
            this.UserItemsGridView.ReadOnly = true;
            this.UserItemsGridView.RowHeadersVisible = false;
            this.UserItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserItemsGridView.SelectionChanged += new System.EventHandler(this.UserItemsGridView_SelectionChanged);
            // 
            // adminFormBindingSource
            // 
            this.adminFormBindingSource.DataSource = typeof(AdminApp.AdminForm);
            // 
            // adminFormBindingSource1
            // 
            this.adminFormBindingSource1.DataSource = typeof(AdminApp.AdminForm);
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserItemsGridView);
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SuppliesGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemsGridView);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.AdminForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminFormBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem ExitToLoginButton;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ExitDesctop;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView SuppliesGridView;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private System.Windows.Forms.BindingSource adminFormBindingSource;
        private System.Windows.Forms.BindingSource adminFormBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfItemsInOrder;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portionBindingSource;
        private System.Windows.Forms.DataGridView UserItemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}

