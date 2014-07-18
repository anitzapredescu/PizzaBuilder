<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaBuilder.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza builder</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Crează pizza:</div>

        <div>
            <label>Tip:</label>
            <asp:DropDownList ID="selectPizzaType" runat="server" Width="200" OnSelectedIndexChanged="typeChanged" AutoPostBack="True" />
        </div>

        <div>
            <label>Dimensiune:</label>
            <asp:DropDownList ID="selectDimension" runat="server" Width="200" OnSelectedIndexChanged="dimensionChanged" AutoPostBack="True" />
        </div>

        <div>
            <label>Blat:</label>
            <asp:DropDownList ID="selectDoughType" runat="server" Width="200" OnSelectedIndexChanged="doughChanged" AutoPostBack="True" />
        </div> 
        <div>
            <label>Extra toppings:</label>
            <asp:CheckBoxList ID="selecttoppings" runat="server" OnSelectedIndexChanged="toppingsChanged" AutoPostBack="True"/>
        </div>

        <div>
            <label>Pizza creată:</label>
            <asp:TextBox ID="textArea" runat="server" Width="250" TextMode="MultiLine" Height="150" />
        </div>
    </form>
</body>
</html>
