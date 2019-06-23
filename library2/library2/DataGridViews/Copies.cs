using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Copies : DataGridView, ISelectable, IHaveinfo
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource copiesBindingSource;
        private library_dbDataSetTableAdapters.CopiesTableAdapter copiesTableAdapter;
        private System.Windows.Forms.BindingSource getSectionsBindingSource;
        private library_dbDataSetTableAdapters.GetSectionsTableAdapter getSectionsTableAdapter;
        private System.Windows.Forms.BindingSource getEditionsForCopiesBindingSource;
        private library_dbDataSetTableAdapters.GetEditionsForCopiesTableAdapter getEditionsForCopiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn editionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sectionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getStatusesBindingSource;
        private library_dbDataSetTableAdapters.GetStatusesTableAdapter getStatusesTableAdapter;
        public Copies()
        {
            this.getStatusesBindingSource = new System.Windows.Forms.BindingSource();
            this.getStatusesTableAdapter = new library2.library_dbDataSetTableAdapters.GetStatusesTableAdapter();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.copiesBindingSource = new BindingSource();
            this.copiesTableAdapter = new library2.library_dbDataSetTableAdapters.CopiesTableAdapter();
            this.getSectionsBindingSource = new System.Windows.Forms.BindingSource();
            this.getSectionsTableAdapter = new library2.library_dbDataSetTableAdapters.GetSectionsTableAdapter();
            this.getEditionsForCopiesBindingSource = new System.Windows.Forms.BindingSource();
            this.getEditionsForCopiesTableAdapter = new library2.library_dbDataSetTableAdapters.GetEditionsForCopiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sectionnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.editionidDataGridViewTextBoxColumn,
            this.sectionnumberDataGridViewTextBoxColumn,
            this.sectionidDataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn});
            this.DataSource = this.copiesBindingSource;
            this.Location = new System.Drawing.Point(47, 111);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(633, 150);
            this.TabIndex = 0;
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn.DataSource = this.getStatusesBindingSource;
            this.statusidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            this.statusidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusidDataGridViewTextBoxColumn.ValueMember = "status_id";
            this.statusidDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            // 
            // getStatusesBindingSource
            // 
            this.getStatusesBindingSource.DataMember = "GetStatuses";
            this.getStatusesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // copiesBindingSource
            // 
            this.copiesBindingSource.DataMember = "Copies";
            this.copiesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // copiesTableAdapter
            // 
            this.copiesTableAdapter.ClearBeforeFill = true;
            // 
            // getSectionsBindingSource
            // 
            this.getSectionsBindingSource.DataMember = "GetSections";
            this.getSectionsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getSectionsTableAdapter
            // 
            this.getSectionsTableAdapter.ClearBeforeFill = true;
            // 
            // getEditionsForCopiesBindingSource
            // 
            this.getEditionsForCopiesBindingSource.DataMember = "GetEditionsForCopies";
            this.getEditionsForCopiesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getEditionsForCopiesTableAdapter
            // 
            this.getEditionsForCopiesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // editionidDataGridViewTextBoxColumn
            // 
            this.editionidDataGridViewTextBoxColumn.DataPropertyName = "edition_id";
            this.editionidDataGridViewTextBoxColumn.DataSource = this.getEditionsForCopiesBindingSource;
            this.editionidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.editionidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.editionidDataGridViewTextBoxColumn.HeaderText = "edition_id";
            this.editionidDataGridViewTextBoxColumn.Name = "editionidDataGridViewTextBoxColumn";
            this.editionidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editionidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editionidDataGridViewTextBoxColumn.ValueMember = "edition_id";
            // 
            // sectionnumberDataGridViewTextBoxColumn
            // 
            this.sectionnumberDataGridViewTextBoxColumn.DataPropertyName = "sectionnumber";
            this.sectionnumberDataGridViewTextBoxColumn.HeaderText = "sectionnumber";
            this.sectionnumberDataGridViewTextBoxColumn.Name = "sectionnumberDataGridViewTextBoxColumn";
            // 
            // sectionidDataGridViewTextBoxColumn
            // 
            this.sectionidDataGridViewTextBoxColumn.DataPropertyName = "section_id";
            this.sectionidDataGridViewTextBoxColumn.DataSource = this.getSectionsBindingSource;
            this.sectionidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.sectionidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sectionidDataGridViewTextBoxColumn.HeaderText = "section_id";
            this.sectionidDataGridViewTextBoxColumn.Name = "sectionidDataGridViewTextBoxColumn";
            this.sectionidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sectionidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sectionidDataGridViewTextBoxColumn.ValueMember = "section_id";

            this.getEditionsForCopiesTableAdapter.Fill(this.library_dbDataSet.GetEditionsForCopies);
            this.getSectionsTableAdapter.Fill(this.library_dbDataSet.GetSections);
            this.getEditionsForCopiesTableAdapter.Fill(this.library_dbDataSet.GetEditionsForCopies);
            this.copiesTableAdapter.Fill(this.library_dbDataSet.Copies);
            this.getStatusesTableAdapter.Fill(this.library_dbDataSet.GetStatuses);
           
        }

        public String GetInfo()
        {
        return "Красным выделены экземпляры, выданные читателям, серым - экземпляры отсутствующие в библиотеке по какой-либо причине, выдать их не получится";
        }
        public void SelectRows(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["statusidDataGridViewTextBoxColumn"].Value.ToString() == "2") // If status = "На руках"
                {
                    row.DefaultCellStyle.BackColor = Color.DeepPink;
                }
                if (row.Cells["statusidDataGridViewTextBoxColumn"].Value.ToString() == "3") // If status = "Утеряна"
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
    }
}
