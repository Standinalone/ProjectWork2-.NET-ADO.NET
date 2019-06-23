using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{


    class EditionsKeywords : DataGridView
    {
        private library_dbDataSet library_dbDataSet = library2.DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource editionsKeywordsBindingSource;
        private library_dbDataSetTableAdapters.EditionsKeywordsTableAdapter editionsKeywordsTableAdapter;
        private System.Windows.Forms.BindingSource getEditionsForEditionsKeywordsBindingSource;
        private library_dbDataSetTableAdapters.GetEditionsForEditionsKeywordsTableAdapter getEditionsForEditionsKeywordsTableAdapter;
        private System.Windows.Forms.BindingSource keyWordsBindingSource;
        private library_dbDataSetTableAdapters.KeyWordsTableAdapter keyWordsTableAdapter;
        private System.Windows.Forms.BindingSource getKeywordsBindingSource;
        private library_dbDataSetTableAdapters.GetKeywordsTableAdapter getKeywordsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn editionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn keyword_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn keywordidDataGridViewTextBoxColumn;

        public EditionsKeywords()
        {
            this.editionsKeywordsBindingSource = new System.Windows.Forms.BindingSource();
            this.editionsKeywordsTableAdapter = new library2.library_dbDataSetTableAdapters.EditionsKeywordsTableAdapter();
            this.getEditionsForEditionsKeywordsBindingSource = new System.Windows.Forms.BindingSource();
            this.getEditionsForEditionsKeywordsTableAdapter = new library2.library_dbDataSetTableAdapters.GetEditionsForEditionsKeywordsTableAdapter();
            this.keyWordsBindingSource = new System.Windows.Forms.BindingSource();
            this.keyWordsTableAdapter = new library2.library_dbDataSetTableAdapters.KeyWordsTableAdapter();
            this.getKeywordsBindingSource = new System.Windows.Forms.BindingSource();
            this.getKeywordsTableAdapter = new library2.library_dbDataSetTableAdapters.GetKeywordsTableAdapter();
            this.keywordidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.keyword_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.AutoGenerateColumns = false;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editionidDataGridViewTextBoxColumn,
            this.keyword_id});
            this.DataSource = this.editionsKeywordsBindingSource;
            this.Location = new System.Drawing.Point(103, 67);
            this.Name = "dataGridView1";
            this.Size = new System.Drawing.Size(468, 150);
            this.TabIndex = 0;
            // 
            // editionsKeywordsBindingSource
            // 
            this.editionsKeywordsBindingSource.DataMember = "EditionsKeywords";
            this.editionsKeywordsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // editionsKeywordsTableAdapter
            // 
            this.editionsKeywordsTableAdapter.ClearBeforeFill = true;
            // 
            // getEditionsForEditionsKeywordsBindingSource
            // 
            this.getEditionsForEditionsKeywordsBindingSource.DataMember = "GetEditionsForEditionsKeywords";
            this.getEditionsForEditionsKeywordsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getEditionsForEditionsKeywordsTableAdapter
            // 
            this.getEditionsForEditionsKeywordsTableAdapter.ClearBeforeFill = true;
            // 
            // keyWordsBindingSource
            // 
            this.keyWordsBindingSource.DataMember = "KeyWords";
            this.keyWordsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // keyWordsTableAdapter
            // 
            this.keyWordsTableAdapter.ClearBeforeFill = true;
            // 
            // getKeywordsBindingSource
            // 
            this.getKeywordsBindingSource.DataMember = "GetKeywords";
            this.getKeywordsBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getKeywordsTableAdapter
            // 
            this.getKeywordsTableAdapter.ClearBeforeFill = true;
            // 
            // keywordidDataGridViewTextBoxColumn
            // 
            this.keywordidDataGridViewTextBoxColumn.DataPropertyName = "keyword_id";
            this.keywordidDataGridViewTextBoxColumn.DataSource = this.getKeywordsBindingSource;
            this.keywordidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.keywordidDataGridViewTextBoxColumn.HeaderText = "keyword_id";
            this.keywordidDataGridViewTextBoxColumn.Name = "keywordidDataGridViewTextBoxColumn";
            this.keywordidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.keywordidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.keywordidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // editionidDataGridViewTextBoxColumn
            // 
            this.editionidDataGridViewTextBoxColumn.DataPropertyName = "edition_id";
            this.editionidDataGridViewTextBoxColumn.DataSource = this.getEditionsForEditionsKeywordsBindingSource;
            this.editionidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.editionidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.editionidDataGridViewTextBoxColumn.HeaderText = "edition_id";
            this.editionidDataGridViewTextBoxColumn.Name = "editionidDataGridViewTextBoxColumn";
            this.editionidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editionidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editionidDataGridViewTextBoxColumn.ValueMember = "edition_id";
            // 
            // keyword_id
            // 
            this.keyword_id.DataPropertyName = "keyword_id";
            this.keyword_id.DataSource = this.getKeywordsBindingSource;
            this.keyword_id.DisplayMember = "name";
            this.keyword_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.keyword_id.HeaderText = "keyword_id";
            this.keyword_id.Name = "keyword_id";
            this.keyword_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.keyword_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.keyword_id.ValueMember = "keyword_id";

            this.getKeywordsTableAdapter.Fill(this.library_dbDataSet.GetKeywords);
            this.keyWordsTableAdapter.Fill(this.library_dbDataSet.KeyWords);
            this.getEditionsForEditionsKeywordsTableAdapter.Fill(this.library_dbDataSet.GetEditionsForEditionsKeywords);
            this.editionsKeywordsTableAdapter.Fill(this.library_dbDataSet.EditionsKeywords);
            this.getEditionsForEditionsKeywordsTableAdapter.Fill(this.library_dbDataSet.GetEditionsForEditionsKeywords);
        }

    }
}
