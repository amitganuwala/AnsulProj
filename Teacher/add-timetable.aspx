<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="add-timetable.aspx.cs" Inherits="Teacher_add_timetable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD TIMETABLE....</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-15">
          			<div class="form-panel">
                           <asp:Label runat="server" ID="lbltchnm"  ></asp:Label>
                           <asp:Label runat="server" ID="lblsch" ></asp:Label>
                   
                             <div class="text-center">
                          <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource37" DataTextField="class" DataValueField="class"></asp:DropDownList>
                          <asp:SqlDataSource ID="SqlDataSource37" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [class] FROM [subject] WHERE (([name] = @name) AND ([school] = @school))">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lbltchnm" Name="name" PropertyName="Text" Type="String" />
                                  <asp:ControlParameter ControlID="lblsch" Name="school" PropertyName="Text" Type="String" />
                              </SelectParameters>
                        </asp:SqlDataSource><br /><br />
                                 </div>
                             <asp:Label runat="server" ID="lbltitle" Text="Daily Timetable" Visible="false"></asp:Label>
                        <table class="table table-striped table-advance table-hover nav-justified text-center">
                            <tr>
                                <td>Lectures -><br />Days</td>
                                <td>1<br />
                                    <asp:TextBox ID="txttime1" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                                <td>2<br />
                                    <asp:TextBox ID="txttime2" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                                <td>3<br />
                                    <asp:TextBox ID="txttime3" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                                <td>4<br />
                                    <asp:TextBox ID="txttime4" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                                <td>5<br />
                                    <asp:TextBox ID="txttime5" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                                <td>6<br />
                                    <asp:TextBox ID="txttime6" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                                <td>7<br />
                                    <asp:TextBox ID="txttime7" runat="server" CssClass="form-control" placeholder="Enter timing"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td><asp:Label runat="server" ID="lblday1" Text="Monday"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="d1l1" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info] ORDER BY [id]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d1l1tch" ></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d1l2" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d1l2tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d1l3" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d1l3tch"></asp:Label>
                                </td>
                                <td>B<br /></td>
                                <td>
                                    <asp:DropDownList ID="d1l4" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d1l4tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d1l5" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d1l5tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d1l6" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d1l6tch"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td><asp:Label runat="server" ID="lblday2" Text="Tuesday"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="d2l1" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d2l1tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d2l2" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d2l2tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d2l3" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d2l3tch"></asp:Label>
                                </td>
                                <td>R<br /></td>
                                <td>
                                    <asp:DropDownList ID="d2l4" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d2l4tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d2l5" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d2l5tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d2l6" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource12" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d2l6tch"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td><asp:Label runat="server" ID="lblday3" Text="Wednesday"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="d3l1" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource13" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d3l1tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d3l2" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource14" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d3l2tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d3l3" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource15" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d3l3tch"></asp:Label>
                                </td>
                                <td>E<br /></td>
                                <td>
                                    <asp:DropDownList ID="d3l4" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource16" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d3l4tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d3l5" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource17" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d3l5tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d3l6" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource18" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d3l6tch"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td><asp:Label runat="server" ID="lblday4" Text="Thursday"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="d4l1" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource19" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d4l1tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d4l2" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource20" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d4l2tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d4l3" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource21" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d4l3tch"></asp:Label>
                                </td>
                                <td>A<br /></td>
                                <td>
                                    <asp:DropDownList ID="d4l4" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource22" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d4l4tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d4l5" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource23" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d4l5tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d4l6" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource24" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d4l6tch"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td><asp:Label runat="server" ID="lblday5" Text="Friday"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="d5l1" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource25" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d5l1tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d5l2" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource26" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d5l2tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d5l3"  CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource27" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d5l3tch"></asp:Label>
                                </td>
                                <td>K<br /></td>
                                <td>
                                    <asp:DropDownList ID="d5l4" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource28" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d5l4tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d5l5" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource29" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d5l5tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d5l6" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource30" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d5l6tch"></asp:Label>
                                </td>

                            </tr>
                            <tr>
                                <td><asp:Label runat="server" ID="lblday6" Text="Saturday"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="d6l1" runat="server" CssClass="form-control" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource31" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d6l1tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d6l2" runat="server" CssClass="form-control" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource32" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d6l2tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d6l3" runat="server" CssClass="form-control"  AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource33" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d6l3tch"></asp:Label>
                                </td>
                                <td></td>
                                <td>
                                    <asp:DropDownList ID="d6l4" runat="server" AutoPostBack="true" CssClass="form-control"  DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource34" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d6l4tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d6l5" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource35" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d6l5tch"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="d6l6" CssClass="form-control"  runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="snm" DataValueField="snm"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource36" runat="server" ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" SelectCommand="SELECT [snm] FROM [subject-info]"></asp:SqlDataSource>
                                    <br /><asp:Label runat="server" ID="d6l6tch"></asp:Label>
                                </td>
                            </tr>
                        </table>
                          <asp:Button ID="btnadd" runat="server" Text="Add Timetable" CssClass="btn btn-block btn-theme" OnClick="btnadd_Click" />
                 </div>
          		</div></div>

              </section></section>


</asp:Content>

