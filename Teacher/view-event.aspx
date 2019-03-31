<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="view-event.aspx.cs" Inherits="Teacher_view_event" %>

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
                     <asp:Label ID="lblsch" runat="server" Visible="false"></asp:Label>
                          <section id="unseen">
                            <asp:table runat="server" class="table table-bordered table-striped table-condensed">
   <asp:TableRow>

       <asp:TableCell RowSpan="5" CssClass="text-center"><asp:Image runat="server" ID="img" ImageUrl="view-event.aspx?pid='Request[pid]'" Height="300px" Width="280px" CssClass="img-rounded" /><br /><asp:Label runat="server" ID="st"></asp:Label></asp:TableCell>
       
       <asp:TableCell><asp:Label runat="server" ID="lblid"></asp:Label></asp:TableCell>
   </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbltitle"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                                   
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldate"></asp:Label></asp:TableCell>

                                </asp:TableRow>
                               
                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lbldescr"></asp:Label></asp:TableCell>

                                </asp:TableRow>

                                <asp:TableRow>
                                    <asp:TableCell><asp:Label runat="server" ID="lblclass"></asp:Label></asp:TableCell>

                                </asp:TableRow>




                                </asp:table></div>
                                
                                
                                <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>
                                <asp:FileUpload ID="FileUpload2" runat="server"></asp:FileUpload>
                                <asp:FileUpload ID="FileUpload3" runat="server"></asp:FileUpload>
                                <asp:FileUpload ID="FileUpload4" runat="server"></asp:FileUpload>
                                <asp:FileUpload ID="FileUpload5" runat="server"></asp:FileUpload>

                                <asp:Button ID="Button1" class="btn btn-theme03" runat="server" 
                            Text="Upload" onclick="Button1_Click"></asp:Button>
                                
                                </div></div>
                                
                                
                                <div class="row mt">
			  		<div class="col-lg-8">
                      <div class="content-panel">
                     	<h3><i class="fa fa-angle-right"></i> Photos...</h3>
		  
          <asp:DataList ID="rptitem" class="list-group-item" RepeatColumns="5" RepeatLayout="Flow" RepeatDirection="Horizontal" runat="server">
          
          <ItemTemplate>
          
          <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("pic","../Teacher/pic/{0}") %>'  Height="120px" Width="130px"></asp:Image>
          
          </ItemTemplate>
          
          </asp:DataList>
                                
                                </section></section>

</asp:Content>

