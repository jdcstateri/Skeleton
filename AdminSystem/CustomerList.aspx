<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="370px" Width="370px"></asp:ListBox>
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 405px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 78px; top: 405px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 153px; top: 405px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Label ID="lblName" runat="server" Text="Enter a Name" style="z-index: 1; left: 10px; top: 460px; position: absolute; right: 1531px;"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 152px; top: 458px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" Text="Apply Filter" style="z-index: 1; left: 10px; top: 493px; position: absolute" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear Filter" style="z-index: 1; left: 145px; top: 493px; position: absolute" OnClick="btnClear_Click" />
            <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 279px; top: 493px; position: absolute" Text="Return to Main Menu" OnClick="btnReturn_Click" />
        </div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 535px; position: absolute"></asp:Label>
    </form>
</body>
</html>
