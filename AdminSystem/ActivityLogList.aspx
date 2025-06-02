<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivityLogList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Activity Log List</title>
    <style>
        .container {
            margin: 20px;
        }
        .listbox {
            width: 900px;
            height: 300px;
        }
        .buttons {
            margin-top: 10px;
        }
        #lblError {
            color: red;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h3>Activity Log List</h3>
            <asp:ListBox ID="lstActivityLogList" runat="server" CssClass="listbox"></asp:ListBox>

            <div class="buttons">
                <asp:Button ID="BtnView" runat="server" Text="View" OnClick="BtnView_Click" />
            </div>

            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
