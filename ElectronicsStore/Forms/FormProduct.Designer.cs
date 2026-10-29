namespace ElectronicsStore.Forms
{
    partial class FormProduct
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelManufacturer = new Label();
            textBoxManufacturer = new TextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            labelFeatures = new Label();
            checkedListBoxFeatures = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            //
            // labelName
            //
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(50, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Модель:";
            //
            // textBoxName
            //
            textBoxName.Location = new Point(140, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 23);
            textBoxName.TabIndex = 1;
            //
            // labelManufacturer
            //
            labelManufacturer.AutoSize = true;
            labelManufacturer.Location = new Point(12, 50);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(92, 15);
            labelManufacturer.TabIndex = 2;
            labelManufacturer.Text = "Производитель:";
            //
            // textBoxManufacturer
            //
            textBoxManufacturer.Location = new Point(140, 47);
            textBoxManufacturer.Name = "textBoxManufacturer";
            textBoxManufacturer.Size = new Size(270, 23);
            textBoxManufacturer.TabIndex = 3;
            //
            // labelCategory
            //
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(12, 85);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(66, 15);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Категория:";
            //
            // comboBoxCategory
            //
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(140, 82);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(270, 23);
            comboBoxCategory.TabIndex = 5;
            //
            // labelPrice
            //
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 120);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(67, 15);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Цена, руб.:";
            //
            // numericUpDownPrice
            //
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(140, 118);
            numericUpDownPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(270, 23);
            numericUpDownPrice.TabIndex = 7;
            numericUpDownPrice.ThousandsSeparator = true;
            //
            // labelFeatures
            //
            labelFeatures.AutoSize = true;
            labelFeatures.Location = new Point(12, 155);
            labelFeatures.Name = "labelFeatures";
            labelFeatures.Size = new Size(102, 15);
            labelFeatures.TabIndex = 8;
            labelFeatures.Text = "Характеристики:";
            //
            // checkedListBoxFeatures
            //
            checkedListBoxFeatures.CheckOnClick = true;
            checkedListBoxFeatures.FormattingEnabled = true;
            checkedListBoxFeatures.Location = new Point(140, 153);
            checkedListBoxFeatures.Name = "checkedListBoxFeatures";
            checkedListBoxFeatures.Size = new Size(270, 130);
            checkedListBoxFeatures.TabIndex = 9;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(140, 300);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 32);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(285, 300);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 32);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormProduct
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 346);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxFeatures);
            Controls.Add(labelFeatures);
            Controls.Add(numericUpDownPrice);
            Controls.Add(labelPrice);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(textBoxManufacturer);
            Controls.Add(labelManufacturer);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Товар";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelManufacturer;
        private TextBox textBoxManufacturer;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private Label labelFeatures;
        private CheckedListBox checkedListBoxFeatures;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
