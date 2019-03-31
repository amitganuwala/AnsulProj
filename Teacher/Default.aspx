<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Teacher_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <section id="main-content">
          <section class="wrapper">
              <div class="row mt">
          		<div class="col-lg-12">
          			
                           <asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
                          <br />
                           WELCOME <asp:Label runat="server" ID="lbltchnm" Font-Size="Larger"></asp:Label>....!
                 
                          </div></div>


              <div class="row">
                  <div class="col-lg-12 main-chart">
                  
                  	<div class="row mtbox">
                  		<div class="col-md-2 col-sm-2 col-md-offset-1 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/event.png" />
					  			<a href="addevent.aspx"><h3>Add Events</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image1" runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/homework.png" />
					  			<a href="addhomework.aspx"><h3>Add Homework</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/student.png" />
					  			<a href="addstudent.aspx"><h3>Add Student</h3></a>
                  			</div>
                  		</div>
                          <div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/attendance.png" />
					  			<a href="attendance.aspx"><h3>Add Attendance</h3></a>
                  			</div>
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/notice.png" />
					  			<a href="addnotice.aspx"><h3>Add Notice</h3></a>
                  			</div>
					  			
                  		</div>
                  	</div><!-- /row mt -->	

                      <div class="row mtbox">
                  		<div class="col-md-2 col-sm-2 col-md-offset-1 box0">
                  		<div class="box1">
					  		<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/timetable.png" />
					  			<a href="add-timetable.aspx"><h3>Add Timetable</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
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
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/view-homework.png" />
					  			<a href="homework-list.aspx"><h3>View Homework</h3></a>
                  			</div>
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/student-profile.png" />
					  			<a href="view.aspx"><h3>View Students</h3></a>
                  			</div>
					  			<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image2" runat="server" Height="100px" Width="90px" ImageUrl="~/Teacher/icons/timetable.png" />
					  			<a href="view-timetable.aspx"><h3>View Timetable</h3></a>
                  			</div>
					  			
                  		</div>
                 </div>
                  	</div><!-- /row mt -->	
     </div></div></section></section>

</asp:Content>