<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator.aspx.cs" Inherits="asp.validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script>
        function validateForm() {
            const name = document.getElementById("name").value;
            const familyName = document.getElementById("familyName").value;
            const address = document.getElementById("address").value;
            const city = document.getElementById("city").value;
            const zipCode = document.getElementById("zipCode").value;
            const phone = document.getElementById("phone").value;
            const email = document.getElementById("email").value;

            const validationResult = document.getElementById("validationResult");
            validationResult.innerHTML = "";

            if (name === familyName) {
                validationResult.innerHTML += "Name and Family Name must be different.<br>";
            }
            if (address.length < 2) {
                validationResult.innerHTML += "Address should have at least 2 letters.<br>";
            }
            if (city.length < 2) {
                validationResult.innerHTML += "City should have at least 2 letters.<br>";
            }
            if (!/^\d{5}$/.test(zipCode)) {
                validationResult.innerHTML += "Zip Code should have 5 digits.<br>";
            }
            if (!/^\d{2}-\d{7}$|^\d{3}-\d{7}$/.test(phone)) {
                validationResult.innerHTML += "Phone should be in the format XX-XXXXXXX or XXX-XXXXXXX.<br>";
            }
            if (!/^\S+@\S+\.\S+$/.test(email)) {
                validationResult.innerHTML += "Email is not valid.<br>";
            }

            if (validationResult.innerHTML === "") {
                validationResult.innerHTML = "Validation successful!";
            }

            return false; // Prevent form submission
        }
    </script>
</head>
<body>
    <form>
        <div>
            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtFamilyName">Family Name:</label>
            <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtAddress">Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtCity">City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtZipCode">Zip Code:</label>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtPhone">Phone:</label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
            <asp:Label ID="resultLabel" runat="server" EnableViewState="false"></asp:Label>
        </div>

    </form>
</body>
</html>
