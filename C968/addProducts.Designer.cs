using System.Windows.Forms;

namespace C968
{
    partial class addProductScreen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductScreen));
            addProductPartsDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            addProductAssociatedPartsDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            addProductAddPartButton = new Button();
            addProductDeleteAssociatedPartButton = new Button();
            addProductCancelButton = new Button();
            addProductSaveButton = new Button();
            addProductSearchBox = new TextBox();
            addProductSearchButton = new Button();
            addProductNameBox = new TextBox();
            addProductInventoryBox = new TextBox();
            addProductPriceBox = new TextBox();
            addProductMinBox = new TextBox();
            addProductMaxBox = new TextBox();
            addProductIDBox = new TextBox();
            addProductIDLabel = new Label();
            addProductNameLabel = new Label();
            addProductInventoryLabel = new Label();
            addProductPriceLabel = new Label();
            addProductMinLabel = new Label();
            addProductMaxLabel = new Label();
            addProductLabel = new Label();
            addProductPartsLabel = new Label();
            addProductAssociatedPartsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)addProductPartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addProductAssociatedPartsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addProductPartsDataGridView
            // 
            addProductPartsDataGridView.BackgroundColor = Color.Peru;
            addProductPartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addProductPartsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkOrange;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            addProductPartsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            addProductPartsDataGridView.Location = new Point(382, 65);
            addProductPartsDataGridView.Margin = new Padding(3, 4, 3, 4);
            addProductPartsDataGridView.Name = "addProductPartsDataGridView";
            addProductPartsDataGridView.RowHeadersVisible = false;
            addProductPartsDataGridView.RowHeadersWidth = 51;
            addProductPartsDataGridView.RowTemplate.Height = 25;
            addProductPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductPartsDataGridView.Size = new Size(753, 200);
            addProductPartsDataGridView.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "Part ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Inventory";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Min";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Max";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // addProductAssociatedPartsDataGridView
            // 
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            addProductAssociatedPartsDataGridView.BackgroundColor = Color.Peru;
            addProductAssociatedPartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addProductAssociatedPartsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            addProductAssociatedPartsDataGridView.Location = new Point(382, 312);
            addProductAssociatedPartsDataGridView.Margin = new Padding(3, 4, 3, 4);
            addProductAssociatedPartsDataGridView.Name = "addProductAssociatedPartsDataGridView";
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkOrange;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            addProductAssociatedPartsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            addProductAssociatedPartsDataGridView.RowHeadersVisible = false;
            addProductAssociatedPartsDataGridView.RowHeadersWidth = 51;
            addProductAssociatedPartsDataGridView.RowTemplate.Height = 25;
            addProductAssociatedPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductAssociatedPartsDataGridView.Size = new Size(753, 200);
            addProductAssociatedPartsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Min";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Max";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // addProductAddPartButton
            // 
            addProductAddPartButton.Location = new Point(1049, 273);
            addProductAddPartButton.Margin = new Padding(3, 4, 3, 4);
            addProductAddPartButton.Name = "addProductAddPartButton";
            addProductAddPartButton.Size = new Size(86, 31);
            addProductAddPartButton.TabIndex = 9;
            addProductAddPartButton.Text = "Add";
            addProductAddPartButton.UseVisualStyleBackColor = true;
            addProductAddPartButton.Click += addProductAddPartButton_Click;
            // 
            // addProductDeleteAssociatedPartButton
            // 
            addProductDeleteAssociatedPartButton.Location = new Point(1049, 520);
            addProductDeleteAssociatedPartButton.Margin = new Padding(3, 4, 3, 4);
            addProductDeleteAssociatedPartButton.Name = "addProductDeleteAssociatedPartButton";
            addProductDeleteAssociatedPartButton.Size = new Size(86, 31);
            addProductDeleteAssociatedPartButton.TabIndex = 22;
            addProductDeleteAssociatedPartButton.Text = "Delete";
            addProductDeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            addProductDeleteAssociatedPartButton.Click += addProductDeleteAssociatedPartButton_Click;
            // 
            // addProductCancelButton
            // 
            addProductCancelButton.Location = new Point(1049, 559);
            addProductCancelButton.Margin = new Padding(3, 4, 3, 4);
            addProductCancelButton.Name = "addProductCancelButton";
            addProductCancelButton.Size = new Size(86, 31);
            addProductCancelButton.TabIndex = 6;
            addProductCancelButton.Text = "Cancel";
            addProductCancelButton.UseVisualStyleBackColor = true;
            addProductCancelButton.Click += addProductCancelButton_Click;
            // 
            // addProductSaveButton
            // 
            addProductSaveButton.Location = new Point(957, 559);
            addProductSaveButton.Margin = new Padding(3, 4, 3, 4);
            addProductSaveButton.Name = "addProductSaveButton";
            addProductSaveButton.Size = new Size(86, 31);
            addProductSaveButton.TabIndex = 5;
            addProductSaveButton.Text = "Save";
            addProductSaveButton.UseVisualStyleBackColor = true;
            addProductSaveButton.Click += addProductSaveButton_Click;
            // 
            // addProductSearchBox
            // 
            addProductSearchBox.Location = new Point(790, 27);
            addProductSearchBox.Margin = new Padding(3, 4, 3, 4);
            addProductSearchBox.Name = "addProductSearchBox";
            addProductSearchBox.Size = new Size(345, 27);
            addProductSearchBox.TabIndex = 7;
            // 
            // addProductSearchButton
            // 
            addProductSearchButton.Location = new Point(697, 27);
            addProductSearchButton.Margin = new Padding(3, 4, 3, 4);
            addProductSearchButton.Name = "addProductSearchButton";
            addProductSearchButton.Size = new Size(86, 31);
            addProductSearchButton.TabIndex = 8;
            addProductSearchButton.Text = "Search";
            addProductSearchButton.UseVisualStyleBackColor = true;
            addProductSearchButton.Click += addProductSearchButton_Click;
            // 
            // addProductNameBox
            // 
            addProductNameBox.BackColor = Color.FromArgb(255, 192, 128);
            addProductNameBox.Location = new Point(139, 227);
            addProductNameBox.Margin = new Padding(3, 4, 3, 4);
            addProductNameBox.Name = "addProductNameBox";
            addProductNameBox.Size = new Size(114, 27);
            addProductNameBox.TabIndex = 0;
            // 
            // addProductInventoryBox
            // 
            addProductInventoryBox.BackColor = Color.FromArgb(255, 192, 128);
            addProductInventoryBox.Location = new Point(139, 265);
            addProductInventoryBox.Margin = new Padding(3, 4, 3, 4);
            addProductInventoryBox.Name = "addProductInventoryBox";
            addProductInventoryBox.Size = new Size(114, 27);
            addProductInventoryBox.TabIndex = 1;
            // 
            // addProductPriceBox
            // 
            addProductPriceBox.BackColor = Color.FromArgb(255, 192, 128);
            addProductPriceBox.Location = new Point(139, 304);
            addProductPriceBox.Margin = new Padding(3, 4, 3, 4);
            addProductPriceBox.Name = "addProductPriceBox";
            addProductPriceBox.Size = new Size(114, 27);
            addProductPriceBox.TabIndex = 2;
            // 
            // addProductMinBox
            // 
            addProductMinBox.BackColor = Color.FromArgb(255, 192, 128);
            addProductMinBox.Location = new Point(253, 343);
            addProductMinBox.Margin = new Padding(3, 4, 3, 4);
            addProductMinBox.Name = "addProductMinBox";
            addProductMinBox.Size = new Size(114, 27);
            addProductMinBox.TabIndex = 4;
            // 
            // addProductMaxBox
            // 
            addProductMaxBox.BackColor = Color.FromArgb(255, 192, 128);
            addProductMaxBox.Location = new Point(69, 345);
            addProductMaxBox.Margin = new Padding(3, 4, 3, 4);
            addProductMaxBox.Name = "addProductMaxBox";
            addProductMaxBox.Size = new Size(114, 27);
            addProductMaxBox.TabIndex = 3;
            // 
            // addProductIDBox
            // 
            addProductIDBox.BackColor = SystemColors.ButtonFace;
            addProductIDBox.Enabled = false;
            addProductIDBox.Location = new Point(139, 188);
            addProductIDBox.Margin = new Padding(3, 4, 3, 4);
            addProductIDBox.Name = "addProductIDBox";
            addProductIDBox.Size = new Size(114, 27);
            addProductIDBox.TabIndex = 23;
            // 
            // addProductIDLabel
            // 
            addProductIDLabel.AutoSize = true;
            addProductIDLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductIDLabel.Location = new Point(6, 192);
            addProductIDLabel.Name = "addProductIDLabel";
            addProductIDLabel.Size = new Size(24, 20);
            addProductIDLabel.TabIndex = 13;
            addProductIDLabel.Text = "ID";
            // 
            // addProductNameLabel
            // 
            addProductNameLabel.AutoSize = true;
            addProductNameLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductNameLabel.Location = new Point(6, 231);
            addProductNameLabel.Name = "addProductNameLabel";
            addProductNameLabel.Size = new Size(49, 20);
            addProductNameLabel.TabIndex = 14;
            addProductNameLabel.Text = "Name";
            // 
            // addProductInventoryLabel
            // 
            addProductInventoryLabel.AutoSize = true;
            addProductInventoryLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductInventoryLabel.Location = new Point(6, 269);
            addProductInventoryLabel.Name = "addProductInventoryLabel";
            addProductInventoryLabel.Size = new Size(70, 20);
            addProductInventoryLabel.TabIndex = 15;
            addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductPriceLabel
            // 
            addProductPriceLabel.AutoSize = true;
            addProductPriceLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductPriceLabel.Location = new Point(6, 308);
            addProductPriceLabel.Name = "addProductPriceLabel";
            addProductPriceLabel.Size = new Size(41, 20);
            addProductPriceLabel.TabIndex = 16;
            addProductPriceLabel.Text = "Price";
            // 
            // addProductMinLabel
            // 
            addProductMinLabel.AutoSize = true;
            addProductMinLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductMinLabel.Location = new Point(198, 351);
            addProductMinLabel.Name = "addProductMinLabel";
            addProductMinLabel.Size = new Size(34, 20);
            addProductMinLabel.TabIndex = 18;
            addProductMinLabel.Text = "Min";
            // 
            // addProductMaxLabel
            // 
            addProductMaxLabel.AutoSize = true;
            addProductMaxLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductMaxLabel.Location = new Point(7, 349);
            addProductMaxLabel.Name = "addProductMaxLabel";
            addProductMaxLabel.Size = new Size(37, 20);
            addProductMaxLabel.TabIndex = 17;
            addProductMaxLabel.Text = "Max";
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Creepster", 24F, FontStyle.Regular, GraphicsUnit.Point);
            addProductLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductLabel.Location = new Point(12, 9);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(208, 47);
            addProductLabel.TabIndex = 21;
            addProductLabel.Text = "Add Product";
            // 
            // addProductPartsLabel
            // 
            addProductPartsLabel.AutoSize = true;
            addProductPartsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addProductPartsLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductPartsLabel.Location = new Point(382, 41);
            addProductPartsLabel.Name = "addProductPartsLabel";
            addProductPartsLabel.Size = new Size(136, 20);
            addProductPartsLabel.TabIndex = 19;
            addProductPartsLabel.Text = "All candidate Parts";
            // 
            // addProductAssociatedPartsLabel
            // 
            addProductAssociatedPartsLabel.AutoSize = true;
            addProductAssociatedPartsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addProductAssociatedPartsLabel.ForeColor = SystemColors.ButtonHighlight;
            addProductAssociatedPartsLabel.Location = new Point(382, 288);
            addProductAssociatedPartsLabel.Name = "addProductAssociatedPartsLabel";
            addProductAssociatedPartsLabel.Size = new Size(238, 20);
            addProductAssociatedPartsLabel.TabIndex = 20;
            addProductAssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // addProductScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1162, 621);
            Controls.Add(addProductAssociatedPartsLabel);
            Controls.Add(addProductPartsLabel);
            Controls.Add(addProductLabel);
            Controls.Add(addProductMaxLabel);
            Controls.Add(addProductMinLabel);
            Controls.Add(addProductPriceLabel);
            Controls.Add(addProductInventoryLabel);
            Controls.Add(addProductNameLabel);
            Controls.Add(addProductIDLabel);
            Controls.Add(addProductIDBox);
            Controls.Add(addProductMaxBox);
            Controls.Add(addProductMinBox);
            Controls.Add(addProductPriceBox);
            Controls.Add(addProductInventoryBox);
            Controls.Add(addProductNameBox);
            Controls.Add(addProductSearchButton);
            Controls.Add(addProductSearchBox);
            Controls.Add(addProductSaveButton);
            Controls.Add(addProductCancelButton);
            Controls.Add(addProductDeleteAssociatedPartButton);
            Controls.Add(addProductAddPartButton);
            Controls.Add(addProductAssociatedPartsDataGridView);
            Controls.Add(addProductPartsDataGridView);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "addProductScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            Load += addProducts_Load;
            ((System.ComponentModel.ISupportInitialize)addProductPartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addProductAssociatedPartsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView addProductPartsDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView addProductAssociatedPartsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button addProductAddPartButton;
        private Button addProductDeleteAssociatedPartButton;
        private Button addProductCancelButton;
        private Button addProductSaveButton;
        private TextBox addProductSearchBox;
        private Button addProductSearchButton;
        private TextBox addProductNameBox;
        private TextBox addProductInventoryBox;
        private TextBox addProductPriceBox;
        private TextBox addProductMinBox;
        private TextBox addProductMaxBox;
        private TextBox addProductIDBox;
        private Label addProductIDLabel;
        private Label addProductNameLabel;
        private Label addProductInventoryLabel;
        private Label addProductPriceLabel;
        private Label addProductMinLabel;
        private Label addProductMaxLabel;
        private Label addProductLabel;
        private Label addProductPartsLabel;
        private Label addProductAssociatedPartsLabel;
    }
}