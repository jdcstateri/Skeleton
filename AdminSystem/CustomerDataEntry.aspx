<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <form id="form1" runat="server">
            <asp:Label ID="lblAccountID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Account ID" width="97px"></asp:Label>
            <asp:TextBox ID="txtAccountID" runat="server" style="z-index: 1; left: 122px; top: 34px; position: absolute; right: 1145px;"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 11px; top: 61px; position: absolute" Text="Name" width="97px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 122px; top: 61px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 87px; position: absolute" Text="Email" width="97px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 122px; top: 87px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute" Text="Password" width="97px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 122px; top: 109px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDateRegistered" runat="server" style="z-index: 1; left: 10px; top: 132px; position: absolute" Text="Date Registered"></asp:Label>
            <asp:TextBox ID="txtDateRegistered" runat="server" style="z-index: 1; left: 122px; top: 132px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkVerified" runat="server" style="z-index: 1; left: 122px; top: 158px; position: absolute" Text="Verified" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 179px; position: absolute"></asp:Label>
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 10px; top: 209px; position: absolute" Text="Ok" OnClick="btnOk_Click" width="60px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 122px; top: 209px; position: absolute" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 280px; top: 34px; position: absolute" Text="Find" height="22px" OnClick="btnFind_Click" width="60px" />
        </form>
    </div>
</body>
</html>
