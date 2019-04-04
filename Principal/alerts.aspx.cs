using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Principal_alerts : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();

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

            string sql = "select * from principal where usr = '" + userId + "'";
            dss = glb.GetDataSet(sql);

            if(!IsPostBack)
            {

            }

            if (dss.Tables[0].Rows.Count == 1)
            {
                // lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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

            if (!IsPostBack)
            {
                fillGridView1(lblsch.Text);

            }
        }
    }

    public void fillGridView1(string school_nm)
    {
        string sql = "SELECT * FROM[alert] WHERE([school] = '"+school_nm+"') ORDER BY[id] DESC";
        dss1 = glb.GetDataSet(sql);
        GridView1.DataSource = dss1;
        GridView1.DataBind();
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-alerts.aspx");
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGridView1(lblsch.Text);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        HttpCookie myCookiepr = Request.Cookies["myCookiepr"];
        string userId = myCookiepr["prnm"];


        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;
        string tname = row.Cells[2].Text;
        string msg = row.Cells[3].Text;
        string school = row.Cells[4].Text;
        string date = row.Cells[5].Text;


        // Label lbldeleteid = (Label)row.FindControl("lblID");
        conn.Open();
        string sql = "DELETE FROM [alert] WHERE [id] = '"+id+"' AND [tname] = '"+tname+"' AND [msg] = '"+msg+"' AND [school] = '"+school+"' AND [date] = '"+date+"'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        // gvbind();
        fillGridView1(lblsch.Text);

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillGridView1(lblsch.Text);

    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;

        string tname = e.NewValues["tname"].ToString();
        string msg = e.NewValues["msg"].ToString();
        string school = e.NewValues["school"].ToString();
        string date = e.NewValues["date"].ToString();

        GridView1.EditIndex = -1;

        conn.Open();

        string sql = "UPDATE [alert] SET [tname] = '"+tname+"', [msg] = '"+msg+"', [school] = '"+school+"', [date] = '"+date+"' WHERE [id] = '"+id+"' ";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        fillGridView1(lblsch.Text);
    }
}