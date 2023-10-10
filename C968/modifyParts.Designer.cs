namespace C968
{
    partial class modifyPartsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyPartsScreen));
            inHouseRadio = new RadioButton();
            outsourcedRadio = new RadioButton();
            idBox = new TextBox();
            nameBox = new TextBox();
            inventoryBox = new TextBox();
            priceBox = new TextBox();
            addMinBox = new TextBox();
            nameMachineBox = new TextBox();
            addMaxBox = new TextBox();
            cancelButton = new Button();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // inHouseRadio
            // 
            inHouseRadio.AutoSize = true;
            inHouseRadio.ForeColor = SystemColors.ButtonHighlight;
            inHouseRadio.Location = new Point(18, 21);
            inHouseRadio.Margin = new Padding(3, 4, 3, 4);
            inHouseRadio.Name = "inHouseRadio";
            inHouseRadio.Size = new Size(90, 24);
            inHouseRadio.TabIndex = 0;
            inHouseRadio.Text = "In-House";
            inHouseRadio.UseVisualStyleBackColor = true;
            inHouseRadio.CheckedChanged += inHouseRadio_CheckedChanged;
            // 
            // outsourcedRadio
            // 
            outsourcedRadio.AutoSize = true;
            outsourcedRadio.ForeColor = SystemColors.ButtonHighlight;
            outsourcedRadio.Location = new Point(172, 21);
            outsourcedRadio.Margin = new Padding(3, 4, 3, 4);
            outsourcedRadio.Name = "outsourcedRadio";
            outsourcedRadio.Size = new Size(106, 24);
            outsourcedRadio.TabIndex = 1;
            outsourcedRadio.Text = "Outsourced";
            outsourcedRadio.UseVisualStyleBackColor = true;
            outsourcedRadio.CheckedChanged += outsourcedRadio_CheckedChanged;
            // 
            // idBox
            // 
            idBox.BackColor = SystemColors.ButtonFace;
            idBox.Enabled = false;
            idBox.Location = new Point(129, 114);
            idBox.Margin = new Padding(3, 4, 3, 4);
            idBox.Name = "idBox";
            idBox.Size = new Size(283, 27);
            idBox.TabIndex = 2;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.White;
            nameBox.Location = new Point(129, 153);
            nameBox.Margin = new Padding(3, 4, 3, 4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(283, 27);
            nameBox.TabIndex = 0;
            // 
            // inventoryBox
            // 
            inventoryBox.BackColor = Color.White;
            inventoryBox.Location = new Point(129, 191);
            inventoryBox.Margin = new Padding(3, 4, 3, 4);
            inventoryBox.Name = "inventoryBox";
            inventoryBox.Size = new Size(283, 27);
            inventoryBox.TabIndex = 1;
            // 
            // priceBox
            // 
            priceBox.BackColor = Color.White;
            priceBox.Location = new Point(129, 230);
            priceBox.Margin = new Padding(3, 4, 3, 4);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(283, 27);
            priceBox.TabIndex = 2;
            // 
            // addMinBox
            // 
            addMinBox.BackColor = Color.White;
            addMinBox.Location = new Point(413, 267);
            addMinBox.Margin = new Padding(3, 4, 3, 4);
            addMinBox.Name = "addMinBox";
            addMinBox.Size = new Size(135, 27);
            addMinBox.TabIndex = 4;
            // 
            // nameMachineBox
            // 
            nameMachineBox.BackColor = Color.White;
            nameMachineBox.Location = new Point(129, 307);
            nameMachineBox.Margin = new Padding(3, 4, 3, 4);
            nameMachineBox.Name = "nameMachineBox";
            nameMachineBox.Size = new Size(283, 27);
            nameMachineBox.TabIndex = 5;
            // 
            // addMaxBox
            // 
            addMaxBox.BackColor = Color.White;
            addMaxBox.Location = new Point(129, 268);
            addMaxBox.Margin = new Padding(3, 4, 3, 4);
            addMaxBox.Name = "addMaxBox";
            addMaxBox.Size = new Size(135, 27);
            addMaxBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(465, 349);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(86, 31);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(372, 349);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(86, 31);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Creepster", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(5, 13);
            label1.Name = "label1";
            label1.Size = new Size(194, 43);
            label1.TabIndex = 11;
            label1.Text = "Modify Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(101, 118);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(77, 157);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 13;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(57, 195);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 14;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(44, 234);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 15;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(371, 273);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 16;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(40, 310);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 17;
            label7.Text = "Machine ID";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(88, 273);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 18;
            label8.Text = "Max";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(5, 310);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 19;
            label9.Text = "Company Name";
            label9.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(inHouseRadio);
            panel1.Controls.Add(outsourcedRadio);
            panel1.Location = new Point(129, 43);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 63);
            panel1.TabIndex = 20;
            // 
            // modifyPartsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 393);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(addMaxBox);
            Controls.Add(nameMachineBox);
            Controls.Add(addMinBox);
            Controls.Add(priceBox);
            Controls.Add(inventoryBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "modifyPartsScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify Part";
            Load += part_template2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton inHouseRadio;
        private RadioButton outsourcedRadio;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox inventoryBox;
        private TextBox priceBox;
        private TextBox addMinBox;
        private TextBox nameMachineBox;
        private TextBox addMaxBox;
        private Button cancelButton;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
    }
}