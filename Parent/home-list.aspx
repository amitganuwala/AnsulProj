<%@ Page Title="" Language="C#" MasterPageFile="~/Parent/MasterPage.master" AutoEventWireup="true" CodeFile="home-list.aspx.cs" Inherits="Teacher_event_list" %>

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
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname">HOMEWORK
    </div>
  
    	<div class="homeworkstyle">
        <br /><br />
        	<div class="col-lg-6">
        
               
                  <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" RepeatColumns="1" >
                        <ItemTemplate>
                        <div class="panel-group" id="accordion">
                
                          <div class="panel panel-default accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse0" aria-expanded="true"> 
   <div class=" heading ">   
  <div class="row">
    <div class=" col-lg-6 text-left"><%# Eval("addtch") %></div>
     <div class=" col-lg-6 text-right"><%# Eval("adddate") %></span></div></div>
     <div class=" heading1 "> 
      <span><h4><b><%# Eval("subject") %></b></h4></span> 
      </div>
      </div>
       <div id="collapse0" class="panel-collapse collapse in" aria-expanded="true" style=""> 
         <div class="panel-body "><%# Eval("hw") %><br /><%# Eval("subdate") %> </div>
          </div></div>
   

                      </ItemTemplate></asp:DataList>
                      </div></div></div></div></div>

</asp:Content>

    