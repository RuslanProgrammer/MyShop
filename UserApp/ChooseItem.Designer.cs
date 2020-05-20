namespace UserApp
{
    partial class ChooseItem
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
            this.AllItemTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.SearchItemBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AllItemTable
            // 
            this.AllItemTable.AllowUserToAddRows = false;
            this.AllItemTable.AllowUserToDeleteRows = false;
            this.AllItemTable.AllowUserToResizeColumns = false;
            this.AllItemTable.AllowUserToResizeRows = false;
            this.AllItemTable.BackgroundColor = System.Drawing.SystemColors.Info;
            this.AllItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllItemTable.Location = new System.Drawing.Point(3, 26);
            this.AllItemTable.MultiSelect = false;
            this.AllItemTable.Name = "AllItemTable";
            this.AllItemTable.ReadOnly = true;
            this.AllItemTable.RowHeadersVisible = false;
            this.AllItemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllItemTable.Size = new System.Drawing.Size(288, 334);
            this.AllItemTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount:";
            // 
            // AmountUpDown
            // 
            this.AmountUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountUpDown.DecimalPlaces = 3;
            this.AmountUpDown.Location = new System.Drawing.Point(64, 371);
            this.AmountUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.AmountUpDown.Name = "AmountUpDown";
            this.AmountUpDown.Size = new System.Drawing.Size(76, 20);
            this.AmountUpDown.TabIndex = 10;
            this.AmountUpDown.ValueChanged += new System.EventHandler(this.AmountUpDown_ValueChanged);
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveItemButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveItemButton.Location = new System.Drawing.Point(206, 368);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(75, 23);
            this.SaveItemButton.TabIndex = 11;
            this.SaveItemButton.Text = "Save";
            this.SaveItemButton.UseVisualStyleBackColor = true;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // SearchItemBox
            // 
            this.SearchItemBox.Location = new System.Drawing.Point(3, 7);
            this.SearchItemBox.Name = "SearchItemBox";
            this.SearchItemBox.Size = new System.Drawing.Size(288, 20);
            this.SearchItemBox.TabIndex = 12;
            this.SearchItemBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChooseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 395);
            this.Controls.Add(this.SearchItemBox);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.AmountUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllItemTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseItem";
            this.Text = "ChooseItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseItem_FormClosing);
            this.Load += new System.EventHandler(this.ChooseItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllItemTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AmountUpDown;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.TextBox SearchItemBox;
    }
}