<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Braille_Shape_Generator_Client.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Braille Shape Generator</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 47px;
        }
        .auto-style2 {
            height: 477px;
        }
        .auto-style3 {
            height: 550px;
        }
        .auto-style4 {
            width: 100%;
            height: 472px;
        }
        .auto-style7 {
            height: 49px;
        }
        .auto-style8 {
            height: 49px;
            width: 550px;
        }
        .auto-style9 {
            width: 550px;
        }
        .auto-style10 {
            margin-left: 16px;
        }
        .auto-style11 {
            margin-left: 18px;
        }
        .auto-style12 {
            width: 550px;
            height: 68px;
        }
        .auto-style13 {
            height: 68px;
        }
    </style>
</head>
<body style="height: 1080px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Montserrat Alternates Black" Font-Size="Larger" Height="40px" Text="                                          Hima's Braille Shape Generator" Width="1498px"></asp:Label>
        </div>
        <div class="auto-style2">
            <table class="auto-style4">
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates Medium" Font-Size="Larger" Text="Shapes"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates Medium" Font-Size="Larger" Text="Characters"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates Medium" Font-Size="Larger" Text="History"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label5" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Select Shape: "></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="152px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label6" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Select Character: "></asp:Label>
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="25px" Width="152px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label7" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Enter Width:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style10"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="Button1" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Lower Case" />
                        <asp:Button ID="Button2" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Upper Case" />
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label8" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Enter Height:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style10"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label9" runat="server" Font-Names="Montserrat Alternates SemiBold" Text="Enter Radius:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style11"></asp:TextBox>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates SemiBold" Font-Size="Medium" Text="Generate" />
&nbsp;
                        <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates SemiBold" Font-Size="Medium" Text="Reset" />
&nbsp;
                        <asp:Button ID="Button7" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates SemiBold" Font-Size="Medium" Text="Print" />
                    </td>
                    <td class="auto-style12">
                        <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates SemiBold" Font-Size="Medium" Text="Generate" />
&nbsp;
                        <asp:Button ID="Button6" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates SemiBold" Font-Size="Medium" Text="Reset" />
&nbsp;
                        <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Names="Montserrat Alternates SemiBold" Font-Size="Medium" Text="Print" />
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="auto-style3">
        </div>
    </form>
</body>
</html>
