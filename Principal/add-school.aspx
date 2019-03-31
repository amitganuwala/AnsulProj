<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="add-school.aspx.cs" Inherits="add_school" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SCHOOL INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                  	 
                      <form class="form-inline" role="form">
                          <div class="form-group"> 
                             <asp:Label runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                              
                                </div>
                          
                          <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="School Photo:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:FileUpload ID="FileUpload1" runat="server" />
                         <asp:TextBox runat="server" ID="txtpic" Visible="false"></asp:TextBox>
                          </div>
                         <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" OnClick="btnadd_Click" />
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	
          	
		</section><! --/wrapper -->
      </section><!-- /MAIN CONTENT -->

      <!--main content end-->
     
</asp:Content>

