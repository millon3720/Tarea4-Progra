using ConexionSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_4
{
    public partial class FrmBuscarEdad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Sentencia1 = "SELECT Edad FROM dbo.RegistrosPacientes";
            ClElementosConexionBdSqlServer Conexion = new ClElementosConexionBdSqlServer();
            double TotalPacientes=Conexion.SeleccionarBd(Sentencia1).Rows.Count;
            string Sentencia = "SELECT Edad FROM dbo.RegistrosPacientes where Edad<=13";
            double porcentajes = (Conexion.SeleccionarBd(Sentencia).Rows.Count / TotalPacientes)*100;
            Label1.Text = "El Porcentaje De Niños en un rango de 0 a 13 años es de " + porcentajes;
            Sentencia = "SELECT Edad FROM dbo.RegistrosPacientes where Edad>13 and Edad<30";
            porcentajes = (Conexion.SeleccionarBd(Sentencia).Rows.Count / TotalPacientes) * 100;
            Label2.Text = "El Porcentaje De Jovenes en un rango de 14 a 29 años es de " + porcentajes;
            Sentencia = "SELECT Edad FROM dbo.RegistrosPacientes where Edad>29";
            porcentajes = (Conexion.SeleccionarBd(Sentencia).Rows.Count / TotalPacientes) * 100;
            Label3.Text = "El Porcentaje De Adultos en un rango de 30 o mas años es de " + porcentajes;
        }
        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMenu.aspx");
        }
    }
}