<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Department.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label18" runat="server" Text="Ejercicios PDF 1"></asp:Label>
        <table>
            <tr>
                <td>
                      <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label1" runat="server" Text="query01"></asp:Label>
                          <br />
                        <asp:GridView class="myGridClass" ID="gv1" runat="server" OnSelectedIndexChanged="gridData_SelectedIndexChanged">
                        </asp:GridView>
                    </div>
                </td>
                <td>
                     <div>
            <asp:Label width=100% CssClass="labelstyle" ID="Label2" runat="server" Text="query02"></asp:Label>
                         <br />
            <asp:GridView class="myGridClass" ID="gv2" runat="server" OnSelectedIndexChanged="gridData_SelectedIndexChanged">
            </asp:GridView>
        </div>
                </td>
                <td class="auto-style1">
                       <div>
            <asp:Label width=100% CssClass="labelstyle" ID="Label3" runat="server" Text="query03"></asp:Label>
                           <br />
            <asp:GridView class="myGridClass" ID="gv3" runat="server" OnSelectedIndexChanged="gridData_SelectedIndexChanged">
            </asp:GridView>
                           <br />
        </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label4" runat="server" Text="query04"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv4" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label5" runat="server" Text="query05"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv5" runat="server">
                        </asp:GridView>
                        <br />
                    </div>
                </td>
                <td class="auto-style1">
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label6" runat="server" Text="query06"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv6" runat="server">
                        </asp:GridView>
                        <br />
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label9" runat="server" Text="query07"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv7" runat="server">
                        </asp:GridView>
                        <br />
                    </div>
                </td>
                <td class="auto-style1">
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label7" runat="server" Text="query08"></asp:Label>
                        <br />
                        
                        <asp:GridView class="myGridClass" ID="gv8" runat="server">
                        </asp:GridView>
                        <br />
                    </div>
                </td>
                <td class="auto-style1">
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label8" runat="server" Text="query09"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv9" runat="server">
                        </asp:GridView>
                        <br />
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label10" runat="server" Text="query10"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv10" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label12" runat="server" Text="query11"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv11" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td class="auto-style1">
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label11" runat="server" Text="query12"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv12" runat="server">
                        </asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label13" runat="server" Text="query13"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv13" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label14" runat="server" Text="query14"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv14" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td class="auto-style1">
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label15" runat="server" Text="query15"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv15" runat="server">
                        </asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label16" runat="server" Text="query16"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv16" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label17" runat="server" Text="query17"></asp:Label>
                        <br />
                        <asp:GridView class="myGridClass" ID="gv17" runat="server">
                        </asp:GridView>
                    </div>
                </td>
                <td class="auto-style1">
                    <div>

                    </div>
                </td>
            </tr>

        </table>
        <br />
      <div align="center">
          <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Siguiente" OnClick="Button1_Click" />
      </div>
       
       
    </form>
</body>
</html>
