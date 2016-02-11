using System;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace GUI
{
    public class DAL
    {
        private static DAL instance = null;
        private OleDbConnection myAccessConn = null;

        private DAL() {
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stockMan.mdb";
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }
        }

        public static DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL();
                }
                return instance;
            }
        }

        public DataTable getCustomers() {
            DataSet myDataSet = new DataSet();
            string strAccessSelect = "SELECT * FROM Customers WHERE TypeID = 0";
            try
            {

                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, "Customers");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
            }
            finally
            {
                myAccessConn.Close();
            }

            // A dataset can contain multiple tables, so let's get the first one
            return myDataSet.Tables[0];
        }

    }
}
