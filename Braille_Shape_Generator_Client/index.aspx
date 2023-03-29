<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Braille_Shape_Generator_Client.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Braille Shape Generator</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Radius: </td>
                    <td><asp:TextBox ID="circle_radius" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="print_circle" runat="server" Text="Print" OnClick="print_circle_Click" /></td>
                    <td><asp:Button ID="reset_radius" runat="server" Text="Reset" /></td>
                </tr>
                <tr>
                    <td>
                        <!-- Result -->
                        <asp:Label ID="circle_result" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
