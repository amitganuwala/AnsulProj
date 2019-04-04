<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="addstudent.aspx.cs" Inherits="Teacher_addstudent" %>

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
                  	  <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Student Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtname" placeholder="Example :- Aman Shahu" required=""></asp:TextBox>
                          </div>
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:DropDownList runat="server" placeholder="Select Class" ID="ddlclass" CssClass="form-control" ></asp:DropDownList>
                          </div>
                          <div class="form-group">
                                               <asp:Label ID="Label4" runat="server" Text="Mobile: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtmob" placeholder="Example :- 9876543210" required=""></asp:TextBox>
        </div>
                            <asp:Button runat="server" class="btn btn-theme" ID="btnad" Text="Add Information" OnClick="btnad_Click"   />
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
    

                    
          </section></section>
</asp:Content>

