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
    public partial class Form2 : Form
    {
        SqlConnection sqlConntection = SettingsClass.sql_connection;
        public Form2()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("[sp_auth]", sqlConntection) { CommandType = CommandType.StoredProcedure })
            {
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@psswrd", textBox2.Text);

                SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.NVarChar, 50);
                returnParameter.Direction = ParameterDirection.Output;

                sqlConntection.Open();
                command.ExecuteNonQuery();
                sqlConntection.Close();

                //label3.Text = returnParameter.Value.ToString();
                label3.Text = command.Parameters["@ReturnVal"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("[sp_auth_in]", sqlConntection) { CommandType = CommandType.StoredProcedure })
            {
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@psswrd", textBox2.Text);

                SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.NVarChar, 50);
                returnParameter.Direction = ParameterDirection.Output;
                SqlParameter returnError = command.Parameters.Add("@Error", SqlDbType.Int);
                returnError.Direction = ParameterDirection.Output;

                sqlConntection.Open();
                command.ExecuteNonQuery();
                sqlConntection.Close();

                //label3.Text = returnParameter.Value.ToString();
                if ((int)command.Parameters["@Error"].Value == 1)
                {
                    label3.Text = "Неверный логин/пароль";
                }
                else
                {
                    String rank = (string)command.Parameters["@ReturnVal"].Value;
                    SettingsClass.rank = rank;
                    Form1 frm = new Form1(rank);
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
            }
        }
    }
}
