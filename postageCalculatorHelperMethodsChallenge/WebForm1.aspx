<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="postageCalculatorHelperMethodsChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h3>Postal Calculator</h3>
            <br />
            <br />
            Width:<asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
            <br />
            Height:<asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
            <br />
            Length:<asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="lengthTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="Shipping" Text="Ground" AutoPostBack="True" OnCheckedChanged="groundRadioButton_CheckedChanged" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" GroupName="Shipping" Text="Air" AutoPostBack="True" OnCheckedChanged="airRadioButton_CheckedChanged" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="Shipping" Text="Next Day" AutoPostBack="True" OnCheckedChanged="nextDayRadioButton_CheckedChanged" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
