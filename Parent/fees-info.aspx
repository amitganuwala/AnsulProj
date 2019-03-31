<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" AutoEventWireup="true" CodeFile="fees-info.aspx.cs" Inherits="parent_fees_info" %>

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
    
    </div>
    <div class="quickview row">
    <div class="col-lg-4 col-sm-4 col-md-4 col-xs-4 seprationquickview">
        	<div class="heading text-center">FEES INFORMATION.. <i class="glyphicon glyphicon-bookmark fa-fw w3-margin-right indicategly"></i></div>
             <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
            
            <div class="">
                
                
                <h6><%# Eval("type") %></h6>
            <h5 style="color: #6699FF"><%# Eval("fees") %></h5>
             <p class="right"> Last date to pay fees is </p>
                 <asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","../Parent/view-event.aspx?id={0}") %>'>View</asp:HyperLink>
            <hr />
   </div></ItemTemplate></asp:DataList></div></div></div></div>
 
</asp:Content>

