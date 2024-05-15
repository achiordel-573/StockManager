namespace StockManager
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            debit_count = new DataGridViewTextBoxColumn();
            sale_count = new DataGridViewTextBoxColumn();
            products_ms = new MenuStrip();
            products_ms_reports = new ToolStripMenuItem();
            products_ms_i_invoice = new ToolStripMenuItem();
            products_ms_i_invoice_export = new ToolStripMenuItem();
            export_to_ms_excel = new ToolStripMenuItem();
            таблицаToolStripMenuItem2 = new ToolStripMenuItem();
            обновитьToolStripMenuItem1 = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            providers_ms = new MenuStrip();
            действияToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            экспортироватьToolStripMenuItem = new ToolStripMenuItem();
            mSExcelToolStripMenuItem2 = new ToolStripMenuItem();
            таблицаToolStripMenuItem = new ToolStripMenuItem();
            обновитьToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            products_ms.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            providers_ms.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(products_ms);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Товары";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { date, product_id, debit_count, sale_count });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 392);
            dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            date.HeaderText = "Дата";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // product_id
            // 
            product_id.HeaderText = "Товар";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            // 
            // debit_count
            // 
            debit_count.HeaderText = "Списано";
            debit_count.Name = "debit_count";
            debit_count.ReadOnly = true;
            // 
            // sale_count
            // 
            sale_count.HeaderText = "Продано";
            sale_count.Name = "sale_count";
            sale_count.ReadOnly = true;
            // 
            // products_ms
            // 
            products_ms.Items.AddRange(new ToolStripItem[] { products_ms_reports, таблицаToolStripMenuItem2 });
            products_ms.Location = new Point(3, 3);
            products_ms.Name = "products_ms";
            products_ms.Size = new Size(786, 24);
            products_ms.TabIndex = 1;
            products_ms.Text = "menuStrip1";
            // 
            // products_ms_reports
            // 
            products_ms_reports.DropDownItems.AddRange(new ToolStripItem[] { products_ms_i_invoice });
            products_ms_reports.Name = "products_ms_reports";
            products_ms_reports.Size = new Size(60, 20);
            products_ms_reports.Text = "Отчёты";
            // 
            // products_ms_i_invoice
            // 
            products_ms_i_invoice.DropDownItems.AddRange(new ToolStripItem[] { products_ms_i_invoice_export });
            products_ms_i_invoice.Name = "products_ms_i_invoice";
            products_ms_i_invoice.Size = new Size(147, 22);
            products_ms_i_invoice.Text = "Поступления";
            // 
            // products_ms_i_invoice_export
            // 
            products_ms_i_invoice_export.DropDownItems.AddRange(new ToolStripItem[] { export_to_ms_excel });
            products_ms_i_invoice_export.Name = "products_ms_i_invoice_export";
            products_ms_i_invoice_export.Size = new Size(119, 22);
            products_ms_i_invoice_export.Text = "Экспорт";
            // 
            // export_to_ms_excel
            // 
            export_to_ms_excel.Name = "export_to_ms_excel";
            export_to_ms_excel.Size = new Size(121, 22);
            export_to_ms_excel.Text = "MS Excel";
            export_to_ms_excel.Click += export_to_ms_excel_Click;
            // 
            // таблицаToolStripMenuItem2
            // 
            таблицаToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { обновитьToolStripMenuItem1 });
            таблицаToolStripMenuItem2.Name = "таблицаToolStripMenuItem2";
            таблицаToolStripMenuItem2.Size = new Size(65, 20);
            таблицаToolStripMenuItem2.Text = "Таблица";
            // 
            // обновитьToolStripMenuItem1
            // 
            обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            обновитьToolStripMenuItem1.Size = new Size(128, 22);
            обновитьToolStripMenuItem1.Text = "Обновить";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(providers_ms);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поставщики";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(786, 392);
            dataGridView2.TabIndex = 0;
            // 
            // providers_ms
            // 
            providers_ms.Items.AddRange(new ToolStripItem[] { действияToolStripMenuItem, таблицаToolStripMenuItem });
            providers_ms.Location = new Point(3, 3);
            providers_ms.Name = "providers_ms";
            providers_ms.Size = new Size(786, 24);
            providers_ms.TabIndex = 1;
            providers_ms.Text = "menuStrip2";
            // 
            // действияToolStripMenuItem
            // 
            действияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem });
            действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            действияToolStripMenuItem.Size = new Size(60, 20);
            действияToolStripMenuItem.Text = "Отчёты";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { экспортироватьToolStripMenuItem });
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(180, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // экспортироватьToolStripMenuItem
            // 
            экспортироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mSExcelToolStripMenuItem2 });
            экспортироватьToolStripMenuItem.Name = "экспортироватьToolStripMenuItem";
            экспортироватьToolStripMenuItem.Size = new Size(180, 22);
            экспортироватьToolStripMenuItem.Text = "Экспортировать";
            // 
            // mSExcelToolStripMenuItem2
            // 
            mSExcelToolStripMenuItem2.Name = "mSExcelToolStripMenuItem2";
            mSExcelToolStripMenuItem2.Size = new Size(180, 22);
            mSExcelToolStripMenuItem2.Text = "MS Excel";
            mSExcelToolStripMenuItem2.Click += mSExcelToolStripMenuItem2_Click;
            // 
            // таблицаToolStripMenuItem
            // 
            таблицаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { обновитьToolStripMenuItem });
            таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            таблицаToolStripMenuItem.Size = new Size(65, 20);
            таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // обновитьToolStripMenuItem
            // 
            обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            обновитьToolStripMenuItem.Size = new Size(128, 22);
            обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MainMenuStrip = products_ms;
            Name = "Form1";
            Text = "StockManager";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            products_ms.ResumeLayout(false);
            products_ms.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            providers_ms.ResumeLayout(false);
            providers_ms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn debit_count;
        private DataGridViewTextBoxColumn sale_count;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private DataGridView dataGridView2;
        private MenuStrip providers_ms;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem mSExcelToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private ToolStripMenuItem mSExcelToolStripMenuItem1;
        private ToolStripMenuItem таблицаToolStripMenuItem2;
        private ToolStripMenuItem обновитьToolStripMenuItem1;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem экспортироватьToolStripMenuItem;
        private ToolStripMenuItem mSExcelToolStripMenuItem2;
        private ToolStripMenuItem таблицаToolStripMenuItem;
        private ToolStripMenuItem обновитьToolStripMenuItem;
        private ToolStripMenuItem таблицаToolStripMenuItem1;
        private MenuStrip products_ms;
        private ToolStripMenuItem products_ms_reports;
        private ToolStripMenuItem products_ms_i_invoice;
        private ToolStripMenuItem products_ms_i_invoice_export;
        private ToolStripMenuItem export_to_ms_excel;
    }
}