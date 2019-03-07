using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenoid.SelenoidClasses
{
    class ObjectManager
    {
        //Getter Setter Methods
        //Acts as data provider for the application

        public string ScreenName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string LocatorType { get; set; }
        public string LocatorValue { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["orconnstrng"].ConnectionString;

        //Retrieving data from database
        public DataTable Select()
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "SELECT * FROM tbl_HomePage";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting data into database
        public bool Insert(ObjectManager c)
        {
            //Create default return value as false
            bool isSuccess = false;

            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Create query to insert data
                string sql = "INSERT INTO tbl_HomePage (Object, Locator) VALUES (@Object, @Locator)";
                //Create cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue("@Object", c.ObjectName);
                cmd.Parameters.AddWithValue("@Locator", c.LocatorValue);
                //cmd.Parameters.AddWithValue("@LocatorType", c.LocatorType);
                //Open the connection
                conn.Open();
                //Executing the above add commands. Return the number of rows (non zero) if successful.
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
