<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivityLogDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>This is the Activity Log Data Entry Page</h3>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblActivityId" runat="server" Style="left: 16px; top: 54px; position: absolute" Text="Activity ID"></asp:Label>
            <asp:TextBox ID="txtActivityId" runat="server" Style="left: 96px; top: 54px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblUserId" runat="server" Style="left: 16px; top: 90px; position: absolute" Text="User ID"></asp:Label>
            <asp:TextBox ID="txtUserId" runat="server" Style="left: 96px; top: 90px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblAction" runat="server" Style="left: 16px; top: 126px; position: absolute" Text="Action"></asp:Label>
            <asp:TextBox ID="txtAction" runat="server" Style="left: 96px; top: 125px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDetail" runat="server" Style="left: 16px; top: 161px; position: absolute" Text="Details"></asp:Label>
            <asp:TextBox ID="txtDetail" runat="server" Style="left: 96px; top: 157px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDateAdded" runat="server" Style="left: 16px; top: 203px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" Style="left: 96px; top: 199px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Style="left: 22px; top: 251px; position: absolute; width: 66px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="Button2" runat="server" Style="left: 115px; top: 252px; position: absolute; width: 69px;" Text="Cancel" />
        </div>
    </form>
</body>
</html>
