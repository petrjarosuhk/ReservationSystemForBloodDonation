<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upravit_rezervaci.aspx.cs" Inherits="ReservationSystemForBloodDonation.upravit_rezervaci" %>

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

             <asp:Label ID="datumL" runat="server"></asp:Label><br/>
             <asp:Label ID="mistoL" runat="server"></asp:Label><br/>
             <asp:Label ID="casL" runat="server"></asp:Label><br/>
             <asp:Label ID="cisloL" runat="server"></asp:Label><br/>

            <asp:Button ID="vymazat_rezervaci" runat="server" Text="Vymazat rezervaci" OnClick="vymazat_rezervaci_Click" />
            <asp:Button ID="zpet" runat="server" Text="Zpět" OnClick="zpet_Click" />
        </div>
    </form>
</body>
</html>
