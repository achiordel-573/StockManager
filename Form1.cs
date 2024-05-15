using Npgsql;
using System.Data;
using System.Configuration;
using Microsoft.Office.Interop.Excel;

namespace StockManager
{
    public partial class Form1 : Form
    {
        private readonly DataSet ds = new DataSet();
        private System.Data.DataTable dt = new System.Data.DataTable();
        private String constr;
        private String DatabaseSetup()
        {
            var builder = new NpgsqlConnectionStringBuilder();
            builder.Host = ConfigurationManager.AppSettings["DB_HOST"];
            builder.Port = Int32.Parse(ConfigurationManager.AppSettings["DB_PORT"]);
            builder.Username = ConfigurationManager.AppSettings["DB_USER"];
            builder.Password = ConfigurationManager.AppSettings["DB_PSWD"];
            builder.Database = ConfigurationManager.AppSettings["DB_NAME"];

            return builder.ConnectionString;
        }

        private void DataSetUpdate(string sql, DataGridView gdv)
        {
            if (constr == null)
            {
                constr = DatabaseSetup();
            }

            using (var conn = new NpgsqlConnection(constr))
            {
                ds.Reset();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                da.Fill(ds);
                dt = ds.Tables[0];
                gdv.DataSource = dt;
            }
        }

        private void DataTableExport(DataGridView dgv)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            String filename = ofd.FileName;

            Microsoft.Office.Interop.Excel.Application eobj = new Microsoft.Office.Interop.Excel.Application();
            eobj.Visible = true;

            Workbook wb = eobj.Workbooks.Add();

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                for (int j = 0; j < dgv.RowCount; j++)
                {
                    eobj.Cells[j + 2, i + 1] = (dgv[i, j].Value).ToString();
                    eobj.Visible = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent(); ;
            String sql = ("select * from providers");
            DataSetUpdate(sql, dataGridView2);
        }

        private void export_to_ms_excel_Click(object sender, EventArgs e)
        {
            DataTableExport(dataGridView1);
        }

        private void mSExcelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataTableExport(dataGridView2);
        }
    }
}