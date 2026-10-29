namespace ElectronicsStore.Forms
{
    partial class FormSupplier
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
            labelContactPerson = new Label();
            textBoxContactPerson = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            //
            // labelName
            //
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Название:";
            //
            // textBoxName
            //
            textBoxName.Location = new Point(140, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 23);
            textBoxName.TabIndex = 1;
            //
            // labelContactPerson
            //
            labelContactPerson.AutoSize = true;
            labelContactPerson.Location = new Point(12, 50);
            labelContactPerson.Name = "labelContactPerson";
            labelContactPerson.Size = new Size(100, 15);
            labelContactPerson.TabIndex = 2;
            labelContactPerson.Text = "Контактное лицо:";
            //
            // textBoxContactPerson
            //
            textBoxContactPerson.Location = new Point(140, 47);
            textBoxContactPerson.Name = "textBoxContactPerson";
            textBoxContactPerson.Size = new Size(270, 23);
            textBoxContactPerson.TabIndex = 3;
            //
            // labelPhone
            //
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(12, 85);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(55, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Телефон:";
            //
            // textBoxPhone
            //
            textBoxPhone.Location = new Point(140, 82);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(270, 23);
            textBoxPhone.TabIndex = 5;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(140, 125);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 32);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(285, 125);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(125, 32);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            //
            // FormSupplier
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 171);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxContactPerson);
            Controls.Add(labelContactPerson);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поставщик";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelContactPerson;
        private TextBox textBoxContactPerson;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
