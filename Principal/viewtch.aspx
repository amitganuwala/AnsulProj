<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="viewtch.aspx.cs" Inherits="Principal_viewtch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <section id="main-content">
          <section class="wrapper">
                  <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
              	
              <div class="row mt">
          		<div class="col-lg-10">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Teacher Information</h4>
                
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" AllowSorting="True">
                              <Columns>

                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    
                                  <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                                  <asp:BoundField DataField="post" HeaderText="Post" SortExpression="post" />
                                  <asp:BoundField DataField="addr" HeaderText="Address" SortExpression="addr" />
                                  <asp:BoundField DataField="mob" HeaderText="Mobile" SortExpression="mob" />
                                  <asp:BoundField DataField="pass" HeaderText="Password" SortExpression="pass" />
                                 
                                  
                              </Columns>
                                    </asp:GridView>
          	
		                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" InsertCommand="INSERT INTO [teacher] ([name], [post], [addr], [mob], [usr], [pass], [school]) VALUES (@name, @post, @addr, @mob, @usr, @pass, @school)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [teacher] WHERE ([school] = @school)" DeleteCommand="DELETE FROM teacher WHERE (usr = @original_usr)" UpdateCommand="UPDATE [teacher] SET [id] = @id, [name] = @name, [post] = @post, [addr] = @addr, [mob] = @mob, [pass] = @pass, [school] = @school WHERE [usr] = @original_usr">
                                        <DeleteParameters>
                                            <asp:Parameter Name="original_usr" Type="String" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="name" Type="String" />
                                            <asp:Parameter Name="post" Type="String" />
                                            <asp:Parameter Name="addr" Type="String" />
                                            <asp:Parameter Name="mob" Type="String" />
                                            <asp:Parameter Name="usr" Type="String" />
                                            <asp:Parameter Name="pass" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                            <asp:Parameter Name="name" Type="String" />
                                            <asp:Parameter Name="post" Type="String" />
                                            <asp:Parameter Name="addr" Type="String" />
                                            <asp:Parameter Name="mob" Type="String" />
                                            <asp:Parameter Name="pass" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                            <asp:Parameter Name="original_usr" Type="String" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
          	

                                 </div></div></div></section></section>

</asp:Content>

