<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dulezite_informace.aspx.cs" Inherits="ReservationSystemForBloodDonation.dulezite_informace" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Čísilo dárce:<asp:TextBox runat="server" ID="cisloT"></asp:TextBox><br/>
             Typ krve:<asp:TextBox runat="server" ID="typT"></asp:TextBox><br/>
             Počet darování:<asp:TextBox runat="server" ID="pocetT"></asp:TextBox>  <br/>
             Rodné číslo:<asp:TextBox runat="server" ID="rodne_cisloT"></asp:TextBox><br/>
            <asp:Button ID="zobrazit" runat="server" Text="Zobrazit údaje" OnClick="zobrazit_Click"/><br/>
            <asp:Button ID="aktualizovat" runat="server" Text="Aktualizovat údaje" OnClick="aktualizovat_Click"/><br/>
            <asp:Button ID="zpet" runat="server" Text="Zpět" OnClick="zpet_Click"/>
        </div>
    </form>
</body>
</html>
