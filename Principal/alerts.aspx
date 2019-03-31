<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="alerts.aspx.cs" Inherits="Principal_alerts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <section id="main-content">
          <section class="wrapper">
          
          	
          <div class="row">
          		<div class="col-lg-12">
          			<div class="form-panel">
                    	<div class="form-panel">
                           <asp:Label runat="server" ID="lblprinm" Visible="false" ></asp:Label>
                         <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                       
                    
                                    <h4><i class="fa fa-angle-right"></i> Alert Information</h4>
            <br /><br />

            <asp:Button ID="btn" class="btn btn-primary btn-success" runat="server" onclick="btn_Click" Text="Add Alerts" />
            <br /><br />
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" 
                                        runat="server" AutoGenerateColumns="False" AllowSorting="True" 
                                        DataSourceID="SqlDataSource1" DataKeyNames="id">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                      ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="tname" HeaderText="tname" SortExpression="tname" />
                                  <asp:BoundField DataField="msg" HeaderText="msg" SortExpression="msg" />
                                  <asp:BoundField DataField="school" HeaderText="school" 
                                      SortExpression="school" />
                                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                  <asp:CommandField ShowEditButton="True" />
                              </Columns>
            
            </asp:GridView>

                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConflictDetection="CompareAllValues" 
                                ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                                DeleteCommand="DELETE FROM [alert] WHERE [id] = @original_id AND [tname] = @original_tname AND [msg] = @original_msg AND [school] = @original_school AND [date] = @original_date" 
                                InsertCommand="INSERT INTO [alert] ([tname], [msg], [school], [date]) VALUES (@tname, @msg, @school, @date)" 
                                OldValuesParameterFormatString="original_{0}" 
                                SelectCommand="SELECT * FROM [alert] WHERE ([school] = @school) ORDER BY [id] DESC" 
                                UpdateCommand="UPDATE [alert] SET [tname] = @tname, [msg] = @msg, [school] = @school, [date] = @date WHERE [id] = @original_id AND [tname] = @original_tname AND [msg] = @original_msg AND [school] = @original_school AND [date] = @original_date">
                                        <DeleteParameters>
                                            <asp:Parameter Name="original_id" Type="Int32" />
                                            <asp:Parameter Name="original_tname" Type="String" />
                                            <asp:Parameter Name="original_msg" Type="String" />
                                            <asp:Parameter Name="original_school" Type="String" />
                                            <asp:Parameter Name="original_date" Type="String" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="tname" Type="String" />
                                            <asp:Parameter Name="msg" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                            <asp:Parameter Name="date" Type="String" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                                Type="String" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="tname" Type="String" />
                                            <asp:Parameter Name="msg" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                            <asp:Parameter Name="date" Type="String" />
                                            <asp:Parameter Name="original_id" Type="Int32" />
                                            <asp:Parameter Name="original_tname" Type="String" />
                                            <asp:Parameter Name="original_msg" Type="String" />
                                            <asp:Parameter Name="original_school" Type="String" />
                                            <asp:Parameter Name="original_date" Type="String" />
                                        </UpdateParameters>
                            </asp:SqlDataSource>

            </div></div></div>
            </section></section>
</asp:Content>

