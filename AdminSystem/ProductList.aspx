<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>


<head runat="server">
    <title>Product List</title>
    <style>
        /* Main page layout and background */
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f2f5; 
            margin: 20px;
            padding: 0;
            display: flex;
            justify-content: center; 
            align-items: flex-start; 
            min-height: 100vh;
            box-sizing: border-box;
        }

        /* Container for the list and all its elements */
        .list-container {
            background-color: #ffffff; 
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1); 
            width: 450px;
            box-sizing: border-box;
            text-align: left;
        }

        /* Page heading */
        .list-container h2 {
            margin-top: 0;
            margin-bottom: 25px;
            color: #333;
            text-align: center;
        }

        /* Container for the ListBox */
        .list-box-area {
            margin-bottom: 20px;
            display: flex;
            justify-content: center;
        }

        /* Actual ListBox control styling */
        .list-box-area select {
            height: 297px;
            width: 319px;
            border: 1px solid #ccc;
            border-radius: 5px;
            padding: 10px;
            box-sizing: border-box;
        }

        /* Grouping for Add, Edit, Delete buttons */
        .action-buttons-top {
            display: flex;
            justify-content: center;
            gap: 25px; 
            margin-bottom: 20px;
        }

        /* Shared style for all buttons */
        .asp-button {
            padding: 10px 18px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1em;
            font-weight: bold;
            transition: background-color 0.2s ease-in-out, transform 0.1s ease-in-out;
            color: white;
            width: 90px;
            box-sizing: border-box;
        }

        /* Add button style */
        #btnAdd_Click {
            background-color: #007bff;
        }
        #btnAdd_Click:hover {
            background-color: #0056b3;
            transform: translateY(-1px);
        }

        /* Edit button style */
        #btn_Edit {
            background-color: #ffc107;
            color: #333; 
        }
        #btn_Edit:hover {
            background-color: #e0a800;
            transform: translateY(-1px);
        }

        /* Delete button style */
        #btnDelete {
            background-color: #dc3545;
        }
        #btnDelete:hover {
            background-color: #c82333;
            transform: translateY(-1px);
        }

        /* Filter area layout */
        .filter-group {
            display: flex;
            align-items: center;
            justify-content: center;
            margin-bottom: 15px;
            gap: 15px;
        }

        .filter-group label {
            font-weight: bold;
            color: #333;
        }

        .filter-group input[type="text"] {
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 5px;
            width: 230px;
            box-sizing: border-box;
        }

        /* Filter button layout and spacing */
        .filter-buttons {
            display: flex;
            gap: 10px;
        }

        /* Styling for Apply/Clear filter buttons */
        #btnApplyFilter, #btnClearFilter {
            background-color: #6c757d;
            width: 120px;
            
        }
        #btnApplyFilter:hover, #btnClearFilter:hover {
            background-color: #5a6268;
            transform: translateY(-1px);
        }

        /* Error message appearance - REMOVED BORDER AND BACKGROUND */
        .error-message {
            color: red; 
            font-weight: bold; 
            text-align: center;
            margin-top: 20px;
            border: none; 
            background-color: transparent; 
            
            display: block;
        }

        /* Back button position and style */
        #btnBack {
            background-color: #17a2b8;
            position: absolute;
            top: 72px; 
            right: 510px; 
            height: 48px;
            width: 90px;
        }
        #btnBack:hover {
            background-color: #138496;
            transform: translateY(-1px);
        }
    </style>

    <script type="text/javascript">
        // Hides the error message label after a short delay (5 seconds)
        function hideErrorAfterDelay() {
            var errorLabel = document.getElementById('<%= lblError.ClientID %>');
            if (errorLabel && errorLabel.style.display !== 'none' && errorLabel.innerText.trim() !== '') {
                setTimeout(function () {
                    errorLabel.style.display = 'none';
                    errorLabel.innerText = '';
                }, 5000); // Automatically disappear after 5 seconds
            }
        }

        // Start the error message timer when the page fully loads
        window.onload = function () {
            hideErrorAfterDelay();
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <div class="list-container">
            <h2>Product List</h2>

            <div class="list-box-area">
                <asp:ListBox ID="lstProductList" runat="server"></asp:ListBox>
            </div>

            <div class="action-buttons-top">
                <asp:Button ID="btnAdd_Click" runat="server" OnClick="btnAdd_Click_Click" Text="Add" CssClass="asp-button" />
                <asp:Button ID="btn_Edit" runat="server" Text="Edit" OnClick="btn_Edit_Click" CssClass="asp-button" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="asp-button" />
            </div>

            <div class="filter-group">
                <asp:Label ID="lblFilterPrompt" runat="server" Text="Enter a Product Title"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server" OnTextChanged="txtFilter_TextChanged"></asp:TextBox>
            </div>

            <div class="filter-buttons">
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" CssClass="asp-button" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" CssClass="asp-button" />
            </div>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-message" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>