using System;
using System.Collections.Generic;
using System.Text;
using Harrison.Inventory.Data.Model;
using System.Data;
using System.Data.SqlClient;
namespace Harrison.Inventory.Data.SqlClient
{
    public class FinancialYearsDAL : IFinancialYearsDAL
    {
        String Sql;
        DataTable dt = new DataTable();
        SqlDataAdapter da;

        public DataTable GetAllFinancialYears()
        { 
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from FIN_YEAR";
            da = Dbcon.Sqlconnection(Sql);
            da.Fill(dt);
            return (dt);
        }
        
        public string AddFinancialYears()
        { 
            DBConnection Dbcon = new DBConnection();
            Sql = "Insert into FIN_YEAR (FIN_YEAR_NAME) values(2019-2020)";
            da=Dbcon.Sqlconnection(Sql);
            da.InsertCommand = new SqlCommand(Sql);
            return ("Data Added");
        }
    }
}