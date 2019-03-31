<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="view-trip.aspx.cs" Inherits="Teacher_view_event" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


       <!-- **********************************************************************************************************************************************************
      MAIN CONTENT
      *********************************************************************************************************************************************************** -->
      <!--main content start-->
      <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i> TRIP / PICNIC...</h3>
		  		<div class="row mt">
			  		<div class="col-lg-12">
                      <div class="content-panel">
                     
                          <section id="unseen">
                            <asp:table runat="server" class="table table-bordered table-striped table-condensed">
   <asp:TableRow>

       <asp:TableCell ColumnSpan="2" BackColor="Turquoise" CssClass="text-center"><asp:Image runat="server" ID="img" ImageUrl="~/Teacher/img/trip.jpg" Height="200px" Width="800px" CssClass="img-thumbnail" /></asp:TableCell>
       
   </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lblid"></asp:Label></asp:TableCell>
                                    <asp:TableCell><asp:Label runat="server" ID="lbltitle"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                               
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lblday"></asp:Label></asp:TableCell>
                                    <asp:TableCell><asp:Label runat="server" ID="lblplace"></asp:Label></asp:TableCell>
                                    
                                </asp:TableRow>
                                   
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldate"></asp:Label></asp:TableCell>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldtl"></asp:Label></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldescr"></asp:Label></asp:TableCell>
                                    <asp:TableCell><asp:Label runat="server" ID="lblschool"></asp:Label></asp:TableCell>
                                    
                                </asp:TableRow>




                                </asp:table></section></div></div></div></section></section>

</asp:Content>

