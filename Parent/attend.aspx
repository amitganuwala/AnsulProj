<%@ Page Title="" Language="C#" MasterPageFile="~/parent/MasterPage.master" Debug="true" AutoEventWireup="true" CodeFile="attend.aspx.cs" Inherits="arent_att" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   
<div id="mainSchool">
	
    	<!--<div class="col-sm-1 col-md-1 col-xs-1 col-lg-1"><span class="glyphicon glyphicon-menu-hamburger"> </span></div>-->
        <span class="glyphicon glyphicon-menu-hamburger" onclick="openNav()"> </span> <span class="schoolname"> </span>	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		
          			<div class="form-panel">

                           <asp:Label runat="server" ID="lblclass" Visible="false"></asp:Label>
                          <asp:Label runat="server" ID="lblstdnm" Visible="false" ></asp:Label>
                         <div class="col-lg-6 right">
                       
                            <h2><asp:Label runat="server" ID="lblsch" ForeColor="Black"></asp:Label></h2>
                        <br /><br />
                        <asp:Calendar ID="Calendar1" runat="server" 
                                 onselectionchanged="Calendar1_SelectionChanged" BackColor="White" 
                                 BorderColor="#6666FF" BorderStyle="Dotted" BorderWidth="2px" Font-Names="Arial" 
                                 Font-Size="X-Large" ForeColor="#000066" Height="350px" Width="1000px">
                            <DayHeaderStyle CssClass="text-center" />
                             </asp:Calendar>
        <asp:Label ID="dt" runat="server" Visible="true" ></asp:Label>

        <br /><br />

        </div></div></div>
        <div class="row">
        
        
        	<div class="col-lg-6">
        
    	<div class="homeworkstyle">
        <br /><br />
               
                  <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" RepeatColumns="1" >
                        <ItemTemplate>
                        <div class="panel-group" id="accordion">
                
                          <div class="panel panel-default accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse0" aria-expanded="true"> 
   <div class=" heading ">   
  <div class="row">
    <div class=" col-lg-6 text-left"><%# Eval("class") %></div>
     <div class=" col-lg-6 text-right"><%# Eval("date") %></span></div></div>
     <div class=" heading1 text-center "> 
      <span><h4><b><%# Eval("daay") %></b></h4></span> 
      </div>
      </div>
       <div id="collapse0" class="panel-collapse collapse in" aria-expanded="true" style=""> 
         <div class="panel-body text-center "><%# Eval("status") %><br /> </div>
          </div></div>
   

                      </ItemTemplate></asp:DataList>
                      </div></div>
                      
                      
                      
                      
                              	<div class="col-lg-4">
        
    	<div class="homeworkstyle">
        <br /><br />
               
                  <!-- First Action -->
                    <asp:DataList class="list" ID="DataList1" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" RepeatColumns="1" >
                        <ItemTemplate>
                        <div class="panel-group" id="accordion">
                
                          <div class="panel panel-default accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse0" aria-expanded="true"> 
   <div class=" heading ">   
  <div class="row">
    <div class=" col-lg-6 text-left"><%# Eval("adddt") %></div>
     <div class=" col-lg-6 text-right"><%# Eval("class") %></span></div></div>
     <div class=" heading1 text-center "> 
      <span><h4><b><%# Eval("subject") %></b></h4></span> 
      </div>
      </div>
       <div id="collapse0" class="panel-collapse collapse in" aria-expanded="true" style=""> 
         <div class="panel-body  text-center"><%# Eval("reason") %><br />From <%# Eval("datest") %>  To <%# Eval("datetl") %> </div>
          </div></div>
   

                      </ItemTemplate></asp:DataList>
                      </div></div>


                      
                              	<div class="col-lg-4">
        
    	<div class="homeworkstyle">
        <br /><br />
               
                  <!-- First Action -->
                    <asp:DataList class="list" ID="DataList2" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" RepeatColumns="1" >
                        <ItemTemplate>
                        <div class="panel-group" id="accordion">
                
                          <div class="panel panel-default accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse0" aria-expanded="true"> 
   <div class=" heading ">   
  <div class="row">
    <div class=" col-lg-6 text-left"><%# Eval("adddt") %></div>
     <div class=" col-lg-6 text-right"><%# Eval("class") %></span></div></div>
     <div class=" heading1 "> 
      <span><h4><b><%# Eval("subject") %></b></h4></span> 
      </div>
      </div>
       <div id="collapse0" class="panel-collapse collapse in" aria-expanded="true" style=""> 
         <div class="panel-body "><%# Eval("reason") %><br />From <%# Eval("datest") %>  To <%# Eval("datetl") %> </div>
          </div></div>
   

                      </ItemTemplate></asp:DataList>
                      

</div></div></div>

        
        </div>
        
                            <asp:Label runat="server" ID="status"></asp:Label>
                        </div>


                       </div></div></div>  


</asp:Content>

