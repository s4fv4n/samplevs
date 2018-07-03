<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerEntry.aspx.cs" Inherits="CustomerDataEntryWeb.CustomerEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerCountry" runat="server" Text="Customer Country"></asp:Label>
        <asp:DropDownList ID="ddlCountryName" runat="server">
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>Pakistan</asp:ListItem>
            <asp:ListItem>UAE</asp:ListItem>
            <asp:ListItem>Canada</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:RadioButton ID="rbtnMale" runat="server" GroupName="Sex" Text="Male" />
        <asp:RadioButton ID="rbtnFemale" runat="server" GroupName="Sex" Text="Female" />
        <br />
        <br />
        <asp:CheckBox ID="chkbxReading" runat="server" Text="Reading" />
        <asp:CheckBox ID="chkbxPainting" runat="server" Text="Painting" />
        <br />
        <br />
        <asp:RadioButton ID="rbtnMarried" runat="server" GroupName="Status" Text="Married" />
        <asp:RadioButton ID="rbtnSingle" runat="server" GroupName="Status" Text="Single" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        <br />
        <br />
        <asp:GridView ID="GridCustomers" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
