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
    public partial class Form4 : Form
    {
        //private Panel panel = new Panel();
        private DataGridView dgv = new DataGridView();
        SqlConnection sqlConnection = SettingsClass.sql_connection;
        private DataGridView main_dgv;
        private DataTable old_table = null;
        public Form4(DataGridView main_dgv)
        {
            this.main_dgv = main_dgv;
            InitializeComponent();
            this.FormClosing += formClosing;
            dgv.Width = textBox1.Width;
            //DataGridView dgv = new DataGridView();
            //dgv.Controls.Add(dgv);
            //dgv.Dock = DockStyle.Fill;
            dgv.Top = textBox1.Top + textBox1.Height;
            dgv.Left = textBox1.Left;
            dgv.Height = 100;
            this.Controls.Add(dgv);
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.DataSource = new BindingSource();
            dgv.CellClick += CellClick;
            dgv.Visible = false;
            old_table = ((main_dgv.DataSource as BindingSource).DataSource as DataTable);
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            (main_dgv.DataSource as BindingSource).DataSource = old_table;
        }

        private void CellClick(object sender, EventArgs e)
        {
            dgv.Visible = false;
            String text = (sender as DataGridView).SelectedCells[0].Value.ToString();
            if (comboBox1.Text == "Ключевые слова")
            {
                String[] arr = textBox1.Text.Split(new String[] { ", " }, StringSplitOptions.None);
                String str = "";
                for(int i =0; i<arr.Length-1; i++)
                {
                    str += arr[i] + ", ";
                }
                textBox1.Text = str + text + ", ";
            }
            else
            {
                textBox1.Text = text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "";
            String parameters = "";
            if (comboBox1.Text == "Автор")
            {
                query = "select  editions.id, editions.name, publication_date, page_count, udc, original_name, price, language_id, genre_id, type_id, subject_id, publisher_id, [isbn-issn] from editions inner join editionsauthors on editions.id = editionsauthors.edition_id inner join authors on authors.id = editionsauthors.author_id where ";
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    String[] arr = textBox1.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    //foreach (string s in arr)
                    //{
                    parameters += " authors.name = " + "'" + arr[0] + "'" + " and authors.lastname = " + "'" + arr[1] + "'";
                    //}
                    //if (parameters != "") parameters = parameters.Substring(0, parameters.Length - 3);
                }
                query += parameters;
            }
            if (comboBox1.Text == "Ключевые слова")
            {
                query = "select  editions.id, editions.name, publication_date, page_count, udc, original_name, price, language_id, genre_id, type_id, subject_id, publisher_id, [isbn-issn] from editions inner join editionskeywords on editions.id = editionskeywords.edition_id inner join keywords on keywords.id = editionskeywords.keyword_id where ";
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    String[] arr = textBox1.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in arr)
                    {
                        parameters += " keywords.name = " + "'" + s + "' or";
                    }
                    if (parameters != "") parameters = parameters.Substring(0, parameters.Length - 3);
                }
                query += parameters;

            }
            if (comboBox1.Text == "Год издания")
            {
                query = "select  editions.id, editions.name, publication_date, page_count, udc, original_name, price, language_id, genre_id, type_id, subject_id, publisher_id, [isbn-issn] from editions where ";
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    String[] arr = textBox1.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    //foreach (string s in arr)
                    //{
                    parameters += " year(publication_date) = "  + arr[0];
                }
                query += parameters;

            }
            if (comboBox1.Text == "Название")
            {
                query = "select distinct editions.id, editions.name, publication_date, page_count, udc, original_name, price, language_id, genre_id, type_id, subject_id, publisher_id, [isbn-issn] from editions where ";
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    //String[] arr = textBox1.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    //foreach (string s in arr)
                    //{
                    parameters += "editions.name = '" + textBox1.Text + "'";
                }
                query += parameters;

            }
            DataTable dt = new DataTable();
            try {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataAdapter sa = new SqlDataAdapter(command);
                    sqlConnection.Close();
                    sa.Fill(dt);
                }
            }
            catch(Exception ex) { }
        //old_table = ((main_dgv.DataSource as BindingSource).DataSource as DataTable);
            (main_dgv.DataSource as BindingSource).DataSource = dt;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                if (comboBox1.Text != "Ключевые слова")
                {
                    int option = comboBox1.Text == "Автор" ? 1 : comboBox1.Text == "Ключевые слова" ? 2 : comboBox1.Text == "Год издания" ? 3 : comboBox1.Text == "Название" ? 4 : 0;
                    dgv.Visible = true;
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand("sp_get_authors", sqlConnection) { CommandType = CommandType.StoredProcedure })
                    {
                        command.Parameters.AddWithValue("@option", option);
                        command.Parameters.AddWithValue("@var1", (sender as TextBox).Text);
                        sqlConnection.Open();
                        SqlDataAdapter sa = new SqlDataAdapter(command);

                        sqlConnection.Close();
                        sa.Fill(dt);
                    }
                    (dgv.DataSource as BindingSource).DataSource = dt;
                }
                else
                {
                    String[] arr = (sender as TextBox).Text.Split(new String[] { ", " }, StringSplitOptions.None);
                    String text = arr[arr.Length - 1];

                    if (text != "")
                    {
                        dgv.Visible = true;
                        DataTable dt = new DataTable();
                        using (SqlCommand command = new SqlCommand("sp_get_authors", sqlConnection) { CommandType = CommandType.StoredProcedure })
                        {
                            command.Parameters.AddWithValue("@option", 2);
                            command.Parameters.AddWithValue("@var1", text);
                            sqlConnection.Open();
                            SqlDataAdapter sa = new SqlDataAdapter(command);

                            sqlConnection.Close();
                            sa.Fill(dt);
                        }
                    (dgv.DataSource as BindingSource).DataSource = dt;
                    }
                }
                dgv.Height = dgv.Rows.Count * dgv.RowTemplate.Height;
            }
            else
            {
                dgv.Visible = false;
                (dgv.DataSource as BindingSource).DataSource = new DataTable();
            }
        }
    }
}
