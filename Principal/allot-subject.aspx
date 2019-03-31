<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="allot-subject.aspx.cs" Inherits="HOD_subject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SUBJECT INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-6">
          			<div class="form-panel">
                  	     <h3><asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                      <form class="form-inline" role="form">
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Teacher Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                             <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name] FROM [teacher] WHERE ([school] = @school)">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
              </asp:SqlDataSource>
                               </div>
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              
                              <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id] DESC">
                                  <SelectParameters>
                                      <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                  </SelectParameters>
              </asp:SqlDataSource>
                         
                               </div>
                           <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Select Subject : " Font-Bold="true" ForeColor="Black"></asp:Label>
                             
                               <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server" DataSourceID="SqlDataSource3" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                               <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info] WHERE ([school] = @school)">
                                   <SelectParameters>
                                       <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                   </SelectParameters>
              </asp:SqlDataSource>
                
                                </div>
                         
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Allot Subject" OnClick="btnadd_Click"  />
                      </form>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	

            	<div class="col-lg-6">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Teacher Information</h4>
            
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource4" AllowSorting="True">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                  <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                  <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
                                  <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
                              </Columns>
                                    </asp:GridView>
                         
                                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" DeleteCommand="DELETE FROM [subject] WHERE [id] = @original_id AND [name] = @original_name AND [class] = @original_class AND [subject] = @original_subject AND [school] = @original_school" InsertCommand="INSERT INTO [subject] ([name], [class], [subject], [school]) VALUES (@name, @class, @subject, @school)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [subject] WHERE ([school] = @school) ORDER BY [class] DESC" UpdateCommand="UPDATE [subject] SET [name] = @name, [class] = @class, [subject] = @subject, [school] = @school WHERE [id] = @original_id AND [name] = @original_name AND [class] = @original_class AND [subject] = @original_subject AND [school] = @original_school">
                                        <DeleteParameters>
                                            <asp:Parameter Name="original_id" Type="Int32" />
                                            <asp:Parameter Name="original_name" Type="String" />
                                            <asp:Parameter Name="original_class" Type="String" />
                                            <asp:Parameter Name="original_subject" Type="String" />
                                            <asp:Parameter Name="original_school" Type="String" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="name" Type="String" />
                                            <asp:Parameter Name="class" Type="String" />
                                            <asp:Parameter Name="subject" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="name" Type="String" />
                                            <asp:Parameter Name="class" Type="String" />
                                            <asp:Parameter Name="subject" Type="String" />
                                            <asp:Parameter Name="school" Type="String" />
                                            <asp:Parameter Name="original_id" Type="Int32" />
                                            <asp:Parameter Name="original_name" Type="String" />
                                            <asp:Parameter Name="original_class" Type="String" />
                                            <asp:Parameter Name="original_subject" Type="String" />
                                            <asp:Parameter Name="original_school" Type="String" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
                         </div></div></div>

                         
                         


              </section></section>

</asp:Content>

