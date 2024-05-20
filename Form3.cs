using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
    public partial class Form3 : Form
    {
        public readonly DataSet dataset = new DataSet();
        public System.Data.DataTable datatable = new System.Data.DataTable();

        public Form3()
        {
            InitializeComponent();

        }

        public void PrepareDataGridView(string query)
        {
            DatabaseUtils du = new DatabaseUtils();
            DataSet ds = du.Select_Records(dataset, query);
            datatable = ds.Tables[0];
            dataGridView1.DataSource = datatable;
        }
    }
}
