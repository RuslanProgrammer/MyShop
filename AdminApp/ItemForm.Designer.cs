namespace AdminApp
{
    partial class ItemForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ChangeImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.AvaliableUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvaliableUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(67, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(233, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.Text = "Product";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(13, 39);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(26, 13);
            this.UnitLabel.TabIndex = 3;
            this.UnitLabel.Text = "Unit";
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Items.AddRange(new object[] {
            "kg",
            "l",
            "unit"});
            this.UnitComboBox.Location = new System.Drawing.Point(67, 36);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(87, 21);
            this.UnitComboBox.TabIndex = 4;
            this.UnitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // PriceUpDown
            // 
            this.PriceUpDown.DecimalPlaces = 2;
            this.PriceUpDown.Location = new System.Drawing.Point(67, 63);
            this.PriceUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PriceUpDown.Name = "PriceUpDown";
            this.PriceUpDown.Size = new System.Drawing.Size(87, 20);
            this.PriceUpDown.TabIndex = 6;
            this.PriceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceUpDown.ValueChanged += new System.EventHandler(this.PriceUpDown_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(16, 147);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(86, 32);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChangeImageButton
            // 
            this.ChangeImageButton.Location = new System.Drawing.Point(67, 116);
            this.ChangeImageButton.Name = "ChangeImageButton";
            this.ChangeImageButton.Size = new System.Drawing.Size(87, 25);
            this.ChangeImageButton.TabIndex = 9;
            this.ChangeImageButton.Text = "Change image";
            this.ChangeImageButton.UseVisualStyleBackColor = true;
            this.ChangeImageButton.Click += new System.EventHandler(this.ChangeImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.png | *.*";
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Location = new System.Drawing.Point(13, 91);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(50, 13);
            this.AvailableLabel.TabIndex = 10;
            this.AvailableLabel.Text = "Available";
            // 
            // AvaliableUpDown
            // 
            this.AvaliableUpDown.DecimalPlaces = 3;
            this.AvaliableUpDown.Location = new System.Drawing.Point(67, 89);
            this.AvaliableUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.AvaliableUpDown.Name = "AvaliableUpDown";
            this.AvaliableUpDown.Size = new System.Drawing.Size(87, 20);
            this.AvaliableUpDown.TabIndex = 11;
            this.AvaliableUpDown.ThousandsSeparator = true;
            this.AvaliableUpDown.ValueChanged += new System.EventHandler(this.AvailableUpDown_ValueChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.ErrorImage = global::AdminApp.Properties.Resources.item;
            this.PictureBox.Image = global::AdminApp.Properties.Resources.item;
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(160, 39);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(140, 140);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 7;
            this.PictureBox.TabStop = false;
            this.PictureBox.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Prices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvaliableUpDown);
            this.Controls.Add(this.AvailableLabel);
            this.Controls.Add(this.ChangeImageButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PriceUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ItemForm";
            this.Text = "Item Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvaliableUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PriceUpDown;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ChangeImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.NumericUpDown AvaliableUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}