<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="event-list.aspx.cs" Inherits="Principal_event_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <section id="main-content">
          <section class="wrapper">

              <div class="row">
                      <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                  <div class="col-lg-9 main-chart">
                  
         
                  <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>LIST OF EVENTS</h3>
                                        
                      <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
                   <div class="desc">
                      	<div class="thumb">
                      		<span class="badge bg-theme"><i class="fa fa-clock-o"></i></span>
                      	</div>
                      	<div class="details">
                      		<p> <%#Eval("title") %></p>
                              <p> <%#Eval("date") %></p>
                              <p><%# Eval("class") %></p>
                              <p><%# Eval("descr") %></p>
                              
                              <div class="right">
                              <asp:Table ID="Table1" Width="200px" runat="server"><asp:TableRow><asp:TableCell><asp:HyperLink runat="server" ID="Hyp" NavigateUrl='<%# Eval("id","~/Principal/view-event.aspx?id={0}") %>'>View Event's Full Information</asp:HyperLink></asp:TableCell></asp:TableRow></asp:Table>
                      	</div></div></div>
                      </ItemTemplate></asp:DataList>
                      </div></div></div></section></section>



</asp:Content>

