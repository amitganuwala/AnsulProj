using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Teacher_tchatt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["totalschoolConnectionString"].ConnectionString;
        SqlConnection objcon = new SqlConnection(conn);
        objcon.Open();
        SqlCommand objcmd = new SqlCommand("spsearch", objcon);
        objcmd.CommandType = CommandType.StoredProcedure;

        if (txtname.Text.Trim() != "")
        {
            SqlParameter param = new SqlParameter("@name", txtname.Text);
            objcmd.Parameters.Add(param);
        }else if (txtday.Text.Trim() != "")
        {
            SqlParameter param = new SqlParameter("@day", txtday.Text);
            objcmd.Parameters.Add(param);
        }

       
        SqlDataReader rdr = objcmd.ExecuteReader();
        grdvw.DataSource = rdr;
        grdvw.DataBind();
    }
}