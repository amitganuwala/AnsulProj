<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="Copy of blog.aspx.cs" Inherits="School_blog" %>

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
 <section id="main-content">
          <section class="wrapper">

<div id="page-content" class="archive-page container">
		<div class="">
			<div class="row">
				<div class="col-md-8">
                <h2>Pending Blogs...</h2>
                 <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
                  
					<div class="box">
						<a href="#"><h2 class="vid-name"><%# Eval("title") %></h2></a>
						<div class="info">
							<h5>By <a href="#"><%# Eval("addnm") %></a></h5>
							<span><i class="fa fa-calendar"></i><%# Eval("date") %></span> 
							
							<span><i class="fa fa-heart"></i><%# Eval("school") %></span>
							<br /><span><%# Eval("subject") %></span>
						</div>
						<div class="wrap-vid">
							<div class="zoom-container">
								<div class="zoom-caption">
								</div>
								<asp:Image ID="img" runat="server" ImageUrl='<%# Eval("pic","../Teacher/img/{0}") %>' Height="140px" Width="250px" />
							</div>
							<p><%# Eval("message") %> <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/School/singlein.aspx?id={0}") %>'>MORE....</asp:HyperLink>
						</div>
					</div>
                    </ItemTemplate></asp:DataList>
	</div>
    
    </div></div></div></section></section>
</asp:Content>

