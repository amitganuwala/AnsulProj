<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="Principal_student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <section id="main-content">
          <section class="wrapper">

<div class="row mtbox">
                  		<div class="col-md-8 col-sm-8 ">
                  				 <div class="desc">
                      	<div class="thumb">
                      	    <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" ForeColor="Black"></asp:Label></h3>
                              <h4><asp:Label runat="server" ID="lblclass"></asp:Label></h4>
                  		</div>
    <br />
     
                      	<div class="thumb center-block centered">
                              <asp:GridView ID="GridView1" Width="100%" CssClass="table table-striped table-advance center-block centered" runat="server" 
                                  AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit1" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing1" OnRowUpdating="GridView1_RowUpdating1">
                                  <Columns>
                                      <asp:CommandField ShowEditButton="True" />
                                      <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                      <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                      <asp:BoundField DataField="usr" HeaderText="usr" SortExpression="usr" />
                                      <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                      <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                      <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                          ReadOnly="True" SortExpression="id" />
                                  </Columns>
                              </asp:GridView>
                  	
                            <%--  <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                  ConnectionString="<%$ ConnectionStrings:school_mateConnectionString5 %>" 
                                  SelectCommand="SELECT [name], [class], [usr], [pass], [mob], [id] FROM [parent] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [name]" 
                                  ConflictDetection="CompareAllValues" 
                                  DeleteCommand="DELETE FROM [parent] WHERE [id] = @original_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([class] = @original_class) OR ([class] IS NULL AND @original_class IS NULL)) AND [usr] = @original_usr AND [pass] = @original_pass AND (([mob] = @original_mob) OR ([mob] IS NULL AND @original_mob IS NULL))" 
                                  InsertCommand="INSERT INTO [parent] ([name], [class], [usr], [pass], [mob]) VALUES (@name, @class, @usr, @pass, @mob)" 
                                  OldValuesParameterFormatString="original_{0}" 
                                  UpdateCommand="UPDATE parent SET usr = @usr WHERE (id = @original_id)">
                                  <DeleteParameters>
                                      <asp:Parameter Name="original_id" Type="Int32" />
                                      <asp:Parameter Name="original_name" Type="String" />
                                      <asp:Parameter Name="original_class" Type="String" />
                                      <asp:Parameter Name="original_usr" Type="String" />
                                      <asp:Parameter Name="original_pass" Type="String" />
                                      <asp:Parameter Name="original_mob" Type="String" />
                                  </DeleteParameters>
                                  <InsertParameters>
                                      <asp:Parameter Name="name" Type="String" />
                                      <asp:Parameter Name="class" Type="String" />
                                      <asp:Parameter Name="usr" Type="String" />
                                      <asp:Parameter Name="pass" Type="String" />
                                      <asp:Parameter Name="mob" Type="String" />
                                  </InsertParameters>
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblclass" Name="class" PropertyName="Text" Type="String" />
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
                                  <UpdateParameters>
                                      <asp:Parameter Name="usr" Type="String" />
                                      <asp:Parameter Name="original_id" Type="Int32" />
                                  </UpdateParameters>
                              </asp:SqlDataSource>--%>


                              <asp:GridView ID="GridView2" 
                                  CssClass="table table-striped table-advance center-block centered" 
                                  runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView2_RowCancelingEdit" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating">
                                  <Columns>
                                      <asp:CommandField ShowEditButton="True" />
                                      <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" 
                                          InsertVisible="False" ReadOnly="True" />
                                      <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                      <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                      <asp:BoundField DataField="usr" HeaderText="usr" SortExpression="usr" />
                                      <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                  </Columns>
                              </asp:GridView>

                             <%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                                  ConnectionString="<%$ ConnectionStrings:school_mateConnectionString5 %>" 
                                  SelectCommand="SELECT [id], [name], [mob], [usr], [pass] FROM [parent] WHERE ([school] = @school) ORDER BY [name]" 
                                  
                                  UpdateCommand="UPDATE parent SET mob = @mob, usr = @usr, pass = @pass WHERE (id = @original_id)" 
                                  ConflictDetection="CompareAllValues" 
                                  DeleteCommand="DELETE FROM [parent] WHERE [id] = @original_id AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([mob] = @original_mob) OR ([mob] IS NULL AND @original_mob IS NULL)) AND [usr] = @original_usr AND [pass] = @original_pass" 
                                  InsertCommand="INSERT INTO [parent] ([name], [mob], [usr], [pass]) VALUES (@name, @mob, @usr, @pass)" 
                                  OldValuesParameterFormatString="original_{0}">
                                  <DeleteParameters>
                                      <asp:Parameter Name="original_id" Type="Int32" />
                                      <asp:Parameter Name="original_name" Type="String" />
                                      <asp:Parameter Name="original_mob" Type="String" />
                                      <asp:Parameter Name="original_usr" Type="String" />
                                      <asp:Parameter Name="original_pass" Type="String" />
                                  </DeleteParameters>
                                  <InsertParameters>
                                      <asp:Parameter Name="name" Type="String" />
                                      <asp:Parameter Name="mob" Type="String" />
                                      <asp:Parameter Name="usr" Type="String" />
                                      <asp:Parameter Name="pass" Type="String" />
                                  </InsertParameters>
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
                                  <UpdateParameters>
                                      <asp:Parameter Name="mob" Type="String" />
                                      <asp:Parameter Name="usr" Type="String" />
                                      <asp:Parameter Name="pass" Type="String" />
                                      <asp:Parameter Name="original_id" Type="Int32" />
                                  </UpdateParameters>
                              </asp:SqlDataSource>--%>
</div></section>
        </section>

</asp:Content>

