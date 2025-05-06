<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddressesDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <form id="form1" runat="server">
            <asp:Label ID="lblAddressID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Address ID" width="97px"></asp:Label>
            <asp:TextBox ID="txtAddressID" runat="server" style="z-index: 1; left: 122px; top: 34px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblAccountID" runat="server" style="z-index: 1; left: 11px; top: 61px; position: absolute" Text="Account ID" width="97px"></asp:Label>
            <asp:TextBox ID="txtAccountID" runat="server" style="z-index: 1; left: 122px; top: 61px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 87px; position: absolute" Text="Address" width="97px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 122px; top: 87px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute" Text="Post Code" width="97px"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 122px; top: 109px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 132px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 122px; top: 132px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 122px; top: 158px; position: absolute" Text="Active" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 179px; position: absolute"></asp:Label>
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 10px; top: 209px; position: absolute" Text="Ok" OnClick="btnOk_Click" width="60px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 122px; top: 209px; position: absolute" Text="Cancel" />
        </form>
    </div>
</body>
</html>
