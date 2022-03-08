<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uprava_mista.aspx.cs" Inherits="ReservationSystemForBloodDonation.uprava_mista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="login" runat="server"></asp:Label><br/>
            Číslo rezervace:<asp:TextBox ID="darec" runat="server"></asp:TextBox>
            <asp:Button ID="vyhledat" runat="server" Text="Vyhledej rezervaci" OnClick="vyhledat_Click" /><br/>
            Rodné číslo:<asp:TextBox ID="cislodarce2" runat="server"></asp:TextBox>
            <asp:Button ID="zmenit_udaje" runat="server" Text="Změnit údaje o dárci" OnClick="zmenit_udaje_Click" /><br/>
             Rodné číslo:<asp:TextBox ID="rodneCislo3" runat="server"></asp:TextBox>
            <asp:Button runat="server" Text="Aktualizovat důležité informace o dárci" OnClick="Unnamed1_Click" /><br/>
            <asp:Button id="odhlasitSe" runat="server" Text="Odhlásit se" OnClick="odhlasitSe_Click"/>
        </div>
    </form>
</body>
</html>
