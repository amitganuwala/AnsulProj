<%@ Page Title="" Language="C#" MasterPageFile="~/Parent/MasterPage.master" AutoEventWireup="true" CodeFile="view-event.aspx.cs" Inherits="Teacher_view_event" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


       <!-- **********************************************************************************************************************************************************
      MAIN CONTENT
      *********************************************************************************************************************************************************** -->
      <!--main content start-->
     <div id="mainSchool">
  <div class="center-block text-center">
     <asp:Label runat="server" ID="lblstdnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
              <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
                                      
                
       <div class="headtop">
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname">
    </div>
    <div class="coverPictureSchool">
    
    </div>	  <h3><i class="fa fa-angle-right"></i> EVENTS...</h3>
		  		<div class="row mt">
			  	     <div class="content-panel">
                     
                          <section id="unseen">
                            <asp:table runat="server" class="table table-bordered table-striped table-condensed table-responsive">
   <asp:TableRow>

       <asp:TableCell RowSpan="5" CssClass="text-center"><asp:Image runat="server" ID="img" ImageUrl="view-event.aspx?pid='Request[pid]'" Height="300px" Width="280px" CssClass="img-rounded" /><asp:Label runat="server" ID="lb"></asp:Label></asp:TableCell>
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
                                    <asp:TableCell><asp:Label runat="server" ID="lblschool"></asp:Label></asp:TableCell>

                                </asp:TableRow>




                                </asp:table></section></div>
                                
                                 <div class="row mt">
			  		<div class="col-lg-8">
                      <div class="content-panel">
                     	<h3><i class="fa fa-angle-right"></i> Photos...</h3>
		  
          <asp:DataList ID="rptitem" class="list-group-item" RepeatColumns="5" RepeatLayout="Flow" RepeatDirection="Horizontal" runat="server">
          
          <ItemTemplate>
            <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Parent/zoom.aspx?id={0}") %>'>          
          <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("pic","../Teacher/pic/{0}") %>'  Height="120px" Width="130px"></asp:Image>
          </asp:HyperLink>
          </ItemTemplate>
          
          </asp:DataList>
                               
                                
                                </div></div></section></section>

</asp:Content>

