using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;     //provides access to appConfig
using System.Data;              //provides items like dataset
using System.Data.SqlClient;    //provides items like sqlcx

/*
 * This class is used to retrieve/record data in the Payroll database tables.  Stored procedures in the database
 * are used, by way of the XML connection string in the App.config file, to make database calls.  Parameterized
 * queries are used, with inputs, outputs, and return values.  The use of SQL Connections, Commands, and DataAdapters is 
 * demonstrated.
 */


namespace GopherPayroll
{    
    class clsDatabase
    {
        //private method to connect specifically to the "Payroll" database
        private static SqlConnection TryPayrollConnection()
        {
            return TryInputConnection("Payroll");
        }

        //public method to return a connection to a database with the connection string in App.config
        public static SqlConnection TryInputConnection(String strDBConnect)
        {
            SqlConnection cnSQL=null;
            bool blnIsError = false;

            //check for zero-length passed string and null value in App.config,             
            //instantiate the connection and set it to the appconfig command
            if (strDBConnect.Trim().Length < 1)
            {
                blnIsError = true;
            }           
            else if(ConfigurationManager.ConnectionStrings[strDBConnect]==null)
            {
                blnIsError = true;
            }
            else
            {                
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings[strDBConnect].ToString();

                try
                {
                    //open connection to the database
                    cnSQL.Open();
                }
                catch(Exception e)
                {
                    blnIsError = true;

                    //close connection to database
                    cnSQL.Close();
                    
                    //release connection resources
                    cnSQL.Dispose();
                }
            }

            if (blnIsError)
            {
                return null;
            }
            else
            {
                return cnSQL;  //return connection
            }            
        }

