using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsVariable.ConnectionString = "Data Source=DESKTOP-9ELN49A\\SQL2014;Persist Security Info=True;Initial Catalog=school_mate;User ID=sa;Password=sky";

        SqlConnection conn = new SqlConnection();
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Principallogin.aspx");
    }
    protected void btnn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Teacherlogin.aspx");
    }
    protected void btnnn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Parentlogin.aspx");
    }
    protected void btnnnn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Schooladminlogin.aspx");
    }


    //private void fillgrid()
    //{
    //    sql = "Select CustomerID as [REG NO],NoBox as [NB],AccNoBox,PackageName,SetupNoReg as [SETUPBOX NO.],ConsumerName as [CONSUMER NAME],Address as [ADDRESS],LandMark as [LANDMARK],Mbno1 as [MB1],Mbno2 as [MB2],Area as [AREA],AgentName as [AGENT],CGSTPer,CGSTAmt,SGSTPer,SGSTAmt,TotRate,Dics,TotAmt as [T-AMT],CustBal as [CUST BAL],RegNo as [LADGER NO],Type,ImgP1,ImgP2,ImgP3,IDProof,DtFrom as [R-CON DT],CNameMarathi,UserName,CustPassword,ChangeCol,NotifyStat,Remark as [REMARK],CompanyId from tblReg where CompanyId='" + clscable.CompanyId + "' order by CustomerID";
    //    ds = new DataSet(sql);
    //    ds = cab.fillgird1(sql);
    //    bs.DataSource = ds.Tables[0];
    //    dgvcable.DataSource = bs;
    //    TrueFalseColmn();
    //}

}