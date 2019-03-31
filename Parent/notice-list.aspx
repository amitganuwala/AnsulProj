<%@ Page Title="" Language="C#" MasterPageFile="~/Parent/MasterPage.master" AutoEventWireup="true" CodeFile="notice-list.aspx.cs" Inherits="Teacher_event_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<meta charset="utf-8" />
 <meta http-equiv="X-UA-Compatible" content="IE=edge" />
 <meta name="viewport" content="width=device-width, initial-scale=1" />
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="mainSchool">
  <div class="center-block text-center">
       <div class="headtop">
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname">
    </div>
    <div class="coverPictureSchool">
    
    </div>
        
         <asp:Label runat="server" ID="lblstdnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
              <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
                                     
          
    <div class="quickview row">
    	<div class="col-lg-4 col-sm-4 col-md-4 col-xs-12 seprationquickview">
        	<div class="heading">Notification <span class="glyphicon glyphicon-bell indicategly"></span></div>
           
               <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
            
            <div class="detailsindicate">
            	<h5><%# Eval("duedate") %></h5>
                <p><%# Eval("notice") %></p>
            </div><hr />
                      </ItemTemplate>
               </asp:DataList>
        </div>
        </div>


</asp:Content>

