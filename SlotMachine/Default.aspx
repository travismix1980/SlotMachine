<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SlotMachine.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome To The Slot Machine<br />
            </h1>
            <br />
            <asp:Image ID="Image1" runat="server" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="1px" Height="164px" Width="164px" />
            <asp:Image ID="Image2" runat="server" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="1px" Height="164px" Width="164px" />
            <asp:Image ID="Image3" runat="server" BorderColor="#3333CC" BorderStyle="Solid" BorderWidth="1px" Height="164px" Width="164px" />
            <br />
            <br />
            Your Bet: <asp:TextBox ID="TxtBet" runat="server" TextMode="Number" ToolTip="Enter a whole number for your bet then pull the lever!"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnLever" runat="server" OnClick="BtnLever_Click" Text="Pull The Lever" />
            <br />
            <br />
            <asp:Label ID="LblResult" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LblMoney" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; - 2x Your Bet<br />
            2 Cherries&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; - 3x Your Bet<br />
            3 Cherries&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; - 4x Your Bet<br />
            3 HorseShoes - 100x Your Bet!!!</div>
    </form>
</body>
</html>
