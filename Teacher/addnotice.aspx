<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="addnotice.aspx.cs" Inherits="Teacher_addnotice" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right">
                </i>ADD NOTICE...</h3>
          	
            	<div class="row mt">
          		
                <div class="col-lg-8">
          			<div class="form-panel">
    
    
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                    <div class="row">
                      <form class="form-inline" role="form">
                         <div class="col-lg-8">
    
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList CssClass="form-control" ID="DropDownList1" AppendDataBoundItems="true" runat="server" AutoPostBack="true" ></asp:DropDownList>
          	
<%--                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                    </SelectParameters>
              </asp:SqlDataSource>--%>

              <cc1:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server"></cc1:ToolkitScriptManager>
                          </div>
                           <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Notice : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtsub" placeholder=""></asp:TextBox>
                          </div>
                         <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Notice Valid till Date : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtdate" placeholder="Enter Due Date"></asp:TextBox>                      </div>
                         
                         <div class="form-group">
                             <asp:CheckBox runat="server" ID="sendtxt" Text="Click here to send notice as SMS" />
                         </div>
                          <asp:Button runat="server" class="btn btn-theme" ID="Button3" Text="Add Information" OnClick="btnadd2_Click" />
                          </div>
                      </form>
                      
                      <div class="col-lg-1">
                      <br /><br /><br /><br /><br /><br /><br /><br /><br />
                       <asp:ImageButton ID="img" runat="server" Height="20px" Width="20px" ImageUrl="~/Principal/icons/6-512.png" />
                                <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" PopupPosition="BottomRight" TargetControlID="txtdate" PopupButtonID="img"></cc1:CalendarExtender>
                             </div>

                      
                      </div>
                      </div>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
    
                      
                  </div></div></div>

                      <asp:GridView ID="GridView2"  runat="server" Visible="false" AutoGenerateColumns="False">
                          <Columns>
                              <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                              <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                          </Columns>
                    </asp:GridView>

<%--          		    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [mob] FROM [parent] WHERE (([class] = @class) AND ([school] = @school))">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="class" PropertyName="SelectedValue" Type="String" />
                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>--%>


                      <asp:GridView ID="GridView3" runat="server" Visible="false"  AutoGenerateColumns="False" >
                          <Columns>
                              <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                              <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                          </Columns>
                    </asp:GridView>

<%--          		    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [name], [mob] FROM [parent] WHERE ([school] = @school)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>--%>

          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
    

              </section></section>
</asp:Content>

