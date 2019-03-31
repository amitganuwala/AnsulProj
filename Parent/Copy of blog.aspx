<%@ Page Title="" Language="C#" MasterPageFile="~/Parent/MasterPage.master" AutoEventWireup="true" CodeFile="Copy of blog.aspx.cs" Inherits="tc_blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Free Bootstrap Themes by Zerotheme dot com - Free Responsive Html5 Templates">
    <meta name="author" content="https://www.Zerotheme.com">
	
    
	
    <!-- Bootstrap Core CSS -->
    <link rel="stylesheet" href="zNewsPaper/css/bootstrap.min.css"  type="text/css">
	
	<!-- Owl Carousel Assets -->
    <link href="zNewsPaper/owl-carousel/owl.carousel.css" rel="stylesheet">
    <link href="zNewsPaper/owl-carousel/owl.theme.css" rel="stylesheet">
	
	<!-- Custom CSS -->
    <link rel="stylesheet" href="zNewsPaper/css/style.css">
	 <link href="zNewsPaper/css/bootstrap-datetimepicker.min.css" rel="stylesheet" media="screen">
	
	<!-- Custom Fonts -->
    <link rel="stylesheet" href="zNewsPaper/font-awesome-4.4.0/css/font-awesome.min.css"  type="text/css">
	
	<!-- jQuery and Modernizr-->
	<script src="zNewsPaper/js/jquery-2.1.1.js"></script>
	
	<!-- Core JavaScript Files -->  	 
    <script src="zNewsPaper/js/bootstrap.min.js"></script>
	
	<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="js/html5shiv.js"></script>
        <script src="js/respond.min.js"></script>
    <![endif]-->

    <style type="text/css">
        .style1
        {
            width: 100%;
            font-size:medium;
        }
        .style2
        {
            width: 1001px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
<div id="mainSchool">
	<div id="Div1" class="index-page container">
		<div class="row">
			<div id="Div2"><!-- background not working -->
				<div class="col-md-10"><br /><br /><br /><h2>Leave Application.</h2><br /><br />
                <asp:Label ID="lblsch" Visible="false" runat="server" ></asp:Label>
                <asp:Label ID="lblstdnm" Visible="false" runat="server" ></asp:Label>
                <asp:Label ID="lblclass" runat="server" Visible="false" ></asp:Label>
                   <table class="style1" width="100%">
                                        <tr>
                                            <td colspan="2">To,</td>
                                            
                                        </tr>
                                        <tr>
                                            <td colspan="2">The Principal,</td>
                                            
                                        </tr>
                                        <tr>
                                        <td colspan="2"><asp:Label ID="lblsch1" runat="server"></asp:Label></td>
                                        </tr>
                                        <tr>
                                        <td colspan="2"><br />Subject : 
                                            <asp:TextBox ID="txtsub" runat="server" Height="16px" Width="732px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                        <td colspan="2"><br /><br />Respected Sir / Ma'am,</td>
                                        </tr>
                                        <tr>
                                        <td colspan="2"><br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Good morning. I am 
                                            <asp:TextBox ID="txtpname" runat="server" Height="16px" Width="148px"></asp:TextBox> &nbsp; parent of <asp:Label ID="stnm" Font-Bold="true" ForeColor="Black" runat="server"></asp:Label> &nbsp;&nbsp; studing in your institute in class <asp:Label ID="lclass" Font-Bold="true" ForeColor="Black" runat="server"></asp:Label> &nbsp;. My ward will not be able to come to school for 
                                        <asp:DropDownList ID="DropDownList1" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            </asp:DropDownList> &nbsp;&nbsp; days from date 
                                            <asp:TextBox ID="TextBox1"  Height="17px" Width="145px" runat="server">  </asp:TextBox> till date  <asp:TextBox  Height="17px" Width="145px" ID="TextBox2"
                                                runat="server"></asp:TextBox> because 
                                            <asp:TextBox ID="txtreason" runat="server" Height="17px" Width="145px"></asp:TextBox> &nbsp;&nbsp;I request you to allow the leave and I promise that my ward will definetely complete the pending work.
                                        </td>

                                        </tr>

                                        <tr>
                                        <td colspan="2">Thanking you.</td>
                                        </tr>
                                        <tr>
                                        <td class="style2"></td>
                                        <td>Yours faithfully,</td>

                                        </tr>
                                        <tr>
                                        <td class="style2"></td>
                                        <td>
                                            <asp:TextBox ID="txtpmm" runat="server" Height="16px" Width="141px"></asp:TextBox></td>
                                        </tr>
                                   </table>
                                 


	</div>
     <div class="col-md-2">
                                       <br />
                                       <asp:Button ID="Button1" class="btn btn-primary" runat="server" 
                                       Text="Send" onclick="Button1_Click"></asp:Button>
                                    </div>
                                  
    
    </div></div></div></section></section>
</asp:Content>

