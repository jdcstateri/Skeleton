<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivityLogDataEntry.aspx.cs" Inherits="ActivityLogDataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activity Log Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Activity Log Details</h3>

        <asp:Label runat="server" Text="Activity ID:" />
        <asp:TextBox ID="txtActivityId" runat="server" ReadOnly="true" /><br />

        <asp:Label runat="server" Text="User ID:" />
        <asp:TextBox ID="txtUserId" runat="server" ReadOnly="true" /><br />

        <asp:Label runat="server" Text="Action:" />
        <asp:TextBox ID="txtAction" runat="server" ReadOnly="true" /><br />

        <asp:Label runat="server" Text="Detail:" />
        <asp:TextBox ID="txtDetail" runat="server" ReadOnly="true" /><br />

        <asp:Label runat="server" Text="Timestamp:" />
        <asp:TextBox ID="txtTimeStamp" runat="server" ReadOnly="true" /><br />

        <asp:Label ID="lblError" runat="server" ForeColor="Red" /><br />

        <asp:Button ID="btnBack" runat="server" Text="Back to List" OnClick="btnBack_Click" />
    </form>
</body>
</html>
