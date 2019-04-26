<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Ejercicios3y4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label14" runat="server" Text="Ejercicios PDF 3"></asp:Label>
       <table>
           <tr>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label1" runat="server" Text="query33"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv33" runat="server"></asp:GridView>
                   </div>
               </td>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label2" runat="server" Text="query34"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv34" runat="server"></asp:GridView>
                   </div>
               </td>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label3" runat="server" Text="query35"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv35" runat="server"></asp:GridView>
                   </div>
               </td>
           </tr>
            <tr>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label4" runat="server" Text="query36"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv36" runat="server"></asp:GridView>
                   </div>
               </td>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label5" runat="server" Text="query37"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv37" runat="server"></asp:GridView>
                   </div>
               </td>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label6" runat="server" Text="query38"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv38" runat="server"></asp:GridView>
                   </div>
               </td>
           </tr>
            <tr>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label7" runat="server" Text="query39"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv39" runat="server"></asp:GridView>
                   </div>
               </td>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label8" runat="server" Text="query40"></asp:Label>
                        <asp:GridView class="myGridClass" ID="gv40" runat="server"></asp:GridView>
                   </div>
                   
               </td>
               <td>
                   <div>
                       <asp:Label width=100% CssClass="labelstyle" ID="Label9" runat="server" Text="query41"></asp:Label>
                       <asp:GridView class="myGridClass" ID="gv41" runat="server"></asp:GridView>
                   </div>
               </td>
           </tr>
                        

       </table> 
        <br />
        <div align="center">
        <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Anterior" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button class="bordereffect" ID="Button2" runat="server" Text="Siguiente" OnClick="Button2_Click" />
    </div>
    </form>
   
</body>
</html>
