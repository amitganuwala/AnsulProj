<%@ Page Title="" Language="C#" MasterPageFile="~/Principal/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Principal_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <section id="main-content">
          <section class="wrapper">
          	<h3><i class="fa fa-angle-right"></i>ADD SCHOOL INFORMATION...</h3>
          	
          	<!-- INLINE FORM ELELEMNTS -->
          	<div class="row mt">
          		<div class="col-lg-12">
          			<div class="form-panel">
                  	 
                      <form class="form-inline" role="form">
                          <div class="form-group"> 
                             <asp:Label ID="Label1" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtnm" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label2" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3><asp:TextBox runat="server" ID="txtaddr" CssClass="form-control"></asp:TextBox></h3>
                              
                                </div>
                          <div class="form-group"> 
                             <asp:Label ID="Label4" runat="server" Text="School  Name: " Font-Bold="true" ForeColor="Black"></asp:Label>
                              <h3>
                                  <asp:FileUpload ID="FileUpload1" runat="server" /><asp:TextBox runat="server" ID="txtpic" Visible="false" ></asp:TextBox></h3>
                              
                                </div>

                          <asp:Button ID="Button1" runat="server" Text="Add Information" CssClass="btn btn-theme" OnClick="Button1_Click"
                                />
                          </form>

                          <asp:GridView ID="GridView1" 
                            class="table table-bordered table-condensed table-dark table-responsive" 
                            runat="server" AutoGenerateColumns="False" DataKeyNames="id" 
                            DataSourceID="SqlDataSource1">
                              <Columns>
                                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                      ReadOnly="True" SortExpression="id" />
                                  <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                                  <asp:BoundField DataField="usr" HeaderText="usr" SortExpression="usr" />
                                  <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                  <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
                                  <asp:BoundField DataField="roll" HeaderText="roll" SortExpression="roll" />
                                  <asp:BoundField DataField="school" HeaderText="school" 
                                      SortExpression="school" />
                                  <asp:BoundField DataField="religion" HeaderText="religion" 
                                      SortExpression="religion" />
                                  <asp:BoundField DataField="caste" HeaderText="caste" SortExpression="caste" />
                                  <asp:BoundField DataField="subcaste" HeaderText="subcaste" 
                                      SortExpression="subcaste" />
                                  <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                                  <asp:BoundField DataField="sgen" HeaderText="sgen" SortExpression="sgen" />
                                  <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                  <asp:BoundField DataField="pic" HeaderText="pic" SortExpression="pic" />
                              </Columns>
                        </asp:GridView>


                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConflictDetection="CompareAllValues" 
                            ConnectionString="<%$ ConnectionStrings:totalschoolConnectionString %>" 
                            DeleteCommand="DELETE FROM [parent] WHERE [id] = @original_id AND (([pname] = @original_pname) OR ([pname] IS NULL AND @original_pname IS NULL)) AND [usr] = @original_usr AND [pass] = @original_pass AND (([class] = @original_class) OR ([class] IS NULL AND @original_class IS NULL)) AND (([roll] = @original_roll) OR ([roll] IS NULL AND @original_roll IS NULL)) AND (([school] = @original_school) OR ([school] IS NULL AND @original_school IS NULL)) AND (([religion] = @original_religion) OR ([religion] IS NULL AND @original_religion IS NULL)) AND (([caste] = @original_caste) OR ([caste] IS NULL AND @original_caste IS NULL)) AND (([subcaste] = @original_subcaste) OR ([subcaste] IS NULL AND @original_subcaste IS NULL)) AND (([mob] = @original_mob) OR ([mob] IS NULL AND @original_mob IS NULL)) AND (([sgen] = @original_sgen) OR ([sgen] IS NULL AND @original_sgen IS NULL)) AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([pic] = @original_pic) OR ([pic] IS NULL AND @original_pic IS NULL))" 
                            InsertCommand="INSERT INTO [parent] ([pname], [usr], [pass], [class], [roll], [school], [religion], [caste], [subcaste], [mob], [sgen], [name], [pic]) VALUES (@pname, @usr, @pass, @class, @roll, @school, @religion, @caste, @subcaste, @mob, @sgen, @name, @pic)" 
                            OldValuesParameterFormatString="original_{0}" 
                            SelectCommand="SELECT * FROM [parent] ORDER BY [id] DESC" 
                            
                            UpdateCommand="UPDATE parent SET school = @school WHERE (id = @original_id)">
                              <DeleteParameters>
                                  <asp:Parameter Name="original_id" Type="Int32" />
                                  <asp:Parameter Name="original_pname" Type="String" />
                                  <asp:Parameter Name="original_usr" Type="String" />
                                  <asp:Parameter Name="original_pass" Type="String" />
                                  <asp:Parameter Name="original_class" Type="String" />
                                  <asp:Parameter Name="original_roll" Type="String" />
                                  <asp:Parameter Name="original_school" Type="String" />
                                  <asp:Parameter Name="original_religion" Type="String" />
                                  <asp:Parameter Name="original_caste" Type="String" />
                                  <asp:Parameter Name="original_subcaste" Type="String" />
                                  <asp:Parameter Name="original_mob" Type="String" />
                                  <asp:Parameter Name="original_sgen" Type="String" />
                                  <asp:Parameter Name="original_name" Type="String" />
                                  <asp:Parameter Name="original_pic" Type="String" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="pname" Type="String" />
                                  <asp:Parameter Name="usr" Type="String" />
                                  <asp:Parameter Name="pass" Type="String" />
                                  <asp:Parameter Name="class" Type="String" />
                                  <asp:Parameter Name="roll" Type="String" />
                                  <asp:Parameter Name="school" Type="String" />
                                  <asp:Parameter Name="religion" Type="String" />
                                  <asp:Parameter Name="caste" Type="String" />
                                  <asp:Parameter Name="subcaste" Type="String" />
                                  <asp:Parameter Name="mob" Type="String" />
                                  <asp:Parameter Name="sgen" Type="String" />
                                  <asp:Parameter Name="name" Type="String" />
                                  <asp:Parameter Name="pic" Type="String" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="school" Type="String" />
                                  <asp:Parameter Name="original_id" Type="Int32" />
                              </UpdateParameters>
                        </asp:SqlDataSource>


                          </div></div>
                </div>
              </section><</section>
</asp:Content>

