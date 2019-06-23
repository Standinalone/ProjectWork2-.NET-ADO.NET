using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Localities : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource getContriesBindingSource;
        private library_dbDataSetTableAdapters.GetContriesTableAdapter getContriesTableAdapter;
        private System.Windows.Forms.BindingSource getLocalityTypesBindingSource;
        private library_dbDataSetTableAdapters.GetLocalityTypesTableAdapter getLocalityTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn localityTypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn contryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource localitiesBindingSource;
        private library_dbDataSetTableAdapters.LocalitiesTableAdapter localitiesTableAdapter;
        public Localities()
        {
            this.localitiesTableAdapter = new library2.library_dbDataSetTableAdapters.LocalitiesTableAdapter();
            this.localitiesBindingSource = new System.Windows.Forms.BindingSource();
            this.library_dbDataSet = new library2.library_dbDataSet();
            this.getContriesBindingSource = new System.Windows.Forms.BindingSource();
            this.getContriesTableAdapter = new library2.library_dbDataSetTableAdapters.GetContriesTableAdapter();
            this.getLocalityTypesBindingSource = new System.Windows.Forms.BindingSource();
            this.getLocalityTypesTableAdapter = new library2.library_dbDataSetTableAdapters.GetLocalityTypesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localityTypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.localityTypeidDataGridViewTextBoxColumn,
            this.contryidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.DataSource = this.localitiesBindingSource;
            this.Location = new System.Drawing.Point(78, 62);
            this.Name = "dataGridView2";
            this.Size = new System.Drawing.Size(692, 150);
            this.TabIndex = 1;
            //
            // localitiesBindingSource
            // 
            this.localitiesBindingSource.DataMember = "Localities";
            this.localitiesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getContriesBindingSource
            // 
            this.getContriesBindingSource.DataMember = "GetContries";
            this.getContriesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getContriesTableAdapter
            // 
            this.getContriesTableAdapter.ClearBeforeFill = true;
            // 
            // getLocalityTypesBindingSource
            // 
            this.getLocalityTypesBindingSource.DataMember = "GetLocalityTypes";
            this.getLocalityTypesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getLocalityTypesTableAdapter
            // 
            this.getLocalityTypesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // localityTypeidDataGridViewTextBoxColumn
            // 
            this.localityTypeidDataGridViewTextBoxColumn.DataPropertyName = "localityType_id";
            this.localityTypeidDataGridViewTextBoxColumn.DataSource = this.getLocalityTypesBindingSource;
            this.localityTypeidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.localityTypeidDataGridViewTextBoxColumn.HeaderText = "localityType_id";
            this.localityTypeidDataGridViewTextBoxColumn.Name = "localityTypeidDataGridViewTextBoxColumn";
            this.localityTypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.localityTypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.localityTypeidDataGridViewTextBoxColumn.ValueMember = "localityType_id";
            this.localityTypeidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // contryidDataGridViewTextBoxColumn
            // 
            this.contryidDataGridViewTextBoxColumn.DataPropertyName = "contry_id";
            this.contryidDataGridViewTextBoxColumn.DataSource = this.getContriesBindingSource;
            this.contryidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.contryidDataGridViewTextBoxColumn.HeaderText = "contry_id";
            this.contryidDataGridViewTextBoxColumn.Name = "contryidDataGridViewTextBoxColumn";
            this.contryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.contryidDataGridViewTextBoxColumn.ValueMember = "contry_id";
            this.contryidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";

            this.localitiesTableAdapter.Fill(this.library_dbDataSet.Localities);
            this.getLocalityTypesTableAdapter.Fill(this.library_dbDataSet.GetLocalityTypes);
            this.getContriesTableAdapter.Fill(this.library_dbDataSet.GetContries);
        }
    }
}
