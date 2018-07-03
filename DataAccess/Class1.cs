using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccess
{
    public class ClsSqlConnection
    {
        public DataSet getCustomers()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["dbConn"].ToString();
            SqlConnection objConn = new SqlConnection(ConnectionString);
            objConn.Open();

            SqlCommand objComm = new SqlCommand("Select * from cTable", objConn);
            DataSet objDS = new DataSet();
            SqlDataAdapter objDA = new SqlDataAdapter(objComm);

            objDA.Fill(objDS);
            objConn.Close();
            return objDS;

            
        }
        public DataSet getCustomers(string CustomerCode)
        {
            string objConnString = ConfigurationManager.ConnectionStrings["dbConn"].ToString();
            SqlConnection objConn = new SqlConnection(objConnString);
            objConn.Open();

            SqlCommand objComm = new SqlCommand("select * from cTable where Cust_Name='" + CustomerCode + "'", objConn);
            DataSet objDataSet = new DataSet();

            SqlDataAdapter objAdapter = new SqlDataAdapter(objComm);
            objAdapter.Fill(objDataSet);

            objConn.Close();

            return objDataSet;
        }

        public bool insertCustomers(string Cname,string Ccountry,string sex, string hobby,string status)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["dbConn"].ToString();
            SqlConnection objConn = new SqlConnection(ConnectionString);
            objConn.Open();
            try {

                string str = "insert into cTable values('" + Cname + "', '"
                    + Ccountry + "','"
                    + sex + "', '"
                    + hobby + "', "
                    + status + ")";
                SqlCommand comm = new SqlCommand(str, objConn);
                comm.ExecuteNonQuery();

                return true;
            }catch(Exception ex)
            {
                                return false;

            }
            finally
            {
                objConn.Close();
            }
        }

        public bool updateCustomer(string Cname, string Ccountry, string sex, string hobby, string status)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["dbConn"].ToString();
            SqlConnection objConn = new SqlConnection(ConnectionString);
            objConn.Open();
            try {
                string str = "update cTable set Cust_Name= '" + Cname + "',Cust_Country= '"
                    + Ccountry + "', Gender='"
                    + sex + "',Hobby= '"
                    + hobby + "', Status="
                    + status + " where Cust_Name='" + Cname + "'";
                SqlCommand comm = new SqlCommand(str, objConn);
                comm.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
            finally
            {
                objConn.Close();
            }
            
        }

        public bool deleteCustomer(string Cname)
        {
            string objConnString = ConfigurationManager.ConnectionStrings["dbConn"].ToString();
            SqlConnection objConn = new SqlConnection(objConnString);
            objConn.Open();
            try
            {
                SqlCommand objComm = new SqlCommand("delete from cTable where Cust_Name='" + Cname + "'", objConn);
                objComm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                objConn.Close();
            }
        }
    }
}
