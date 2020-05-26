namespace AdminApp
{
    partial class SupplyForm
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
            this.Labelfortotal = new System.Windows.Forms.Label();
            this.TotalLabe = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SupplyTable = new System.Windows.Forms.DataGridView();
            this.AutoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Labelfortotal
            // 
            this.Labelfortotal.AutoSize = true;
            this.Labelfortotal.Location = new System.Drawing.Point(227, 142);
            this.Labelfortotal.Name = "Labelfortotal";
            this.Labelfortotal.Size = new System.Drawing.Size(34, 13);
            this.Labelfortotal.TabIndex = 1;
            this.Labelfortotal.Text = "Total:";
            // 
            // TotalLabe
            // 
            this.TotalLabe.AutoSize = true;
            this.TotalLabe.Location = new System.Drawing.Point(258, 144);
            this.TotalLabe.Name = "TotalLabe";
            this.TotalLabe.Size = new System.Drawing.Size(13, 13);
            this.TotalLabe.TabIndex = 2;
            this.TotalLabe.Text = "0";
            this.TotalLabe.UseMnemonic = false;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(12, 158);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(52, 21);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(70, 158);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(52, 21);
            this.Deletebutton.TabIndex = 5;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(230, 158);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 28);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SupplyTable
            // 
            this.SupplyTable.AllowUserToAddRows = false;
            this.SupplyTable.AllowUserToDeleteRows = false;
            this.SupplyTable.BackgroundColor = System.Drawing.SystemColors.Info;
            this.SupplyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyTable.Location = new System.Drawing.Point(12, 13);
            this.SupplyTable.MultiSelect = false;
            this.SupplyTable.Name = "SupplyTable";
            this.SupplyTable.ReadOnly = true;
            this.SupplyTable.RowHeadersVisible = false;
            this.SupplyTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplyTable.Size = new System.Drawing.Size(303, 128);
            this.SupplyTable.TabIndex = 7;
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(128, 158);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(52, 21);
            this.AutoButton.TabIndex = 8;
            this.AutoButton.Text = "Auto";
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 191);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.SupplyTable);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.TotalLabe);
            this.Controls.Add(this.Labelfortotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SupplyForm";
            this.Text = "SupplyForm";
            ((System.ComponentModel.ISupportInitialize)(this.SupplyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Labelfortotal;
        private System.Windows.Forms.Label TotalLabe;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView SupplyTable;
        private System.Windows.Forms.Button AutoButton;
    }
}