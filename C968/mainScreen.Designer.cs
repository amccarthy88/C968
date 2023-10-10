namespace C968
{
    partial class C968
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C968));
            partsDataGridView = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            productsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            partsSearchButton = new Button();
            partsAddButton = new Button();
            partsModifyButton = new Button();
            partsDeleteButton = new Button();
            productsDeleteButton = new Button();
            productsModifyButton = new Button();
            productsAddButton = new Button();
            button8 = new Button();
            partsTableLabel = new Label();
            productsListLabel = new Label();
            mainLabel = new Label();
            partsSearchBox = new TextBox();
            textBox2 = new TextBox();
            button9 = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // partsDataGridView
            // 
            partsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.AllowUserToResizeColumns = false;
            partsDataGridView.AllowUserToResizeRows = false;
            partsDataGridView.BackgroundColor = Color.Peru;
            partsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3, Column6, Column4, Column5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkOrange;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            partsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            partsDataGridView.Location = new Point(12, 99);
            partsDataGridView.MultiSelect = false;
            partsDataGridView.Name = "partsDataGridView";
            partsDataGridView.ReadOnly = true;
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.RowHeadersWidth = 51;
            partsDataGridView.RowTemplate.Height = 29;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.Size = new Size(664, 188);
            partsDataGridView.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Part ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 110;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 110;
            // 
            // Column3
            // 
            Column3.HeaderText = "Inventory";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 110;
            // 
            // Column6
            // 
            Column6.HeaderText = "Price";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "Min";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 110;
            // 
            // Column5
            // 
            Column5.HeaderText = "Max";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 110;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToResizeColumns = false;
            productsDataGridView.AllowUserToResizeRows = false;
            productsDataGridView.BackgroundColor = Color.Peru;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkOrange;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            productsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            productsDataGridView.Location = new Point(682, 99);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.RowTemplate.Height = 29;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(663, 188);
            productsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Min";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Max";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 110;
            // 
            // partsSearchButton
            // 
            partsSearchButton.BackColor = Color.Gray;
            partsSearchButton.ForeColor = SystemColors.ActiveCaptionText;
            partsSearchButton.Location = new Point(382, 64);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(122, 29);
            partsSearchButton.TabIndex = 2;
            partsSearchButton.Text = "Spooky Search";
            partsSearchButton.UseVisualStyleBackColor = false;
            partsSearchButton.Click += partsSearchButton_Click;
            // 
            // partsAddButton
            // 
            partsAddButton.BackColor = Color.Gray;
            partsAddButton.ForeColor = SystemColors.ActiveCaptionText;
            partsAddButton.Location = new Point(382, 293);
            partsAddButton.Name = "partsAddButton";
            partsAddButton.Size = new Size(94, 29);
            partsAddButton.TabIndex = 3;
            partsAddButton.Text = "Add";
            toolTip1.SetToolTip(partsAddButton, "Click to Add Body Part");
            partsAddButton.UseVisualStyleBackColor = false;
            partsAddButton.Click += button2_Click;
            // 
            // partsModifyButton
            // 
            partsModifyButton.BackColor = Color.Gray;
            partsModifyButton.ForeColor = SystemColors.ActiveCaptionText;
            partsModifyButton.Location = new Point(482, 293);
            partsModifyButton.Name = "partsModifyButton";
            partsModifyButton.Size = new Size(94, 29);
            partsModifyButton.TabIndex = 4;
            partsModifyButton.Text = "Modify";
            toolTip1.SetToolTip(partsModifyButton, "Click to modify body part");
            partsModifyButton.UseVisualStyleBackColor = false;
            partsModifyButton.Click += partsModifyButton_Click;
            // 
            // partsDeleteButton
            // 
            partsDeleteButton.BackColor = Color.Gray;
            partsDeleteButton.ForeColor = SystemColors.ActiveCaptionText;
            partsDeleteButton.Location = new Point(582, 293);
            partsDeleteButton.Name = "partsDeleteButton";
            partsDeleteButton.Size = new Size(94, 29);
            partsDeleteButton.TabIndex = 5;
            partsDeleteButton.Text = "Delete";
            toolTip1.SetToolTip(partsDeleteButton, "Click to delete body part");
            partsDeleteButton.UseVisualStyleBackColor = false;
            partsDeleteButton.Click += button4_Click;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.BackColor = Color.Gray;
            productsDeleteButton.ForeColor = SystemColors.ActiveCaptionText;
            productsDeleteButton.Location = new Point(1251, 293);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(94, 29);
            productsDeleteButton.TabIndex = 9;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = false;
            productsDeleteButton.Click += button5_Click;
            // 
            // productsModifyButton
            // 
            productsModifyButton.BackColor = Color.Gray;
            productsModifyButton.ForeColor = SystemColors.ActiveCaptionText;
            productsModifyButton.Location = new Point(1151, 293);
            productsModifyButton.Name = "productsModifyButton";
            productsModifyButton.Size = new Size(94, 29);
            productsModifyButton.TabIndex = 8;
            productsModifyButton.Text = "Modify";
            productsModifyButton.UseVisualStyleBackColor = false;
            productsModifyButton.Click += button6_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.BackColor = Color.Gray;
            productsAddButton.ForeColor = SystemColors.ActiveCaptionText;
            productsAddButton.Location = new Point(1051, 293);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(94, 29);
            productsAddButton.TabIndex = 7;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = false;
            productsAddButton.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(1051, 64);
            button8.Name = "button8";
            button8.Size = new Size(120, 29);
            button8.TabIndex = 6;
            button8.Text = "Spooky Search";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // partsTableLabel
            // 
            partsTableLabel.AutoSize = true;
            partsTableLabel.BackColor = Color.FromArgb(64, 64, 64);
            partsTableLabel.Font = new Font("Creepster", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partsTableLabel.ForeColor = SystemColors.ButtonHighlight;
            partsTableLabel.Location = new Point(12, 68);
            partsTableLabel.Name = "partsTableLabel";
            partsTableLabel.Size = new Size(54, 23);
            partsTableLabel.TabIndex = 10;
            partsTableLabel.Text = "Parts";
            toolTip1.SetToolTip(partsTableLabel, "Body Parts");
            // 
            // productsListLabel
            // 
            productsListLabel.AutoSize = true;
            productsListLabel.BackColor = Color.FromArgb(64, 64, 64);
            productsListLabel.Font = new Font("Creepster", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productsListLabel.ForeColor = SystemColors.ButtonHighlight;
            productsListLabel.Location = new Point(682, 71);
            productsListLabel.Name = "productsListLabel";
            productsListLabel.Size = new Size(82, 23);
            productsListLabel.TabIndex = 11;
            productsListLabel.Text = "Products";
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.BackColor = Color.FromArgb(64, 64, 64);
            mainLabel.Font = new Font("Creepster", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.ForeColor = SystemColors.ButtonHighlight;
            mainLabel.Location = new Point(12, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(468, 43);
            mainLabel.TabIndex = 12;
            mainLabel.Text = "Inventory Management System";
            // 
            // partsSearchBox
            // 
            partsSearchBox.BackColor = Color.Lavender;
            partsSearchBox.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            partsSearchBox.Location = new Point(510, 65);
            partsSearchBox.Name = "partsSearchBox";
            partsSearchBox.PlaceholderText = "Search for body part...";
            partsSearchBox.Size = new Size(166, 27);
            partsSearchBox.TabIndex = 13;
            partsSearchBox.KeyPress += partsSearchBox_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Lavender;
            textBox2.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(1177, 65);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Witch Product?";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 14;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(1251, 351);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 15;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // C968
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1355, 473);
            Controls.Add(button9);
            Controls.Add(textBox2);
            Controls.Add(partsSearchBox);
            Controls.Add(mainLabel);
            Controls.Add(productsListLabel);
            Controls.Add(partsTableLabel);
            Controls.Add(productsDeleteButton);
            Controls.Add(productsModifyButton);
            Controls.Add(productsAddButton);
            Controls.Add(button8);
            Controls.Add(partsDeleteButton);
            Controls.Add(partsModifyButton);
            Controls.Add(partsAddButton);
            Controls.Add(partsSearchButton);
            Controls.Add(productsDataGridView);
            Controls.Add(partsDataGridView);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "C968";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mr. Skeltal's Spooky Bone Parts and Products Emporium (Spooky Stuff to Sell to Creepy People)";
            Load += C968_Load;
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView partsDataGridView;
        private DataGridView productsDataGridView;
        private Button partsSearchButton;
        private Button partsAddButton;
        private Button partsModifyButton;
        private Button partsDeleteButton;
        private Button productsDeleteButton;
        private Button productsModifyButton;
        private Button productsAddButton;
        private Button button8;
        private Label partsTableLabel;
        private Label productsListLabel;
        private Label mainLabel;
        private TextBox partsSearchBox;
        private TextBox textBox2;
        private Button button9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}