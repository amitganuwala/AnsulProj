using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal_addsubject : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();

    ClsGlobal glb = new ClsGlobal();
    SqlConnection conn = new SqlConnection(ClsVariable.ConnectionString);
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        Sessioninfo();
        // displaypic();
    }
    public void Sessioninfo()
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];


        if (myCookiepr != null)
        {

            string userId = myCookiepr["prnm"];

            //Select sels = new Select();
            //dss = sels.selectprinci(userId);

            string sql = "select * from principal where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);

            if (dss.Tables[0].Rows.Count == 1)
            {
                // lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
                lblsch.Text = dss.Tables[0].Rows[0]["school"].ToString();
            }
            else
            {
                string message1 = "Login Session Expired....Please Login again.";
                string script = "window.onload = function(){ alert('";
                script += message1;
                script += "');";
                script += "window.location = '";
                script += Request.Url.AbsoluteUri;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

                Response.Redirect("../Principallogin.aspx");
            }

            if(!IsPostBack)
            {
                fillGridView1(lblsch.Text);

            }
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spsub", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@snm";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = txtsnm.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmaicat = new SqlParameter();
        objmaicat.ParameterName = "@school";
        objmaicat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaicat.Value = lblsch.Text;
        objcom.Parameters.Add(objmaicat);

        string message1 = " Subject Added Successfully...! ";
        string script = "window.onload = function(){ alert('";
        script += message1;
        script += "');";
        script += "window.location = '";
        script += Request.Url.AbsoluteUri;
        script += "'; }";
        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

        objcom.ExecuteNonQuery();
        // Response.Write("Created Successfully");
        objcon.Close();

    }

    public void fillGridView1(string school_nm)
    {
        string sql = "SELECT * FROM [subject-info] WHERE ([school] = '"+school_nm+"') ORDER BY [id] DESC";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }


    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;

        string snm = (String)e.NewValues["snm"];
        string school = (String)e.NewValues["school"];
        GridView1.EditIndex = -1;

        conn.Open();
        string sql = "UPDATE [subject-info] SET [snm] = '"+snm+"', [school] = '"+school+"' WHERE [id] = '"+id+"' AND (([school] = '"+lblsch.Text+"') OR ([school] IS NULL AND '"+lblsch.Text+"' IS NULL))";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        fillGridView1(lblsch.Text);
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillGridView1(lblsch.Text);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;
        string snm = row.Cells[2].Text;
        string school = row.Cells[3].Text;



        // Label lbldeleteid = (Label)row.FindControl("lblID");
        conn.Open();
        string sql = "DELETE FROM [subject-info] WHERE [id] = '" + id+"' AND (([school] = '"+school+"') OR ([school] IS NULL AND '"+school+"' IS NULL))";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        // gvbind();
        fillGridView1(school);
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGridView1(lblsch.Text);
    }
}