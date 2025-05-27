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
            <asp:Button ID="BtnAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" Style="left: 15px; top: 356px; position: absolute" />
            <asp:Button ID="BtnEdit" runat="server" OnClick="ButtonEdit_Click1" Text="Edit" Style="left: 79px; top: 356px; position: absolute" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" Style="left: 137px; top: 356px; position: absolute" />
        </div>
        <div>
             <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 18px; top: 405px; position: absolute" Text="Filter By Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 137px; top: 403px; position: absolute"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BtnFilter" runat="server" OnClick="ButtonFilter_Click" Text="Apply Filter" Style="left: 15px; top: 450px; position: absolute" />
            <asp:Button ID="BtnClear" runat="server" OnClick="ButtonClear_Click" Text="Clear Filter" Style="left: 137px; top: 450px; position: absolute" />
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text="[lblError]" Style="z-index: 1; left: 14px; top: 500px; position: absolute; height: 73px; width: 322px"></asp:Label>
        </div>
             
    </form>
</body>
</html>
