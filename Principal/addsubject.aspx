<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="addsubject.aspx.cs" Inherits="Principal_addsubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SUBJECT...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-5">
          			<div class="form-panel">
                  	   <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Subject Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtsnm" placeholder="Example :- English"></asp:TextBox>
                          </div>
                             <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" OnClick="btnadd_Click"/>
                          </form>
    </div></div>

                	
           
          		<div class="col-lg-6">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Subject Information</h4>
                                    <p>&nbsp;</p>
                                    <p>
                                        <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-advance table-hover" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                                            <Columns>
                                                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                                <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                                <asp:BoundField DataField="snm" HeaderText="Subject Name" SortExpression="snm" />
                                                <asp:BoundField DataField="school" HeaderText="School" SortExpression="school" />
                                            </Columns>
                                        </asp:GridView>
<%--                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%# ClsVariable.ConnectionString%>" DeleteCommand="DELETE FROM [subject-info] WHERE [snm] = @original_snm AND [id] = @original_id AND (([school] = @original_school) OR ([school] IS NULL AND @original_school IS NULL))" InsertCommand="INSERT INTO [subject-info] ([snm], [school]) VALUES (@snm, @school)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [subject-info] WHERE ([school] = @school) ORDER BY [id] DESC" UpdateCommand="UPDATE [subject-info] SET [id] = @id, [school] = @school WHERE [snm] = @original_snm AND [id] = @original_id AND (([school] = @original_school) OR ([school] IS NULL AND @original_school IS NULL))">
                                            <DeleteParameters>
                                                <asp:Parameter Name="original_snm" Type="String" />
                                                <asp:Parameter Name="original_id" Type="Int32" />
                                                <asp:Parameter Name="original_school" Type="String" />
                                            </DeleteParameters>
                                            <InsertParameters>
                                                <asp:Parameter Name="snm" Type="String" />
                                                <asp:Parameter Name="school" Type="String" />
                                            </InsertParameters>
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                            </SelectParameters>
                                            <UpdateParameters>
                                                <asp:Parameter Name="id" Type="Int32" />
                                                <asp:Parameter Name="school" Type="String" />
                                                <asp:Parameter Name="original_snm" Type="String" />
                                                <asp:Parameter Name="original_id" Type="Int32" />
                                                <asp:Parameter Name="original_school" Type="String" />
                                            </UpdateParameters>
                                        </asp:SqlDataSource>--%>
                                    </p>
            

                          </div></div></div>
            


          </section></section>

</asp:Content>

