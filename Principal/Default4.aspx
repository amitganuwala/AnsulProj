<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Principal_Default" %>

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
                           WELCOME <asp:Label runat="server" ID="lblprinm" Font-Size="Larger"></asp:Label>....!
                 
                          </div></div></div>

              
                <div class="row">
                  <div class="col-lg-12 main-chart">
                  
                  	<div class="row mtbox">
                  		<div class="col-md-2 col-sm-2 col-md-offset-1 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image1" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/event.png" />
					  			<a href="addevent.aspx"><h3>Add Events</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image5" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/notice.png" />
					  			<a href="addnotice.aspx"><h3>Add Notice</h3></a>
                  			</div>
					  			
                  		</div>
                          <div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image7" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/view-event.png" />
					  			<a href="event-list.aspx"><h3>View Events</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image8" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/view-notice.png" />
					  			<a href="notice-list.aspx"><h3>View Notice</h3></a>
                  			</div>
                  		</div>
                         <div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image11" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/get-money.png" />
					  			<a href="addfees.aspx"><h3>Add Fees</h3></a>
                  			</div>
					  			
                  	</div><!-- /row mt -->	
</div>


                      <div class="row mtbox">
                  		<div class="col-md-2 col-sm-2 col-md-offset-1 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image9" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/school.png" />
					  			<a href="add-school.aspx"><h3>Add School Info</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image12" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/fees.png" />
					  			<a href="allot-subject.aspx"><h3>Allot Subject to Teacher</h3></a>
                  			</div>
					  			
                  		</div>
                          <div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image13" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/transfer.png" />
					  			<a href="addsubject.aspx"><h3>Add Subject</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image14" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/school.png" />
					  			<a href="view-sch.aspx"><h3>View School Info</h3></a>
                  			</div>
                  		</div>
                         <div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image15" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/teacher.png" />
					  			<a href="addteacher.aspx"><h3>Add Teacher</h3></a>
                  			</div>
					  			
                  	</div><!-- /row mt -->	
</div>


                      <div class="row mtbox">
                  		<div class="col-md-2 col-sm-2 col-md-offset-1 box0">
                  		<div class="box1">
					  		<asp:Image ID="Image6" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/timetable.png" />
					  			<a href="timetable.aspx"><h3>View Timetable</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image10" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/student-profile.png" />
					  			<a href="view.aspx"><h3>View Students</h3></a>
                  			</div>
					  			
                  		</div>
                          
                  		
                          <div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image2" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/homework.png" />
					  			<a href="addclass-section.aspx"><h3>Add Class</h3></a>
                  			</div>
					  			
                  		</div>
                  		<div class="col-md-2 col-sm-2 box0">
                  			<div class="box1">
					  			<asp:Image ID="Image3" runat="server" Height="100px" Width="90px" ImageUrl="~/Principal/icons/student.png" />
					  			<a href="viewtch.aspx"><h3>View Teacher</h3></a>
                  			</div>
                  		</div>
                          <div class="col-md-2 col-sm-2 box0">
                  			
                  		</div>
                  		
               
                  	</div><!-- /row mt -->	
     </div></div></section></section>



</asp:Content>