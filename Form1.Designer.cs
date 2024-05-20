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
            products_ms = new MenuStrip();
            products_ms_reports = new ToolStripMenuItem();
            products_ms_i_invoice = new ToolStripMenuItem();
            поставщикиToolStripMenuItem = new ToolStripMenuItem();
            списанияToolStripMenuItem = new ToolStripMenuItem();
            таблицаToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            products_ms.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
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
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 392);
            dataGridView1.TabIndex = 0;
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
            products_ms_reports.DropDownItems.AddRange(new ToolStripItem[] { products_ms_i_invoice, поставщикиToolStripMenuItem, списанияToolStripMenuItem });
            products_ms_reports.Name = "products_ms_reports";
            products_ms_reports.Size = new Size(60, 20);
            products_ms_reports.Text = "Отчёты";
            // 
            // products_ms_i_invoice
            // 
            products_ms_i_invoice.Name = "products_ms_i_invoice";
            products_ms_i_invoice.Size = new Size(147, 22);
            products_ms_i_invoice.Text = "Поступления";
            // 
            // поставщикиToolStripMenuItem
            // 
            поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            поставщикиToolStripMenuItem.Size = new Size(147, 22);
            поставщикиToolStripMenuItem.Text = "Поставщики";
            // 
            // списанияToolStripMenuItem
            // 
            списанияToolStripMenuItem.Name = "списанияToolStripMenuItem";
            списанияToolStripMenuItem.Size = new Size(147, 22);
            списанияToolStripMenuItem.Text = "Списания";
            // 
            // таблицаToolStripMenuItem2
            // 
            таблицаToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, изменитьToolStripMenuItem, удалитьToolStripMenuItem });
            таблицаToolStripMenuItem2.Name = "таблицаToolStripMenuItem2";
            таблицаToolStripMenuItem2.Size = new Size(65, 20);
            таблицаToolStripMenuItem2.Text = "Таблица";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Добавить";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(180, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem mSExcelToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private ToolStripMenuItem mSExcelToolStripMenuItem1;
        private ToolStripMenuItem таблицаToolStripMenuItem2;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem таблицаToolStripMenuItem1;
        private MenuStrip products_ms;
        private ToolStripMenuItem products_ms_reports;
        private ToolStripMenuItem products_ms_i_invoice;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem списанияToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}