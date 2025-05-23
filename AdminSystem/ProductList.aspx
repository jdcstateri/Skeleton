<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="297px" Width="319px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd_Click" runat="server" OnClick="btnAdd_Click_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
