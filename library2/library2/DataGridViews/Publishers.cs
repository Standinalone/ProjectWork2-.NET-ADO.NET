using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Publishers : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private library_dbDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.BindingSource getLocalitiesBindingSource;
        private library_dbDataSetTableAdapters.GetLocalitiesForPublishersTableAdapter GetLocalitiesForPublishersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn localityidDataGridViewTextBoxColumn;
        public Publishers()
        {
            this.publishersBindingSource = new System.Windows.Forms.BindingSource();
            this.publishersTableAdapter = new library2.library_dbDataSetTableAdapters.PublishersTableAdapter();
            this.getLocalitiesBindingSource = new System.Windows.Forms.BindingSource();
            this.GetLocalitiesForPublishersTableAdapter = new library2.library_dbDataSetTableAdapters.GetLocalitiesForPublishersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.localityidDataGridViewTextBoxColumn});
            this.DataSource = this.publishersBindingSource;
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
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.library_dbDataSet;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // getLocalitiesBindingSource
            // 
            this.getLocalitiesBindingSource.DataMember = "GetLocalitiesForPublishers";
            this.getLocalitiesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getLocalitiesTableAdapter
            // 
            this.GetLocalitiesForPublishersTableAdapter.ClearBeforeFill = true;
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
            this.localityidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.localityidDataGridViewTextBoxColumn.HeaderText = "locality_id";
            this.localityidDataGridViewTextBoxColumn.Name = "localityidDataGridViewTextBoxColumn";
            this.localityidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.localityidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.localityidDataGridViewTextBoxColumn.ValueMember = "locality_id";

            this.GetLocalitiesForPublishersTableAdapter.Fill(this.library_dbDataSet.GetLocalitiesForPublishers);
            this.publishersTableAdapter.Fill(this.library_dbDataSet.Publishers);
        }
    }
}
