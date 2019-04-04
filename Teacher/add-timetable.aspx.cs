
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_add_timetable : System.Web.UI.Page
{
    DataSet dss = new DataSet();
    DataSet dss1 = new DataSet();
    DataSet dss2 = new DataSet();
    DataSet dss3 = new DataSet();
    DataSet dss4 = new DataSet();
    DataSet dss5 = new DataSet();
    DataSet dss6 = new DataSet();
    DataSet dss7 = new DataSet();
    DataSet dss8 = new DataSet();
    DataSet dss9 = new DataSet();
    DataSet dss10 = new DataSet();
    DataSet dss11 = new DataSet();
    DataSet dss12 = new DataSet();
    DataSet dss13 = new DataSet();
    DataSet dss14 = new DataSet();
    DataSet dss15 = new DataSet();

    ClsGlobal glb = new ClsGlobal();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Sessioninfo();
        ViewProfile();
        
    }
    public void Sessioninfo()
    {

        HttpCookie myCookiet = Request.Cookies["myCookiet"];


        if (myCookiet != null)
        {

            string userId = myCookiet["tnm"];

            string sql = "select * from teacher where usr='" + userId + "' ";
            dss = glb.GetDataSet(sql);



            if (dss.Tables[0].Rows.Count == 1)
            {
                lbltchnm.Text = dss.Tables[0].Rows[0]["name"].ToString();
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

                Response.Redirect("../locklogin.aspx");
            }

          if(!IsPostBack)
            {
                SetValues();
            }
        }
    }
    public void ViewProfile()
    {
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.selectimetbl(d1l1.SelectedValue,DropDownList1.SelectedValue,lblsch.Text);
        if (ds.Tables[0].Rows.Count == 1)
        {
            d1l1tch.Text = ds.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d1l1tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds1 = new DataSet();
        Select sel1 = new Select();
        ds1 = sel1.selectimetbl(d1l2.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds1.Tables[0].Rows.Count == 1)
        {
            d1l2tch.Text = ds1.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d1l2tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds2 = new DataSet();
        Select sel2 = new Select();
        ds2 = sel2.selectimetbl(d1l3.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds2.Tables[0].Rows.Count == 1)
        {
            d1l3tch.Text = ds2.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d1l3tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds3 = new DataSet();
        Select sel3 = new Select();
        ds3 = sel3.selectimetbl(d1l4.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds3.Tables[0].Rows.Count == 1)
        {
            d1l4tch.Text = ds3.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d1l4tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds4 = new DataSet();
        Select sel4 = new Select();
        ds4 = sel4.selectimetbl(d1l5.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds4.Tables[0].Rows.Count == 1)
        {
            d1l5tch.Text = ds4.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d1l5tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds5 = new DataSet();
        Select sel5 = new Select();
        ds5 = sel5.selectimetbl(d1l6.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds5.Tables[0].Rows.Count == 1)
        {
            d1l6tch.Text = ds5.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d1l6tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds6 = new DataSet();
        Select sel6 = new Select();
        ds6 = sel6.selectimetbl(d2l1.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds6.Tables[0].Rows.Count == 1)
        {
            d2l1tch.Text = ds6.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d2l1tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds7 = new DataSet();
        Select sel7 = new Select();
        ds7 = sel7.selectimetbl(d2l2.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds7.Tables[0].Rows.Count == 1)
        {
            d2l2tch.Text = ds7.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d2l2tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds8 = new DataSet();
        Select sel8 = new Select();
        ds8 = sel8.selectimetbl(d2l3.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds8.Tables[0].Rows.Count == 1)
        {
            d2l3tch.Text = ds8.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d2l3tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds9 = new DataSet();
        Select sel9 = new Select();
        ds9 = sel9.selectimetbl(d2l4.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds9.Tables[0].Rows.Count == 1)
        {
            d2l4tch.Text = ds9.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d2l4tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds10 = new DataSet();
        Select sel10 = new Select();
        ds10 = sel10.selectimetbl(d2l5.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds10.Tables[0].Rows.Count == 1)
        {
            d2l5tch.Text = ds10.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d2l5tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds11 = new DataSet();
        Select sel11 = new Select();
        ds11 = sel11.selectimetbl(d2l6.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds11.Tables[0].Rows.Count == 1)
        {
            d2l6tch.Text = ds11.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d2l6tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds12 = new DataSet();
        Select sel12 = new Select();
        ds12 = sel12.selectimetbl(d3l1.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds12.Tables[0].Rows.Count == 1)
        {
            d3l1tch.Text = ds12.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d3l1tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds13 = new DataSet();
        Select sel13 = new Select();
        ds13 = sel13.selectimetbl(d3l2.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds13.Tables[0].Rows.Count == 1)
        {
            d3l2tch.Text = ds13.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d3l2tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds14 = new DataSet();
        Select sel14 = new Select();
        ds14 = sel14.selectimetbl(d3l3.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds14.Tables[0].Rows.Count == 1)
        {
            d3l3tch.Text = ds14.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d3l3tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds15 = new DataSet();
        Select sel15 = new Select();
        ds15 = sel15.selectimetbl(d3l4.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds15.Tables[0].Rows.Count == 1)
        {
            d3l4tch.Text = ds15.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d3l4tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds16 = new DataSet();
        Select sel16 = new Select();
        ds16 = sel16.selectimetbl(d3l5.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds16.Tables[0].Rows.Count == 1)
        {
            d3l5tch.Text = ds16.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d3l5tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds17 = new DataSet();
        Select sel17 = new Select();
        ds17 = sel17.selectimetbl(d3l6.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds17.Tables[0].Rows.Count == 1)
        {
            d3l6tch.Text = ds17.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d3l6tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds18 = new DataSet();
        Select sel18 = new Select();
        ds18 = sel18.selectimetbl(d4l1.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds18.Tables[0].Rows.Count == 1)
        {
            d4l1tch.Text = ds18.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d4l1tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds19 = new DataSet();
        Select sel19 = new Select();
        ds19 = sel19.selectimetbl(d4l2.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds19.Tables[0].Rows.Count == 1)
        {
            d4l2tch.Text = ds19.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d4l2tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds20 = new DataSet();
        Select sel20 = new Select();
        ds20 = sel20.selectimetbl(d4l3.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds20.Tables[0].Rows.Count == 1)
        {
            d4l3tch.Text = ds20.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d4l3tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds21 = new DataSet();
        Select sel21 = new Select();
        ds21 = sel21.selectimetbl(d4l4.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds21.Tables[0].Rows.Count == 1)
        {
            d4l4tch.Text = ds21.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d4l4tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds22 = new DataSet();
        Select sel22 = new Select();
        ds22 = sel22.selectimetbl(d4l5.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds22.Tables[0].Rows.Count == 1)
        {
            d4l5tch.Text = ds22.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d4l5tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds23 = new DataSet();
        Select sel23 = new Select();
        ds23 = sel23.selectimetbl(d4l6.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds23.Tables[0].Rows.Count == 1)
        {
            d4l6tch.Text = ds23.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d4l6tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds24 = new DataSet();
        Select sel24 = new Select();
        ds24 = sel24.selectimetbl(d5l1.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds24.Tables[0].Rows.Count == 1)
        {
            d5l1tch.Text = ds24.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d5l1tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds25 = new DataSet();
        Select sel25 = new Select();
        ds25 = sel25.selectimetbl(d5l2.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds25.Tables[0].Rows.Count == 1)
        {
            d5l2tch.Text = ds25.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d5l2tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds26 = new DataSet();
        Select sel26 = new Select();
        ds26 = sel26.selectimetbl(d5l3.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds26.Tables[0].Rows.Count == 1)
        {
            d5l3tch.Text = ds26.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d5l3tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds27 = new DataSet();
        Select sel27 = new Select();
        ds27 = sel27.selectimetbl(d5l4.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds27.Tables[0].Rows.Count == 1)
        {
            d5l4tch.Text = ds27.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d5l4tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds28 = new DataSet();
        Select sel28 = new Select();
        ds28 = sel28.selectimetbl(d5l5.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds28.Tables[0].Rows.Count == 1)
        {
            d5l5tch.Text = ds28.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d5l5tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds29 = new DataSet();
        Select sel29 = new Select();
        ds29 = sel29.selectimetbl(d5l6.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds29.Tables[0].Rows.Count == 1)
        {
            d5l6tch.Text = ds29.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d5l6tch.Text = "No teacher alloted to this subject";

        }

        DataSet ds30 = new DataSet();
        Select sel30= new Select();
        ds30 = sel30.selectimetbl(d6l1.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds30.Tables[0].Rows.Count == 1)
        {
            d6l1tch.Text = ds30.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d6l1tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds31 = new DataSet();
        Select sel31 = new Select();
        ds31 = sel31.selectimetbl(d6l2.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds31.Tables[0].Rows.Count == 1)
        {
            d6l2tch.Text = ds31.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d6l2tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds32 = new DataSet();
        Select sel32 = new Select();
        ds32 = sel32.selectimetbl(d6l3.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds32.Tables[0].Rows.Count == 1)
        {
            d6l3tch.Text = ds32.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d6l3tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds33 = new DataSet();
        Select sel33 = new Select();
        ds33 = sel33.selectimetbl(d6l4.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds33.Tables[0].Rows.Count == 1)
        {
            d6l4tch.Text = ds33.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d6l4tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds34 = new DataSet();
        Select sel34 = new Select();
        ds34 = sel34.selectimetbl(d6l5.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds34.Tables[0].Rows.Count == 1)
        {
            d6l5tch.Text = ds34.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d6l5tch.Text = "No teacher alloted to this subject";

        }
        DataSet ds35 = new DataSet();
        Select sel35 = new Select();
        ds35 = sel35.selectimetbl(d6l6.SelectedValue, DropDownList1.SelectedValue, lblsch.Text);
        if (ds35.Tables[0].Rows.Count == 1)
        {
            d6l6tch.Text = ds35.Tables[0].Rows[0]["name"].ToString();
        }
        else
        {
            d6l6tch.Text = "No teacher alloted to this subject";

        }


    }
    protected void btnadd_Click(object sender, EventArgs e)
    {


        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("sptimetable", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@title";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbltitle.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objmainca = new SqlParameter();
        objmainca.ParameterName = "@class";
        objmainca.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmainca.Value = DropDownList1.SelectedValue;
        objcom.Parameters.Add(objmainca);

        SqlParameter objmainct = new SqlParameter();
        objmainct.ParameterName = "@school";
        objmainct.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmainct.Value = lblsch.Text;
        objcom.Parameters.Add(objmainct);

        SqlParameter objmainc = new SqlParameter();
        objmainc.ParameterName = "@day1";
        objmainc.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmainc.Value = lblday1.Text;
        objcom.Parameters.Add(objmainc);

        SqlParameter objmainat = new SqlParameter();
        objmainat.ParameterName = "@day2";
        objmainat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmainat.Value = lblday2.Text;
        objcom.Parameters.Add(objmainat);

        SqlParameter objmaint = new SqlParameter();
        objmaint.ParameterName = "@day3";
        objmaint.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaint.Value = lblday3.Text;
        objcom.Parameters.Add(objmaint);

        SqlParameter objmaicat = new SqlParameter();
        objmaicat.ParameterName = "@day4";
        objmaicat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaicat.Value = lblday4.Text;
        objcom.Parameters.Add(objmaicat);

        SqlParameter objmait = new SqlParameter();
        objmait.ParameterName = "@day5";
        objmait.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmait.Value = lblday5.Text;
        objcom.Parameters.Add(objmait);

        SqlParameter objmancat = new SqlParameter();
        objmancat.ParameterName = "@day6";
        objmancat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmancat.Value = lblday6.Text;
        objcom.Parameters.Add(objmancat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@lec1";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = txttime1.Text;
        objcom.Parameters.Add(objname);

        SqlParameter objnme = new SqlParameter();
        objnme.ParameterName = "@lec2";
        objnme.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnme.Value = txttime2.Text;
        objcom.Parameters.Add(objnme);

        SqlParameter objnae = new SqlParameter();
        objnae.ParameterName = "@lec3";
        objnae.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnae.Value = txttime3.Text;
        objcom.Parameters.Add(objnae);

        SqlParameter objnam = new SqlParameter();
        objnam.ParameterName = "@lec4";
        objnam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnam.Value = txttime5.Text;
        objcom.Parameters.Add(objnam);

        SqlParameter objnsme = new SqlParameter();
        objnsme.ParameterName = "@lec5";
        objnsme.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnsme.Value = txttime6.Text;
        objcom.Parameters.Add(objnsme);

        SqlParameter objnsame = new SqlParameter();
        objnsame.ParameterName = "@lec6";
        objnsame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objnsame.Value = txttime7.Text;
        objcom.Parameters.Add(objnsame);

        SqlParameter objphotoname = new SqlParameter();
        objphotoname.ParameterName = "@d1l1";
        objphotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphotoname.Value = d1l1.SelectedValue;
        objcom.Parameters.Add(objphotoname);

        SqlParameter objhotoname = new SqlParameter();
        objhotoname.ParameterName = "@d1l2";
        objhotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objhotoname.Value = d1l2.SelectedValue;
        objcom.Parameters.Add(objhotoname);

        SqlParameter objpotoname = new SqlParameter();
        objpotoname.ParameterName = "@d1l3";
        objpotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpotoname.Value = d1l3.SelectedValue;
        objcom.Parameters.Add(objpotoname);

        SqlParameter objphtoname = new SqlParameter();
        objphtoname.ParameterName = "@d1l4";
        objphtoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphtoname.Value = d1l4.SelectedValue;
        objcom.Parameters.Add(objphtoname);

        SqlParameter objphooname = new SqlParameter();
        objphooname.ParameterName = "@d1l5";
        objphooname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphooname.Value = d1l5.SelectedValue;
        objcom.Parameters.Add(objphooname);

        SqlParameter objphotname = new SqlParameter();
        objphotname.ParameterName = "@d1l6";
        objphotname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphotname.Value = d1l6.SelectedValue;
        objcom.Parameters.Add(objphotname);

        SqlParameter ojphotoname = new SqlParameter();
        ojphotoname.ParameterName = "@d2l1";
        ojphotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        ojphotoname.Value = d2l1.SelectedValue;
        objcom.Parameters.Add(ojphotoname);

        SqlParameter objhotonam = new SqlParameter();
        objhotonam.ParameterName = "@d2l2";
        objhotonam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objhotonam.Value = d2l2.SelectedValue;
        objcom.Parameters.Add(objhotonam);

        SqlParameter objpotonae = new SqlParameter();
        objpotonae.ParameterName = "@d2l3";
        objpotonae.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpotonae.Value = d2l3.SelectedValue;
        objcom.Parameters.Add(objpotonae);

        SqlParameter objphtonme = new SqlParameter();
        objphtonme.ParameterName = "@d2l4";
        objphtonme.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphtonme.Value = d2l4.SelectedValue;
        objcom.Parameters.Add(objphtonme);

        SqlParameter objphooame = new SqlParameter();
        objphooame.ParameterName = "@d2l5";
        objphooame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphooame.Value = d2l5.SelectedValue;
        objcom.Parameters.Add(objphooame);

        SqlParameter objphotnam = new SqlParameter();
        objphotnam.ParameterName = "@d2l6";
        objphotnam.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphotnam.Value = d2l6.SelectedValue;
        objcom.Parameters.Add(objphotnam);

        SqlParameter obhotoname = new SqlParameter();
        obhotoname.ParameterName = "@d3l1";
        obhotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        obhotoname.Value = d3l1.SelectedValue;
        objcom.Parameters.Add(obhotoname);

        SqlParameter objhotona = new SqlParameter();
        objhotona.ParameterName = "@d3l2";
        objhotona.SqlDbType = System.Data.SqlDbType.NVarChar;
        objhotona.Value = d3l2.SelectedValue;
        objcom.Parameters.Add(objhotona);

        SqlParameter objptoname = new SqlParameter();
        objptoname.ParameterName = "@d3l3";
        objptoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objptoname.Value = d3l3.SelectedValue;
        objcom.Parameters.Add(objptoname);

        SqlParameter objphtoame = new SqlParameter();
        objphtoame.ParameterName = "@d3l4";
        objphtoame.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphtoame.Value = d3l4.SelectedValue;
        objcom.Parameters.Add(objphtoame);

        SqlParameter objphoonae = new SqlParameter();
        objphoonae.ParameterName = "@d3l5";
        objphoonae.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoonae.Value = d3l5.SelectedValue;
        objcom.Parameters.Add(objphoonae);

        SqlParameter objphoname = new SqlParameter();
        objphoname.ParameterName = "@d3l6";
        objphoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoname.Value = d3l6.SelectedValue;
        objcom.Parameters.Add(objphoname);

        SqlParameter bjphotoname = new SqlParameter();
        bjphotoname.ParameterName = "@d4l1";
        bjphotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphotoname.Value = d4l1.SelectedValue;
        objcom.Parameters.Add(bjphotoname);

        SqlParameter bjhotoname = new SqlParameter();
        bjhotoname.ParameterName = "@d4l2";
        bjhotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjhotoname.Value = d4l2.SelectedValue;
        objcom.Parameters.Add(bjhotoname);

        SqlParameter bjpotoname = new SqlParameter();
        bjpotoname.ParameterName = "@d4l3";
        bjpotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjpotoname.Value = d4l3.SelectedValue;
        objcom.Parameters.Add(bjpotoname);

        SqlParameter bjphtoname = new SqlParameter();
        bjphtoname.ParameterName = "@d4l4";
        bjphtoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphtoname.Value = d4l4.SelectedValue;
        objcom.Parameters.Add(bjphtoname);

        SqlParameter bjphooname = new SqlParameter();
        bjphooname.ParameterName = "@d4l5";
        bjphooname.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphooname.Value = d4l5.SelectedValue;
        objcom.Parameters.Add(bjphooname);

        SqlParameter bjphotname = new SqlParameter();
        bjphotname.ParameterName = "@d4l6";
        bjphotname.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphotname.Value = d4l6.SelectedValue;
        objcom.Parameters.Add(bjphotname);

        SqlParameter jphotoname = new SqlParameter();
        jphotoname.ParameterName = "@d5l1";
        jphotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphotoname.Value = d5l1.SelectedValue;
        objcom.Parameters.Add(jphotoname);

        SqlParameter jhotoname = new SqlParameter();
        jhotoname.ParameterName = "@d5l2";
        jhotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        jhotoname.Value = d5l2.SelectedValue;
        objcom.Parameters.Add(jhotoname);

        SqlParameter jpotoname = new SqlParameter();
        jpotoname.ParameterName = "@d5l3";
        jpotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        jpotoname.Value = d5l3.SelectedValue;
        objcom.Parameters.Add(jpotoname);

        SqlParameter jphtoname = new SqlParameter();
        jphtoname.ParameterName = "@d5l4";
        jphtoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphtoname.Value = d5l4.SelectedValue;
        objcom.Parameters.Add(jphtoname);

        SqlParameter jphooname = new SqlParameter();
        jphooname.ParameterName = "@d5l5";
        jphooname.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphooname.Value = d5l5.SelectedValue;
        objcom.Parameters.Add(jphooname);

        SqlParameter jphotname = new SqlParameter();
        jphotname.ParameterName = "@d5l6";
        jphotname.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphotname.Value = d5l6.SelectedValue;
        objcom.Parameters.Add(jphotname);

        SqlParameter photoname = new SqlParameter();
        photoname.ParameterName = "@d6l1";
        photoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        photoname.Value = d6l1.SelectedValue;
        objcom.Parameters.Add(photoname);

        SqlParameter hotoname = new SqlParameter();
        hotoname.ParameterName = "@d6l2";
        hotoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        hotoname.Value = d6l2.SelectedValue;
        objcom.Parameters.Add(hotoname);

        SqlParameter potoname = new SqlParameter();
        potoname.ParameterName = "@d6l3";
        potoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        potoname.Value = d6l3.SelectedValue;
        objcom.Parameters.Add(potoname);

        SqlParameter phtoname = new SqlParameter();
        phtoname.ParameterName = "@d6l4";
        phtoname.SqlDbType = System.Data.SqlDbType.NVarChar;
        phtoname.Value = d6l4.SelectedValue;
        objcom.Parameters.Add(phtoname);

        SqlParameter phooname = new SqlParameter();
        phooname.ParameterName = "@d6l5";
        phooname.SqlDbType = System.Data.SqlDbType.NVarChar;
        phooname.Value = d6l5.SelectedValue;
        objcom.Parameters.Add(phooname);

        SqlParameter photname = new SqlParameter();
        photname.ParameterName = "@d6l6";
        photname.SqlDbType = System.Data.SqlDbType.NVarChar;
        photname.Value = d6l6.SelectedValue;
        objcom.Parameters.Add(photname);

        SqlParameter objphotonametch = new SqlParameter();
        objphotonametch.ParameterName = "@d1l1tch";
        objphotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphotonametch.Value = d1l1tch.Text;
        objcom.Parameters.Add(objphotonametch);

        SqlParameter objhotonametch = new SqlParameter();
        objhotonametch.ParameterName = "@d1l2tch";
        objhotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objhotonametch.Value = d1l2tch.Text;
        objcom.Parameters.Add(objhotonametch);

        SqlParameter objpotonametch = new SqlParameter();
        objpotonametch.ParameterName = "@d1l3tch";
        objpotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpotonametch.Value = d1l3tch.Text;
        objcom.Parameters.Add(objpotonametch);

        SqlParameter objphtonametch = new SqlParameter();
        objphtonametch.ParameterName = "@d1l4tch";
        objphtonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphtonametch.Value = d1l4tch.Text;
        objcom.Parameters.Add(objphtonametch);

        SqlParameter objphoonametch = new SqlParameter();
        objphoonametch.ParameterName = "@d1l5tch";
        objphoonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoonametch.Value = d1l5tch.Text;
        objcom.Parameters.Add(objphoonametch);

        SqlParameter objphotnametch = new SqlParameter();
        objphotnametch.ParameterName = "@d1l6tch";
        objphotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphotnametch.Value = d1l6tch.Text;
        objcom.Parameters.Add(objphotnametch);

        SqlParameter ojphotonametch = new SqlParameter();
        ojphotonametch.ParameterName = "@d2l1tch";
        ojphotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        ojphotonametch.Value = d2l1tch.Text;
        objcom.Parameters.Add(ojphotonametch);

        SqlParameter objhotonamtch = new SqlParameter();
        objhotonamtch.ParameterName = "@d2l2tch";
        objhotonamtch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objhotonamtch.Value = d2l2tch.Text;
        objcom.Parameters.Add(objhotonamtch);

        SqlParameter objpotonaetch = new SqlParameter();
        objpotonaetch.ParameterName = "@d2l3tch";
        objpotonaetch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpotonaetch.Value = d2l3tch.Text;
        objcom.Parameters.Add(objpotonaetch);

        SqlParameter objphtonmetch = new SqlParameter();
        objphtonmetch.ParameterName = "@d2l4tch";
        objphtonmetch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphtonmetch.Value = d2l4tch.Text;
        objcom.Parameters.Add(objphtonmetch);

        SqlParameter objphooametch = new SqlParameter();
        objphooametch.ParameterName = "@d2l5tch";
        objphooametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphooametch.Value = d2l5tch.Text;
        objcom.Parameters.Add(objphooametch);

        SqlParameter objphotnamtch = new SqlParameter();
        objphotnamtch.ParameterName = "@d2l6tch";
        objphotnamtch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphotnamtch.Value = d2l6tch.Text;
        objcom.Parameters.Add(objphotnamtch);

        SqlParameter obhotonametch = new SqlParameter();
        obhotonametch.ParameterName = "@d3l1tch";
        obhotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        obhotonametch.Value = d3l1tch.Text;
        objcom.Parameters.Add(obhotonametch);

        SqlParameter objhotonatch = new SqlParameter();
        objhotonatch.ParameterName = "@d3l2tch";
        objhotonatch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objhotonatch.Value = d3l2tch.Text;
        objcom.Parameters.Add(objhotonatch);

        SqlParameter objptonametch = new SqlParameter();
        objptonametch.ParameterName = "@d3l3tch";
        objptonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objptonametch.Value = d3l3tch.Text;
        objcom.Parameters.Add(objptonametch);

        SqlParameter objphtoametch = new SqlParameter();
        objphtoametch.ParameterName = "@d3l4tch";
        objphtoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphtoametch.Value = d3l4tch.Text;
        objcom.Parameters.Add(objphtoametch);

        SqlParameter objphoonaetch = new SqlParameter();
        objphoonaetch.ParameterName = "@d3l5tch";
        objphoonaetch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoonaetch.Value = d3l5tch.Text;
        objcom.Parameters.Add(objphoonaetch);

        SqlParameter objphonametch = new SqlParameter();
        objphonametch.ParameterName = "@d3l6tch";
        objphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphonametch.Value = d3l6tch.Text;
        objcom.Parameters.Add(objphonametch);

        SqlParameter bjphotonametch = new SqlParameter();
        bjphotonametch.ParameterName = "@d4l1tch";
        bjphotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphotonametch.Value = d4l1tch.Text;
        objcom.Parameters.Add(bjphotonametch);

        SqlParameter bjhotonametch = new SqlParameter();
        bjhotonametch.ParameterName = "@d4l2tch";
        bjhotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjhotonametch.Value = d4l2tch.Text;
        objcom.Parameters.Add(bjhotonametch);

        SqlParameter bjpotonametch = new SqlParameter();
        bjpotonametch.ParameterName = "@d4l3tch";
        bjpotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjpotonametch.Value = d4l3tch.Text;
        objcom.Parameters.Add(bjpotonametch);

        SqlParameter bjphtonametch = new SqlParameter();
        bjphtonametch.ParameterName = "@d4l4tch";
        bjphtonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphtonametch.Value = d4l4tch.Text;
        objcom.Parameters.Add(bjphtonametch);

        SqlParameter bjphoonametch = new SqlParameter();
        bjphoonametch.ParameterName = "@d4l5tch";
        bjphoonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphoonametch.Value = d4l5tch.Text;
        objcom.Parameters.Add(bjphoonametch);

        SqlParameter bjphotnametch = new SqlParameter();
        bjphotnametch.ParameterName = "@d4l6tch";
        bjphotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bjphotnametch.Value = d4l6tch.Text;
        objcom.Parameters.Add(bjphotnametch);

        SqlParameter jphotonametch = new SqlParameter();
        jphotonametch.ParameterName = "@d5l1tch";
        jphotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphotonametch.Value = d5l1tch.Text;
        objcom.Parameters.Add(jphotonametch);

        SqlParameter jhotonametch = new SqlParameter();
        jhotonametch.ParameterName = "@d5l2tch";
        jhotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        jhotonametch.Value = d5l2tch.Text;
        objcom.Parameters.Add(jhotonametch);

        SqlParameter jpotonametch = new SqlParameter();
        jpotonametch.ParameterName = "@d5l3tch";
        jpotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        jpotonametch.Value = d5l3tch.Text;
        objcom.Parameters.Add(jpotonametch);

        SqlParameter jphtonametch = new SqlParameter();
        jphtonametch.ParameterName = "@d5l4tch";
        jphtonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphtonametch.Value = d5l4tch.Text;
        objcom.Parameters.Add(jphtonametch);

        SqlParameter jphoonametch = new SqlParameter();
        jphoonametch.ParameterName = "@d5l5tch";
        jphoonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphoonametch.Value = d5l5tch.Text;
        objcom.Parameters.Add(jphoonametch);

        SqlParameter jphotnametch = new SqlParameter();
        jphotnametch.ParameterName = "@d5l6tch";
        jphotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        jphotnametch.Value = d5l6tch.Text;
        objcom.Parameters.Add(jphotnametch);

        SqlParameter photonametch = new SqlParameter();
        photonametch.ParameterName = "@d6l1tch";
        photonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        photonametch.Value = d6l1tch.Text;
        objcom.Parameters.Add(photonametch);

        SqlParameter hotonametch = new SqlParameter();
        hotonametch.ParameterName = "@d6l2tch";
        hotonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        hotonametch.Value = d6l2tch.Text;
        objcom.Parameters.Add(hotonametch);

        SqlParameter potonametch = new SqlParameter();
        potonametch.ParameterName = "@d6l3tch";
        potonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        potonametch.Value = d6l3tch.Text;
        objcom.Parameters.Add(potonametch);

        SqlParameter phtonametch = new SqlParameter();
        phtonametch.ParameterName = "@d6l4tch";
        phtonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        phtonametch.Value = d6l4tch.Text;
        objcom.Parameters.Add(phtonametch);

        SqlParameter phoonametch = new SqlParameter();
        phoonametch.ParameterName = "@d6l5tch";
        phoonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        phoonametch.Value = d6l5tch.Text;
        objcom.Parameters.Add(phoonametch);

        SqlParameter photnametch = new SqlParameter();
        photnametch.ParameterName = "@d6l6tch";
        photnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        photnametch.Value = d6l6tch.Text;
        objcom.Parameters.Add(photnametch);

        SqlParameter xphonametch = new SqlParameter();
        xphonametch.ParameterName = "@d1l1lec";
        xphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        xphonametch.Value = txttime1.Text;
        objcom.Parameters.Add(xphonametch);

        SqlParameter xhotnametch = new SqlParameter();
        xhotnametch.ParameterName = "@d1l2lec";
        xhotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        xhotnametch.Value = txttime2.Text;
        objcom.Parameters.Add(xhotnametch);

        SqlParameter xpotametch = new SqlParameter();
        xpotametch.ParameterName = "@d1l3lec";
        xpotametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        xpotametch.Value = txttime3.Text;
        objcom.Parameters.Add(xpotametch);

        SqlParameter xphanametch = new SqlParameter();
        xphanametch.ParameterName = "@d1l4lec";
        xphanametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        xphanametch.Value = txttime5.Text;
        objcom.Parameters.Add(xphanametch);

        SqlParameter xphnametch = new SqlParameter();
        xphnametch.ParameterName = "@d1l5lec";
        xphnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        xphnametch.Value = txttime6.Text;
        objcom.Parameters.Add(xphnametch);

        SqlParameter xphoametch = new SqlParameter();
        xphoametch.ParameterName = "@d1l6lec";
        xphoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        xphoametch.Value = txttime7.Text;
        objcom.Parameters.Add(xphoametch);

        SqlParameter vphonametch = new SqlParameter();
        vphonametch.ParameterName = "@d2l1lec";
        vphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        vphonametch.Value = txttime1.Text;
        objcom.Parameters.Add(vphonametch);

        SqlParameter vhotnametch = new SqlParameter();
        vhotnametch.ParameterName = "@d2l2lec";
        vhotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        vhotnametch.Value = txttime2.Text;
        objcom.Parameters.Add(vhotnametch);

        SqlParameter vpotametch = new SqlParameter();
        vpotametch.ParameterName = "@d2l3lec";
        vpotametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        vpotametch.Value = txttime3.Text;
        objcom.Parameters.Add(vpotametch);

        SqlParameter vphanametch = new SqlParameter();
        vphanametch.ParameterName = "@d2l4lec";
        vphanametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        vphanametch.Value = txttime5.Text;
        objcom.Parameters.Add(vphanametch);

        SqlParameter vphnametch = new SqlParameter();
        vphnametch.ParameterName = "@d2l5lec";
        vphnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        vphnametch.Value = txttime6.Text;
        objcom.Parameters.Add(vphnametch);

        SqlParameter vphoametch = new SqlParameter();
        vphoametch.ParameterName = "@d2l6lec";
        vphoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        vphoametch.Value = txttime7.Text;
        objcom.Parameters.Add(vphoametch);

        SqlParameter cphonametch = new SqlParameter();
        cphonametch.ParameterName = "@d3l1lec";
        cphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        cphonametch.Value = txttime1.Text;
        objcom.Parameters.Add(cphonametch);

        SqlParameter chotnametch = new SqlParameter();
        chotnametch.ParameterName = "@d3l2lec";
        chotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        chotnametch.Value = txttime2.Text;
        objcom.Parameters.Add(chotnametch);

        SqlParameter cpotametch = new SqlParameter();
        cpotametch.ParameterName = "@d3l3lec";
        cpotametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        cpotametch.Value = txttime3.Text;
        objcom.Parameters.Add(cpotametch);

        SqlParameter cphanametch = new SqlParameter();
        cphanametch.ParameterName = "@d3l4lec";
        cphanametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        cphanametch.Value = txttime5.Text;
        objcom.Parameters.Add(cphanametch);

        SqlParameter cphnametch = new SqlParameter();
        cphnametch.ParameterName = "@d3l5lec";
        cphnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        cphnametch.Value = txttime6.Text;
        objcom.Parameters.Add(cphnametch);

        SqlParameter cphoametch = new SqlParameter();
        cphoametch.ParameterName = "@d3l6lec";
        cphoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        cphoametch.Value = txttime7.Text;
        objcom.Parameters.Add(cphoametch);

        SqlParameter sphonametch = new SqlParameter();
        sphonametch.ParameterName = "@d4l1lec";
        sphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        sphonametch.Value = txttime1.Text;
        objcom.Parameters.Add(sphonametch);

        SqlParameter shotnametch = new SqlParameter();
        shotnametch.ParameterName = "@d4l2lec";
        shotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        shotnametch.Value = txttime2.Text;
        objcom.Parameters.Add(shotnametch);

        SqlParameter spotametch = new SqlParameter();
        spotametch.ParameterName = "@d4l3lec";
        spotametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        spotametch.Value = txttime3.Text;
        objcom.Parameters.Add(spotametch);

        SqlParameter sphanametch = new SqlParameter();
        sphanametch.ParameterName = "@d4l4lec";
        sphanametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        sphanametch.Value = txttime5.Text;
        objcom.Parameters.Add(sphanametch);

        SqlParameter sphnametch = new SqlParameter();
        sphnametch.ParameterName = "@d4l5lec";
        sphnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        sphnametch.Value = txttime6.Text;
        objcom.Parameters.Add(sphnametch);

        SqlParameter sphoametch = new SqlParameter();
        sphoametch.ParameterName = "@d4l6lec";
        sphoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        sphoametch.Value = txttime7.Text;
        objcom.Parameters.Add(sphoametch);

        SqlParameter ssphonametch = new SqlParameter();
        ssphonametch.ParameterName = "@d5l1lec";
        ssphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        ssphonametch.Value = txttime1.Text;
        objcom.Parameters.Add(ssphonametch);

        SqlParameter sshotnametch = new SqlParameter();
        sshotnametch.ParameterName = "@d5l2lec";
        sshotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        sshotnametch.Value = txttime2.Text;
        objcom.Parameters.Add(sshotnametch);

        SqlParameter sspotametch = new SqlParameter();
        sspotametch.ParameterName = "@d5l3lec";
        sspotametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        sspotametch.Value = txttime3.Text;
        objcom.Parameters.Add(sspotametch);

        SqlParameter ssphanametch = new SqlParameter();
        ssphanametch.ParameterName = "@d5l4lec";
        ssphanametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        ssphanametch.Value = txttime5.Text;
        objcom.Parameters.Add(ssphanametch);

        SqlParameter ssphnametch = new SqlParameter();
        ssphnametch.ParameterName = "@d5l5lec";
        ssphnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        ssphnametch.Value = txttime6.Text;
        objcom.Parameters.Add(ssphnametch);

        SqlParameter ssphoametch = new SqlParameter();
        ssphoametch.ParameterName = "@d5l6lec";
        ssphoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        ssphoametch.Value = txttime7.Text;
        objcom.Parameters.Add(ssphoametch);

        SqlParameter bphonametch = new SqlParameter();
        bphonametch.ParameterName = "@d6l1lec";
        bphonametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bphonametch.Value = txttime1.Text;
        objcom.Parameters.Add(bphonametch);

        SqlParameter bhotnametch = new SqlParameter();
        bhotnametch.ParameterName = "@d6l2lec";
        bhotnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bhotnametch.Value = txttime2.Text;
        objcom.Parameters.Add(bhotnametch);

        SqlParameter bpotametch = new SqlParameter();
        bpotametch.ParameterName = "@d6l3lec";
        bpotametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bpotametch.Value = txttime3.Text;
        objcom.Parameters.Add(bpotametch);

        SqlParameter bphanametch = new SqlParameter();
        bphanametch.ParameterName = "@d6l4lec";
        bphanametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bphanametch.Value = txttime5.Text;
        objcom.Parameters.Add(bphanametch);

        SqlParameter bphnametch = new SqlParameter();
        bphnametch.ParameterName = "@d6l5lec";
        bphnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bphnametch.Value = txttime6.Text;
        objcom.Parameters.Add(bphnametch);

        SqlParameter bphoametch = new SqlParameter();
        bphoametch.ParameterName = "@d6l6lec";
        bphoametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        bphoametch.Value = txttime7.Text;
        objcom.Parameters.Add(bphoametch);



        SqlParameter phnnametch = new SqlParameter();
        phnnametch.ParameterName = "@lecbrk";
        phnnametch.SqlDbType = System.Data.SqlDbType.NVarChar;
        phnnametch.Value = txttime4.Text;
        objcom.Parameters.Add(phnnametch);
        
        string message1 = " Timetable Added Successfully...! ";
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

      //  Response.Redirect("view-timetable.aspx");
    }


    public void SetValues()
    {
        string sql = "SELECT [class] FROM [subject] WHERE (([name] = '"+lbltchnm.Text+"') AND ([school] = '"+lblsch.Text+"'))";
        dss1 = glb.GetDataSet(sql);
        DropDownList1.DataSource = dss1.Tables[0];
        DropDownList1.DataTextField = "class";
        DropDownList1.DataValueField = "class";
        DropDownList1.DataBind();

        string sql1 = "SELECT [snm] FROM [subject-info] ORDER BY [id]";
        dss2 = glb.GetDataSet(sql1);
        d1l1.DataSource = dss2.Tables[0];
        d1l1.DataTextField = "snm";
        d1l1.DataValueField = "snm";
        d1l1.DataBind();

        string sql2 = "SELECT [snm] FROM [subject-info]";
        dss3 = glb.GetDataSet(sql2);
        d1l2.DataSource = dss3.Tables[0];
        d1l2.DataTextField = "snm";
        d1l2.DataValueField = "snm";
        d1l2.DataBind();


        string sql3 = "SELECT [snm] FROM [subject-info]";
        dss4 = glb.GetDataSet(sql3);
        d1l3.DataSource = dss4.Tables[0];
        d1l3.DataTextField = "snm";
        d1l3.DataValueField = "snm";
        d1l3.DataBind();

        d1l4.DataSource = dss4.Tables[0];
        d1l4.DataTextField = "snm";
        d1l4.DataValueField = "snm";
        d1l4.DataBind();

        d1l5.DataSource = dss4.Tables[0];
        d1l5.DataTextField = "snm";
        d1l5.DataValueField = "snm";
        d1l5.DataBind();

        d1l6.DataSource = dss4.Tables[0];
        d1l6.DataTextField = "snm";
        d1l6.DataValueField = "snm";
        d1l6.DataBind();

        d2l1.DataSource = dss4.Tables[0];
        d2l1.DataTextField = "snm";
        d2l1.DataValueField = "snm";
        d2l1.DataBind();

        d2l2.DataSource = dss4.Tables[0];
        d2l2.DataTextField = "snm";
        d2l2.DataValueField = "snm";
        d2l2.DataBind();

        d2l3.DataSource = dss4.Tables[0];
        d2l3.DataTextField = "snm";
        d2l3.DataValueField = "snm";
        d2l3.DataBind();

        d2l4.DataSource = dss4.Tables[0];
        d2l4.DataTextField = "snm";
        d2l4.DataValueField = "snm";
        d2l4.DataBind();


        d2l5.DataSource = dss4.Tables[0];
        d2l5.DataTextField = "snm";
        d2l5.DataValueField = "snm";
        d2l5.DataBind();

        d2l6.DataSource = dss4.Tables[0];
        d2l6.DataTextField = "snm";
        d2l6.DataValueField = "snm";
        d2l6.DataBind();

        d3l1.DataSource = dss4.Tables[0];
        d3l1.DataTextField = "snm";
        d3l1.DataValueField = "snm";
        d3l1.DataBind();

        d3l2.DataSource = dss4.Tables[0];
        d3l2.DataTextField = "snm";
        d3l2.DataValueField = "snm";
        d3l2.DataBind();

        d3l3.DataSource = dss4.Tables[0];
        d3l3.DataTextField = "snm";
        d3l3.DataValueField = "snm";
        d3l3.DataBind();


        d3l4.DataSource = dss4.Tables[0];
        d3l4.DataTextField = "snm";
        d3l4.DataValueField = "snm";
        d3l4.DataBind();


        d3l5.DataSource = dss4.Tables[0];
        d3l5.DataTextField = "snm";
        d3l5.DataValueField = "snm";
        d3l5.DataBind();

        d3l6.DataSource = dss4.Tables[0];
        d3l6.DataTextField = "snm";
        d3l6.DataValueField = "snm";
        d3l6.DataBind();


        d4l1.DataSource = dss4.Tables[0];
        d4l1.DataTextField = "snm";
        d4l1.DataValueField = "snm";
        d4l1.DataBind();



        d4l2.DataSource = dss4.Tables[0];
        d4l2.DataTextField = "snm";
        d4l2.DataValueField = "snm";
        d4l2.DataBind();



        d4l3.DataSource = dss4.Tables[0];
        d4l3.DataTextField = "snm";
        d4l3.DataValueField = "snm";
        d4l3.DataBind();


        d4l4.DataSource = dss4.Tables[0];
        d4l4.DataTextField = "snm";
        d4l4.DataValueField = "snm";
        d4l4.DataBind();

        d4l5.DataSource = dss4.Tables[0];
        d4l5.DataTextField = "snm";
        d4l5.DataValueField = "snm";
        d4l5.DataBind();

        d4l6.DataSource = dss4.Tables[0];
        d4l6.DataTextField = "snm";
        d4l6.DataValueField = "snm";
        d4l6.DataBind();

        d4l6.DataSource = dss4.Tables[0];
        d4l6.DataTextField = "snm";
        d4l6.DataValueField = "snm";
        d4l6.DataBind();

        d5l1.DataSource = dss4.Tables[0];
        d5l1.DataTextField = "snm";
        d5l1.DataValueField = "snm";
        d5l1.DataBind();


        d5l2.DataSource = dss4.Tables[0];
        d5l2.DataTextField = "snm";
        d5l2.DataValueField = "snm";
        d5l2.DataBind();

        d5l3.DataSource = dss4.Tables[0];
        d5l3.DataTextField = "snm";
        d5l3.DataValueField = "snm";
        d5l3.DataBind();

        d5l4.DataSource = dss4.Tables[0];
        d5l4.DataTextField = "snm";
        d5l4.DataValueField = "snm";
        d5l4.DataBind();

        d5l5.DataSource = dss4.Tables[0];
        d5l5.DataTextField = "snm";
        d5l5.DataValueField = "snm";
        d5l5.DataBind();

        d5l6.DataSource = dss4.Tables[0];
        d5l6.DataTextField = "snm";
        d5l6.DataValueField = "snm";
        d5l6.DataBind();

        d6l1.DataSource = dss4.Tables[0];
        d6l1.DataTextField = "snm";
        d6l1.DataValueField = "snm";
        d6l1.DataBind();

        d6l2.DataSource = dss4.Tables[0];
        d6l2.DataTextField = "snm";
        d6l2.DataValueField = "snm";
        d6l2.DataBind();

        d6l3.DataSource = dss4.Tables[0];
        d6l3.DataTextField = "snm";
        d6l3.DataValueField = "snm";
        d6l3.DataBind();

        d6l4.DataSource = dss4.Tables[0];
        d6l4.DataTextField = "snm";
        d6l4.DataValueField = "snm";
        d6l4.DataBind();

        d6l5.DataSource = dss4.Tables[0];
        d6l5.DataTextField = "snm";
        d6l5.DataValueField = "snm";
        d6l5.DataBind();


        d6l6.DataSource = dss4.Tables[0];
        d6l6.DataTextField = "snm";
        d6l6.DataValueField = "snm";
        d6l6.DataBind();


    }

}