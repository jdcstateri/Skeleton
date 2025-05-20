<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddressesList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstAddressesList" runat="server" Height="370px" Width="370px"></asp:ListBox>
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 405px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 78px; top: 405px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 153px; top: 405px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        </div>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
