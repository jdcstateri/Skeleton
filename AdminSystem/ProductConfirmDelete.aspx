<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Deletion</title>
    <style>
        /* Center the form container in the viewport */
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f2f5;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            box-sizing: border-box;
        }

        /* Confirmation dialog box styling */
        .confirm-dialog-container {
            position: relative;
            width: 350px;
            height: 180px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            overflow: hidden;
            padding: 20px;
            box-sizing: border-box;
        }

        /* Confirmation message */
        .confirm-dialog-container p {
            position: absolute;
            left: 20px;
            top: 50px;
            width: calc(100% - 40px);
            text-align: center;
            font-size: 1.1em;
            color: #333;
            margin: 0;
        }

        /* Button base style */
        .confirm-button {
            height: 35px;
            width: 80px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1em;
            font-weight: bold;
            color: white;
            transition: background-color 0.2s, transform 0.1s;
        }

        /* Yes button: red, left side */
        #btnYes {
            background-color: #dc3545;
            position: absolute;
            left: 80px;
            top: 120px;
        }

        #btnYes:hover {
            background-color: #c82333;
            transform: translateY(-1px);
        }

        /* No button: gray, right side */
        #btnNo {
            background-color: #6c757d;
            position: absolute;
            left: 190px;
            top: 120px;
        }

        #btnNo:hover {
            background-color: #5a6268;
            transform: translateY(-1px);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="confirm-dialog-container">
            <p>Are you sure you want to delete this record?</p>

            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" CssClass="confirm-button" />

            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" CssClass="confirm-button" />
        </div>
    </form>
</body>
</html>