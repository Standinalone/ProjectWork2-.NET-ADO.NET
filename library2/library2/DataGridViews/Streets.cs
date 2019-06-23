using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Streets : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private library_dbDataSetTableAdapters.StreetsTableAdapter streetsTableAdapter;
        private System.Windows.Forms.BindingSource getLocalitiesBindingSource;
        private library_dbDataSetTableAdapters.GetLocalitiesTableAdapter getLocalitiesTableAdapter;
        private System.Windows.Forms.BindingSource getStreetTypesBindingSource;
        private library_dbDataSetTableAdapters.GetStreetTypesTableAdapter getStreetTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn localityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn streetTypeidDataGridViewTextBoxColumn;

        public Streets()
        {
            this.library_dbDataSet = new library2.library_dbDataSet();
            this.streetsTableAdapter = new library2.library_dbDataSetTableAdapters.StreetsTableAdapter();
            this.getLocalitiesBindingSource = new System.Windows.Forms.BindingSource();
            this.getLocalitiesTableAdapter = new library2.library_dbDataSetTableAdapters.GetLocalitiesTableAdapter();
            this.getStreetTypesBindingSource = new System.Windows.Forms.BindingSource();
            this.getStreetTypesTableAdapter = new library2.library_dbDataSetTableAdapters.GetStreetTypesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.streetTypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.streetsBindingSource = new BindingSource();

            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.localityidDataGridViewTextBoxColumn,
            this.streetTypeidDataGridViewTextBoxColumn});
            this.DataSource = this.streetsBindingSource;
            this.Location = new System.Drawing.Point(115, 140);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(667, 150);
            this.TabIndex = 0;
            // 
            // streetsBindingSource
            // 
            this.streetsBindingSource.DataMember = "Streets";
            this.streetsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // streetsTableAdapter
            // 
            this.streetsTableAdapter.ClearBeforeFill = true;
            // 
            // getLocalitiesBindingSource
            // 
            this.getLocalitiesBindingSource.DataMember = "GetLocalities";
            this.getLocalitiesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getLocalitiesTableAdapter
            // 
            this.getLocalitiesTableAdapter.ClearBeforeFill = true;
            // 
            // getStreetTypesBindingSource
            // 
            this.getStreetTypesBindingSource.DataMember = "GetStreetTypes";
            this.getStreetTypesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getStreetTypesTableAdapter
            // 
            this.getStreetTypesTableAdapter.ClearBeforeFill = true;
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
            // localityidDataGridViewTextBoxColumn
            // 
            this.localityidDataGridViewTextBoxColumn.DataPropertyName = "locality_id";
            this.localityidDataGridViewTextBoxColumn.DataSource = this.getLocalitiesBindingSource;
            this.localityidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.localityidDataGridViewTextBoxColumn.HeaderText = "locality_id";
            this.localityidDataGridViewTextBoxColumn.Name = "localityidDataGridViewTextBoxColumn";
            this.localityidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.localityidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.localityidDataGridViewTextBoxColumn.ValueMember = "locality_id";
            this.localityidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // streetTypeidDataGridViewTextBoxColumn
            // 
            this.streetTypeidDataGridViewTextBoxColumn.DataPropertyName = "streetType_id";
            this.streetTypeidDataGridViewTextBoxColumn.DataSource = this.getStreetTypesBindingSource;
            this.streetTypeidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.streetTypeidDataGridViewTextBoxColumn.HeaderText = "streetType_id";
            this.streetTypeidDataGridViewTextBoxColumn.Name = "streetTypeidDataGridViewTextBoxColumn";
            this.streetTypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.streetTypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.streetTypeidDataGridViewTextBoxColumn.ValueMember = "streetType_id";
            this.streetTypeidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            this.getStreetTypesTableAdapter.Fill(this.library_dbDataSet.GetStreetTypes);
            this.getLocalitiesTableAdapter.Fill(this.library_dbDataSet.GetLocalities);
            this.streetsTableAdapter.Fill(this.library_dbDataSet.Streets);
        }
    }
}
