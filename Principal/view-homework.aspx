<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="view-homework.aspx.cs" Inherits="Principal_view_event" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


       <!-- **********************************************************************************************************************************************************
      MAIN CONTENT
      *********************************************************************************************************************************************************** -->
      <!--main content start-->
      <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i> EVENTS...</h3>
		  		<div class="row mt">
			  		<div class="col-lg-8">
                      <div class="content-panel">
                     
                          <section id="unseen">
                            <asp:table runat="server" class="table table-bordered table-striped table-condensed">
   <asp:TableRow>

       <asp:TableCell RowSpan="5" CssClass="text-center"><asp:Image runat="server" ID="img" ImageUrl="view-homework.aspx?pid='Request[pid]'" Height="300px" Width="280px" CssClass="img-rounded" /><br /><asp:Label runat="server" ID="st"></asp:Label></asp:TableCell>
       <asp:TableCell><asp:Label runat="server" ID="lblid"></asp:Label></asp:TableCell>
   </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell> <asp:Label runat="server" ID="lbltitle"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                                   
                                <asp:TableRow>
                                    <asp:TableCell> <asp:Label runat="server" ID="lbldate"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                               
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldescr"></asp:Label></asp:TableCell>

                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lblclass"></asp:Label></asp:TableCell>

                                </asp:TableRow>




                                </asp:table></section></div></div></div></section></section>

</asp:Content>

