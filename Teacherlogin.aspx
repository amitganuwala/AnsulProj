<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teacherlogin.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="Dashboard">
    <meta name="keyword" content="Dashboard, Bootstrap, Admin, Template, Theme, Responsive, Fluid, Retina">

    <!-- Bootstrap core CSS -->
    <link href="assets/css/bootstrap.css" rel="stylesheet">
    <!--external css-->
    <link href="assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="assets/css/zabuto_calendar.css">
    <link rel="stylesheet" type="text/css" href="assets/js/gritter/css/jquery.gritter.css" />
    <link rel="stylesheet" type="text/css" href="assets/lineicons/style.css">    
    
    <!-- Custom styles for this template -->
    <link href="assets/css/style.css" rel="stylesheet">
    <link href="assets/css/style-responsive.css" rel="stylesheet">

    <script src="assets/js/chart-master/Chart.js"></script>
    
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
   
</head>
<body>
    
	  <div id="login-page">
	  	<div class="container">
	  	
		      <form class="form-login"  runat="server">
		        <h2 class="form-login-heading">Sign In now</h2>
		        <div class="login-wrap">
		            <asp:TextBox runat="server" ID="txtname" class="form-control" AutoPostBack="true" placeholder="Name" autofocus></asp:TextBox>
		            <br>
		            <asp:TextBox runat="server" ID="txtpass" TextMode="Password" class="form-control" placeholder="Password"></asp:TextBox>
                    <br /> 
                    
                    
                    <label class="checkbox">
		                <span class="pull-right">
                            <asp:CheckBox ID="check"  hidden="hidden" runat="server" />
		                    <a data-toggle="modal" href="login.aspx#myModal"> Forgot Password?</a>
		                </span>
		            </label>
		            <asp:Button runat="server" ID="btnsubmit" class="btn btn-theme btn-block" Text="Sign In" OnClick="btnsubmit_Click"/>
		            
                    
                    <hr/>
	
                    <asp:GridView ID="GridView1" runat="server" Visible="False" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                            <asp:BoundField DataField="school" HeaderText="school" 
                                SortExpression="school" />
                        </Columns>
                    </asp:GridView>
		           <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:school_mateConnectionString5 %>" 
                        SelectCommand="SELECT [name], [school] FROM [teacher] WHERE ([usr] = @usr)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="txtname" Name="usr" PropertyName="Text" 
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>--%>
		      </form>	  	
	  	
	  	</div>
	  </div>

    <!-- js placed at the end of the document so the pages load faster -->
    <script src="assets/js/jquery.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>

    <!--BACKSTRETCH-->
    <!-- You can use an image of whatever size. This script will stretch to fit in any screen size.-->
    <script type="text/javascript" src="assets/js/jquery.backstretch.min.js"></script>
    <script>
        $.backstretch("assets/img/login-bg.jpg", { speed: 500 });
    </script>

  
    </div>
    </form>
</body>
</html>
