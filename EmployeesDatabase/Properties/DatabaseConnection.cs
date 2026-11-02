using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EmployeesDatabase.Properties
{
    internal class DatabaseConnection
    {
        private string sql_string;
        private string strCon;
        private SqlDataAdapter da_1;
        public string Sql
        {

            set { sql_string = value; }

        }
        public string connection_string
        {

            set { strCon = value; }

        }
        public System.Data.DataSet GetConnection
        {

            get { return MyDataSet(); }

        }


        private System.Data.DataSet MyDataSet()
        {
            if (string.IsNullOrWhiteSpace(strCon))
            {
                throw new InvalidOperationException(
                    "Database connection string is empty.");
            }

            SqlConnection con = new SqlConnection(strCon);

            da_1 = new SqlDataAdapter(sql_string, con);

            System.Data.DataSet dat_set = new System.Data.DataSet();

            da_1.Fill(dat_set, "Table_Data_1");

            return dat_set;
        }

        public void UpdateDatabase(System.Data.DataSet ds)
        {
            if (da_1 == null)
            {
                throw new InvalidOperationException(
                    "Load the database data before saving.");
            }

            SqlCommandBuilder cb = new SqlCommandBuilder(da_1);

            da_1.Update(ds.Tables[0]);
        }



    }
}
