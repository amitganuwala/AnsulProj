<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="add-alerts.aspx.cs" Inherits="Principal_add_alerts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <section id="main-content">
          <section class="wrapper ">
          	<h3><i class="fa fa-angle-right"></i>ADD ALERTS FOR THE TEACHERS...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
                          <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                  	 
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Teacher name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                         <asp:DropDownList ID="DropDownList1" AutoPostBack="true" class="form-control" runat="server"></asp:DropDownList>
                          </div>
                         <asp:GridView  Visible="false" ID="GridView1" runat="server" AutoGenerateColumns="False" >
                             <Columns>
                                 <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                             </Columns>
                          </asp:GridView>


                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:school_mateConnectionString5 %>" 
                              SelectCommand="SELECT [mob] FROM [teacher] WHERE (([school] = @school) AND ([name] = @name))">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                      Type="String" />
                                  <asp:ControlParameter ControlID="DropDownList1" Name="name" 
                                      PropertyName="SelectedValue" Type="String" />
                              </SelectParameters>
                          </asp:SqlDataSource>

                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Message / Task: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" TextMode="MultiLine" class="form-control" id="txttask" required=""></asp:TextBox>
                          </div>
                         
                          <asp:Button runat="server" class="btn btn-theme02" ID="btnadd" Text="Add Information" OnClick="btnadd_Click" />
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
</asp:Content>

