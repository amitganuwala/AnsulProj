<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="teacher.aspx.cs" Inherits="Teacher_teacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


   <section id="main-content">
          <section class="wrapper site-min-height">
          	<h3><i class="fa fa-angle-right"></i> Teacher Profile</h3>


<div>

         <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Update Profile" OnClick="btnadd_Click" />

</div>


         <div class="row">
				<!-- WEATHER-2 PANEL -->
             
             <div class="col-lg-6 main-chart">
						
							<div class="weather-2 pn">
								<div class="weather-2-header">
									<div class="row">
										<div class="col-sm-6 col-xs-6">
											<p><h3><asp:Label runat="server" CssClass="text-capitalize" ID="lblsch"></asp:Label></h3></p>
										</div>
										<div class="col-sm-6 col-xs-6 goright">
											<p class="small"><asp:Label runat="server" ID="id"></asp:Label></p>
										</div>
									</div>
								</div><!-- /weather-2 header -->
								<div class="row centered">
									<asp:Image ID="img" runat="server" ImageUrl class="img-circle" width="80px" Height="90px" />			
								</div>
								<div class="row data">
                                <div class="col-lg-10 ds">
									<div class="col-sm-6 col-xs-6 goleft">
										<br /><br /><h4><b><asp:Label runat="server" ID="lblname"></asp:Label></b></h4>
										<h6><asp:Label runat="server" ID="lblpost"></asp:Label></h6>
                                        <h6>Username- &nbsp;<asp:Label runat="server" ID="lblusr"></asp:Label></h6>
										
									</div>
									<div class="col-sm-6 col-xs-6 goright">
										<br /><br />
										<h6><b><asp:Label runat="server" ID="lbladdr"></asp:Label></b></h6>
										<h5><asp:Label runat="server" ID="lblmob"></asp:Label></h5>
                                        <h6>Password- &nbsp;<asp:Label runat="server" ID="lblpass"></asp:Label></h6>
									</div>
								</div>
                                </div>
							</div>
						</div><!--/col-md-4 -->
         	
          
                  <div class="col-lg-6 main-chart">
                <div class="col-lg-10 ds">
                    <!--COMPLETED ACTIONS DONUTS CHART-->
						<h3>SUBJECT INFORMATION</h3>
                                        
                      <!-- First Action -->
                    <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" RepeatDirection="Vertical" >
                        <ItemTemplate>
                   <div class="desc">
                      	<div class="thumb">
                      	</div>
                      	<div class="details">
  							<div class="col-md-6">
											<p class="small mt">Class -</p>
											<p><h4><%# Eval("class") %></h4></p>
										</div>
                                    </div>
                                    <div class="details">
										<div class="col-md-6">
											<p class="small mt">Subject -</p>
											<p><h4><%# Eval("subject") %></h4></p>
										</div>
									</div>
                                 </div>
                                      </ItemTemplate>    
                                    </asp:DataList>
							</div>
						</div><!-- /col-md-4 -->
					

</div>



           
          </section></section>


</asp:Content>

