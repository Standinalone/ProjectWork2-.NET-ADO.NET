using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2.DataGridViews
{
    class Editions : DataGridView, IHavetrivia, IHaveMoreInfo
    {
        private library_dbDataSet library_dbDataSet = DataGridViews.library_db.library_dbDataSet;
        private System.Windows.Forms.BindingSource editionsBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource getTypesBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource getLanguagesBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource getSubjectsBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource getGenresBindingSource = new System.Windows.Forms.BindingSource();
        private System.Windows.Forms.BindingSource getISBNBindingSource = new System.Windows.Forms.BindingSource();

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn pagecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn udcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn originalnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewComboBoxColumn languageidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private System.Windows.Forms.DataGridViewComboBoxColumn subjectidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private System.Windows.Forms.DataGridViewComboBoxColumn typeidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private System.Windows.Forms.DataGridViewComboBoxColumn genreidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private System.Windows.Forms.DataGridViewComboBoxColumn iSBNISSNDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private System.Windows.Forms.DataGridViewComboBoxColumn publisheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        private library_dbDataSetTableAdapters.GetLanguagesTableAdapter getLanguagesTableAdapter = new library2.library_dbDataSetTableAdapters.GetLanguagesTableAdapter();
        private library_dbDataSetTableAdapters.GetSubjectsTableAdapter getSubjectsTableAdapter = new library2.library_dbDataSetTableAdapters.GetSubjectsTableAdapter();
        private library_dbDataSetTableAdapters.GetGenresTableAdapter getGenresTableAdapter = new library2.library_dbDataSetTableAdapters.GetGenresTableAdapter();
        private library_dbDataSetTableAdapters.GetTypesTableAdapter getTypesTableAdapter = new library2.library_dbDataSetTableAdapters.GetTypesTableAdapter();
        private library_dbDataSetTableAdapters.GetTypesTableAdapter getISBNTableAdapter = new library2.library_dbDataSetTableAdapters.GetTypesTableAdapter();
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        private System.Windows.Forms.DataGridViewTextBoxColumn cipherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();


        private library_dbDataSetTableAdapters.EditionsTableAdapter editionsTableAdapter = new library2.library_dbDataSetTableAdapters.EditionsTableAdapter();
        private System.Windows.Forms.BindingSource getPublishersBindingSource;
        private library_dbDataSetTableAdapters.GetPublishersTableAdapter getPublishersTableAdapter;
        public Editions()
        {
            Tag = "Эта таблица предназначена для хранения записей об изданиях, хранящихся в библиотеке.  ";
            this.getPublishersBindingSource = new System.Windows.Forms.BindingSource();
            this.getPublishersTableAdapter = new library2.library_dbDataSetTableAdapters.GetPublishersTableAdapter();
            // 
            // getPublishersTableAdapter
            // 
            //this.getPublishersTableAdapter.ClearBeforeFill = true;
            // 
            // 
            // getPublishersBindingSource
            // 
            this.getPublishersBindingSource.DataMember = "GetPublishers";
            this.getPublishersBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getISBNBindingSource
            //
            this.getISBNBindingSource.DataMember = "GetTypes";
            this.getISBNBindingSource.DataSource = this.library_dbDataSet;
            //
            // getGenresBindingSource
            //
            this.getGenresBindingSource.DataMember = "GetGenres";
            this.getGenresBindingSource.DataSource = this.library_dbDataSet;
            //
            // getSubjectsBindingSource
            //
            this.getSubjectsBindingSource.DataMember = "GetSubjects";
            this.getSubjectsBindingSource.DataSource = this.library_dbDataSet;
            //
            // editionsBindingSource
            //
            this.editionsBindingSource.DataMember = "Editions";
            //this.editionsBindingSource.DataMember = "GetEditions2";
            this.editionsBindingSource.DataSource = this.library_dbDataSet;
            //
            // getTypesBindingSource
            // 
            this.getTypesBindingSource.DataMember = "GetTypes";
            this.getTypesBindingSource.DataSource = this.library_dbDataSet;
            // 
            // getLanguagesBindingSource
            // 
            this.getLanguagesBindingSource.DataMember = "GetLanguages";
            this.getLanguagesBindingSource.DataSource = this.library_dbDataSet;
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
            // publicationdateDataGridViewTextBoxColumn
            // 
            this.publicationdateDataGridViewTextBoxColumn.DataPropertyName = "publication_date";
            this.publicationdateDataGridViewTextBoxColumn.HeaderText = "publication_date";
            this.publicationdateDataGridViewTextBoxColumn.Name = "publicationdateDataGridViewTextBoxColumn";
            // 
            // pagecountDataGridViewTextBoxColumn
            // 
            this.pagecountDataGridViewTextBoxColumn.DataPropertyName = "page_count";
            this.pagecountDataGridViewTextBoxColumn.HeaderText = "page_count";
            this.pagecountDataGridViewTextBoxColumn.Name = "pagecountDataGridViewTextBoxColumn";
            // 
            // udcDataGridViewTextBoxColumn
            // 
            this.udcDataGridViewTextBoxColumn.DataPropertyName = "udc";
            this.udcDataGridViewTextBoxColumn.HeaderText = "udc";
            this.udcDataGridViewTextBoxColumn.Name = "udcDataGridViewTextBoxColumn";
            // 
            // originalnameDataGridViewTextBoxColumn
            // 
            this.originalnameDataGridViewTextBoxColumn.DataPropertyName = "original_name";
            this.originalnameDataGridViewTextBoxColumn.HeaderText = "original_name";
            this.originalnameDataGridViewTextBoxColumn.Name = "originalnameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // languageidDataGridViewComboBoxColumn
            // 
            this.languageidDataGridViewComboBoxColumn.DataPropertyName = "language_id";
            this.languageidDataGridViewComboBoxColumn.DataSource = this.getLanguagesBindingSource;
            this.languageidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.languageidDataGridViewComboBoxColumn.HeaderText = "Язык";
            this.languageidDataGridViewComboBoxColumn.Name = "languageidDataGridViewComboBoxColumn";
            this.languageidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.languageidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.languageidDataGridViewComboBoxColumn.ValueMember = "language_id";
            this.languageidDataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.languageidDataGridViewComboBoxColumn.ReadOnly = true;
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewComboBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewComboBoxColumn.HeaderText = "subject_id";
            this.subjectidDataGridViewComboBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            // 
            // typeidDataGridViewComboBoxColumn
            // 
            this.typeidDataGridViewComboBoxColumn.DataPropertyName = "type_id";
            this.typeidDataGridViewComboBoxColumn.DataSource = this.getTypesBindingSource;
            this.typeidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.typeidDataGridViewComboBoxColumn.HeaderText = "Тип";
            this.typeidDataGridViewComboBoxColumn.Name = "typeidDataGridViewComboBoxColumn";
            this.typeidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeidDataGridViewComboBoxColumn.ValueMember = "type_id";
            this.typeidDataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeidDataGridViewComboBoxColumn.ReadOnly = true;
            //
            // genreidDataGridViewComboBoxColumn
            // 
            this.genreidDataGridViewComboBoxColumn.DataPropertyName = "genre_id";
            this.genreidDataGridViewComboBoxColumn.DataSource = this.getGenresBindingSource;
            this.genreidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.genreidDataGridViewComboBoxColumn.HeaderText = "Жанр";
            this.genreidDataGridViewComboBoxColumn.Name = "genreidDataGridViewComboBoxColumn";
            this.genreidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genreidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genreidDataGridViewComboBoxColumn.ValueMember = "genre_id";
            this.genreidDataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.genreidDataGridViewComboBoxColumn.ReadOnly = true;
            // 
            // publisheridDataGridViewTextBoxColumn
            // 
            this.publisheridDataGridViewTextBoxColumn.DataPropertyName = "publisher_id";
            this.publisheridDataGridViewTextBoxColumn.DataSource = this.getPublishersBindingSource;
            this.publisheridDataGridViewTextBoxColumn.DisplayMember = "name";
            this.publisheridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.publisheridDataGridViewTextBoxColumn.HeaderText = "publisher_id";
            this.publisheridDataGridViewTextBoxColumn.Name = "publisheridDataGridViewTextBoxColumn";
            this.publisheridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.publisheridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.publisheridDataGridViewTextBoxColumn.ValueMember = "publisher_id";
            //
            // subjectidDataGridViewComboBoxColumn
            // 
            //this.subjectidDataGridViewComboBoxColumn
            this.subjectidDataGridViewComboBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewComboBoxColumn.DataSource = this.getSubjectsBindingSource;
            this.subjectidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.subjectidDataGridViewComboBoxColumn.HeaderText = "Вид";
            this.subjectidDataGridViewComboBoxColumn.Name = "subjectidDataGridViewComboBoxColumn";
            this.subjectidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subjectidDataGridViewComboBoxColumn.ValueMember = "subject_id";
            this.subjectidDataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.subjectidDataGridViewComboBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn-issn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "[ISBN-ISSN]";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.cipherDataGridViewTextBoxColumn.DataPropertyName = "cipher";
            this.cipherDataGridViewTextBoxColumn.HeaderText = "cipher";
            this.cipherDataGridViewTextBoxColumn.Name = "cipherDataGridViewTextBoxColumn";
            //
            // Managing Columns
            //
            this.AutoGenerateColumns = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.idDataGridViewTextBoxColumn,
                this.nameDataGridViewTextBoxColumn,
                this.publicationdateDataGridViewTextBoxColumn,
                this.pagecountDataGridViewTextBoxColumn,
                this.udcDataGridViewTextBoxColumn,
                this.originalnameDataGridViewTextBoxColumn,
                this.priceDataGridViewTextBoxColumn,
                this.languageidDataGridViewComboBoxColumn,
                this.genreidDataGridViewComboBoxColumn,
                this.typeidDataGridViewComboBoxColumn,
                this.subjectidDataGridViewComboBoxColumn,
                this.publisheridDataGridViewTextBoxColumn,
                this.isbnDataGridViewTextBoxColumn,
                this.cipherDataGridViewTextBoxColumn});
            this.DataSource = this.editionsBindingSource;
            this.TabIndex = 0;

            getTypesTableAdapter.ClearBeforeFill = true;
            editionsTableAdapter.ClearBeforeFill = true;
            getLanguagesTableAdapter.ClearBeforeFill = true;
            getGenresTableAdapter.ClearBeforeFill = true;
            getSubjectsTableAdapter.ClearBeforeFill = true;
            
            editionsTableAdapter.Fill(this.library_dbDataSet.Editions);
            getLanguagesTableAdapter.Fill(this.library_dbDataSet.GetLanguages);
            getGenresTableAdapter.Fill(this.library_dbDataSet.GetGenres);
            getTypesTableAdapter.Fill(this.library_dbDataSet.GetTypes);
            getSubjectsTableAdapter.Fill(this.library_dbDataSet.GetSubjects);
            getPublishersTableAdapter.Fill(this.library_dbDataSet.GetPublishers);
        }
        
        public string getInfo(int edition_id)
        {
            String info = "";
            SqlConnection sql_connection = SettingsClass.sql_connection;
            SqlCommand cmn;
            String query = "";
            SqlDataReader reader;
            info += "<font size = '2'>";

            query = $"SELECT cipher from editions where id = {edition_id}";
            cmn = new SqlCommand(query, sql_connection);
            sql_connection.Open();
            reader = cmn.ExecuteReader();
            reader.Read();
            info += reader.GetValue(0).ToString() == "" ? "" : "<b>"+reader.GetValue(0).ToString() + "</b><br>";



            reader.Close();
            sql_connection.Close();

            query = $"SELECT name from editions where id = {edition_id}" +
                $" union all " +
                $"select Genres.name from Genres inner join Editions on Editions.genre_id = Genres.id where Editions.id = {edition_id}" +
                $" union all " +
                $"SELECT Substring(name,1,1)  + '. ' + lastname from authors inner join EditionsAuthors on Authors.id = EditionsAuthors.author_id where EditionsAuthors.edition_id = {edition_id}";


            cmn = new SqlCommand(query, sql_connection);
            sql_connection.Open();
            reader = cmn.ExecuteReader();
            reader.Read();
            info += reader.GetValue(0).ToString() + ": ";
            try
            {
                reader.Read();
                info += reader.GetValue(0).ToString() + " / ";
            }
            catch(Exception ex) { }
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    info += (reader.GetValue(0).ToString()) + ", ";
                }
                if (info != "") info = info.Substring(0, info.Length - 2);
                info += " / ";
            }
            sql_connection.Close();
            //query = $"select publishers.name from Editions left join Publishers on Editions.publisher_id = Publishers.id where Editions.id = {edition_id}";
            //sql_connection.Open();
            //cmn = new SqlCommand(query, sql_connection);
            //reader = cmn.ExecuteReader();
            //reader.Read();
            //info += reader.GetValue(0).ToString() == "" ? " NULL " : reader.GetValue(0).ToString() + ", ";
            //sql_connection.Close();

            //query = //$"select publishers.name from Editions left join Publishers on Editions.publisher_id = Publishers.id where Editions.id = {edition_id}" +
            //    //$" union all " +
            //    $"select YEAR(Editions.publication_date) from Editions where Editions.id = {edition_id}" +
            //    $" union all " +
            //    $"select page_count from Editions where Editions.id = {edition_id}" +
            //    $" union all " +
            //    $"select [isbn-issn] from Editions where Editions.id = {edition_id}" +
            //    $" union all " +
            //    $"select price from Editions where Editions.id = {edition_id}";
            query = $"select publishers.name, YEAR(Editions.publication_date), page_count, [isbn-issn],price  from Editions left join Publishers on Editions.publisher_id = Publishers.id where Editions.id = {edition_id}";
            cmn = new SqlCommand(query, sql_connection);

            sql_connection.Open();
            reader = cmn.ExecuteReader();
            reader.Read();
            info += reader.GetValue(0).ToString() == "" ? " NULL " : reader.GetValue(0).ToString() + ", ";
            //reader.Read();
            info += reader.GetValue(1).ToString()==""?" NULL ": reader.GetValue(1).ToString() + ". -";
            //reader.Read();
            info += reader.GetValue(2).ToString()==""?" NULL ": reader.GetValue(2).ToString() + " с. -<b>ISBN/ISSN: </b>";
            //reader.Read();
            info += reader.GetValue(3).ToString() == "" ? " NULL " : reader.GetValue(3).ToString() + " : ";
            //reader.Read();
            info += reader.GetValue(4).ToString() == "" ? " NULL " : reader.GetValue(4).ToString() + " грн";



            reader.Close();
            sql_connection.Close();

            info += "<br><br><b>Авторы: </b><br>";
            
            query = $"SELECT name  + ' ' + lastname from authors inner join EditionsAuthors on Authors.id = EditionsAuthors.author_id where EditionsAuthors.edition_id = {edition_id}";
            cmn = new SqlCommand(query, sql_connection);

            sql_connection.Open();
            reader = cmn.ExecuteReader();

            try
            {
                while (reader.Read())
                {

                    info += (reader.GetValue(0).ToString()) + ", ";

                    if (info != "") info = info.Substring(0, info.Length - 2);
                }
            }
            catch (Exception ex) { }
            reader.Close();
            sql_connection.Close();

            info += "<br><br><b>Ключевые слова: </b><br>";
            query = $"SELECT Keywords.name from keywords inner join EditionsKeywords on Keywords.id = EditionsKeywords.keyword_id where EditionsKeywords.edition_id = {edition_id}";
            cmn = new SqlCommand(query, sql_connection);

            sql_connection.Open();
            reader = cmn.ExecuteReader();
            while (reader.Read())
            {
                info += (reader.GetValue(0).ToString()) + ", ";
            }
            if (info != "") info = info.Substring(0, info.Length - 2);
            reader.Close();
            sql_connection.Close();
           

            query = $"SELECT COUNT(id) from Copies where edition_id = {edition_id} " +
                    "union all " +
                    $"SELECT COUNT(id) from Copies where edition_id = {edition_id} and status_id = 1";
            cmn = new SqlCommand(query, sql_connection);

            sql_connection.Open();
            reader = cmn.ExecuteReader();
            info += "<br><br><b>Всего экземпляров: </b>";
            reader.Read();
            info += (reader.GetValue(0).ToString()) + ".";
            info += "<br>Свободно: ";
            reader.Read();
            info += (reader.GetValue(0).ToString()) + ".";
            //if (info != "") info = info.Substring(0, info.Length - 2);
            reader.Close();
            sql_connection.Close();

            query = $"select COUNT (Copies.id), sectionnumber as 'Номер', Sections.name as 'имя' from Copies inner join Sections on copies.section_id = Sections.id where edition_id = {edition_id} and status_id = 1 group by sectionnumber, Sections.name";
            cmn = new SqlCommand(query, sql_connection);

            info += "<br>";
            sql_connection.Open();
            reader = cmn.ExecuteReader();
            while (reader.Read())
            {
                info += (reader.GetValue(2).ToString()) + ".";
                info += (reader.GetValue(1).ToString());
                info += "(" + (reader.GetValue(0).ToString()) + ")";
                info += "<br>";
            }
            //if (info != "") info = info.Substring(0, info.Length - 2);
            reader.Close();
            sql_connection.Close();

            query = $"select COUNT(lending_date) from Chronology inner join Debentures on Chronology.debentury_id = Debentures.id inner join Copies on Debentures.copy_id = Copies.id inner join Editions on Copies.edition_id = Editions.id where edition_id = {edition_id}";
            cmn = new SqlCommand(query, sql_connection);
            info += "<br><br><b>Всего выдач: </b>";
            sql_connection.Open();
            reader = cmn.ExecuteReader();
            reader.Read();
            info += (reader.GetValue(0).ToString());
            reader.Close();
            sql_connection.Close();

            info += "</font>";
            return info;
        }

        public string getTrivia(int edition_id)
        {
            //List<String> authors = new List<string>();
            String authors = "";
            SqlConnection sql_connection = SettingsClass.sql_connection;
            String query = $"SELECT name  + ' ' + lastname from authors inner join EditionsAuthors on Authors.id = EditionsAuthors.author_id where EditionsAuthors.edition_id = {edition_id}";
            SqlCommand cmn = new SqlCommand(query, sql_connection);
            sql_connection.Open();
            SqlDataReader reader = cmn.ExecuteReader();
            //int amount = (int)cmn.ExecuteScalar();
            while (reader.Read())
            {
                //authors.Add(reader.GetValue(0).ToString());
                authors += (reader.GetValue(0).ToString()) + ", ";
            }
            if (authors != "") authors = authors.Substring(0, authors.Length - 2);
            reader.Close();
            sql_connection.Close();


            return "Авторы: " + authors;
        }
    }
}
