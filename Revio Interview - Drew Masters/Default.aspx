<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        Enter City :
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        Enter State:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
        <br />
        <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GO" />
        <br />
        <br />
    
    </div>
        <table style="table-layout: fixed; width: 100%">
            <tr>
                <td>DATE: </td>
                <td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="Label7" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="Label10" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>CONDITION: </td>
                <td>
                    <div style="word-wrap: break-word;">
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </div>
                </td>
                <td>
                    <div style="word-wrap: break-word;">
                        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </div>
                </td>
                <td>
                    <div style="word-wrap: break-word;">
                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                    </div>
                </td>
                <td>
                    <div style="word-wrap: break-word;">
                        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Image ID="Image1" runat="server" /></td>
                <td><asp:Image ID="Image2" runat="server" /></td>
                <td><asp:Image ID="Image3" runat="server" /></td>
                <td><asp:Image ID="Image4" runat="server" /></td>
            </tr>
            <tr>
                <td>WIND SPEED: </td>
                <td><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="Label9" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="Label12" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
