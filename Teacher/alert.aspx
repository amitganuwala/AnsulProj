<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="alert.aspx.cs" Inherits="Teacher_alert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ALERTS....</h3>
          	<p class="category">Some Tasks from the Principal</p>
          	<!-- INLINE FORM ELELEMNTS -->
 
                  <div class="col-lg-9 main-chart">
                  
          <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
                  <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>List of Alerts....</h3>
                                        
                      <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
                   <div class="desc">
                      	<div class="thumb">
                      		<span class="badge bg-theme"><i class="fa fa-clock-o"></i></span>
                      	</div>
                      	<div class="details">
                    <p> <%#Eval("msg") %></p>
                              <p> <%#Eval("date") %></p>
                            


  </div></div></ItemTemplate></asp:DataList>

        </div></div></div></div>
        </section></section>
</asp:Content>

