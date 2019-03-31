<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="Teacher_upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD STUDENT's INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                  	 
                      <form class="form-inline" role="form">
                          <div class="form-group"> 
                             <asp:Label ID="Label1" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                              
                                </div>
                          
                          <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Select Excel File:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:FileUpload ID="FileUpload1" runat="server" />
                         
                          </div>
            <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Show Data" OnClick="btnadd_Click" />             
                         <br />
                         <asp:RadioButtonList ID="rbHDR" runat="server">
                                <asp:ListItem Text="Yes" Value="Yes" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="No" Value="No"></asp:ListItem>
                         </asp:RadioButtonList>
                      </form>
          			</div><!-- /form-panel -->
                    <br /><br /><asp:Button runat="server" class="btn btn-theme" ID="btn" Text="Submit Data" OnClick="btn_Click" /><br /><br />
                      <asp:GridView ID="GridView1" runat="server"></asp:GridView>

          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	
          	
		</section><!--/wrapper -->
      </section><!-- /MAIN CONTENT -->

      <!--main content end-->


</asp:Content>

