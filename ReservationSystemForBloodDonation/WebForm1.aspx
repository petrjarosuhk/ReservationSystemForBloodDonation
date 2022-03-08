<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ReservationSystemForBloodDonation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="get">
      <div>
    <label for="searchGenre">Genre to look for:</label>
    <input type="text" name="searchGenre" value="" />
    <input type="Submit" value="Search Genre" /><br/>
    (Leave blank to list all movies.)<br/>
    </div>
    </form>
</body>
</html>
