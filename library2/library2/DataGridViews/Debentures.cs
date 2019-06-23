using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Debentures : DataGridView, ISelectable, IHaveinfo
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;

        private System.Windows.Forms.BindingSource debenturesBindingSource;
        private library_dbDataSetTableAdapters.DebenturesTableAdapter debenturesTableAdapter;
        private System.Windows.Forms.BindingSource getReadersForDebenturesBindingSource;
        private library_dbDataSetTableAdapters.GetReadersForDebenturesTableAdapter getReadersForDebenturesTableAdapter;
        private System.Windows.Forms.BindingSource getEditionsForDebenturesBindingSource;
        private library_dbDataSetTableAdapters.GetEditionsForDebenturesTableAdapter getEditionsForDebenturesTableAdapter;
        private System.Windows.Forms.BindingSource getEditionsForDebenturesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn copyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn readeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expecteddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returningdateDataGridViewTextBoxColumn;

        public Debentures()
        {
            this.getReadersForDebenturesBindingSource = new System.Windows.Forms.BindingSource();
            this.debenturesBindingSource = new System.Windows.Forms.BindingSource();
            this.debenturesTableAdapter = new library2.library_dbDataSetTableAdapters.DebenturesTableAdapter();
            this.getReadersForDebenturesTableAdapter = new library2.library_dbDataSetTableAdapters.GetReadersForDebenturesTableAdapter();
            this.getEditionsForDebenturesBindingSource = new System.Windows.Forms.BindingSource();
            this.getEditionsForDebenturesTableAdapter = new library2.library_dbDataSetTableAdapters.GetEditionsForDebenturesTableAdapter();
            this.getEditionsForDebenturesBindingSource1 = new System.Windows.Forms.BindingSource();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.readeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lendingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expecteddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();


            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.copyidDataGridViewTextBoxColumn,
            this.readeridDataGridViewTextBoxColumn,
            this.lendingdateDataGridViewTextBoxColumn,
            this.expecteddateDataGridViewTextBoxColumn,
            this.returningdateDataGridViewTextBoxColumn});
            this.DataSource = this.debenturesBindingSource;
            this.Location = new System.Drawing.Point(8, 94);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(700, 150);
            this.TabIndex = 0;
            // 
            // getReadersForDebenturesBindingSource
            // 
            this.getReadersForDebenturesBindingSource.DataMember = "GetReadersForDebentures";
            this.getReadersForDebenturesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // debenturesBindingSource
            // 
            this.debenturesBindingSource.DataMember = "Debentures";
            this.debenturesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // debenturesTableAdapter
            // 
            this.debenturesTableAdapter.ClearBeforeFill = true;
            // 
            // getReadersForDebenturesTableAdapter
            // 
            this.getReadersForDebenturesTableAdapter.ClearBeforeFill = true;
            // 
            // getEditionsForDebenturesBindingSource
            // 
            this.getEditionsForDebenturesBindingSource.DataMember = "GetEditionsForDebentures";
            this.getEditionsForDebenturesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getEditionsForDebenturesTableAdapter
            // 
            this.getEditionsForDebenturesTableAdapter.ClearBeforeFill = true;
            // 
            // getEditionsForDebenturesBindingSource1
            // 
            this.getEditionsForDebenturesBindingSource1.DataMember = "GetEditionsForDebentures";
            this.getEditionsForDebenturesBindingSource1.DataSource = this.library_dbDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // copyidDataGridViewTextBoxColumn
            // 
            this.copyidDataGridViewTextBoxColumn.DataPropertyName = "copy_id";
            this.copyidDataGridViewTextBoxColumn.DataSource = this.getEditionsForDebenturesBindingSource1;
            this.copyidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.copyidDataGridViewTextBoxColumn.HeaderText = "copy_id";
            this.copyidDataGridViewTextBoxColumn.Name = "copyidDataGridViewTextBoxColumn";
            this.copyidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.copyidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.copyidDataGridViewTextBoxColumn.ValueMember = "copy_id";
            this.copyidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // readeridDataGridViewTextBoxColumn
            // 
            this.readeridDataGridViewTextBoxColumn.DataPropertyName = "reader_id";
            this.readeridDataGridViewTextBoxColumn.DataSource = this.getReadersForDebenturesBindingSource;
            this.readeridDataGridViewTextBoxColumn.DisplayMember = "name";
            this.readeridDataGridViewTextBoxColumn.HeaderText = "reader_id";
            this.readeridDataGridViewTextBoxColumn.Name = "readeridDataGridViewTextBoxColumn";
            this.readeridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.readeridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.readeridDataGridViewTextBoxColumn.ValueMember = "reader_id";
            this.readeridDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // lendingdateDataGridViewTextBoxColumn
            // 
            this.lendingdateDataGridViewTextBoxColumn.DataPropertyName = "lending_date";
            this.lendingdateDataGridViewTextBoxColumn.HeaderText = "lending_date";
            this.lendingdateDataGridViewTextBoxColumn.Name = "lendingdateDataGridViewTextBoxColumn";
            // 
            // expecteddateDataGridViewTextBoxColumn
            // 
            this.expecteddateDataGridViewTextBoxColumn.DataPropertyName = "expected_date";
            this.expecteddateDataGridViewTextBoxColumn.HeaderText = "expected_date";
            this.expecteddateDataGridViewTextBoxColumn.Name = "expecteddateDataGridViewTextBoxColumn";
            // 
            // returningdateDataGridViewTextBoxColumn
            // 
            this.returningdateDataGridViewTextBoxColumn.DataPropertyName = "returning_date";
            this.returningdateDataGridViewTextBoxColumn.HeaderText = "returning_date";
            this.returningdateDataGridViewTextBoxColumn.Name = "returningdateDataGridViewTextBoxColumn";
            // 
            getEditionsForDebenturesTableAdapter.ClearBeforeFill = true;
            getReadersForDebenturesTableAdapter.ClearBeforeFill = true;
            debenturesTableAdapter.ClearBeforeFill = true;

            this.getEditionsForDebenturesTableAdapter.Fill(this.library_dbDataSet.GetEditionsForDebentures);
            this.getReadersForDebenturesTableAdapter.Fill(this.library_dbDataSet.GetReadersForDebentures);
            this.debenturesTableAdapter.Fill(this.library_dbDataSet.Debentures);
        }

        public string GetInfo()
        {
            return "Красным выделены незакрытые долги. Выдать эти книги не получится";
        }

        public void SelectRows(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["returningdateDataGridViewTextBoxColumn"].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
            }
        }
    }
}
