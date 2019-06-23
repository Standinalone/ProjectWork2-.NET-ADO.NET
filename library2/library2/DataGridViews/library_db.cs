using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library2.DataGridViews
{
    static class library_db
    {
        public static library_dbDataSet library_dbDataSet;
        public static void InitiateComponents()
        {
            library_dbDataSet = new library2.library_dbDataSet();
            library_dbDataSet.DataSetName = "library_dbDataSet";
            library_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        }
    }
}
