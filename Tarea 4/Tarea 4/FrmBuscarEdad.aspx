<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmBuscarEdad.aspx.cs" Inherits="Tarea_4.FrmBuscarEdad" %>

<!DOCTYPE html>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <br />
        <br />
        <br />
        <div>  <center>      <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Larger"></asp:Label>
            <br />
        <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="Larger"></asp:Label>
            <br />
        <asp:Label ID="Label3" runat="server" Text="Label" Font-Size="Larger"></asp:Label>

            <br />
            <br />
                    <asp:Button ID="Button1" runat="server" Height="55px" Text="Volver" Width="110px" OnClick="Volver_Click" CssClass="btn btn-success" Font-Size="Larger" />
</center>

        </div>
    </form>
</body>
</html>
