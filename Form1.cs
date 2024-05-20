using Npgsql;
using System.Data;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlTypes;

namespace StockManager
{
    public partial class Form1 : Form
    {
        private readonly DataSet ds = new DataSet();
        private System.Data.DataTable dt = new System.Data.DataTable();
        private void ExcelExport()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            String filename = ofd.FileName;

            Microsoft.Office.Interop.Excel.Application eobj = new Microsoft.Office.Interop.Excel.Application();
            eobj.Visible = true;

            Workbook wb = eobj.Workbooks.Add();

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    eobj.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                    eobj.Visible = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent(); ;
            GetProducts();
        }
        private void GetProducts()
        {
            string cmd = "SELECT * FROM products";
            DatabaseUtils du = new DatabaseUtils();
            DataSet da = du.Select_Records(ds, cmd);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Èäåíòèôèêàòîð";
            dataGridView1.Columns[1].HeaderText = "Íàçâàíèå";
            dataGridView1.Columns[2].HeaderText = "Êîëè÷åñòâî";
        }
        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseUtils du = new DatabaseUtils();
            du.Delete_Record((int)(dataGridView1.CurrentRow.Cells["id"].Value));
            GetProducts();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            GetProducts();
        }

        private void products_ms_i_invoice_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM incoming_invoices";
            Form3 viewer = new Form3();
            viewer.PrepareDataGridView(cmd);
            viewer.ShowDialog();
        }

        private void ïîñòàâùèêèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM providers";
            Form3 viewer = new Form3();
            viewer.PrepareDataGridView(cmd);
            viewer.ShowDialog();
        }

        private void ñïèñàíèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM debit_invoices";
            Form3 viewer = new Form3();
            viewer.PrepareDataGridView(cmd);
            viewer.ShowDialog();
        }

        private void ïðîäàæèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TODO*/
            ExcelExport();
        }
    }
}