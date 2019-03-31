<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="Teacher_update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    

   <section id="main-content">
          <section class="wrapper site-min-height">
          	<h3><i class="fa fa-angle-right"></i> Update Profile</h3>
          			<div class="form-panel">
                  	 	
                      <form class="form-inline" role="form">
                            <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                         <asp:Label runat="server" ID="lblid"  ></asp:Label>
                       
         <div class="row">
				<!-- WEATHER-2 PANEL -->
   <div class="col-lg-4">
                       
                          <div class="form-group">
                             <asp:Label ID="Label3" runat="server" Text="Update Mobile No. : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtmob"></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnmob" Text="Update" OnClick="btnmob_Click" />
                   
          		
          		</div><!-- /col-lg-12 -->
       <div class="col-lg-4">
          		          <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Update Address:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtaddr" ></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Update" OnClick="btnadd_Click" />
                 
          			</div><!-- /form-panel -->
          		
        <div class="col-lg-4">
          			<div class="form-panel">
                  	 	
                          <div class="form-group">
                             <asp:Label ID="Label5" runat="server" Text="Change Password: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtpass" TextMode="Password" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label6" runat="server" Text="Change User ID:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtusr" TextMode="Password" ></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnpass" Text="Change" OnClick="btnpass_Click" />
                     
          			</div>
          		</div><!-- /col-lg-12 -->

        <div class="col-lg-4">
          			<div class="form-panel">
                  	 	
                    
                          <div class="form-group">
                                <asp:Label ID="Label8" runat="server" Text="Change Profile Pic:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:FileUpload ID="FileUpload1" runat="server" />
                              <asp:TextBox runat="server" class="form-control" id="txtpic" Visible="false" ></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnpic" Text="Add Information" OnClick="btnpic_Click" />
                   
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->

        
        
         </div>

         </form></div>
     </section></section>




</asp:Content>

