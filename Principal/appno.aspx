<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="appno.aspx.cs" Inherits="Principal_appno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>Pending Homework...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
                                    			<div class="form-panel">
                             <asp:Label runat="server" ID="lbltchnm" Visible="false" ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" Visible="false"></asp:Label>
                       
                           <form class="form-inline" role="form">
                         
                      <div class="content-panel">
                     <asp:Button ID="Button1" class="btn-success" runat="server" Text="Approve" 
                              onclick="Button1_Click"></asp:Button><asp:Button ID="Button2" 
                              class="btn-danger" runat="server" Text="Reject" onclick="Button2_Click"></asp:Button>
                         



                            <table runat="server" class="table table-bordered table-striped table-condensed w-100">
                                <tr>
                                    <td><asp:Label runat="server" ID="lblid"></asp:Label></td>
                                    <td><asp:Label runat="server" ID="lbltitle"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td><asp:Label runat="server" ID="lbladdt"></asp:Label></td>
                                    <td><asp:Label runat="server" ID="lbldescr"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td><asp:Label runat="server" ID="lblclass"></asp:Label></td>
                                    <td><asp:Label runat="server" ID="lbladtch"></asp:Label></td>
                                </tr>
                          </table>
                         

       <asp:GridView ID="GridView1" runat="server" Visible="False" DataSourceID="SqlDataSource1" 
                              AutoGenerateColumns="False">
           <Columns>
               <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
           </Columns>
                          </asp:GridView>
                                <asp:GridView ID="GridView2" Visible="False" runat="server" AutoGenerateColumns="False" 
                              DataSourceID="SqlDataSource2">
                                    <Columns>
                                        <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                    </Columns>
                          </asp:GridView>
                                
                                
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:school_mateConnectionString5 %>" 
                              SelectCommand="SELECT [mob] FROM [parent] WHERE ([school] = @school)">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                            Type="String" />
                                    </SelectParameters>
                          </asp:SqlDataSource>
                                
                                
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                              ConnectionString="<%$ ConnectionStrings:school_mateConnectionString5 %>" 
                              SelectCommand="SELECT [mob] FROM [parent] WHERE (([class] = @class) AND ([school] = @school))">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lblclass" Name="class" PropertyName="Text" 
                                            Type="String" />
                                        <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" 
                                            Type="String" />
                                    </SelectParameters>
                          </asp:SqlDataSource>
                                
                                
                                
                                </div></div></div></form></div></div></div>

            </div></form></div></div></div></section></section>
</asp:Content>

