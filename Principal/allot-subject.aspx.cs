using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HOD_subject : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();
    DataSet dss3 = new DataSet();
    DataSet dss4 = new DataSet();


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
                string sql1 = "select name from teacher where school = '" + dss.Tables[0].Rows[0]["school"].ToString() + "'";
                dss1 = glb.GetDataSet(sql1);
                DropDownList1.DataSource = dss1.Tables[0];
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "name";
                DropDownList1.DataBind();


                string sql2 = "select class from classsection where school = '" + dss.Tables[0].Rows[0]["school"].ToString() + "'ORDER BY id DESC";
                dss2 = glb.GetDataSet(sql2);
                DropDownList2.DataSource = dss2.Tables[0];
                DropDownList2.DataTextField = "class";
                DropDownList2.DataValueField = "class";
                DropDownList2.DataBind();



                string sql3 = "select snm from [subject-info] where school = '" + dss.Tables[0].Rows[0]["school"].ToString() + "'";
                dss3 = glb.GetDataSet(sql3);
                DropDownList3.DataSource = dss3.Tables[0];
                DropDownList3.DataTextField = "snm";
                DropDownList3.DataValueField = "snm";
                DropDownList3.DataBind();

                fillGridView1(dss.Tables[0].Rows[0]["school"].ToString());


            }





            if (dss.Tables[0].Rows.Count == 1)
            {
                //lblprinm.Text = dss.Tables[0].Rows[0]["namr"].ToString();
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
        }
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spsubject", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@name";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@class";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = DropDownList2.SelectedValue;
        objcom.Parameters.Add(objname);

        SqlParameter objnamew = new SqlParameter();
        objnamew.ParameterName = "@subject";
        objnamew.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnamew.Value = DropDownList3.SelectedValue;
        objcom.Parameters.Add(objnamew);

      //  string a = "school";
        SqlParameter objincat = new SqlParameter();
        objincat.ParameterName = "@school";
        objincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objincat.Value = lblsch.Text;
        objcom.Parameters.Add(objincat);

        string message1 = " Subject Alloted Successfully...! ";
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

        fillGridView1(lblsch.Text);

    }

    public void fillGridView1(string school_nm)
    {
        string sql = "SELECT * FROM [subject] WHERE ([school] = '"+school_nm+"') ORDER BY [class] DESC";
        dss4 = glb.GetDataSet(sql);
        GridView1.DataSource = dss4;
        GridView1.DataBind();
    }

    
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;
        string name = row.Cells[2].Text;
        string classs = row.Cells[3].Text;
        string subject = row.Cells[4].Text;
        string school = row.Cells[5].Text;



        // Label lbldeleteid = (Label)row.FindControl("lblID");
        conn.Open();
        string sql = "DELETE FROM [subject] WHERE [id] = '"+id+"' AND [name] = '"+name+"' AND [class] = '"+classs+"' AND [subject] = '"+subject+"' AND [school] = '"+school+"'";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        // gvbind();
        fillGridView1(school);
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited.  
        GridView1.EditIndex = e.NewEditIndex;
        fillGridView1(lblsch.Text);
    }





    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        string id = row.Cells[1].Text;
        //string name = row.Cells[2].Text;
        //string classs = row.Cells[3].Text;
        //string subject = row.Cells[4].Text;
        //string school = row.Cells[5].Text;

        string txtName = (String)e.NewValues["name"];
        string txtclasss = (String)e.NewValues["class"];
        string txtsubject = (String)e.NewValues["subject"];
        string txtschool = (String)e.NewValues["school"];
        GridView1.EditIndex = -1;

        conn.Open();
        string sql = "UPDATE [subject] SET [name] = '"+ txtName + "', [class] = '"+ txtclasss + "', [subject] = '"+ txtsubject + "', [school] = '"+ txtschool + "' WHERE [id] = '" + id + "' ";
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        fillGridView1(lblsch.Text);
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillGridView1(lblsch.Text);
    }
}