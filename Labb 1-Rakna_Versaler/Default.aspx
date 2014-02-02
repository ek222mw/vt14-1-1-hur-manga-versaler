<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Labb_1_Rakna_Versaler.Default" ViewStateMode ="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <h1>Antal Versaler</h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
    <div>
    <asp:TextBox ID="VersalTextBox" runat="server"></asp:TextBox>
    </div>
        <div>
            <asp:Button ID="CountButton" runat="server" Text="Count" OnClick="CountButton_Click" />
        </div>
        <div>
            <asp:Button ID="ResetButton" runat="server" Text="Reset textfield" />
        </div>
        <p>
            <asp:Label ID="VersalLabel" runat="server" Text=""></asp:Label>

        </p>
    </form>
</body>
</html>
