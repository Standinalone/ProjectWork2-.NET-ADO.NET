using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Addresses : DataGridView
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private library_dbDataSetTableAdapters.AddressesTableAdapter addressesTableAdapter;
        private System.Windows.Forms.BindingSource getStreetsBindingSource;
        private library_dbDataSetTableAdapters.GetStreetsTableAdapter getStreetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn streetidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;

        public Addresses()
        {
            this.addressesBindingSource = new System.Windows.Forms.BindingSource();
            this.library_dbDataSet = new library2.library_dbDataSet();
            this.addressesTableAdapter = new library2.library_dbDataSetTableAdapters.AddressesTableAdapter();
            this.getStreetsBindingSource = new System.Windows.Forms.BindingSource();
            this.getStreetsTableAdapter = new library2.library_dbDataSetTableAdapters.GetStreetsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.streetidDataGridViewTextBoxColumn});
            this.DataSource = this.addressesBindingSource;
            this.Location = new System.Drawing.Point(107, 157);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(452, 150);
            this.TabIndex = 0;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "Addresses";
            this.addressesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // getStreetsBindingSource
            // 
            this.getStreetsBindingSource.DataMember = "GetStreets";
            this.getStreetsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getStreetsTableAdapter
            // 
            this.getStreetsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "house";
            this.houseDataGridViewTextBoxColumn.HeaderText = "house";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            //
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // streetidDataGridViewTextBoxColumn
            // 
            this.streetidDataGridViewTextBoxColumn.DataPropertyName = "street_id";
            this.streetidDataGridViewTextBoxColumn.DataSource = this.getStreetsBindingSource;
            this.streetidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.streetidDataGridViewTextBoxColumn.HeaderText = "street_id";
            this.streetidDataGridViewTextBoxColumn.Name = "streetidDataGridViewTextBoxColumn";
            this.streetidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.streetidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.streetidDataGridViewTextBoxColumn.ValueMember = "street_id";
            this.streetidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            this.getStreetsTableAdapter.Fill(this.library_dbDataSet.GetStreets);
            this.addressesTableAdapter.Fill(this.library_dbDataSet.Addresses);
        }
    }
}
