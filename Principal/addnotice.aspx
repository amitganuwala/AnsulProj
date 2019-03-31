<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="addnotice.aspx.cs" Inherits="Principal_addnotice" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
                             <h3><asp:Label runat="server" ID="lblsch" Visible="false" Font-Bold="true" Font-Size="X-Large" ForeColor="Black"></asp:Label></h3>
                    <div class="row">
                      <form class="form-inline" role="form">
                         <div class="col-lg-8">
    
                          <div class="form-group">
                             <asp:Label ID="Label2" runat="server" Text="Class: " Font-Bold="true" ForeColor="Black"></asp:Label>
                               <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" AppendDataBoundItems="true" DataSourceID="SqlDataSource2" DataTextField="class" DataValueField="class"></asp:DropDownList>
          	
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [classsection] WHERE ([school] = @school) ORDER BY [id]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                    </SelectParameters>
              </asp:SqlDataSource>
              <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
                          </div>
                           <div class="form-group">
                             <asp:Label ID="Label4" runat="server" Text="Notice : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtsub" placeholder=""></asp:TextBox>
                          </div>
                         <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="DueDate : " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <asp:TextBox runat="server" class="form-control" id="txtdate" placeholder=""></asp:TextBox>
                          </div>
                          
                          <asp:Button runat="server" class="btn btn-theme" ID="Button3" Text="Add Information" OnClick="btnadd2_Click"  />
                          </div>
                      </form>
                      
                      <div class="col-lg-1">
                      <br /><br /><br /><br /><br /><br /><br /><br /><br />
                       <asp:ImageButton ID="img" runat="server" Height="20px" Width="20px" ImageUrl="~/Principal/icons/6-512.png" />
                                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" PopupPosition="BottomRight" TargetControlID="txtdate" PopupButtonID="img"></cc1:CalendarExtender>
                             </div>

                      
                      </div>
                      </div>
          			</div><!-- /form-panel -->
          		</div><!-- /col-lg-12 -->
          	</div><!-- /row -->
    
                      
                  </div></div></div>

              </section></section>
</asp:Content>

