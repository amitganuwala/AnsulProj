<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="teacher.aspx.cs" Inherits="Principal_teacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


   <section id="main-content">
          <section class="wrapper site-min-height">
          	<h3><i class="fa fa-angle-right"></i> Teacher Profile</h3>
         <div class="row">
				<!-- WEATHER-2 PANEL -->
						<div class="col-lg-6 ">
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
									<asp:Image runat="server" Id="img" class="img-circle" width="120" />			
								</div>
								<div class="row data">
									<div class="col-sm-6 col-xs-6 goleft">
										<br /><br /><h4><b><asp:Label runat="server" ID="lblname"></asp:Label></b></h4>
										<h6><asp:Label runat="server" ID="lblpost"></asp:Label></h6>
										
									</div>
									<div class="col-sm-6 col-xs-6 goright">
										<br /><br />
										<h6><b><asp:Label runat="server" ID="lbladdr"></asp:Label></b></h6>
										<h5><asp:Label runat="server" ID="lblmob"></asp:Label></h5>
									</div>
								</div>
							</div>
						</div><!--/col-md-4 -->
         		<div class="col-lg-5">
          			<div class="form-panel">
                  	 	
                      <form class="form-inline" role="form">
                          
                          <div class="form-group">
                             <asp:Label ID="Label3" runat="server" Text="Update Mobile No. : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtmob" placeholder="Example :- Your mobile no."></asp:TextBox>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Update Address:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtaddr" placeholder="Example :- Your address"></asp:TextBox>
                          </div>
                          <div class="form-group">
                             <asp:Label ID="Label5" runat="server" Text="Change Password: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtpass" TextMode="Password" placeholder="Example :- Your password"></asp:TextBox>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label6" runat="server" Text="Confirm Password:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtcpass" TextMode="Password" placeholder="Example :- Same password as above"></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" OnClick="btnadd_Click" />
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->

			</div>
              <br /><br />
						<div class="col-lg-6 ">
                             
							<!-- WHITE PANEL - TOP USER -->
							<div class="white-panel pn">
								<div class="white-header">
									<h3>Subject Information</h3>
								</div>
                                <div class="content-panel">
                                 <asp:DataList class="list" ID="rptitem" runat="server"  RepeatLayout="flow" >
                                      <ItemTemplate>
              
									<div class="row">
										<div class="col-md-6">
											<p class="small mt">Class -</p>
											<p><h4><%# Eval("class") %></h4></p>
										</div>
										<div class="col-md-6">
											<p class="small mt">Subject -</p>
											<p><h4><%# Eval("subject") %></h4></p>
										</div>
									</div>
                                          <hr />
                                      </ItemTemplate>    
                                    </asp:DataList>
							</div>
						</div><!-- /col-md-4 -->
					</div>


          </section></section>


</asp:Content>