        //retrieves an employee's information from several tables in the database.
        //used in the PayrollReviewForm to fill the data grid.
        public static DataSet getEmpPayrollDBDataSet(int intEmpID)
        {
            //set up local connection, command, data adapter, and data set
            SqlConnection conSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            bool blnIsError = false;

            conSQL = TryPayrollConnection();
            if (conSQL == null)
            {
                blnIsError = true;
            }
            else
            {
                //set SqlCommand() object connection, type, text, and parameters
                cmdSQL = new SqlCommand();
                
                cmdSQL.Connection = conSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetPayrollByEmployee";//name of stored procedure

                //set input parameter             
                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;//input to db
                cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                //set return value of database                 
                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                //set data adapter to the sql command and try to fill the dataset                 
                try
                {
                    dsSQL = new DataSet();
                    daSQL = new SqlDataAdapter(cmdSQL);

                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception e)
                {
                    blnIsError = true;

                    //discpose ds if not filled
                    if (dsSQL != null)
                        dsSQL.Dispose();
                }
                finally
                {
                    conSQL.Close();
                    conSQL.Dispose();
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                }
            }

            //choose return value
            if (blnIsError)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //retrieves all employees' information from employee table in Payroll database.  Used in the 
        //PayrollReviewForm to complete the text box display on the top of the form.
        public static DataSet getEmployeeDBDataSet()
        {
            //set up local connection, command, data adapter, data set, and error flag
            SqlConnection conSQL;            
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            bool blnIsError = false;

            conSQL = TryPayrollConnection();
            if (conSQL == null)
            {
                blnIsError = true;
            }
            else
            {
                //set SqlCommand() object connection, type, text, and parameters
                cmdSQL = new SqlCommand();
                
                cmdSQL.Connection = conSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetAllEmployees";//name of stored procedure
                
                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                //set data adapter to the sql command and try to fill the dataset                 
                try
                {
                    dsSQL = new DataSet();
                    daSQL = new SqlDataAdapter(cmdSQL);                    
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch(Exception e)
                {
                    blnIsError = true;
                    
                    //discpose ds if not filled
                    if(dsSQL!=null)
                        dsSQL.Dispose();
                }
                finally
                {
                    conSQL.Close();
                    conSQL.Dispose();
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();                    
                }        
            }

            //choose return value
            if (blnIsError)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //retrieves full employee names from the Employees table in the Payroll database
        public static DataSet LoadEmployeeNames()
        {
            //set up local cconnection, command, data adapter, data set, and error flag
            SqlConnection conSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            bool blnIsError = false;

            conSQL = TryPayrollConnection();
            if (conSQL == null)
            {
                blnIsError = true;
            }
            else
            {
                //set SqlCommand() object connection, type, text, and parameters
                cmdSQL = new SqlCommand();
                
                cmdSQL.Connection = conSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetEmployeeNames";//name of stored procedure
                
                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                //set data adapter to the sql command and try to fill the dataset                 
                try
                {
                    dsSQL = new DataSet();
                    daSQL = new SqlDataAdapter(cmdSQL);                    
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception e)
                {
                    blnIsError = true;

                    //discpose ds if not filled
                    if (dsSQL != null)
                        dsSQL.Dispose();
                }
                finally
                {
                    conSQL.Close();
                    conSQL.Dispose();
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                }
            }

            //choose return value
            if (blnIsError)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //returns payrate based on employee id input, used in AddPayrollRecordsForm to display pay rate and calculate weekly pay
        //success = return employee id, else return -1
        public static Decimal GetEmployeePayrate(int EmpId)
        {
            //set up local connection, command, pay rate, and error-checking variables
            SqlConnection conSQL;
            SqlCommand cmdSQL;
            Decimal decPayRate = 0;                        
            bool blnIsError = false;
            
            //validate passed employee id and connection, run query, and test query result
            if (EmpId < 0)
            {
                blnIsError = true;
            }
            else
            {
                conSQL = TryPayrollConnection();
                if (conSQL == null)
                {
                    blnIsError = true;
                }
                else
                {
                    //set SqlCommand() object connection, type, text, and parameters
                    cmdSQL = new SqlCommand();
                    
                    cmdSQL.Connection = conSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "GetPayRateByID";//name of stored procedure
                    
                    cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                    cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@EmpID"].Value = EmpId;


                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                    cmdSQL.Parameters.Add(new SqlParameter("@PayRate", SqlDbType.SmallMoney));
                    cmdSQL.Parameters["@PayRate"].Direction = ParameterDirection.Output;

                    //set data adapter to the sql command and try to execute the query                
                    try
                    {                        
                        cmdSQL.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        blnIsError = true;
                    }
                    finally
                    {                        
                        conSQL.Close();
                        conSQL.Dispose();
                    }                    

                    //test for error with output value from query
                    if (!blnIsError)
                    {
                        if (cmdSQL.Parameters["@PayRate"].Value == DBNull.Value)
                        {
                            blnIsError = true;
                        }
                        else
                        {
                            decPayRate = Convert.ToDecimal(cmdSQL.Parameters["@PayRate"].Value);
                        }
                    }
                }
            }
            
            //choose return value
            if (blnIsError)
            {
                return -1.0M;
            }
            else
            {
                return decPayRate;
            }

        }

        //attempts to insert a single record into the Payroll table via stored procedure, returns a 1 if added a line (else 0), 
        //and is called from the AddPayrollRecordsForm        
        public static int InsertPayroll(int EmpId, String WeekEnding, decimal HoursWorked)
        {
            //set up local connection, command, flag for line added, and error-checking variables
            SqlConnection conSQL;
            SqlCommand cmdSQL;
            Int32 intLineAdded = 0;
            bool blnIsError = false;
            
            //validate passed parameters and connection, create sql command, run query, test query results, and
            //return 1 if line added
            if (EmpId < 0 || String.IsNullOrEmpty(WeekEnding) || HoursWorked<0)
            {
                blnIsError = true;
            }
            else
            {
                conSQL = TryPayrollConnection();

                if (conSQL == null)
                {
                    blnIsError = true;
                }
                else
                {
                    //set SqlCommand() object connection, type, text, and parameters
                    cmdSQL = new SqlCommand();
                    
                    cmdSQL.Connection = conSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "InsertPayroll";//name of stored procedure
                    
                    cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                    cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@EmpID"].Value = EmpId;

                    cmdSQL.Parameters.Add(new SqlParameter("@WeekEnding", SqlDbType.NChar));
                    cmdSQL.Parameters["@WeekEnding"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@WeekEnding"].Value = WeekEnding;

                    cmdSQL.Parameters.Add(new SqlParameter("@HoursWorked", SqlDbType.Decimal));
                    cmdSQL.Parameters["@HoursWorked"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@HoursWorked"].Value = HoursWorked;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                    //set data adapter to the sql command and try to execute the query                
                    try
                    {
                        if (cmdSQL.ExecuteNonQuery()==1)
                            intLineAdded++;                        
                    }
                    catch (Exception ex)
                    {
                        blnIsError = true;
                    }
                    finally
                    {                        
                        conSQL.Close();
                        conSQL.Dispose();
                    }                    
                }
            }

            //choose return value
            if (blnIsError)
            {
                return 0;
            }
            else
            {
                return intLineAdded;
            }

        }
    }
}
