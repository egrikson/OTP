namespace ElectronicsStore.Forms
{
    partial class FormOrder
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
            labelCustomer = new Label();
            comboBoxCustomer = new ComboBox();
            labelDeliveryType = new Label();
            comboBoxDeliveryType = new ComboBox();
            labelDeliveryAddress = new Label();
            textBoxDeliveryAddress = new TextBox();
            labelDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            groupBoxProducts = new GroupBox();
            dataGridViewProducts = new DataGridView();
            ColumnProduct = new DataGridViewComboBoxColumn();
            ColumnCount = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            //
            // labelCustomer
            //
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(12, 15);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(49, 15);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Клиент:";
            //
            // comboBoxCustomer
            //
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(155, 12);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(315, 23);
            comboBoxCustomer.TabIndex = 1;
            //
            // labelDeliveryType
            //
            labelDeliveryType.AutoSize = true;
            labelDeliveryType.Location = new Point(12, 50);
            labelDeliveryType.Name = "labelDeliveryType";
            labelDeliveryType.Size = new Size(107, 15);
            labelDeliveryType.TabIndex = 2;
            labelDeliveryType.Text = "Способ получения:";
            //
            // comboBoxDeliveryType
            //
            comboBoxDeliveryType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeliveryType.FormattingEnabled = true;
            comboBoxDeliveryType.Location = new Point(155, 47);
            comboBoxDeliveryType.Name = "comboBoxDeliveryType";
            comboBoxDeliveryType.Size = new Size(315, 23);
            comboBoxDeliveryType.TabIndex = 3;
            //
            // labelDeliveryAddress
            //
            labelDeliveryAddress.AutoSize = true;
            labelDeliveryAddress.Location = new Point(12, 85);
            labelDeliveryAddress.Name = "labelDeliveryAddress";
            labelDeliveryAddress.Size = new Size(95, 15);
            labelDeliveryAddress.TabIndex = 4;
            labelDeliveryAddress.Text = "Адрес доставки:";
            //
            // textBoxDeliveryAddress
            //
            textBoxDeliveryAddress.Location = new Point(155, 82);
            textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            textBoxDeliveryAddress.Size = new Size(315, 23);
            textBoxDeliveryAddress.TabIndex = 5;
            //
            // labelDate
            //
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 120);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(75, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "Дата заказа:";
            //
            // dateTimePickerDate
            //
            dateTimePickerDate.Enabled = false;
            dateTimePickerDate.Location = new Point(155, 117);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(315, 23);
            dateTimePickerDate.TabIndex = 7;
            //
            // groupBoxProducts
            //
            groupBoxProducts.Controls.Add(dataGridViewProducts);
            groupBoxProducts.Location = new Point(12, 152);
            groupBoxProducts.Name = "groupBoxProducts";
            groupBoxProducts.Size = new Size(458, 230);
            groupBoxProducts.TabIndex = 8;
            groupBoxProducts.TabStop = false;
            groupBoxProducts.Text = "Товары";
            //
            // dataGridViewProducts
            //
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ColumnProduct, ColumnCount });
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(3, 19);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(452, 208);
            dataGridViewProducts.TabIndex = 0;
            //
            // ColumnProduct
            //
            ColumnProduct.HeaderText = "Товар";
            ColumnProduct.Name = "ColumnProduct";
            //
            // ColumnCount
            //
            ColumnCount.HeaderText = "Количество";
            ColumnCount.Name = "ColumnCount";
            //
            // buttonSave
            //
            buttonSave.Location = new Point(200, 395);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 32);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(345, 395);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 32);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormOrder
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 441);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(groupBoxProducts);
            Controls.Add(dateTimePickerDate);
            Controls.Add(labelDate);
            Controls.Add(textBoxDeliveryAddress);
            Controls.Add(labelDeliveryAddress);
            Controls.Add(comboBoxDeliveryType);
            Controls.Add(labelDeliveryType);
            Controls.Add(comboBoxCustomer);
            Controls.Add(labelCustomer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Заказ";
            groupBoxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomer;
        private ComboBox comboBoxCustomer;
        private Label labelDeliveryType;
        private ComboBox comboBoxDeliveryType;
        private Label labelDeliveryAddress;
        private TextBox textBoxDeliveryAddress;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private GroupBox groupBoxProducts;
        private DataGridView dataGridViewProducts;
        private DataGridViewComboBoxColumn ColumnProduct;
        private DataGridViewTextBoxColumn ColumnCount;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
