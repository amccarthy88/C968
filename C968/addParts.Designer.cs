namespace C968
{
    partial class addPartsForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPartsForm));
            addInHouseRadio = new RadioButton();
            addOutsourcedRadio = new RadioButton();
            addIDBox = new TextBox();
            addNameBox = new TextBox();
            addInventoryBox = new TextBox();
            addPriceCostBox = new TextBox();
            addMinBox = new TextBox();
            addCompanyNameBox = new TextBox();
            addMaxBox = new TextBox();
            addCancelButton = new Button();
            addSaveButton = new Button();
            addPartLabel = new Label();
            addIDLabel = new Label();
            addNameLabel = new Label();
            addInventoryLabel = new Label();
            addPriceCostLabel = new Label();
            addMaxLabel = new Label();
            machineIDLabel = new Label();
            minLabel = new Label();
            addCompanyLabel = new Label();
            addRadioContainer = new Panel();
            toolTip1 = new ToolTip(components);
            addRadioContainer.SuspendLayout();
            SuspendLayout();
            // 
            // addInHouseRadio
            // 
            addInHouseRadio.AutoSize = true;
            addInHouseRadio.ForeColor = SystemColors.ButtonHighlight;
            addInHouseRadio.Location = new Point(11, 35);
            addInHouseRadio.Margin = new Padding(3, 4, 3, 4);
            addInHouseRadio.Name = "addInHouseRadio";
            addInHouseRadio.Size = new Size(90, 24);
            addInHouseRadio.TabIndex = 0;
            addInHouseRadio.Text = "In-House";
            toolTip1.SetToolTip(addInHouseRadio, "In Haunted House");
            addInHouseRadio.UseVisualStyleBackColor = true;
            addInHouseRadio.CheckedChanged += inHouseRadio_CheckedChanged;
            // 
            // addOutsourcedRadio
            // 
            addOutsourcedRadio.AutoSize = true;
            addOutsourcedRadio.ForeColor = SystemColors.ButtonHighlight;
            addOutsourcedRadio.Location = new Point(165, 35);
            addOutsourcedRadio.Margin = new Padding(3, 4, 3, 4);
            addOutsourcedRadio.Name = "addOutsourcedRadio";
            addOutsourcedRadio.Size = new Size(106, 24);
            addOutsourcedRadio.TabIndex = 1;
            addOutsourcedRadio.Text = "Outsourced";
            addOutsourcedRadio.UseVisualStyleBackColor = true;
            addOutsourcedRadio.CheckedChanged += outsourcedRadio_CheckedChanged;
            // 
            // addIDBox
            // 
            addIDBox.BackColor = SystemColors.AppWorkspace;
            addIDBox.Enabled = false;
            addIDBox.Location = new Point(137, 115);
            addIDBox.Margin = new Padding(3, 4, 3, 4);
            addIDBox.Name = "addIDBox";
            addIDBox.Size = new Size(283, 27);
            addIDBox.TabIndex = 2;
            // 
            // addNameBox
            // 
            addNameBox.BackColor = Color.FromArgb(255, 192, 128);
            addNameBox.Location = new Point(137, 154);
            addNameBox.Margin = new Padding(3, 4, 3, 4);
            addNameBox.Name = "addNameBox";
            addNameBox.Size = new Size(283, 27);
            addNameBox.TabIndex = 0;
            // 
            // addInventoryBox
            // 
            addInventoryBox.BackColor = Color.FromArgb(255, 192, 128);
            addInventoryBox.Location = new Point(137, 192);
            addInventoryBox.Margin = new Padding(3, 4, 3, 4);
            addInventoryBox.Name = "addInventoryBox";
            addInventoryBox.Size = new Size(283, 27);
            addInventoryBox.TabIndex = 1;
            // 
            // addPriceCostBox
            // 
            addPriceCostBox.BackColor = Color.FromArgb(255, 192, 128);
            addPriceCostBox.Location = new Point(137, 231);
            addPriceCostBox.Margin = new Padding(3, 4, 3, 4);
            addPriceCostBox.Name = "addPriceCostBox";
            addPriceCostBox.Size = new Size(283, 27);
            addPriceCostBox.TabIndex = 2;
            // 
            // addMinBox
            // 
            addMinBox.BackColor = Color.FromArgb(255, 192, 128);
            addMinBox.Location = new Point(424, 268);
            addMinBox.Margin = new Padding(3, 4, 3, 4);
            addMinBox.Name = "addMinBox";
            addMinBox.Size = new Size(135, 27);
            addMinBox.TabIndex = 4;
            // 
            // addCompanyNameBox
            // 
            addCompanyNameBox.BackColor = Color.FromArgb(255, 192, 128);
            addCompanyNameBox.Location = new Point(137, 308);
            addCompanyNameBox.Margin = new Padding(3, 4, 3, 4);
            addCompanyNameBox.Name = "addCompanyNameBox";
            addCompanyNameBox.Size = new Size(283, 27);
            addCompanyNameBox.TabIndex = 5;
            // 
            // addMaxBox
            // 
            addMaxBox.BackColor = Color.FromArgb(255, 192, 128);
            addMaxBox.Location = new Point(137, 269);
            addMaxBox.Margin = new Padding(3, 4, 3, 4);
            addMaxBox.Name = "addMaxBox";
            addMaxBox.Size = new Size(135, 27);
            addMaxBox.TabIndex = 3;
            // 
            // addCancelButton
            // 
            addCancelButton.Location = new Point(473, 350);
            addCancelButton.Margin = new Padding(3, 4, 3, 4);
            addCancelButton.Name = "addCancelButton";
            addCancelButton.Size = new Size(86, 31);
            addCancelButton.TabIndex = 7;
            addCancelButton.Text = "Cancel";
            addCancelButton.UseVisualStyleBackColor = true;
            addCancelButton.Click += cancelButton_Click;
            // 
            // addSaveButton
            // 
            addSaveButton.Location = new Point(380, 350);
            addSaveButton.Margin = new Padding(3, 4, 3, 4);
            addSaveButton.Name = "addSaveButton";
            addSaveButton.Size = new Size(86, 31);
            addSaveButton.TabIndex = 6;
            addSaveButton.Text = "Save";
            addSaveButton.UseVisualStyleBackColor = true;
            addSaveButton.Click += addSaveButton_Click;
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.BackColor = Color.FromArgb(38, 38, 38);
            addPartLabel.Font = new Font("Creepster", 24F, FontStyle.Regular, GraphicsUnit.Point);
            addPartLabel.ForeColor = SystemColors.ButtonHighlight;
            addPartLabel.Location = new Point(25, 9);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(152, 47);
            addPartLabel.TabIndex = 11;
            addPartLabel.Text = "Add Part";
            toolTip1.SetToolTip(addPartLabel, "Add Body Part");
            // 
            // addIDLabel
            // 
            addIDLabel.AutoSize = true;
            addIDLabel.ForeColor = SystemColors.ButtonHighlight;
            addIDLabel.Location = new Point(109, 119);
            addIDLabel.Name = "addIDLabel";
            addIDLabel.Size = new Size(24, 20);
            addIDLabel.TabIndex = 12;
            addIDLabel.Text = "ID";
            // 
            // addNameLabel
            // 
            addNameLabel.AutoSize = true;
            addNameLabel.ForeColor = SystemColors.ButtonHighlight;
            addNameLabel.Location = new Point(85, 158);
            addNameLabel.Name = "addNameLabel";
            addNameLabel.Size = new Size(49, 20);
            addNameLabel.TabIndex = 13;
            addNameLabel.Text = "Name";
            // 
            // addInventoryLabel
            // 
            addInventoryLabel.AutoSize = true;
            addInventoryLabel.ForeColor = SystemColors.ButtonHighlight;
            addInventoryLabel.Location = new Point(65, 196);
            addInventoryLabel.Name = "addInventoryLabel";
            addInventoryLabel.Size = new Size(70, 20);
            addInventoryLabel.TabIndex = 14;
            addInventoryLabel.Text = "Inventory";
            // 
            // addPriceCostLabel
            // 
            addPriceCostLabel.AutoSize = true;
            addPriceCostLabel.ForeColor = SystemColors.ButtonHighlight;
            addPriceCostLabel.Location = new Point(52, 235);
            addPriceCostLabel.Name = "addPriceCostLabel";
            addPriceCostLabel.Size = new Size(84, 20);
            addPriceCostLabel.TabIndex = 15;
            addPriceCostLabel.Text = "Price / Cost";
            // 
            // addMaxLabel
            // 
            addMaxLabel.AutoSize = true;
            addMaxLabel.ForeColor = SystemColors.ButtonHighlight;
            addMaxLabel.Location = new Point(382, 271);
            addMaxLabel.Name = "addMaxLabel";
            addMaxLabel.Size = new Size(34, 20);
            addMaxLabel.TabIndex = 16;
            addMaxLabel.Text = "Min";
            // 
            // machineIDLabel
            // 
            machineIDLabel.AutoSize = true;
            machineIDLabel.ForeColor = SystemColors.ButtonHighlight;
            machineIDLabel.Location = new Point(49, 311);
            machineIDLabel.Name = "machineIDLabel";
            machineIDLabel.Size = new Size(84, 20);
            machineIDLabel.TabIndex = 17;
            machineIDLabel.Text = "Machine ID";
            machineIDLabel.Visible = false;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.ForeColor = SystemColors.ButtonHighlight;
            minLabel.Location = new Point(94, 272);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(37, 20);
            minLabel.TabIndex = 18;
            minLabel.Text = "Max";
            // 
            // addCompanyLabel
            // 
            addCompanyLabel.AutoSize = true;
            addCompanyLabel.ForeColor = SystemColors.ButtonHighlight;
            addCompanyLabel.Location = new Point(16, 311);
            addCompanyLabel.Name = "addCompanyLabel";
            addCompanyLabel.Size = new Size(116, 20);
            addCompanyLabel.TabIndex = 19;
            addCompanyLabel.Text = "Company Name";
            addCompanyLabel.Visible = false;
            // 
            // addRadioContainer
            // 
            addRadioContainer.Controls.Add(addInHouseRadio);
            addRadioContainer.Controls.Add(addOutsourcedRadio);
            addRadioContainer.Location = new Point(137, 44);
            addRadioContainer.Margin = new Padding(3, 4, 3, 4);
            addRadioContainer.Name = "addRadioContainer";
            addRadioContainer.Size = new Size(283, 63);
            addRadioContainer.TabIndex = 20;
            // 
            // addPartsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 393);
            Controls.Add(addPartLabel);
            Controls.Add(addRadioContainer);
            Controls.Add(addCompanyLabel);
            Controls.Add(minLabel);
            Controls.Add(machineIDLabel);
            Controls.Add(addMaxLabel);
            Controls.Add(addPriceCostLabel);
            Controls.Add(addInventoryLabel);
            Controls.Add(addNameLabel);
            Controls.Add(addIDLabel);
            Controls.Add(addSaveButton);
            Controls.Add(addCancelButton);
            Controls.Add(addMaxBox);
            Controls.Add(addCompanyNameBox);
            Controls.Add(addMinBox);
            Controls.Add(addPriceCostBox);
            Controls.Add(addInventoryBox);
            Controls.Add(addNameBox);
            Controls.Add(addIDBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "addPartsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Part";
            Load += part_template1_Load;
            addRadioContainer.ResumeLayout(false);
            addRadioContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton addInHouseRadio;
        private RadioButton addOutsourcedRadio;
        private TextBox addIDBox;
        private TextBox addNameBox;
        private TextBox addInventoryBox;
        private TextBox addPriceCostBox;
        private TextBox addMinBox;
        private TextBox addCompanyNameBox;
        private TextBox addMaxBox;
        private Button addCancelButton;
        private Button addSaveButton;
        private Label addPartLabel;
        private Label addIDLabel;
        private Label addNameLabel;
        private Label addInventoryLabel;
        private Label addPriceCostLabel;
        private Label addMaxLabel;
        private Label machineIDLabel;
        private Label minLabel;
        private Label addCompanyLabel;
        private Panel addRadioContainer;
        private ToolTip toolTip1;
    }
}