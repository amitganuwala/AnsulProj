<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" AutoEventWireup="true" CodeFile="gal.aspx.cs" Inherits="parent_gal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
    
              <div class="row">
                  <div class="col-lg-12 ">
                  
                      
                  <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>Photo Gallery</h3>

            <asp:DataList ID="rptitem" class="list-group-item" RepeatColumns="5" RepeatLayout="Flow" RepeatDirection="Horizontal" runat="server">
          
          <ItemTemplate>
  <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Parent/zoom.aspx?id={0}") %>'>
               
          <asp:Image ID="Image1" class="img" runat="server" ImageUrl='<%# Eval("pic","../Teacher/pic/{0}") %>' Style="cursor: pointer" OnClientClick="return LoadDiv(this.src);" Height="250px" Width="250px"></asp:Image>
               </asp:HyperLink>
          
          </ItemTemplate>
          
          </asp:DataList>
</div>
     </div></div></div></div></div>


</asp:Content>

