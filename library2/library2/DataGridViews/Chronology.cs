using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Chronology : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource chronologyBindingSource;
        private library_dbDataSetTableAdapters.ChronologyTableAdapter chronologyTableAdapter;
        private System.Windows.Forms.BindingSource getOperationsBindingSource;
        private library_dbDataSetTableAdapters.GetOperationsTableAdapter getOperationsTableAdapter;
        private System.Windows.Forms.BindingSource getDebenturesBindingSource;
        private library_dbDataSetTableAdapters.GetDebenturesTableAdapter getDebenturesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn operationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn debenturyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;

        public Chronology()
        {
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chronologyTableAdapter = new library2.library_dbDataSetTableAdapters.ChronologyTableAdapter();
            this.getOperationsBindingSource = new System.Windows.Forms.BindingSource();
            this.getOperationsTableAdapter = new library2.library_dbDataSetTableAdapters.GetOperationsTableAdapter();
            this.getDebenturesBindingSource = new System.Windows.Forms.BindingSource();
            this.getDebenturesTableAdapter = new library2.library_dbDataSetTableAdapters.GetDebenturesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.debenturyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chronologyBindingSource = new BindingSource();

            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.operationidDataGridViewTextBoxColumn,
            this.debenturyidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.DataSource = this.chronologyBindingSource;
            this.Location = new System.Drawing.Point(47, 111);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(633, 150);
            this.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // chronologyBindingSource
            // 
            this.chronologyBindingSource.DataMember = "Chronology";
            this.chronologyBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chronologyTableAdapter
            // 
            this.chronologyTableAdapter.ClearBeforeFill = true;
            // 
            // getOperationsBindingSource
            // 
            this.getOperationsBindingSource.DataMember = "GetOperations";
            this.getOperationsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getOperationsTableAdapter
            // 
            this.getOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // getDebenturesBindingSource
            // 
            this.getDebenturesBindingSource.DataMember = "GetDebentures";
            this.getDebenturesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getDebenturesTableAdapter
            // 
            this.getDebenturesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationidDataGridViewTextBoxColumn
            // 
            this.operationidDataGridViewTextBoxColumn.DataPropertyName = "operation_id";
            this.operationidDataGridViewTextBoxColumn.DataSource = this.getOperationsBindingSource;
            this.operationidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.operationidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.operationidDataGridViewTextBoxColumn.HeaderText = "operation_id";
            this.operationidDataGridViewTextBoxColumn.Name = "operationidDataGridViewTextBoxColumn";
            this.operationidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operationidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.operationidDataGridViewTextBoxColumn.ValueMember = "operation_id";
            // 
            // debenturyidDataGridViewTextBoxColumn
            // 
            this.debenturyidDataGridViewTextBoxColumn.DataPropertyName = "debentury_id";
            this.debenturyidDataGridViewTextBoxColumn.DataSource = this.getDebenturesBindingSource;
            this.debenturyidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.debenturyidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.debenturyidDataGridViewTextBoxColumn.HeaderText = "debentury_id";
            this.debenturyidDataGridViewTextBoxColumn.Name = "debenturyidDataGridViewTextBoxColumn";
            this.debenturyidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debenturyidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.debenturyidDataGridViewTextBoxColumn.ValueMember = "debentury_id";

            this.getDebenturesTableAdapter.Fill(this.library_dbDataSet.GetDebentures);
            this.getOperationsTableAdapter.Fill(this.library_dbDataSet.GetOperations);
            this.chronologyTableAdapter.Fill(this.library_dbDataSet.Chronology);
        }
    }
}
