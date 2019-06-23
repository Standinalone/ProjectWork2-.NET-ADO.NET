using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2
{
    public class ComboDataGridView : DataGridView
    {
        private DataGridViewCheckBoxColumn Column1 = new DataGridViewCheckBoxColumn();
        private DataGridViewComboBoxColumn Column2 = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn Column3 = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn Column4 = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn Column5 = new DataGridViewComboBoxColumn();
        public MyToolBar myToolBar; // Passed from Kit instance
        public String table_name;
        public DataGridView dataGridView;
        private Dictionary<String, String> operations = new Dictionary<string, string>();
        private static SqlConnection sql_connection = SettingsClass.sql_connection;

        public ComboDataGridView(DataGridView dataGridView, MyToolBar myToolBar, String table_name)
        {
            this.dataGridView = dataGridView;
            this.myToolBar = myToolBar;
            this.table_name = table_name;
            this.RowTemplate.Height = 20;

            operations.Add("И", "AND");
            operations.Add("ИЛИ", "OR");
            operations.Add("НЕ", "NOT");
            //
            // Column1
            // 
            this.Column1.HeaderText = "Включен";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Связь";
            this.Column2.Name = "Column2";
            this.Column2.Items.AddRange(new String[] { "И", "ИЛИ", "НЕ" });
            //this.Column2.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Поле";
            this.Column3.Name = "Column3";
            //this.Column3.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Условие";
            this.Column4.Name = "Column4";
            this.Column4.Items.AddRange(new String[] { "=", "<>", ">", ">=", "<", "<=" });
            //this.Column4.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Значение";
            this.Column5.Name = "Column5";
            //this.Column5.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            fillColumn3();
        }
        public void fillColumn3() // Fills Column3 with dataGridView's headers
        {
            DataGridViewComboBoxColumn cb3 = (this.Columns[2] as DataGridViewComboBoxColumn);
            //foreach (DataColumn clmn in ((dataGridView.DataSource as BindingSource).DataSource as DataTable).Columns)
            //{
            //    cb3.Items.Add(clmn.Caption);
            //}
            foreach(DataGridViewColumn clmn in dataGridView.Columns)
            {
                cb3.Items.Add(clmn.DataPropertyName);
            }
        }
        //
        // Events
        //
        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e) // Replace the last cell with DataGridViewComboboxCell instance
        {
            this.Rows[e.RowIndex].Cells[4] = (new DataGridViewComboBoxCell());
            (this.Rows[e.RowIndex].Cells[4] as DataGridViewComboBoxCell).DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
        }
        protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                this.Rows[e.RowIndex].Cells[4] = (new DataGridViewComboBoxCell());
                DataGridViewComboBoxCell cb4 = (this.Rows[e.RowIndex].Cells[4] as DataGridViewComboBoxCell);
                if (this.Rows[e.RowIndex].Cells[2].Value == null) return;
                // Getting index of selected item in the filter grid
                int index = (this.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell).Items.IndexOf(this.Rows[e.RowIndex].Cells[2].Value);
                //int index = (this.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell).
                String value;
                SqlConnection sql_connection;
                SqlCommand sql_command;
                DataTable dt = new DataTable();
                sql_connection = new SqlConnection("integrated security=SSPI; Data Source=\".\"; initial catalog=library_db;persist security info=False");

                if (dataGridView.Columns[index].GetType().Name == "DataGridViewComboBoxColumn")
                {
                    value = (dataGridView.Columns[index] as DataGridViewComboBoxColumn).ValueMember;
                    sql_command = new SqlCommand("select distinct *  from " + ((dataGridView.Columns[index] as DataGridViewComboBoxColumn).DataSource as BindingSource).DataMember + ";", sql_connection);
                }
                else
                {
                    value = this.Rows[e.RowIndex].Cells[2].Value.ToString();
                    sql_command = new SqlCommand("select distinct " + value + " from " + table_name + ";", sql_connection);
                }
                SqlDataAdapter da = new SqlDataAdapter(sql_command);
                da.Fill(dt);


                BindingSource bs = new BindingSource();
                //bs.DataSource = DataGridViews.library_db.library_dbDataSet;
                bs.DataSource = dt;
                cb4.DataSource = bs;
                if (dataGridView.Columns[index].GetType().Name == "DataGridViewComboBoxColumn")
                {
                    //bs.DataMember = ((dataGridView.Columns[index] as DataGridViewComboBoxColumn).DataSource as BindingSource).DataMember;
                    cb4.ValueMember = (dataGridView.Columns[index] as DataGridViewComboBoxColumn).ValueMember;
                    cb4.DisplayMember = "name";
                }
                else
                {
                    //bs.DataMember = table_name;
                    cb4.DisplayMember = this.Rows[e.RowIndex].Cells[2].Value.ToString();
                }

                cb4.Tag = dataGridView.Columns[index];

            }
        }
        protected override void OnCellValueChanged(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // If it's a checkbox
            {
                String sql_string = "";
                foreach (DataGridViewRow dr in this.Rows)
                {
                    if (dr.Cells[0].Value != null && (bool)dr.Cells[0].Value) // If option "Включить" chosen
                    {
                        String operation;
                        String field;
                        String condition;
                        String value = "";
                        try
                        {
                            //int ind = (this.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell).Items.IndexOf(this.Rows[e.RowIndex].Cells[2].Value);
                            //operation = operations[this[1, e.RowIndex].Value.ToString()];
                            int ind = (this.Rows[dr.Index].Cells[2] as DataGridViewComboBoxCell).Items.IndexOf(this.Rows[dr.Index].Cells[2].Value);
                            operation = operations[this[1, dr.Index].Value.ToString()];
                            if (dr.Cells[4].Tag.GetType().Name == "DataGridViewComboBoxColumn") // If 4th column contains information from a view
                            {
                                field = (dataGridView.Columns[ind] as DataGridViewComboBoxColumn).ValueMember;
                            }

                            else
                            {
                                field = dr.Cells[2].Value.ToString();
                            }
                            value = dr.Cells[4].Value.ToString();
                            condition = dr.Cells[3].Value.ToString();
                            if ((dr.Cells[4].ValueType.Name == "String") || (dr.Cells[4].ValueType.Name == "Date") || (dr.Cells[4].ValueType.Name == "DateTime"))
                            {
                                value = "'" + value + "'";
                            }
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                        if (!string.IsNullOrEmpty(sql_string))
                        {
                            sql_string += operation + " ";
                        }
                        sql_string += field + " " + condition + " " + value + " ";
                    }
                }
                if (!string.IsNullOrEmpty(sql_string)) sql_string = "where (" + sql_string + ")";
                SqlConnection sql_connection;
                SqlCommand sql_command;
                DataTable dt = new DataTable();
                sql_connection = new SqlConnection("integrated security=SSPI; Data Source=\".\"; initial catalog=library_db;persist security info=False");

                sql_command = new SqlCommand("select * from " + table_name + " " + sql_string + ";", sql_connection);
                Console.WriteLine(sql_command.CommandText);
                SqlDataAdapter da = new SqlDataAdapter(sql_command);
                da.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                myToolBar.BindingSource = bs;
                dataGridView.DataSource = bs;
            }
        }
        protected override void OnCellMouseUp(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseUp(e);
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                this.EndEdit();
            }
        }
    }
}
