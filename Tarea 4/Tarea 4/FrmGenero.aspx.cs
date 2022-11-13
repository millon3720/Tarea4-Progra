using ConexionSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_4
{
    public partial class FrmGenero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Sentencia1 = "SELECT Sexo FROM dbo.RegistrosPacientes";
            ClElementosConexionBdSqlServer Conexion = new ClElementosConexionBdSqlServer();
            double TotalPacientes = Conexion.SeleccionarBd(Sentencia1).Rows.Count;
            string Sentencia = "SELECT Sexo FROM dbo.RegistrosPacientes where Sexo=Hombres";
            double porcentajes = (Conexion.SeleccionarBd(Sentencia).Rows.Count / TotalPacientes) * 100;
            Label1.Text = "El Porcentaje De Hombres Hospitalizados Es De:" + porcentajes; 
            Sentencia = "SELECT Sexo FROM dbo.RegistrosPacientes where Sexo=Mujeres";
            porcentajes = (Conexion.SeleccionarBd(Sentencia).Rows.Count / TotalPacientes) * 100;
            Label2.Text = "El Porcentaje De Mujeres Hospitalizadas Es De:" + porcentajes;
        }
        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMenu.aspx");
        }
    }
}