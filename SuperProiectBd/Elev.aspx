<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Elev.aspx.cs" Inherits="SuperProiectBd.Elev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 780px;
            height: 617px;
        }
        .auto-style2 {
            width: 389px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Esti logat ca elev!" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Urmatoarele tale ore de legislatie:<asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
                </td>
                <td class="auto-style2">Urmatoarele tale ore de condus:<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Expirare licenta profesori:</td>
                <td class="auto-style2">Expirare licenta instructori:</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridView3" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style2">
                    <asp:GridView ID="GridView4" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
