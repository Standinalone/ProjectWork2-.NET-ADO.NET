namespace library2
{
    partial class Form_Readers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKDebenturesReadersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_dbDataSet = new library2.library_dbDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.getBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_dbDataSet1 = new library2.library_dbDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debenturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new library2.library_dbDataSetTableAdapters.ReadersTableAdapter();
            this.debenturesTableAdapter = new library2.library_dbDataSetTableAdapters.DebenturesTableAdapter();
            this.getBooksTableAdapter = new library2.library_dbDataSetTableAdapters.getBooksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.fKDebenturesReadersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expecteddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDebenturesReadersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_dbDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debenturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDebenturesReadersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 266);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 173);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(550, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выдача";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.copyidDataGridViewTextBoxColumn,
            this.readeridDataGridViewTextBoxColumn,
            this.lendingdateDataGridViewTextBoxColumn,
            this.expecteddateDataGridViewTextBoxColumn,
            this.returningdateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKDebenturesReadersBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 86);
            this.dataGridView2.TabIndex = 0;
            // 
            // fKDebenturesReadersBindingSource
            // 
            this.fKDebenturesReadersBindingSource.DataMember = "FK_Debentures_Readers";
            this.fKDebenturesReadersBindingSource.DataSource = this.readersBindingSource;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.library_dbDataSet;
            // 
            // library_dbDataSet
            // 
            this.library_dbDataSet.DataSetName = "library_dbDataSet";
            this.library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(550, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Возврат";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(550, 147);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Хронология";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(550, 147);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Книги на руках";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MinimumSize = new System.Drawing.Size(0, 100);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(550, 147);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // getBooksBindingSource
            // 
            this.getBooksBindingSource.DataMember = "getBooks";
            this.getBooksBindingSource.DataSource = this.library_dbDataSet1;
            // 
            // library_dbDataSet1
            // 
            this.library_dbDataSet1.DataSetName = "library_dbDataSet";
            this.library_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.genderidDataGridViewTextBoxColumn,
            this.addressidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.readersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 133);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // genderidDataGridViewTextBoxColumn
            // 
            this.genderidDataGridViewTextBoxColumn.DataPropertyName = "gender_id";
            this.genderidDataGridViewTextBoxColumn.HeaderText = "gender_id";
            this.genderidDataGridViewTextBoxColumn.Name = "genderidDataGridViewTextBoxColumn";
            // 
            // addressidDataGridViewTextBoxColumn
            // 
            this.addressidDataGridViewTextBoxColumn.DataPropertyName = "address_id";
            this.addressidDataGridViewTextBoxColumn.HeaderText = "address_id";
            this.addressidDataGridViewTextBoxColumn.Name = "addressidDataGridViewTextBoxColumn";
            // 
            // debenturesBindingSource
            // 
            this.debenturesBindingSource.DataMember = "Debentures";
            this.debenturesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // debenturesTableAdapter
            // 
            this.debenturesTableAdapter.ClearBeforeFill = true;
            // 
            // getBooksTableAdapter
            // 
            this.getBooksTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // fKDebenturesReadersBindingSource1
            // 
            this.fKDebenturesReadersBindingSource1.DataMember = "FK_Debentures_Readers";
            this.fKDebenturesReadersBindingSource1.DataSource = this.readersBindingSource;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // copyidDataGridViewTextBoxColumn
            // 
            this.copyidDataGridViewTextBoxColumn.DataPropertyName = "copy_id";
            this.copyidDataGridViewTextBoxColumn.HeaderText = "copy_id";
            this.copyidDataGridViewTextBoxColumn.Name = "copyidDataGridViewTextBoxColumn";
            // 
            // readeridDataGridViewTextBoxColumn
            // 
            this.readeridDataGridViewTextBoxColumn.DataPropertyName = "reader_id";
            this.readeridDataGridViewTextBoxColumn.HeaderText = "reader_id";
            this.readeridDataGridViewTextBoxColumn.Name = "readeridDataGridViewTextBoxColumn";
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
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(544, 140);
            this.dataGridView4.TabIndex = 0;
            // 
            // Form_Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Readers";
            this.Text = "Читатели";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDebenturesReadersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_dbDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debenturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDebenturesReadersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private library_dbDataSet library_dbDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource debenturesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private library_dbDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKDebenturesReadersBindingSource;
        private library_dbDataSetTableAdapters.DebenturesTableAdapter debenturesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource getBooksBindingSource;
        private library_dbDataSet library_dbDataSet1;
        private library_dbDataSetTableAdapters.getBooksTableAdapter getBooksTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn copyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expecteddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returningdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKDebenturesReadersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}