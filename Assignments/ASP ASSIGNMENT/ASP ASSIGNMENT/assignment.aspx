<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment.aspx.cs" Inherits="ASP_ASSIGNMENT.assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="list">
    <form id="form1" runat="server">
        <div>
              <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                <asp:ListItem Text="Select an item" Value="" />
                <asp:ListItem Text="Car" Value="car" />
                <asp:ListItem Text="Bike" Value="bike" />
                <asp:ListItem Text="Truck" Value="truck" />
            </asp:DropDownList>
            <br />
            <asp:Image ID="imgDisplay" runat="server" Visible="false" />
            <br />
            <asp:Label ID="lblCost" runat="server" Text="" />
        </div>
    </form>
</body>
</html>
