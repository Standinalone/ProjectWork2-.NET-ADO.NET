using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2
{
    public partial class Form_Readers : Form
    {
        public Form_Readers()
        {
            InitializeComponent();
            //library2.Form1.MyToolBar tb = new library2.Form1.MyToolBar();
            //tb.AddStandardItems();
            //tb.Location = new Point(0, 0);
            //tb.BindingSource = readersBindingSource;
            //this.Controls.Add(tb);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_dbDataSet.Debentures' table. You can move, or remove it, as needed.
            this.debenturesTableAdapter.Fill(this.library_dbDataSet.Debentures);
            // TODO: This line of code loads data into the 'library_dbDataSet.Readers' table. You can move, or remove it, as needed.
            this.readersTableAdapter.Fill(this.library_dbDataSet.Readers);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage4)
            {
                int reader_id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                SqlConnection sql_connection;
                SqlCommand sql_command;
                DataTable dt = new DataTable();
                sql_connection = new SqlConnection("integrated security=SSPI; Data Source=\".\"; initial catalog=library_db;persist security info=False");
                sql_connection.Open();
                sql_command = new SqlCommand("[getBooks]", sql_connection);
                sql_command.CommandType = CommandType.StoredProcedure;
                sql_command.Parameters.Add("@var1", SqlDbType.Int);
                sql_command.Parameters["@var1"].Value = reader_id;
                SqlDataAdapter da = new SqlDataAdapter(sql_command);
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;

                dataGridView3.DataSource = bs;
                label1.Text = dt.Rows.Count.ToString();
                dataGridView3.AutoGenerateColumns = true;

                sql_connection.Close();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                int reader_id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
                SqlConnection sql_connection;
                SqlCommand sql_command;
                DataTable dt = new DataTable();
                sql_connection = new SqlConnection("integrated security=SSPI; Data Source=\".\"; initial catalog=library_db;persist security info=False");
                sql_connection.Open();
                sql_command = new SqlCommand("[sp_getChronology]", sql_connection);
                sql_command.CommandType = CommandType.StoredProcedure;
                sql_command.Parameters.Add("@var1", SqlDbType.Int);
                sql_command.Parameters["@var1"].Value = reader_id;
                SqlDataAdapter da = new SqlDataAdapter(sql_command);
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;

                dataGridView4.DataSource = bs;
                label1.Text = dt.Rows.Count.ToString();
                dataGridView4.AutoGenerateColumns = true;

                sql_connection.Close();
            }
        }
    }
}
