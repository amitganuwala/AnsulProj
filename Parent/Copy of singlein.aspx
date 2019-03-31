<%@ Page Title="" Language="C#" MasterPageFile="~/Parent/MasterPage.master" AutoEventWireup="true" CodeFile="Copy of singlein.aspx.cs" Inherits="pr_single" %>

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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="mainSchool">
<section id="main-content">
          <section class="wrapper">

<div id="page-content" class="single-page container">
		<div class="row">
			<div class="col-md-8">
				<div class="box">
					<div class="wrap-vid">
						<asp:Image ID="img" runat="server" Height="570px" Width="722px" />
                        <asp:Label ID="st" runat="server"></asp:Label>
					</div>
					<div class="share">
						<asp:Label runat="server" ID="lblid" Visible="false"></asp:Label>
					</div>
					<div class="line"></div>
					<h1 class="vid-name"><a href="#"><asp:Label runat="server" ID="title"></asp:Label></a></h1>
					<div class="info">
						<h5>By <a href="#"><asp:Label runat="server" ID="tchnm"></asp:Label></a></h5>
						<span><i class="fa fa-calendar"><asp:Label ID="date" runat="server"></asp:Label></i></span> 
						<span><i class="fa fa-heart"></i><asp:Label ID="school" runat="server"></asp:Label></span>
                        <span><i class="fa fa-comment"></i><asp:Label ID="subject" runat="server"></asp:Label></span>
					</div>
					<p style="margin-top: 20px"><asp:Label ID="descr" runat="server"></asp:Label></p>
					
	</div></div></div>
    </div>
    </div>
    </section></section>
    </div>
</asp:Content>

