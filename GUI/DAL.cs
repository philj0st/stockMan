using System;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace GUI
{
    public class DAL
    {
        private static DAL instance = null;
        private OleDbConnection connectionHandle = null;

        private DAL() {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb";
            try
            {
                connectionHandle = new OleDbConnection(connectionString);
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

        public DataTable getCustomersFromStoredProcedure() {
            DataSet myDataSet = new DataSet();
            try
            {
                OleDbCommand cmd = new OleDbCommand("getCustomersStoredProc", connectionHandle);
                cmd.CommandType = CommandType.StoredProcedure;
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(cmd);

                connectionHandle.Open();
                myDataAdapter.Fill(myDataSet, "Customers");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connectionHandle.Close();
            }
            return myDataSet.Tables[0];
        }

        public DataTable getTable(string tableName) {
            DataSet myDataSet = new DataSet();
            try
            {

                OleDbCommand myAccessCommand = new OleDbCommand(tableName, connectionHandle);
                myAccessCommand.CommandType = CommandType.TableDirect;
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                connectionHandle.Open();
                myDataAdapter.Fill(myDataSet, "Customers");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
            }
            finally
            {
                connectionHandle.Close();
            }

            // A dataset can contain multiple tables, so let's get the first one
            return myDataSet.Tables[0];
        }

        public DataTable getStock(int[] customerIDs, int[] supplierIDs, int[] elementIDs) {

            bool firstStatementFlag = true;
            string customerPattern = "";
            string supplierPattern = "";
            string elementPattern = "";
            
            //if the parameter is not empty, add it to the query
            if (!(customerIDs.Length == 0))
            {
                customerPattern = "WHERE Customer.ID IN (" + String.Join(",", customerIDs) + ")";
                firstStatementFlag = false;
            }
            if (!(supplierIDs.Length == 0)) {
                if (firstStatementFlag)
                {
                    supplierPattern = "WHERE Supplier.ID IN (" + String.Join(",", supplierIDs) + ")";
                }
                else
                {
                    supplierPattern = "AND Supplier.ID IN (" + String.Join(",", supplierIDs) + ")";
                }
            }
            if (!(elementIDs.Length == 0))
            {
                if (firstStatementFlag)
                {
                    customerPattern = "WHERE Element.ID IN (" + String.Join(",", elementIDs) + ")";
                }
                else
                {
                    elementPattern = "AND Element.ID IN (" + String.Join(",", elementIDs) + ")";
                }
            }

            //sorry for the german words in the query
                string queryString = String.Format(@"
            SELECT Stock.ID, Customer.companyName AS Kunde, Supplier.companyName AS Lieferwerk, Element.elementName AS Element, Stock.amount AS Bestand
            FROM Supplier 
            INNER JOIN (Element INNER JOIN (Customer INNER JOIN Stock ON Customer.ID = Stock.customerID) ON Element.ID = Stock.elementID) ON Supplier.ID = Stock.supplierID
            {0}
            {1}
            {2}
            ;", customerPattern, supplierPattern, elementPattern);
            Console.WriteLine(queryString);
            return query(queryString);
        }

        private DataTable query(string queryString) {
            DataSet dataSet = new DataSet();
            try
            {

                OleDbCommand command = new OleDbCommand(queryString, connectionHandle);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);

                connectionHandle.Open();
                dataAdapter.Fill(dataSet, "result");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
            }
            finally
            {
                connectionHandle.Close();
            }

            // A dataset can contain multiple tables, so let's get the first one
            return dataSet.Tables[0];
        }

    }
}
