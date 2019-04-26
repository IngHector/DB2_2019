<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Ejercicios4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label1" runat="server" Text="Ejercicios PDF 4"></asp:Label>
        <table>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label2" runat="server" Text="query42"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv42" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label3" runat="server" Text="query43"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv43" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label4" runat="server" Text="query44"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv44" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label5" runat="server" Text="query45"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv45" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label6" runat="server" Text="query46"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv46" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label7" runat="server" Text="query47"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv47" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label8" runat="server" Text="query48"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv48" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label9" runat="server" Text="query49"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv49" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label10" runat="server" Text="query50"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv50" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label11" runat="server" Text="query51"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv51" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label width=100% CssClass="labelstyle" ID="Label12" runat="server" Text="query52"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv52" runat="server"></asp:GridView>
                    </div>
                </td>
                
            </tr>
        </table>
        <div align="center">
            <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Anterior" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
