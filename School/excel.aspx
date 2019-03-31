<%@ Page Title="" Language="C#" MasterPageFile="~/School/Site.master" AutoEventWireup="true" CodeFile="excel.aspx.cs" Inherits="School_addnotice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right">
                </i>ADD NOTICE...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-8">
          			<div class="form-panel">
    
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                    
                      <form class="form-inline" role="form">
                        
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList CssClass="form-control" ID="DropDownList1" AppendDataBoundItems="true" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class"></asp:DropDownList>
          	
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                    </SelectParameters>
              </asp:SqlDataSource>

                          </div>
                           <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Notice : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtsub" placeholder=""></asp:TextBox>
                          </div>
                          <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Notice Valid till Date : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtdate" placeholder="Enter Due Date"></asp:TextBox>
                          </div>
                         <div class="form-group">
                             <asp:CheckBox runat="server" ID="sendtxt" Text="Click here to send notice as SMS" />
                         </div>
                          <asp:Button runat="server" class="btn btn-theme" ID="btnadd" Text="Add Information" OnClick="btnadd_Click"  />
                      </form>
          			</div><!-- /form-panel -->


                      <asp:GridView ID="GridView2"  runat="server" Visible="false" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
                          <Columns>
                              <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                              <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                          </Columns>
                    </asp:GridView>

          		    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [mob] FROM [parent] WHERE (([class] = @class) AND ([school] = @school))">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>


                      <asp:GridView ID="GridView3" runat="server" Visible="false"  AutoGenerateColumns="False" DataSourceID="SqlDataSource4">
                          <Columns>
                              <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                              <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                          </Columns>
                    </asp:GridView>
          		    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [mob] FROM [parent] WHERE ([school] = @school)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
    

               <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                                    <h4><i class="fa fa-angle-right"></i> Notice Information</h4>
            
                          <asp:GridView ID="GridView1" class="table table-striped table-advance table-hover" runat="server" AutoGenerateColumns="False"  AllowSorting="True" DataKeyNames="id" DataSourceID="SqlDataSource1">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                  <asp:BoundField DataField="notice" HeaderText="notice" SortExpression="notice" />
                                  <asp:BoundField DataField="school" HeaderText="school" SortExpression="school" />
                                  <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                  <asp:BoundField DataField="adfrom" HeaderText="adfrom" SortExpression="adfrom" />
                              </Columns>
                                    </asp:GridView>
                     
                          
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [id], [class], [notice], [school], [date], [adfrom] FROM [notice] WHERE (([class] = @class) AND ([school] = @school)) ORDER BY [id] DESC">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
                                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                     
                          
                  </div></div></div>

              </section></section>
</asp:Content>

