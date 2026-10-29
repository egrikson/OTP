namespace ElectronicsStore
{
    partial class FormElectronicsStore
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
            menuStrip = new MenuStrip();
            directoriesToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            suppliesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip
            //
            menuStrip.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            //
            // directoriesToolStripMenuItem
            //
            directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productsToolStripMenuItem, customersToolStripMenuItem, suppliersToolStripMenuItem });
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Size = new Size(94, 20);
            directoriesToolStripMenuItem.Text = "Справочники";
            //
            // productsToolStripMenuItem
            //
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(180, 22);
            productsToolStripMenuItem.Text = "Товары";
            productsToolStripMenuItem.Click += ProductsToolStripMenuItem_Click;
            //
            // customersToolStripMenuItem
            //
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(180, 22);
            customersToolStripMenuItem.Text = "Клиенты";
            customersToolStripMenuItem.Click += CustomersToolStripMenuItem_Click;
            //
            // suppliersToolStripMenuItem
            //
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(180, 22);
            suppliersToolStripMenuItem.Text = "Поставщики";
            suppliersToolStripMenuItem.Click += SuppliersToolStripMenuItem_Click;
            //
            // operationsToolStripMenuItem
            //
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordersToolStripMenuItem, suppliesToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(75, 20);
            operationsToolStripMenuItem.Text = "Операции";
            //
            // ordersToolStripMenuItem
            //
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(180, 22);
            ordersToolStripMenuItem.Text = "Заказы";
            ordersToolStripMenuItem.Click += OrdersToolStripMenuItem_Click;
            //
            // suppliesToolStripMenuItem
            //
            suppliesToolStripMenuItem.Name = "suppliesToolStripMenuItem";
            suppliesToolStripMenuItem.Size = new Size(180, 22);
            suppliesToolStripMenuItem.Text = "Поставки товаров";
            suppliesToolStripMenuItem.Click += SuppliesToolStripMenuItem_Click;
            //
            // reportsToolStripMenuItem
            //
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(60, 20);
            reportsToolStripMenuItem.Text = "Отчеты";
            //
            // FormElectronicsStore
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormElectronicsStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Интернет-магазин электроники";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem directoriesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem suppliesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}
