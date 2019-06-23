using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library2
{
    public static class SettingsClass
    {
        public static String rank = "Администратор"; // rank by default
        public enum FormWithFieldsOptions { Nothing, edit, add, choose, chooseMultiple };
        public static SqlConnection sql_connection = new SqlConnection("integrated security=SSPI; Data Source=\".\\SQL2008EXPRESS\"; initial catalog=library_db;persist security info=true");
        //public static SqlConnection sql_connection = new SqlConnection("integrated security=SSPI; Data Source=\"STRATEG03\\SQLEXPRESS\"; initial catalog=library_db;persist security info=true");

        static public Dictionary<String, String> tables_dict = new Dictionary<String, String>();
        //static public Dictionary<String, String> foreign_dict = new Dictionary<string, string>();
        //static public Dictionary<String, String> manyToMany = new Dictionary<string, string>();
        static public Dictionary<String, List<String>> manyToMany = new Dictionary<string, List<String>>();
        static public Dictionary<String, List<String>> foreign_dict = new Dictionary<string, List<String>>();

        static public Size tableWindowSize = new Size(874, 514); // Size of table Windows
        static public List<String> quickData = new List<string>();
        public static void InitializeComponents()
        {
            // For adding data to manyToMany relational tables
            manyToMany.Add("Editions", new List<string>() { "EditionsAuthors", "EditionsKeywords" });
            foreign_dict.Add("Editions", new List<string>() { "library2.DataGridViews.Authors", "Keywords" });
            //manyToMany.Add("Editions", "EditionsKeywords");
            //foreign_dict.Add("Editions", "library2.DataGridViews.Keywords");

            // Specifies which table should be opened for each field. May be either standart table or DataGridView class in DataGridViews folder
            tables_dict.Add("gender_id", "Genders");
            tables_dict.Add("language_id", "Languages");
            tables_dict.Add("subject_id", "Subjects");
            tables_dict.Add("genre_id", "Genres");
            tables_dict.Add("type_id", "EditionTypes");
            tables_dict.Add("localityType_id", "LocalityTypes");
            tables_dict.Add("contry_id", "Contries");
            tables_dict.Add("streetType_id", "StreetTypes");
            tables_dict.Add("status_id", "Statuses");
            tables_dict.Add("section_id", "Sections");
            tables_dict.Add("keyword_id", "Keywords");

            tables_dict.Add("locality_id", "library2.DataGridViews.Localities");
            tables_dict.Add("publisher_id", "library2.DataGridViews.Publishers");
            tables_dict.Add("address_id", "library2.DataGridViews.Addresses");
            tables_dict.Add("street_id", "library2.DataGridViews.Streets");
            tables_dict.Add("copy_id", "library2.DataGridViews.Copies");
            tables_dict.Add("position_id", "library2.DataGridViews.Readers");
            tables_dict.Add("debentures_id", "library2.DataGridViews.Debentures");
            tables_dict.Add("author_id", "library2.DataGridViews.Authors");
            tables_dict.Add("edition_id", "library2.DataGridViews.Editions");
            tables_dict.Add("reader_id", "library2.DataGridViews.Readers");

            tables_dict.Add("expected_date", "Time");
            tables_dict.Add("returning_date", "Time");
            tables_dict.Add("lending_date", "Time");
            tables_dict.Add("date_of_birth", "");
            tables_dict.Add("publication_date", "");
            tables_dict.Add("startOfWork_date", "");
        }
        public static void getData()
        {
            List<String> result = new List<string>();
            String query = 
                "select count (id) from copies " +
                "union all " +
                "select count (id) from copies where status_id =1 " +
                "union all " +
                "select count (id) from copies where status_id = 2 " +
                "union all " +
                "select count (id) from readers;";
            SqlCommand cmn = new SqlCommand(query, sql_connection);
            sql_connection.Open();
            SqlDataReader reader = cmn.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            sql_connection.Close();
            quickData = result;

        }
    }
}
