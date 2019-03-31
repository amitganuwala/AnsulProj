<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="School_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <section id="main-content">
          <section class="wrapper">
              <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                           <asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
                          <br />
                           WELCOME <asp:Label runat="server" ID="lbltchnm" Font-Size="Larger"></asp:Label>....!
                 
                          </div></div></div>


              <div class="row">
                  <div class="col-lg-12 main-chart">
                  			
                  
                  	<div class="row mtbox">
                  		<div class="col-md-2 col-sm-2 col-md-offset-1 box0">
                  			
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/view-event.png" />
					  			<a href="event-list.aspx"><h3>View Events</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/view-notice.png" />
					  			<a href="notice-list.aspx"><h3>View Notice</h3></a>
                  			</div>
                  		</div>
                          
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/student-profile.png" />
					  			<a href="view.aspx"><h3>View Students</h3></a>
                  			</div>
					  			
                  		</div>
                 </div>
                  	</div><!-- /row mt -->	
     </div>
                  </div>
                  </section></section>

</asp:Content>