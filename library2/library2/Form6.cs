using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsClass.sql_connection = new System.Data.SqlClient.SqlConnection();
            //SettingsClass.sql_connection.Database = "library_db";
            String conn = textBox1.Text;
            SettingsClass.sql_connection.ConnectionString = $"integrated security=SSPI; Data Source=\"{textBox1.Text}\"; initial catalog=\"library_db\";persist security info=false";
            Form2 frm = new Form2();
            frm.Show();

        }
    }
}
