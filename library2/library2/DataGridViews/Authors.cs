using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Authors : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private library_dbDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource getGendersBindingSource;
        private library_dbDataSetTableAdapters.GetGendersTableAdapter getGendersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genderidDataGridViewTextBoxColumn;

        public Authors()
        {
            this.library_dbDataSet = new library2.library_dbDataSet();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource();
            this.authorsTableAdapter = new library2.library_dbDataSetTableAdapters.AuthorsTableAdapter();
            this.getGendersBindingSource = new System.Windows.Forms.BindingSource();
            this.getGendersTableAdapter = new library2.library_dbDataSetTableAdapters.GetGendersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();

            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.genderidDataGridViewTextBoxColumn});
            this.DataSource = this.authorsBindingSource;
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
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
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

            this.getGendersTableAdapter.Fill(this.library_dbDataSet.GetGenders);
            this.authorsTableAdapter.Fill(this.library_dbDataSet.Authors);
        }
    }
}
