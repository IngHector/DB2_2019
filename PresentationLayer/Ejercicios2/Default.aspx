<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Employee._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label16" runat="server" Text="Ejercicios PDF 2"></asp:Label>
      <table>
          <tr>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label1" runat="server" Text="query18"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv18" runat="server" />
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label2" runat="server" Text="query19"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv19" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label3" runat="server" Text="query20"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv20" runat="server"></asp:GridView>
                  </div>
              </td>
          </tr>
          <tr>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label4" runat="server" Text="query21"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv21" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label12" runat="server" Text="query22"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv22" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label5" runat="server" Text="query23"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv23" runat="server"></asp:GridView>
                  </div>
              </td>
          </tr>
          <tr>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label6" runat="server" Text="query24"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv24" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label7" runat="server" Text="query25"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv25" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label8" runat="server" Text="query26"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv26" runat="server"></asp:GridView>
                  </div>
              </td>
          </tr>
          <tr>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label9" runat="server" Text="query27"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv27" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label10" runat="server" Text="query28"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv28" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label11" runat="server" Text="query29"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv29" runat="server"></asp:GridView>
                  </div>
              </td>
          </tr>
          <tr>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label13" runat="server" Text="query30"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv30" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label14" runat="server" Text="query31"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv31" runat="server"></asp:GridView>
                  </div>
              </td>
              <td>
                  <div>
                      <asp:Label width=100% CssClass="labelstyle" ID="Label15" runat="server" Text="query32"></asp:Label>
                      <asp:GridView class="myGridClass" ID="gv32" runat="server"></asp:GridView>
                  </div>
              </td>
          </tr>
      </table>
      
        <br />
      
        <div align="center">
             <asp:Button class="bordereffect" ID="Button2" runat="server" Text="Anterior" OnClick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Siguiente" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
