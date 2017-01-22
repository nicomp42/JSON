<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtJson" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
        <br />
    </div>
    </form>
</body>
</html>
