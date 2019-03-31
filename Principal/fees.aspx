<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="fees.aspx.cs" Inherits="Principal_fees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SCHOOL INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
    
                      
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Select Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:DropDownList ID="DropDownList1" AutoPostBack="true" class="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection]"></asp:SqlDataSource>
                          </div>
                     
                      </div></div>

              <div class="row mt">
          		<div class="col-lg-4">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> </h4>
            
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False" AllowSorting="True" AllowPaging="True" DataSourceID="SqlDataSource1" DataKeyNames="id" >
                              <Columns>
                                  <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" />

                                  
                                         <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
   
                                         <asp:TemplateField HeaderText="" ControlStyle-ForeColor="White">

                                    <ItemTemplate>
                                        <a href="fees.aspx?id=<%#Eval("id") %>"><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></a>
                                           
                                    </ItemTemplate>
                                    </asp:TemplateField>
   



                              </Columns>
                                    </asp:GridView>
                            


                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [id], [name] FROM [student] WHERE ([class] = @class)">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                            


                          </div></div>

                  <div class="col-lg-4">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> </h4>
            <asp:Label runat="server" ID="lblclass"></asp:Label>
                </div></div>






              </div>
              </section></section>


</asp:Content>

