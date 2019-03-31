using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Teacher_schedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        Sessioninfo();


        lblday.Text = System.DateTime.Now.DayOfWeek.ToString();
        view();
        if (lblday.Text == "Monday")
        {
            monday.Visible = true;
        }
        else if (lblday.Text == "Tuesday")
        {
            tuesday.Visible = true;
        }
        else if (lblday.Text == "Wednesday")
        {
            wednesday.Visible = true;
        }
        else if (lblday.Text == "Thursday")
        {
            thursday.Visible = true;
        }
        else if (lblday.Text == "Friday")
        {
            friday.Visible = true;
        }
        else if (lblday.Text == "Saturday")
        {
            saturday.Visible = true;
        }
    }

    public void Sessioninfo()
    {
        HttpCookie myCookiet = Request.Cookies["myCookiet"];


        if (myCookiet != null)
        {

            string userId = myCookiet["tnm"];

            DataSet dss = new DataSet();
            Select sels = new Select();
            dss = sels.selectimeses(userId);
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

                Response.Redirect("../locklogin.aspx");
            }
        }
    }
    protected void view()
    {

        DataSet dss = new DataSet();
        Select sels = new Select();
        dss = sels.timetbl(lblsch.Text);
        if (dss.Tables[0].Rows.Count == 1)
        {
            lbllec1.Text = dss.Tables[0].Rows[0]["lec1"].ToString();
            lbllec2.Text = dss.Tables[0].Rows[0]["lec2"].ToString();
            lbllec3.Text = dss.Tables[0].Rows[0]["lec3"].ToString();
            lbllec4.Text = dss.Tables[0].Rows[0]["lec4"].ToString();
            lbllec5.Text = dss.Tables[0].Rows[0]["lec5"].ToString();
            lbllec6.Text = dss.Tables[0].Rows[0]["lec6"].ToString();
            lblbrk.Text = dss.Tables[0].Rows[0]["lecbrk"].ToString();
        }


        string d1 = "Monday";
        
        DataSet ds = new DataSet();
        Select sel = new Select();
        ds = sel.monl1(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds.Tables[0].Rows.Count == 1)
        {
            lbld1l1.Text = ds.Tables[0].Rows[0]["d1l1"].ToString();
            monl1.Text = ds.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld1l1.Text = "No class scheduled";

        }

        DataSet ds1 = new DataSet();
        Select sel1 = new Select();
        ds1 = sel1.monl2(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds1.Tables[0].Rows.Count == 1)
        {
            lbld1l2.Text = ds1.Tables[0].Rows[0]["d1l2"].ToString();
            monl2.Text = ds1.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld1l2.Text = "No class scheduled";

        }

        DataSet ds2 = new DataSet();
        Select sel2 = new Select();
        ds2 = sel2.monl3(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds2.Tables[0].Rows.Count == 1)
        {
            lbld1l3.Text = ds2.Tables[0].Rows[0]["d1l3"].ToString();
            monl3.Text = ds2.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld1l3.Text = "No class scheduled";

        }

        DataSet ds3 = new DataSet();
        Select sel3 = new Select();
        ds3 = sel3.monl4(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds3.Tables[0].Rows.Count == 1)
        {
            lbld1l4.Text = ds3.Tables[0].Rows[0]["d1l4"].ToString();
            monl4.Text = ds3.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld1l4.Text = "No class scheduled";

        }

        DataSet ds4 = new DataSet();
        Select sel4 = new Select();
        ds4 = sel4.monl5(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds4.Tables[0].Rows.Count == 1)
        {
            lbld1l5.Text = ds4.Tables[0].Rows[0]["d1l5"].ToString();
            monl5.Text = ds4.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld1l5.Text = "No class scheduled";

        }

        DataSet ds5 = new DataSet();
        Select sel5 = new Select();
        ds5 = sel5.monl6(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds5.Tables[0].Rows.Count == 1)
        {
            lbld1l6.Text = ds5.Tables[0].Rows[0]["d1l6"].ToString();
            monl6.Text = ds5.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld1l6.Text = "No class scheduled";

        }


        string d2 = "Tuesday";
        DataSet ds6 = new DataSet();
        Select sel6 = new Select();
        ds6 = sel6.tuel1(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds6.Tables[0].Rows.Count == 1)
        {
            lbld2l1.Text = ds6.Tables[0].Rows[0]["d2l1"].ToString();
            tue1.Text = ds6.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld2l1.Text = "No class scheduled";

        }

        DataSet ds7 = new DataSet();
        Select sel7 = new Select();
        ds7 = sel7.tuel2(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds7.Tables[0].Rows.Count == 1)
        {
            lbld2l2.Text = ds7.Tables[0].Rows[0]["d2l2"].ToString();
            tue2.Text = ds7.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld2l2.Text = "No class scheduled to this lecture";

        }

        DataSet ds8 = new DataSet();
        Select sel8 = new Select();
        ds8 = sel8.tuel3(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds8.Tables[0].Rows.Count == 1)
        {
            lbld2l3.Text = ds8.Tables[0].Rows[0]["d2l3"].ToString();
            tue3.Text = ds8.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld2l3.Text = "No class scheduled to this lecture";

        }

        DataSet ds9 = new DataSet();
        Select sel9 = new Select();
        ds9 = sel9.tuel4(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds9.Tables[0].Rows.Count == 1)
        {
            lbld2l4.Text = ds9.Tables[0].Rows[0]["d2l4"].ToString();
            tue4.Text = ds9.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld2l4.Text = "No class scheduled to this lecture";

        }

        DataSet ds10 = new DataSet();
        Select sel10 = new Select();
        ds10 = sel10.tuel5(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds10.Tables[0].Rows.Count == 1)
        {
            lbld2l5.Text = ds10.Tables[0].Rows[0]["d2l5"].ToString();
            tue5.Text = ds10.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld2l5.Text = "No class scheduled to this lecture";

        }

        DataSet ds11 = new DataSet();
        Select sel11 = new Select();
        ds11 = sel11.tuel6(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds11.Tables[0].Rows.Count == 1)
        {
            lbld2l6.Text = ds11.Tables[0].Rows[0]["d2l6"].ToString();
            tue6.Text = ds11.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld2l6.Text = "No class scheduled to this lecture";

        }

        DataSet ds12 = new DataSet();
        Select sel12 = new Select();
        ds12 = sel12.wedl1(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds12.Tables[0].Rows.Count == 1)
        {
            lbld3l1.Text = ds12.Tables[0].Rows[0]["d3l1"].ToString();
            wed1.Text = ds12.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld3l1.Text = "No class scheduled to this lecture";

        }

        DataSet ds13 = new DataSet();
        Select sel13 = new Select();
        ds13 = sel13.wedl2(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds13.Tables[0].Rows.Count == 1)
        {
            lbld3l2.Text = ds13.Tables[0].Rows[0]["d3l2"].ToString();
            wed2.Text = ds13.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld3l2.Text = "No class scheduled to this lecture";

        }

        DataSet ds14 = new DataSet();
        Select sel14 = new Select();
        ds14 = sel14.wedl3(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds14.Tables[0].Rows.Count == 1)
        {
            lbld3l3.Text = ds14.Tables[0].Rows[0]["d3l3"].ToString();
            wed3.Text = ds14.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld3l3.Text = "No class scheduled to this lecture";

        }

        DataSet ds15 = new DataSet();
        Select sel15 = new Select();
        ds15 = sel15.wedl4(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds15.Tables[0].Rows.Count == 1)
        {
            lbld3l4.Text = ds15.Tables[0].Rows[0]["d3l4"].ToString();
            wed4.Text = ds15.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld3l4.Text = "No class scheduled to this lecture";

        }

        DataSet ds16 = new DataSet();
        Select sel16 = new Select();
        ds16 = sel16.wedl5(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds16.Tables[0].Rows.Count == 1)
        {
            lbld3l5.Text = ds16.Tables[0].Rows[0]["d3l5"].ToString();
            wed5.Text = ds16.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld3l5.Text = "No class scheduled to this lecture";

        }
        DataSet ds17 = new DataSet();
        Select sel17 = new Select();
        ds17 = sel17.wedl6(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds17.Tables[0].Rows.Count == 1)
        {
            lbld3l6.Text = ds17.Tables[0].Rows[0]["d3l6"].ToString();
            wed6.Text = ds17.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld3l6.Text = "No class scheduled to this lecture";

        }

        DataSet ds18 = new DataSet();
        Select sel18 = new Select();
        ds18 = sel18.thu1(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds18.Tables[0].Rows.Count == 1)
        {
            lbld4l1.Text = ds18.Tables[0].Rows[0]["d4l1"].ToString();
            thu1.Text = ds18.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld4l1.Text = "No class scheduled to this lecture";

        }

        DataSet ds19 = new DataSet();
        Select sel19 = new Select();
        ds19 = sel19.thu2(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds19.Tables[0].Rows.Count == 1)
        {
            lbld4l2.Text = ds19.Tables[0].Rows[0]["d4l2"].ToString();
            thu2.Text = ds19.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld4l2.Text = "No class scheduled to this lecture";

        }

        DataSet ds20 = new DataSet();
        Select sel20 = new Select();
        ds20 = sel20.thu3(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds20.Tables[0].Rows.Count == 1)
        {
            lbld4l3.Text = ds20.Tables[0].Rows[0]["d4l3"].ToString();
            thu3.Text = ds20.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld4l3.Text = "No class scheduled to this lecture";
        }

        DataSet ds21 = new DataSet();
        Select sel21 = new Select();
        ds21 = sel21.thu4(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds21.Tables[0].Rows.Count == 1)
        {
            lbld4l4.Text = ds21.Tables[0].Rows[0]["d4l4"].ToString();
            thu4.Text = ds21.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld4l4.Text = "No class scheduled to this lecture";

        }

        DataSet ds22 = new DataSet();
        Select sel22 = new Select();
        ds22 = sel22.thu5(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds22.Tables[0].Rows.Count == 1)
        {
            lbld4l5.Text = ds22.Tables[0].Rows[0]["d4l5"].ToString();
            thu5.Text = ds22.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld4l5.Text = "No class scheduled to this lecture";

        }


        DataSet ds23 = new DataSet();
        Select sel23 = new Select();
        ds23 = sel23.thu6(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds23.Tables[0].Rows.Count == 1)
        {
            lbld4l6.Text = ds23.Tables[0].Rows[0]["d4l6"].ToString();
            thu6.Text = ds23.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld4l6.Text = "No class scheduled to this lecture";

        }


        DataSet ds24 = new DataSet();
        Select sel24 = new Select();
        ds24 = sel24.fri1(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds24.Tables[0].Rows.Count == 1)
        {
            lbld5l1.Text = ds24.Tables[0].Rows[0]["d5l1"].ToString();
            fri1.Text = ds18.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld5l1.Text = "No class scheduled to this lecture";

        }

        DataSet ds25 = new DataSet();
        Select sel25 = new Select();
        ds25 = sel25.fri2(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds25.Tables[0].Rows.Count == 1)
        {
            lbld5l2.Text = ds25.Tables[0].Rows[0]["d5l2"].ToString();
            fri2.Text = ds25.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld5l2.Text = "No class scheduled to this lecture";

        }

        DataSet ds26 = new DataSet();
        Select sel26 = new Select();
        ds26 = sel26.fri3(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds26.Tables[0].Rows.Count == 1)
        {
            lbld5l3.Text = ds26.Tables[0].Rows[0]["d5l3"].ToString();
            fri3.Text = ds26.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld5l3.Text = "No class scheduled to this lecture";
        }

        DataSet ds27 = new DataSet();
        Select sel27 = new Select();
        ds27 = sel27.fri4(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds27.Tables[0].Rows.Count == 1)
        {
            lbld5l4.Text = ds27.Tables[0].Rows[0]["d5l4"].ToString();
            fri4.Text = ds27.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld5l4.Text = "No class scheduled to this lecture";

        }

        DataSet ds28 = new DataSet();
        Select sel28 = new Select();
        ds28 = sel28.fri5(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds28.Tables[0].Rows.Count == 1)
        {
            lbld5l5.Text = ds28.Tables[0].Rows[0]["d5l5"].ToString();
            fri5.Text = ds28.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld5l5.Text = "No class scheduled to this lecture";

        }


        DataSet ds29 = new DataSet();
        Select sel29 = new Select();
        ds29 = sel29.fri6(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds29.Tables[0].Rows.Count == 1)
        {
            lbld5l6.Text = ds29.Tables[0].Rows[0]["d5l6"].ToString();
            fri6.Text = ds29.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld5l6.Text = "No class scheduled to this lecture";

        }



        DataSet ds30 = new DataSet();
        Select sel30 = new Select();
        ds30 = sel30.sat1(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds30.Tables[0].Rows.Count == 1)
        {
            lbld6l1.Text = ds30.Tables[0].Rows[0]["d5l1"].ToString();
            sat1.Text = ds30.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld6l1.Text = "No class scheduled to this lecture";

        }

        DataSet ds31 = new DataSet();
        Select sel31 = new Select();
        ds31 = sel31.sat2(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds31.Tables[0].Rows.Count == 1)
        {
            lbld6l2.Text = ds31.Tables[0].Rows[0]["d6l2"].ToString();
            sat2.Text = ds31.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld6l2.Text = "No class scheduled to this lecture";

        }

        DataSet ds32 = new DataSet();
        Select sel32 = new Select();
        ds32 = sel32.sat3(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds32.Tables[0].Rows.Count == 1)
        {
            lbld6l3.Text = ds32.Tables[0].Rows[0]["d6l3"].ToString();
            sat3.Text = ds32.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld6l3.Text = "No class scheduled to this lecture";
        }

        DataSet ds33 = new DataSet();
        Select sel33 = new Select();
        ds33 = sel33.sat4(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds33.Tables[0].Rows.Count == 1)
        {
            lbld6l4.Text = ds33.Tables[0].Rows[0]["d6l4"].ToString();
            sat4.Text = ds33.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld6l4.Text = "No class scheduled to this lecture";

        }

        DataSet ds34 = new DataSet();
        Select sel34 = new Select();
        ds34 = sel34.sat5(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds34.Tables[0].Rows.Count == 1)
        {
            lbld6l5.Text = ds34.Tables[0].Rows[0]["d6l5"].ToString();
            sat5.Text = ds34.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld6l5.Text = "No class scheduled to this lecture";

        }


        DataSet ds35 = new DataSet();
        Select sel35 = new Select();
        ds35 = sel35.sat6(lbltchnm.Text, lblsch.Text, d1.ToString());
        if (ds35.Tables[0].Rows.Count == 1)
        {
            lbld6l6.Text = ds35.Tables[0].Rows[0]["d6l6"].ToString();
            sat6.Text = ds35.Tables[0].Rows[0]["class"].ToString();
        }
        else
        {
            lbld6l6.Text = "No class scheduled to this lecture";

        }
   
    }
    protected void btnd1l1_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        //SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld1l1.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = monl1.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec1.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c1d1l1.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd1l2_Click(object sender, EventArgs e)
    {
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld1l2.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = monl2.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec2.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c1d1l2.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd1l3_Click(object sender, EventArgs e)
    {
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld1l3.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = monl3.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec3.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c1d1l3.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd1l4_Click(object sender, EventArgs e)
    {
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld1l4.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = monl4.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec4.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c1d1l4.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd1l5_Click(object sender, EventArgs e)
    {
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld1l5.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = monl5.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec5.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c1d1l5.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd1l6_Click(object sender, EventArgs e)
    {
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection(ClsVariable.ConnectionString);
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld1l6.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = monl6.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec6.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c1d1l6.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd2l1_Click(object sender, EventArgs e)
    {
        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld2l1.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = tue1.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec1.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c2d2l1.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd2l2_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld2l2.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = tue2.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec2.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c2d2l2.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd2l3_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld2l3.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = tue3.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec3.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c2d2l3.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd2l4_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld2l4.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = tue4.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec4.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c2d2l4.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd2l5_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld2l5.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = tue5.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec5.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c2d2l5.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd2l6_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld2l6.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = tue6.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec6.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c2d2l6.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd3l1_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld3l1.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = wed1.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec1.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c3d3l1.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd3l2_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld3l2.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = wed2.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec2.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c3d3l2.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd3l3_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld3l3.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = wed3.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec3.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c3d3l3.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd3l4_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld3l4.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = wed4.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec4.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c3d3l4.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd3l5_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld3l5.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = wed5.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec5.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c3d3l5.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd3l6_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld3l6.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = wed6.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec6.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c3d3l6.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd4l1_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld4l1.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = thu1.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec1.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c4d4l1.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd4l2_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld4l2.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = thu2.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec2.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c4d4l2.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd4l3_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld4l3.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = thu3.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec3.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c4d4l3.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd4l4_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld4l4.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = thu4.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec4.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c4d4l4.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd4l5_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld4l5.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = thu5.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec5.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c4d4l5.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd4l6_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld4l6.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = thu6.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec6.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c4d4l6.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd5l1_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld5l1.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = fri1.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec1.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c5d5l1.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd5l2_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld5l2.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = fri2.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec2.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c5d5l2.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd5l3_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld5l3.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = fri3.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec3.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c5d5l3.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd5l4_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld5l4.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = fri4.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec4.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c5d5l4.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd5l5_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld5l5.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = fri5.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec5.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c5d5l5.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd5l6_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld5l6.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = fri6.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec6.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c5d5l6.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd6l1_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld6l1.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = sat1.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec1.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c6d6l1.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd6l2_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld6l2.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = sat2.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec2.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c6d6l2.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd6l3_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld6l3.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = sat3.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec3.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c6d6l3.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd6l4_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld6l4.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = sat4.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec4.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c6d6l4.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd6l5_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld6l5.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = sat5.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec5.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c6d6l5.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
    protected void btnd6l6_Click(object sender, EventArgs e)
    {

        //SqlConnection objcon = new SqlConnection("Data Source=localhost;Persist Security Info=True;Initial Catalog=school_mate;User ID=school;Password=QWERTYuiopasdfghjkl@123456");
        SqlConnection objcon = new SqlConnection("Data Source=intel-pc\\sqlexpress;Initial Catalog=totalschool;Integrated Security=True");
        objcon.Open();
        SqlCommand objcom = new SqlCommand("spcourse", objcon);
        objcom.CommandType = CommandType.StoredProcedure;

        SqlParameter objmaincat = new SqlParameter();
        objmaincat.ParameterName = "@subject";
        objmaincat.SqlDbType = System.Data.SqlDbType.NVarChar;
        objmaincat.Value = lbld6l6.Text;
        objcom.Parameters.Add(objmaincat);

        SqlParameter objname = new SqlParameter();
        objname.ParameterName = "@date";
        objname.SqlDbType = System.Data.SqlDbType.NVarChar;
        objname.Value = System.DateTime.Now.ToString("dd/MM/yyyy");
        objcom.Parameters.Add(objname);

        SqlParameter objphoto = new SqlParameter();
        objphoto.ParameterName = "@class";
        objphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        objphoto.Value = sat6.Text;
        objcom.Parameters.Add(objphoto);

        SqlParameter objpho = new SqlParameter();
        objpho.ParameterName = "@day";
        objpho.SqlDbType = System.Data.SqlDbType.NVarChar;
        objpho.Value = lblday.Text;
        objcom.Parameters.Add(objpho);

        SqlParameter obpheo = new SqlParameter();
        obpheo.ParameterName = "@time";
        obpheo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpheo.Value = lbllec6.Text;
        objcom.Parameters.Add(obpheo);

        SqlParameter obpo = new SqlParameter();
        obpo.ParameterName = "@tchnm";
        obpo.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpo.Value = lbltchnm.Text;
        objcom.Parameters.Add(obpo);

        SqlParameter obpom = new SqlParameter();
        obpom.ParameterName = "@course";
        obpom.SqlDbType = System.Data.SqlDbType.NVarChar;
        obpom.Value = c6d6l6.Text;
        objcom.Parameters.Add(obpom);


        SqlParameter obphoto = new SqlParameter();
        obphoto.ParameterName = "@school";
        obphoto.SqlDbType = System.Data.SqlDbType.NVarChar;
        obphoto.Value = lblsch.Text;
        objcom.Parameters.Add(obphoto);

        string message1 = " Course Added Successfully...! ";
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
}