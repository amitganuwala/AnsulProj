using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

/// <summary>
/// Summary description for ClsGlobal
/// </summary>
public class ClsGlobal
{
    
         public static string ReportType;
    public static string reportSql;

    #region Class Level Variable
    public static SqlConnection con;
    public static SqlCommand cmd;
    public static SqlDataAdapter da;
    #endregion

    #region OpenConnection Function
    public void OpenConnection()
    {
        if (con == null)
        {
            con = new SqlConnection(ClsVariable.ConnectionString);

        }
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        cmd = new SqlCommand();
        cmd.Connection = con;
    }
    #endregion

    #region CloseConnection Function
    public void CloseConnection()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }
    #endregion

    #region DisposeConnection Function
    public static void DisposeConnection()
    {
        if (con != null)
        {
            con.Dispose();
            con = null;
        }
    }
    #endregion

    #region ExecuteSql Method
    //public int ExecuteSql(string strsql)
    public int ExecuteSql(string strsql)
    {
        OpenConnection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strsql;
        int intresult;
        intresult = cmd.ExecuteNonQuery();
        CloseConnection();
        DisposeConnection();
        return intresult;
    }
    #endregion

    #region GetDataTable Method

    public DataTable GetDataTable(string strsql)
    {
        OpenConnection();
        da = new SqlDataAdapter(strsql, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        da.Dispose();
        CloseConnection();
        DisposeConnection();
        return dt;
    }
    #endregion

    #region GetDataSet Method

    public DataSet GetDataSet(string strsql)
    {
        OpenConnection();
        da = new SqlDataAdapter(strsql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        da.Dispose();
        CloseConnection();
        DisposeConnection();
        return ds;
    }
    #endregion

    #region GetDataReader Method

    public SqlDataReader GetDataReader(string strsql)
    {
        OpenConnection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strsql;
        SqlDataReader dr;
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;
    }
    #endregion

    #region IsExist Method

    public Boolean IsExist(string strsql)
    {
        OpenConnection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strsql;
        int intresult;
        intresult = (int)cmd.ExecuteScalar();
        CloseConnection();
        DisposeConnection();

        if (intresult > 0)
        {
            return true;
        }
        else
        {
            return false;

        }

    }
    #endregion

    #region ExecuteScalardata Function
    public int ExecuteScalardata(string strsql)
    {
        OpenConnection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strsql;
        int strresult;
        strresult = Convert.ToInt32(cmd.ExecuteScalar());
        CloseConnection();
        DisposeConnection();
        return strresult;
    }
    #endregion

    #region ExecuteScalar Function
    public string ExecuteScalar(string strsql)
    {
        OpenConnection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = strsql;
        string strresult;
        strresult = Convert.ToString(cmd.ExecuteScalar());
        CloseConnection();
        DisposeConnection();
        return strresult;
    }
    #endregion

    #region Change Date
    public void Chdate()
    {
        RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);

        //Set value for short Date Format HardCode
        rkey.SetValue("sShortDate", "dd/MM/yyyy");
        // Set value for Long Date Format HardCode
        rkey.SetValue("sLongDate", "dd/MM/yyyy");
    }
    #endregion

    public static int DayInMon;
    public static int MonPrint;
    public static int YearPrint;
    public static string frmdt;
    public static string todt;

    //Decleration
    public static string Left(string param, int length)
    {
        string result = param.Substring(0, length);
        //return the result of the operation
        return result;
    }

    public static string Right(string param, int length)
    {
        //string result = param.Substring(param.Length - length, length);
        ////return the result of the operation
        //return result;
        string result = param.Substring(param.Length - length, length);
        //return the result of the operation
        return result;
    }


   

    public DataSet collect(string str)
    {
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds = new DataSet();
        OpenConnection();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = str;
        adp.SelectCommand = cmd;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        adp.Fill(ds);
        CloseConnection();
        DisposeConnection();
        return ds;
    }
    public int getSrNo(String str)
    {

        try
        {
            OpenConnection();
            cmd = new SqlCommand(str, con);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            return r;
        }
        catch (Exception err)
        {
            return 1;
        }
        finally
        {
            CloseConnection();
        }
    }

}
