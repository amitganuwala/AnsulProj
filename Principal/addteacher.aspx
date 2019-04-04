<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="addteacher.aspx.cs" Inherits="HOD_addteacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD TEACHER INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	     <h3><asp:Label Visible="false" runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                      <div class="row">
                      <div class="col-lg-5">
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Teacher Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtname" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Post:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtpost" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                             <asp:Label ID="Label3" runat="server" Text="Mobile No. : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtmob" MaxLength="10" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label4" runat="server" Text="Address:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtaddr" ></asp:TextBox>
                          </div>
                          </div>
                          <div class="col-lg-5">
                           <div class="form-group">
                                <asp:Label ID="Label7" runat="server" Text="Username:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtusr" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                             <asp:Label ID="Label5" runat="server" Text="Password: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtpass" TextMode="Password" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label6" runat="server" Text="Confirm Password:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtcpass" TextMode="Password" ></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" OnClick="btnadd_Click"  />
                          </div>
                          </div>
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	

              	
          	</div></div></div>
		</section><! --/wrapper -->
      </section><!-- /MAIN CONTENT -->

      <!--main content end-->
    

</asp:Content>

