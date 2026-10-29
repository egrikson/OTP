namespace ElectronicsStore.Forms
{
    partial class FormSupply
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
            labelSupplier = new Label();
            comboBoxSupplier = new ComboBox();
            labelProduct = new Label();
            comboBoxProduct = new ComboBox();
            labelCount = new Label();
            numericUpDownCount = new NumericUpDown();
            labelPurchasePrice = new Label();
            numericUpDownPurchasePrice = new NumericUpDown();
            labelDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPurchasePrice).BeginInit();
            SuspendLayout();
            //
            // labelSupplier
            //
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(12, 15);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(70, 15);
            labelSupplier.TabIndex = 0;
            labelSupplier.Text = "Поставщик:";
            //
            // comboBoxSupplier
            //
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(175, 12);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(235, 23);
            comboBoxSupplier.TabIndex = 1;
            //
            // labelProduct
            //
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(12, 50);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(41, 15);
            labelProduct.TabIndex = 2;
            labelProduct.Text = "Товар:";
            //
            // comboBoxProduct
            //
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(175, 47);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(235, 23);
            comboBoxProduct.TabIndex = 3;
            //
            // labelCount
            //
            labelCount.AutoSize = true;
            labelCount.Location = new Point(12, 85);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(75, 15);
            labelCount.TabIndex = 4;
            labelCount.Text = "Количество:";
            //
            // numericUpDownCount
            //
            numericUpDownCount.Location = new Point(175, 83);
            numericUpDownCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(235, 23);
            numericUpDownCount.TabIndex = 5;
            numericUpDownCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // labelPurchasePrice
            //
            labelPurchasePrice.AutoSize = true;
            labelPurchasePrice.Location = new Point(12, 120);
            labelPurchasePrice.Name = "labelPurchasePrice";
            labelPurchasePrice.Size = new Size(132, 15);
            labelPurchasePrice.TabIndex = 6;
            labelPurchasePrice.Text = "Закупочная цена, руб.:";
            //
            // numericUpDownPurchasePrice
            //
            numericUpDownPurchasePrice.DecimalPlaces = 2;
            numericUpDownPurchasePrice.Location = new Point(175, 118);
            numericUpDownPurchasePrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownPurchasePrice.Name = "numericUpDownPurchasePrice";
            numericUpDownPurchasePrice.Size = new Size(235, 23);
            numericUpDownPurchasePrice.TabIndex = 7;
            numericUpDownPurchasePrice.ThousandsSeparator = true;
            //
            // labelDate
            //
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 155);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(87, 15);
            labelDate.TabIndex = 8;
            labelDate.Text = "Дата поставки:";
            //
            // dateTimePickerDate
            //
            dateTimePickerDate.Enabled = false;
            dateTimePickerDate.Location = new Point(175, 152);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(235, 23);
            dateTimePickerDate.TabIndex = 9;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(140, 195);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 32);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(285, 195);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 32);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormSupply
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 241);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerDate);
            Controls.Add(labelDate);
            Controls.Add(numericUpDownPurchasePrice);
            Controls.Add(labelPurchasePrice);
            Controls.Add(numericUpDownCount);
            Controls.Add(labelCount);
            Controls.Add(comboBoxProduct);
            Controls.Add(labelProduct);
            Controls.Add(comboBoxSupplier);
            Controls.Add(labelSupplier);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSupply";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поставка товара";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPurchasePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSupplier;
        private ComboBox comboBoxSupplier;
        private Label labelProduct;
        private ComboBox comboBoxProduct;
        private Label labelCount;
        private NumericUpDown numericUpDownCount;
        private Label labelPurchasePrice;
        private NumericUpDown numericUpDownPurchasePrice;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
