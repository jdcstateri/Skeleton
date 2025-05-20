<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="320px" Width="330px"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="BtnAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" style="left: 15px; top: 356px; position: absolute"/>
            <asp:Button ID="BtnEdit" runat="server" OnClick="ButtonEdit_Click1" Text="Edit" style="left: 79px; top: 356px; position: absolute" />
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text="[lblError]" style="z-index: 1; left: 14px; top: 394px; position: absolute; height: 73px; width: 322px"></asp:Label>
            
        </div>
    </form>
</body>
</html>
