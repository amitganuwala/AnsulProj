<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="addfees.aspx.cs" Inherits="HOD_addfees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD FEES INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-6">
          			<div class="form-panel">
                  <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3> 	 
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Select Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              
          	<asp:DropDownList ID="DropDownList1" class="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="class" DataValueField="class"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id]">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
              </asp:SqlDataSource>
                       
                              
                                 </div>
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Add Fees Amount: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:TextBox runat="server" class="form-control" id="txtfees" placeholder="Example :- 15000/-"></asp:TextBox>
                          </div>
                          <div class="form-group">
                             <asp:Label ID="Label3" runat="server" Text="Add Fees Type: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:TextBox runat="server" class="form-control" id="txttype" placeholder="Example :- Admission Fees"></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" OnClick="btnadd_Click" />
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
                  
                 

          	<div class="col-lg-5">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Fees Information</h4>
            
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource4" AllowSorting="True">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="class" HeaderText="Class" SortExpression="class" />
                                  <asp:BoundField DataField="fees" HeaderText="Fees Amount" SortExpression="fees" />
                                  <asp:BoundField DataField="type" HeaderText="Type" SortExpression="type" />
                                  <asp:BoundField DataField="school" HeaderText="School" SortExpression="school" />
                              </Columns>
                                    </asp:GridView>
		                            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" DeleteCommand="DELETE FROM [fees] WHERE [id] = @original_id AND [class] = @original_class AND [fees] = @original_fees AND [type] = @original_type AND [school] = @original_school" InsertCommand="INSERT INTO [fees] ([class], [fees], [type], [school]) VALUES (@class, @fees, @type, @school)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [id], [class], [fees], [type], [school] FROM [fees] WHERE ([school] = @school) ORDER BY [id] DESC" UpdateCommand="UPDATE [fees] SET [class] = @class, [fees] = @fees, [type] = @type, [school] = @school WHERE [id] = @original_id AND [class] = @original_class AND [fees] = @original_fees AND [type] = @original_type AND [school] = @original_school">
                                        <DeleteParameters>
                                            <asp:Parameter Name="original_id" Type="Int32" />
                                            <asp:Parameter Name="original_class" Type="String" />
                                            <asp:Parameter Name="original_fees" Type="String" />
                                            <asp:Parameter Name="original_type" Type="String" />
                                            <asp:Parameter Name="original_school" Type="String" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="class" Type="String" />
                                            <asp:Parameter Name="fees" Type="String" />
                                            <asp:Parameter Name="type" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="class" Type="String" />
                                            <asp:Parameter Name="fees" Type="String" />
                                            <asp:Parameter Name="type" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                            <asp:Parameter Name="original_id" Type="Int32" />
                                            <asp:Parameter Name="original_class" Type="String" />
                                            <asp:Parameter Name="original_fees" Type="String" />
                                            <asp:Parameter Name="original_type" Type="String" />
                                            <asp:Parameter Name="original_school" Type="String" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
            </div></div>
          		</div>
                             
		</section><!--/wrapper -->
      </section><!-- /MAIN CONTENT -->



      <!--main content end-->

     

</asp:Content>

