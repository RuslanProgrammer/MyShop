namespace UserApp
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toSignInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.HistoryGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchItemBox = new System.Windows.Forms.TextBox();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.basketToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDesktopToolStripMenuItem,
            this.toSignInToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toDesktopToolStripMenuItem
            // 
            this.toDesktopToolStripMenuItem.Name = "toDesktopToolStripMenuItem";
            this.toDesktopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toDesktopToolStripMenuItem.Text = "To Desktop";
            this.toDesktopToolStripMenuItem.Click += new System.EventHandler(this.toDesktopToolStripMenuItem_Click);
            // 
            // toSignInToolStripMenuItem
            // 
            this.toSignInToolStripMenuItem.Name = "toSignInToolStripMenuItem";
            this.toSignInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toSignInToolStripMenuItem.Text = "To Sign In";
            this.toSignInToolStripMenuItem.Click += new System.EventHandler(this.toSignInToolStripMenuItem_Click);
            // 
            // basketToolStripMenuItem
            // 
            this.basketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.basketToolStripMenuItem.Name = "basketToolStripMenuItem";
            this.basketToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.basketToolStripMenuItem.Text = "Basket";
            this.basketToolStripMenuItem.Click += new System.EventHandler(this.basketToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ItemsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ItemsLabel.Location = new System.Drawing.Point(21, 37);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(98, 31);
            this.ItemsLabel.TabIndex = 5;
            this.ItemsLabel.Text = "Basket";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 486);
            this.label1.TabIndex = 6;
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.AllowUserToAddRows = false;
            this.ItemsGridView.AllowUserToDeleteRows = false;
            this.ItemsGridView.AllowUserToResizeColumns = false;
            this.ItemsGridView.AllowUserToResizeRows = false;
            this.ItemsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGridView.Location = new System.Drawing.Point(12, 90);
            this.ItemsGridView.MultiSelect = false;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.ReadOnly = true;
            this.ItemsGridView.RowHeadersVisible = false;
            this.ItemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGridView.Size = new System.Drawing.Size(289, 424);
            this.ItemsGridView.TabIndex = 7;
            this.ItemsGridView.SizeChanged += new System.EventHandler(this.ItemsGridView_SizeChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(306, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 414);
            this.label3.TabIndex = 9;
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.AllowUserToAddRows = false;
            this.HistoryGridView.AllowUserToDeleteRows = false;
            this.HistoryGridView.AllowUserToResizeColumns = false;
            this.HistoryGridView.AllowUserToResizeRows = false;
            this.HistoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Location = new System.Drawing.Point(306, 71);
            this.HistoryGridView.MultiSelect = false;
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.ReadOnly = true;
            this.HistoryGridView.RowHeadersVisible = false;
            this.HistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryGridView.Size = new System.Drawing.Size(289, 371);
            this.HistoryGridView.TabIndex = 11;
            this.HistoryGridView.SelectionChanged += new System.EventHandler(this.HistoryGridView_SelectionChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(316, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "My History";
            // 
            // SearchItemBox
            // 
            this.SearchItemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchItemBox.Location = new System.Drawing.Point(12, 71);
            this.SearchItemBox.Name = "SearchItemBox";
            this.SearchItemBox.Size = new System.Drawing.Size(289, 20);
            this.SearchItemBox.TabIndex = 14;
            this.SearchItemBox.TextChanged += new System.EventHandler(this.SearchItemBox_TextChanged);
            // 
            // Finishbutton
            // 
            this.Finishbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Finishbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Finishbutton.Location = new System.Drawing.Point(454, 462);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(138, 52);
            this.Finishbutton.TabIndex = 15;
            this.Finishbutton.Text = "Finish";
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.Finishbutton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 523);
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.SearchItemBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HistoryGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemsGridView);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(620, 562);
            this.Name = "UserForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toSignInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView HistoryGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchItemBox;
        private System.Windows.Forms.ToolStripMenuItem basketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button Finishbutton;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}

