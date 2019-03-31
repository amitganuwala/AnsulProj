<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="attendance.aspx.cs" Inherits="Principal_attendance" %>

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
                  	 
                            <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" AllowSorting="True" DataKeyNames="id" DataSourceID="SqlDataSource1">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                    <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                    <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
                                </Columns>
                            </asp:GridView>
    
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" DeleteCommand="DELETE FROM [student] WHERE [id] = @original_id AND [name] = @original_name AND [class] = @original_class AND [school] = @original_school" InsertCommand="INSERT INTO [student] ([name], [class], [school]) VALUES (@name, @class, @school)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [id], [name], [class], [school] FROM [student] ORDER BY [name]" UpdateCommand="UPDATE [student] SET [name] = @name, [class] = @class, [school] = @school WHERE [id] = @original_id AND [name] = @original_name AND [class] = @original_class AND [school] = @original_school">
                                <DeleteParameters>
                                    <asp:Parameter Name="original_id" Type="Int32" />
                                    <asp:Parameter Name="original_name" Type="String" />
                                    <asp:Parameter Name="original_class" Type="String" />
                                    <asp:Parameter Name="original_school" Type="String" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="name" Type="String" />
                                    <asp:Parameter Name="class" Type="String" />
                                    <asp:Parameter Name="school" Type="String" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="name" Type="String" />
                                    <asp:Parameter Name="class" Type="String" />
                                    <asp:Parameter Name="school" Type="String" />
                                    <asp:Parameter Name="original_id" Type="Int32" />
                                    <asp:Parameter Name="original_name" Type="String" />
                                    <asp:Parameter Name="original_class" Type="String" />
                                    <asp:Parameter Name="original_school" Type="String" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
    
                          </div></div></div>

              </section></section>
</asp:Content>

