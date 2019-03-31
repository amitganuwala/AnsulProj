<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Site.master" AutoEventWireup="true" CodeFile="schedule.aspx.cs" Inherits="Teacher_schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="main-content">
          <section class="wrapper">
              <div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                           <asp:Label runat="server" ID="lblsch" Font-Bold="true" Font-Size="XX-Large" ForeColor="Black" ></asp:Label>
                          <br />
                           WELCOME <asp:Label runat="server" ID="lbltchnm" Font-Size="Larger" Text="payal"></asp:Label>
                 
                          </div></div></div>


              <div class="row">
                  <div class="col-lg-12 main-chart">
                           
                         <asp:Label runat="server" ID="lblday" Font-Bold="true" Font-Size="Larger" ForeColor="Black"></asp:Label>

                             <table class="table table-striped table-advance table-hover nav-justified text-center">
                                           <tr>
                                               <td><asp:Label runat="server" ID="lbllec1" ></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec2" ></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec3" ></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lblbrk" ></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec4" ></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec5" ></asp:Label></td>
                                               <td><asp:Label runat="server" ID="lbllec6" ></asp:Label></td>                                               
                                           </tr>
                                </table>

                                <asp:Panel ID="monday" runat="server" Visible="false">
                                <table class="table table-striped table-advance table-hover nav-justified text-center">
                                           <tr>
                                               
                                               <td><asp:Label runat="server" ID="lbld1l1" ></asp:Label><br /><asp:Label runat="server" ID="monl1" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c1d1l1" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd1l1" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd1l1_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld1l2" ></asp:Label><br /><asp:Label runat="server" ID="monl2" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c1d1l2" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd1l2" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd1l2_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld1l3" ></asp:Label><br /><asp:Label runat="server" ID="monl3" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c1d1l3" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd1l3" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd1l3_Click" /></td>
                                               <td><b>BREAK</b></td>
                                               <td><asp:Label runat="server" ID="lbld1l4" ></asp:Label><br /><asp:Label runat="server" ID="monl4" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c1d1l4" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd1l4" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd1l4_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld1l5" ></asp:Label><br /><asp:Label runat="server" ID="monl5" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c1d1l5" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd1l5" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd1l5_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld1l6" ></asp:Label><br /><asp:Label runat="server" ID="monl6" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c1d1l6" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd1l6" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd1l6_Click" /></td>                                               
                                           </tr>
                                           </table>
                                           </asp:Panel>
                                           <asp:Panel ID="tuesday" runat="server" Visible="false">
                                           <table class="table table-striped table-advance table-hover nav-justified text-center" >
                                           <tr>
                                               
                                               <td><asp:Label runat="server" ID="lbld2l1"></asp:Label><br /><asp:Label runat="server" ID="tue1" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c2d2l1" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd2l1" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd2l1_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld2l2"></asp:Label><br /><asp:Label runat="server" ID="tue2" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c2d2l2" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd2l2" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd2l2_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld2l3"></asp:Label><br /><asp:Label runat="server" ID="tue3" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c2d2l3" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd2l3" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd2l3_Click" /></td>
                                               <td><b>BREAK</b></td>
                                               <td><asp:Label runat="server" ID="lbld2l4" ></asp:Label><br /><asp:Label runat="server" ID="tue4"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c2d2l4" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd2l4" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd2l4_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld2l5" ></asp:Label><br /><asp:Label runat="server" ID="tue5"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c2d2l5" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd2l5" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd2l5_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld2l6" ></asp:Label><br /><asp:Label runat="server" ID="tue6"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c2d2l6" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd2l6" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd2l6_Click" /></td>                                               
                                           </tr>
                                           </table>
                                           </asp:Panel>
                                           <asp:Panel ID="wednesday" runat="server" Visible="false">
                                           <table class="table table-striped table-advance table-hover nav-justified text-center" >
                                           <tr>
                                               
                                               <td><asp:Label runat="server" ID="lbld3l1" ></asp:Label><br /><asp:Label runat="server" ID="wed1"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c3d3l1" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd3l1" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd3l1_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld3l2" ></asp:Label><br /><asp:Label runat="server" ID="wed2"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c3d3l2" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd3l2" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd3l2_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld3l3" ></asp:Label><br /><asp:Label runat="server" ID="wed3"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c3d3l3" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd3l3" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd3l3_Click" /></td>
                                               <td><b>BREAK</b></td>
                                               <td><asp:Label runat="server" ID="lbld3l4" ></asp:Label><br /><asp:Label runat="server" ID="wed4"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c3d3l4" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd3l4" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd3l4_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld3l5" ></asp:Label><br /><asp:Label runat="server" ID="wed5"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c3d3l5" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd3l5" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd3l5_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld3l6" ></asp:Label><br /><asp:Label runat="server" ID="wed6"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c3d3l6" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd3l6" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd3l6_Click" /></td>                                               
                                           </tr>
                                           </table>
                                           </asp:Panel>
                                           <asp:Panel ID="thursday" runat="server" Visible="false">
                                           <table class="table table-striped table-advance table-hover nav-justified text-center">
                                           <tr>
                                               
                                               <td><asp:Label runat="server" ID="lbld4l1" ></asp:Label><br /><asp:Label runat="server" ID="thu1"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c4d4l1" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd4l1" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd4l1_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld4l2" ></asp:Label><br /><asp:Label runat="server" ID="thu2"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c4d4l2" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd4l2" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd4l2_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld4l3" ></asp:Label><br /><asp:Label runat="server" ID="thu3"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c4d4l3" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd4l3" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd4l3_Click" /></td>
                                               <td><b>BREAK</b></td>
                                               <td><asp:Label runat="server" ID="lbld4l4"></asp:Label><br /><asp:Label runat="server" ID="thu4" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c4d4l4" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd4l4" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd4l4_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld4l5" ></asp:Label><br /><asp:Label runat="server" ID="thu5"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c4d4l5" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd4l5" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd4l5_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld4l6" ></asp:Label><br /><asp:Label runat="server" ID="thu6"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c4d4l6" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd4l6" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd4l6_Click" /></td>                                               
                                           </tr>
                                           </table>
                                           </asp:Panel>
                                           <asp:Panel ID="friday" runat="server" Visible="false">
                                           <table class="table table-striped table-advance table-hover nav-justified text-center" >
                                           <tr>
                                               
                                               <td><asp:Label runat="server" ID="lbld5l1" ></asp:Label><br /><asp:Label runat="server" ID="fri1" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c5d5l1" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd5l1" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd5l1_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld5l2" ></asp:Label><br /><asp:Label runat="server" ID="fri2" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c5d5l2" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd5l2" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd5l2_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld5l3" ></asp:Label><br /><asp:Label runat="server" ID="fri3" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c5d5l3" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd5l3" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd5l3_Click" /></td>
                                               <td><b>BREAK</b></td>
                                               <td><asp:Label runat="server" ID="lbld5l4" ></asp:Label><br /><asp:Label runat="server" ID="fri4" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c5d5l4" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd5l4" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd5l4_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld5l5" ></asp:Label><br /><asp:Label runat="server" ID="fri5" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c5d5l5" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd5l5" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd5l5_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld5l6" ></asp:Label><br /><asp:Label runat="server" ID="fri6" ></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c5d5l6" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd5l6" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd5l6_Click" /></td>                                               
                                           </tr>
                                           </table>
                                           </asp:Panel>

                                           <asp:Panel ID="saturday" runat="server" Visible="false">
                                           <table class="table table-striped table-advance table-hover nav-justified text-center">
                                           <tr>
                                               
                                               <td><asp:Label runat="server" ID="lbld6l1"></asp:Label><br /><asp:Label runat="server" ID="sat1"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c6d6l1" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd6l1" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd6l1_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld6l2"></asp:Label><br /><asp:Label runat="server" ID="sat2"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c6d6l2" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd6l2" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd6l2_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld6l3"></asp:Label><br /><asp:Label runat="server" ID="sat3"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c6d6l3" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd6l3" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd6l3_Click" /></td>
                                               <td><b>BREAK</b></td>
                                               <td><asp:Label runat="server" ID="lbld6l4"></asp:Label><br /><asp:Label runat="server" ID="sat4"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c6d6l4" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd6l4" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd6l4_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld6l5"></asp:Label><br /><asp:Label runat="server" ID="sat5"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c6d6l5" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd6l5" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd6l5_Click" /></td>
                                               <td><asp:Label runat="server" ID="lbld6l6"></asp:Label><br /><asp:Label runat="server" ID="sat6"></asp:Label><br /><br /><asp:TextBox runat="server"  ID="c6d6l6" class="form-control"></asp:TextBox><br />
                                                   <asp:Button ID="btnd6l6" runat="server" class="btn btn-block" Text="Add Course" 
                                                       onclick="btnd6l6_Click" /></td>                                               
                                           </tr>
                                       </table>
                                       </asp:Panel>
                                   
     </div></div>
     </section></section>
</asp:Content>

