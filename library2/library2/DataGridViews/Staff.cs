using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Staff : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private library_dbDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource getGendersBindingSource;
        private library_dbDataSetTableAdapters.GetGendersTableAdapter getGendersTableAdapter;
        private System.Windows.Forms.BindingSource getAddressesBindingSource;
        private library_dbDataSetTableAdapters.GetAddressesTableAdapter getAddressesTableAdapter;
        private System.Windows.Forms.BindingSource getPositionsBindingSource;
        private library_dbDataSetTableAdapters.GetPositionsTableAdapter getPositionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOfWorkdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        public Staff()
        {
            this.staffBindingSource = new System.Windows.Forms.BindingSource();
            this.staffTableAdapter = new library2.library_dbDataSetTableAdapters.StaffTableAdapter();
            this.getGendersBindingSource = new System.Windows.Forms.BindingSource();
            this.getGendersTableAdapter = new library2.library_dbDataSetTableAdapters.GetGendersTableAdapter();
            this.getAddressesBindingSource = new System.Windows.Forms.BindingSource();
            this.getAddressesTableAdapter = new library2.library_dbDataSetTableAdapters.GetAddressesTableAdapter();
            this.getPositionsBindingSource = new System.Windows.Forms.BindingSource();
            this.getPositionsTableAdapter = new library2.library_dbDataSetTableAdapters.GetPositionsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startOfWorkdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addressidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.positionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // 
            // dataGridView
            // 
            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.startOfWorkdateDataGridViewTextBoxColumn,
            this.genderidDataGridViewTextBoxColumn,
            this.addressidDataGridViewTextBoxColumn,
            this.positionidDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DataSource = this.staffBindingSource;
            this.Location = new System.Drawing.Point(47, 111);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(633, 150);
            this.TabIndex = 0;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // library_dbDataSet1
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.library_dbDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // getGendersBindingSource
            // 
            this.getGendersBindingSource.DataMember = "GetGenders";
            this.getGendersBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getGendersTableAdapter
            // 
            this.getGendersTableAdapter.ClearBeforeFill = true;
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
            // getPositionsBindingSource
            // 
            this.getPositionsBindingSource.DataMember = "GetPositions";
            this.getPositionsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getPositionsTableAdapter
            // 
            this.getPositionsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // startOfWorkdateDataGridViewTextBoxColumn
            // 
            this.startOfWorkdateDataGridViewTextBoxColumn.DataPropertyName = "startOfWork_date";
            this.startOfWorkdateDataGridViewTextBoxColumn.HeaderText = "startOfWork_date";
            this.startOfWorkdateDataGridViewTextBoxColumn.Name = "startOfWorkdateDataGridViewTextBoxColumn";
            // 
            // genderidDataGridViewTextBoxColumn
            // 
            this.genderidDataGridViewTextBoxColumn.DataPropertyName = "gender_id";
            this.genderidDataGridViewTextBoxColumn.DataSource = this.getGendersBindingSource;
            this.genderidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.genderidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.genderidDataGridViewTextBoxColumn.HeaderText = "gender_id";
            this.genderidDataGridViewTextBoxColumn.Name = "genderidDataGridViewTextBoxColumn";
            this.genderidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genderidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genderidDataGridViewTextBoxColumn.ValueMember = "gender_id";
            // 
            // addressidDataGridViewTextBoxColumn
            // 
            this.addressidDataGridViewTextBoxColumn.DataPropertyName = "address_id";
            this.addressidDataGridViewTextBoxColumn.DataSource = this.getAddressesBindingSource;
            this.addressidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.addressidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.addressidDataGridViewTextBoxColumn.HeaderText = "address_id";
            this.addressidDataGridViewTextBoxColumn.Name = "addressidDataGridViewTextBoxColumn";
            this.addressidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addressidDataGridViewTextBoxColumn.ValueMember = "address_id";
            // 
            // positionidDataGridViewTextBoxColumn
            // 
            this.positionidDataGridViewTextBoxColumn.DataPropertyName = "position_id";
            this.positionidDataGridViewTextBoxColumn.DataSource = this.getPositionsBindingSource;
            this.positionidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.positionidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.positionidDataGridViewTextBoxColumn.HeaderText = "position_id";
            this.positionidDataGridViewTextBoxColumn.Name = "positionidDataGridViewTextBoxColumn";
            this.positionidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.positionidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.positionidDataGridViewTextBoxColumn.ValueMember = "position_id";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";

            this.getPositionsTableAdapter.Fill(this.library_dbDataSet.GetPositions);
            this.getAddressesTableAdapter.Fill(this.library_dbDataSet.GetAddresses);
            this.getGendersTableAdapter.Fill(this.library_dbDataSet.GetGenders);
            this.staffTableAdapter.Fill(this.library_dbDataSet.Staff);
        }
    }
}