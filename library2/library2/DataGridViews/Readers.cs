using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Readers : DataGridView, IHavetrivia
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource getEditionsBindingSource;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private library_dbDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private library_dbDataSetTableAdapters.GetGendersTableAdapter gendersTableAdapter;
        private System.Windows.Forms.BindingSource getAddressesBindingSource;
        private library_dbDataSetTableAdapters.GetAddressesTableAdapter getAddressesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;

        public Readers()
        {

            this.readersBindingSource = new System.Windows.Forms.BindingSource();
            this.getEditionsBindingSource = new System.Windows.Forms.BindingSource();
            this.readersTableAdapter = new library2.library_dbDataSetTableAdapters.ReadersTableAdapter();
            this.gendersBindingSource = new System.Windows.Forms.BindingSource();
            this.gendersTableAdapter = new library2.library_dbDataSetTableAdapters.GetGendersTableAdapter();
            this.getAddressesBindingSource = new System.Windows.Forms.BindingSource();
            this.getAddressesTableAdapter = new library2.library_dbDataSetTableAdapters.GetAddressesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addressidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            // 
            // dataGridView1
            // 
            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.genderidDataGridViewTextBoxColumn,
            this.addressidDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn
        });

            this.DataSource = this.readersBindingSource;
            this.Location = new System.Drawing.Point(-4, 87);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(740, 150);
            this.TabIndex = 0;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet1
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEditionsBindingSource
            // 
            this.getEditionsBindingSource.DataMember = "GetEditions";
            this.getEditionsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataMember = "GetGenders";
            this.gendersBindingSource.DataSource = this.library_dbDataSet;
            // 
            // gendersTableAdapter
            // 
            this.gendersTableAdapter.ClearBeforeFill = true;
            // 
            // getAddressesBindingSource
            // 
            this.getAddressesBindingSource.DataMember = "GetAddresses";
            this.getAddressesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getAddressesTableAdapter
            // 
            this.getAddressesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // genderidDataGridViewTextBoxColumn
            // 
            this.genderidDataGridViewTextBoxColumn.DataPropertyName = "gender_id";
            this.genderidDataGridViewTextBoxColumn.DataSource = this.gendersBindingSource;
            this.genderidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.genderidDataGridViewTextBoxColumn.HeaderText = "gender_id";
            this.genderidDataGridViewTextBoxColumn.Name = "genderidDataGridViewTextBoxColumn";
            this.genderidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genderidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genderidDataGridViewTextBoxColumn.ValueMember = "gender_id";
            this.genderidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // addressidDataGridViewTextBoxColumn
            // 
            this.addressidDataGridViewTextBoxColumn.DataPropertyName = "address_id";
            this.addressidDataGridViewTextBoxColumn.DataSource = this.getAddressesBindingSource;
            this.addressidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.addressidDataGridViewTextBoxColumn.HeaderText = "address_id";
            this.addressidDataGridViewTextBoxColumn.Name = "addressidDataGridViewTextBoxColumn";
            this.addressidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addressidDataGridViewTextBoxColumn.ValueMember = "address_id";
            this.addressidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.Visible = false;

            this.getAddressesTableAdapter.Fill(this.library_dbDataSet.GetAddresses);
            this.gendersTableAdapter.Fill(this.library_dbDataSet.GetGenders);
            this.readersTableAdapter.Fill(this.library_dbDataSet.Readers);
        }

        public string getTrivia(int reader_id)
        {
            //List<String> books = new List<string>();
            SqlConnection sql_connection = SettingsClass.sql_connection;
            String query = $"SELECT   count (Copies.id) FROM ((Editions INNER JOIN Copies ON Editions.id = Copies.edition_id) INNER JOIN Debentures ON Copies.id = Debentures.copy_id) where returning_date is null and reader_id = {reader_id}";
            SqlCommand cmn = new SqlCommand(query, sql_connection);
            // SqlDataReader reader = cmn.ExecuteReader();
            sql_connection.Open();
            int amount = (int)cmn.ExecuteScalar();
            sql_connection.Close();
            //while (reader.Read())
            //{
            //    books.Add(reader.GetValue(0).ToString());
            //}
            return "Книг на руках: " + amount.ToString();
        }
    }
}
