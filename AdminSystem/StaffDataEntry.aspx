<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 495px">
    <h3>This is the Staff Data Entry Page</h3>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Style="left: 14px; top: 53px; position: absolute; bottom: 602px;" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" Style="left: 95px; top: 50px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblName" runat="server" Style="left: 14px; top: 82px; position: absolute;" Text="Name" Width="37"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Style="left: 95px; top: 76px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblEmail" runat="server" Style="left: 14px; top: 114px; position: absolute" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" Style="left: 95px; top: 106px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Style="left: 14px; top: 147px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Style="left: 95px; top: 145px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDateAdded" runat="server" Style="left: 14px; top: 265px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" Style="left: 95px; top: 260px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblLastLogin" runat="server" Style="left: 14px; top: 231px; position: absolute; width: 95px;" Text="Last Login"></asp:Label>
            <asp:TextBox ID="txtLastLogin" runat="server" Style="left: 95px; top: 224px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="ChkAdmin" runat="server" Style="left: 95px; top: 184px; position: absolute" Text="IsAdmin" />
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Style="left: 14px; top: 525px; position: absolute; width: 66px;" Text="[lblError]"></asp:Label>
        </div>

        <h3 style="position: absolute; top: 305px; left: 8px;">This is the ActivityLogs Data Entry Page</h3>

        <div>
            <asp:Label ID="lblActivityID" runat="server" Style="left: 14px; top: 395px; position: absolute" Text="Activity ID"></asp:Label>
            <asp:TextBox ID="txtActivityID" runat="server" Style="left: 95px; top: 392px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblUserID" runat="server" Style="left: 14px; top: 354px; position: absolute" Text="User ID"></asp:Label>
            <asp:TextBox ID="txtUserID" runat="server" Style="left: 95px; top: 353px; position: absolute"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblAction" runat="server" Style="left: 17px; top: 437px; position: absolute" Text="Action"></asp:Label>
            <asp:TextBox ID="txtAction" runat="server" Style="left: 95px; top: 439px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDetail" runat="server" Style="left: 15px; top: 480px; position: absolute" Text="Details"></asp:Label>
            <asp:TextBox ID="txtDetail" runat="server" Style="left: 95px; top: 480px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Style="left: 14px; top: 569px; position: absolute; width: 66px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="Button2" runat="server" Style="left: 109px; top: 568px; position: absolute; width: 69px;" Text="Cancel" />

        </div>
    </form>
</body>
</html>
