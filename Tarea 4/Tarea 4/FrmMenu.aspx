<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMenu.aspx.cs" Inherits="Tarea_4.FrmMenu" %>

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
        <div>
            <center>
            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar Paciente" CssClass="btn btn-success" OnClick="BtnAgregar_Click" Height="117px" Width="190px" />
            <asp:Button ID="BtnPacientes" runat="server" Text="Mostrar Pacientes" CssClass="btn btn-success" OnClick="BtnPacientes_Click" Height="117px" Width="190px" />
            <asp:Button ID="BtnBuscarPaciente" runat="server" Text="Buscar Paciente" CssClass="btn btn-success" OnClick="BtnBuscarPaciente_Click" Height="117px" Width="190px" />
            <asp:Button ID="BtnEdad" runat="server" Text="Mostrar Rangos Edades" CssClass="btn btn-success" OnClick="BtnEdad_Click" Height="117px" Width="190px" />
            <asp:Button ID="BtnGenero" runat="server" Text="Mostrar Rangos Generos" CssClass="btn btn-success" OnClick="BtnGenero_Click" Height="117px" Width="190px" />
            <asp:Button ID="BtnSeguro" runat="server" Text="Mostrar Rangos Seguros" CssClass="btn btn-success" OnClick="BtnSeguro_Click" Height="117px" Width="190px" />
      </center>
        </div>
    </form>
</body>
</html>
