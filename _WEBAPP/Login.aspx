<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_WEBAPP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 51%;
            height: 162px;
        }
        .auto-style2 {
            width: 253px;
            text-align: right;
        }
        .auto-style3 {
            width: 1263px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; font-size: xx-large; text-align: center">
            Login Page</div>
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style2">Username</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxUsername" runat="server" Width="327px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="327px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="field is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button_Login" runat="server" OnClick="Button_Login_Click" Text="Login" Width="129px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
