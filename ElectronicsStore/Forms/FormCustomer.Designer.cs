namespace ElectronicsStore.Forms
{
    partial class FormCustomer
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
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            //
            // labelFullName
            //
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(12, 15);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(37, 15);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "ФИО:";
            //
            // textBoxFullName
            //
            textBoxFullName.Location = new Point(140, 12);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(270, 23);
            textBoxFullName.TabIndex = 1;
            //
            // labelPhone
            //
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(12, 50);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(55, 15);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Телефон:";
            //
            // textBoxPhone
            //
            textBoxPhone.Location = new Point(140, 47);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(270, 23);
            textBoxPhone.TabIndex = 3;
            //
            // labelEmail
            //
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 85);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(64, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Эл. почта:";
            //
            // textBoxEmail
            //
            textBoxEmail.Location = new Point(140, 82);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 23);
            textBoxEmail.TabIndex = 5;
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
            // FormCustomer
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 171);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Клиент";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
