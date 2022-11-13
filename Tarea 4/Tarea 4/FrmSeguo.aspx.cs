using ConexionSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_4
{
    public partial class FrmSeguo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Sentencia1 = "SELECT seguro FROM dbo.RegistrosPacientes";
            ClElementosConexionBdSqlServer Conexion = new ClElementosConexionBdSqlServer();
            double TotalPacientes = Conexion.SeleccionarBd(Sentencia1).Rows.Count;
            string Sentencia = "SELECT seguro FROM dbo.RegistrosPacientes where seguro=1";
            double porcentajes = (Conexion.SeleccionarBd(Sentencia).Rows.Count / TotalPacientes) * 100;
            Label.Text = "El Porcentaje Pacientes Con Seguro Es De:" + porcentajes;
        }
        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMenu.aspx");
        }
    }
}