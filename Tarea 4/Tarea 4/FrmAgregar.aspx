<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAgregar.aspx.cs" Inherits="Tarea_4.FrmAgregar" %>

<!DOCTYPE html>
<link href="StyleSheet1.css" rel="stylesheet" />
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
               <div class="col-aut" >
        <asp:Label ID="Label1" runat="server" Text="Nombre" Font-Size="Larger"></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Edad" Font-Size="Larger"></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="TxtEdad" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Genero" Font-Size="Larger"></asp:Label>
&nbsp;<br />
                   <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Font-Size="Larger" Text="Hombre" />
                   <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Font-Size="Larger" Text="Mujer" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Direccion" Font-Size="Larger"></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Telefono" Font-Size="Larger"></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <br />
&nbsp;<br />
        <asp:CheckBox ID="CbSeguro" runat="server" Text="El Paciente Tiene Seguro?" Font-Size="Larger" />
            <br />
           
        <br />
        <asp:Button ID="BtnAgregar" runat="server" Height="55px" Text="Guardar" Width="110px" OnClick="BtnAgregar_Click" CssClass="btn btn-success" Font-Size="Larger" />
        <asp:Button ID="Button1" runat="server" Height="55px" Text="Volver" Width="110px" OnClick="Volver_Click" CssClass="btn btn-success" Font-Size="Larger" />
        <br />
            </div>
            </center>
    </form>
</body>
</html>
