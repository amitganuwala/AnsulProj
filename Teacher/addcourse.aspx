<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="addcourse.aspx.cs" Inherits="Teacher_addcourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD COURSE...</h3>
          	  <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                      <asp:Label runat="server" ID="lblday" Font-Bold="true" Font-Size="Larger" ForeColor="Black" Visible="false"></asp:Label>
                        	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
      <asp:Label runat="server" ID="Label1" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="Label8" Visible="false"></asp:Label>
                       
                      <div class="row">
                      <div class="col-lg-10">
                      <form class="form-inline" role="form">
                          <div class="form-group">
                                  <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:DropDownList ID="DropDownList2" runat="server"  AutoPostBack="true"
                                  DataSourceID="SqlDataSource1" DataTextField="class" DataValueField="class"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                  ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                  SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school)">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                          Type="String" />
                                  </SelectParameters>
                              </asp:SqlDataSource>
                         </div>
                          <div class="form-group">
                         <asp:Label ID="Label3" runat="server" Text="Subject:" Font-Bold="true" ForeColor="Black"></asp:Label>
                             <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server" DataSourceID="SqlDataSource3" DataTextField="subject" DataValueField="subject"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [subject] FROM [subject] WHERE (([name] = @name) AND ([school] = @school))">
                                    <SelectParameters>
                                        
                                        <asp:ControlParameter ControlID="lbltchnm" Name="name" PropertyName="Text" Type="String" />
                                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                    </SelectParameters>
                                    </asp:SqlDataSource>
                                </div>
                          <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Timing : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <div class="row">
                              <div class="col-lg-3">
                                <asp:TextBox runat="server" class="form-control" id="txttime1" ></asp:TextBox>
                               </div>
                               <div class="col-lg-2">
                               <asp:DropDownList ID="DropDownList1" runat="server">
                                   <asp:ListItem Value="am"></asp:ListItem>
                                   <asp:ListItem Value="pm"></asp:ListItem>
                                   </asp:DropDownList>
                               </div>
                               <div class="col-lg-3">
                                <asp:TextBox runat="server" class="form-control" id="txttime2" ></asp:TextBox>
                               </div>
                               <div class="col-lg-2">
                               <asp:DropDownList ID="DropDownList4" runat="server">
                                   <asp:ListItem Value="am"></asp:ListItem>
                                   <asp:ListItem Value="pm"></asp:ListItem>
                                   </asp:DropDownList>
                               </div>
                          </div>
                          </div>
                          <div class="form-group">
                                <asp:Label ID="Label5" runat="server" Text="Course:" Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtcourse" ></asp:TextBox>
                          </div>
                          </div>
                          <div class="form-group">
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" 
                                  onclick="btnadd_Click"  />
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
          	
</div>
              	
          	</div></div></div>
		</section><! --/wrapper -->
      </section><!-- /MAIN CONTENT -->



</asp:Content>

