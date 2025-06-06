<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>


<head runat="server">
    <title>Product Management System</title>
    <script type="text/javascript">
        function hideErrorAfterDelay() {
            var errorLabel = document.getElementById('<%= lblError.ClientID %>');

            //If an error is currently visible, hide it after a short delay
            if (errorLabel && errorLabel.style.display !== 'none' && errorLabel.innerText.trim() !== '') {
                setTimeout(function () {
                    errorLabel.style.display = 'none';
                    errorLabel.innerText = ''; //clear the message as well
                }, 5000); //a 5 second delay to give users time to read it
            }
        }

        // Run the error hiding logic when the page loads
        window.onload = function () {
            hideErrorAfterDelay();
        };
    </script>
    <style>
        /* Set up the page background and font */
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

        /* Style for the error message label */
        .error-message {
            color: red;
            font-weight: bold;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <div style="position: relative; width: 504px; height: 556px; margin: 20px auto; background-color: #ffffff; border-radius: 5px; box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); overflow: hidden; top: -50px; left: -22px;">

            <h2 style="position: absolute; left: 20px; top: 20px; font-family: Arial, sans-serif; color: #333; margin: 0; padding: 0;">Product Management System</h2>

            <asp:Label ID="lblItemId" runat="server" Text="Item ID" style="position: absolute; left: 20px; top: 70px; font-family: Arial, sans-serif;"></asp:Label>
            <asp:TextBox ID="txtItemID" runat="server" style="position: absolute; left: 140px; top: 65px; width: 150px; border: 1px solid #ccc; padding: 5px; border-radius: 4px;"></asp:TextBox>

            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" style="border-style: none; border-color: inherit; border-width: medium; position: absolute; left: 320px; top: 65px; height: 39px; width: 71px; background-color: #007bff; color: white; border-radius: 4px; cursor: pointer;"></asp:Button>
            <asp:Button ID="btnFClear" runat="server" Text="Clear" OnClick="btnFClear_Click" style="border-style: none; border-color: inherit; border-width: medium; position: absolute; left: 399px; top: 65px; height: 39px; width: 75px; background-color: #007bff; color: white; border-radius: 4px; cursor: pointer;"></asp:Button>

            <asp:Label ID="lblProductTitle" runat="server" Text="Product Title" style="position: absolute; left: 20px; top: 110px; font-family: Arial, sans-serif;"></asp:Label>
            <asp:TextBox ID="txtProductTitle" runat="server" style="position: absolute; left: 140px; top: 105px; width: 148px; border: 1px solid #ccc; padding: 5px; border-radius: 4px;"></asp:TextBox>

            <asp:Label ID="lblProductDescription" runat="server" Text="Product Description" style="position: absolute; left: 15px; top: 150px; font-family: Arial, sans-serif;"></asp:Label>
            <asp:TextBox ID="txtProductDescription" runat="server" TextMode="MultiLine" style="position: absolute; left: 16px; top: 176px; height: 75px; width: 290px; border: 1px solid #ccc; padding: 5px; border-radius: 4px;"></asp:TextBox>

            <asp:Label ID="lblPrice" runat="server" Text="Price" style="position: absolute; left: 21px; top: 285px; font-family: Arial, sans-serif;"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="position: absolute; left: 154px; top: 278px; width: 150px; border: 1px solid #ccc; padding: 5px; border-radius: 4px;"></asp:TextBox>

            <asp:Label ID="lblStockNumber" runat="server" Text="Stock Number" style="position: absolute; left: 19px; top: 330px; font-family: Arial, sans-serif;"></asp:Label>
            <asp:TextBox ID="txtStockNumber" runat="server" style="position: absolute; left: 153px; top: 321px; width: 150px; border: 1px solid #ccc; padding: 5px; border-radius: 4px;"></asp:TextBox>

            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" style="position: absolute; left: 20px; top: 363px; font-family: Arial, sans-serif;"></asp:Label>
           <asp:TextBox ID="txtDateAdded" runat="server" TextMode="Date" style="position: absolute; left: 153px; top: 357px; width: 150px; border: 1px solid #ccc; padding: 5px; border-radius: 4px;"></asp:TextBox>

            <asp:CheckBox ID="chkIsPublished" runat="server" Text="Is Published" style="position: absolute; left: 315px; top: 397px; font-family: Arial, sans-serif;"></asp:CheckBox>

            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" style="border-style: none; border-color: inherit; border-width: medium; position: absolute; left: 293px; top: 431px; height: 34px; width: 65px; background-color: #28a745; color: white; border-radius: 4px; cursor: pointer;"></asp:Button>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="border-style: none; border-color: inherit; border-width: medium; position: absolute; left: 373px; top: 432px; height: 33px; width: 62px; background-color: #dc3545; color: white; border-radius: 4px; cursor: pointer;" OnClick="btnCancel_Click"></asp:Button>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-message" Visible="False" style="position: absolute; left: 42px; top: 504px; width: calc(100% - 40px);"></asp:Label>
        </div>
    </form>
</body>
</html>
