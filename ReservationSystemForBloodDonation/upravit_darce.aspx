<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upravit_darce.aspx.cs" Inherits="ReservationSystemForBloodDonation.upravit_darce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox id="jmenoT" runat="server"></asp:TextBox><br/>
               <asp:TextBox id="prijmeniT" runat="server"></asp:TextBox><br/>
               <asp:TextBox id="uliceT" runat="server"></asp:TextBox><br/>
               <asp:TextBox id="pscT" runat="server"></asp:TextBox><br/>
               <asp:TextBox id="mestoT" runat="server"></asp:TextBox><br/>
               <asp:TextBox id="telefonT" runat="server"></asp:TextBox><br/>
               <asp:TextBox id="emailT" runat="server"></asp:TextBox><br/>
              <asp:TextBox id="rcT" runat="server"></asp:TextBox><br/>
            <asp:Button ID="aktualizovat" runat="server" Text="Aktualizovat a uložit údaje" OnClick="aktualizovat_Click" /><br/>
            <asp:Button ID="zobrazit" runat="server" Text="Zobrazit dárce" OnClick="zobrazit_Click"/><br/>
            <asp:Button ID="zpet" runat="server" Text="Zpět" OnClick="zpet_Click"/>
        </div>
    </form>
</body>
</html>
