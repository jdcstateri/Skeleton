<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductUserLogin.aspx.cs" Inherits="ProductUserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product User Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f4f4f4;
        }
        .login-container {
            width: 350px;
            margin: 50px auto;
            padding: 30px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        h2 {
            color: #333;
            margin-bottom: 20px;
        }
        .input-group {
            margin-bottom: 15px;
            text-align: left;
        }
        .input-group label {
            display: inline-block;
            width: 90px; 
            text-align: right;
            margin-right: 10px;
            font-weight: bold;
        }
        .input-group input[type="text"],
        .input-group input[type="password"] {
            width: calc(100% - 110px); 
            padding: 8px;
            border: 1px solid #ddd;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .buttons-group {
            margin-top: 20px;
            text-align: center;
        }
        .buttons-group .asp-button { 
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            margin: 0 5px;
            transition: background-color 0.3s ease;
        }
        .buttons-group #btnLogin {
            background-color: #007bff;
            color: white;
        }
        .buttons-group #btnLogin:hover {
            background-color: #0056b3;
        }
        .buttons-group #btnCancel {
            background-color: #6c757d;
            color: white;
        }
        .buttons-group #btnCancel:hover {
            background-color: #5a6268;
        }
        .error-message {
            color: red;
            margin-top: 15px;
            text-align: center;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Product Users Login</h2>

            <div class="input-group">
                <label for="txtUserName">Email :</label>
                <asp:TextBox ID="txtPEmail" runat="server"></asp:TextBox>
            </div>

            <div class="input-group">
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            
            <div class="buttons-group">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="asp-button" OnClick="btnLogin_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="asp-button" OnClick="btnCancel_Click" />
            </div>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-message"></asp:Label>
        </div>
    </form>
</body>
</html>