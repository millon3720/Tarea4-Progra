using ConexionSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_4
{
    public partial class FrmMostrarPacientes : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            string Sentencia = "SELECT Nombre FROM dbo.RegistrosPacientes";
            ClElementosConexionBdSqlServer Conexion = new ClElementosConexionBdSqlServer();
            GridView1.DataSource = Conexion.SeleccionarBd(Sentencia);
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMenu.aspx");
        }

    }
}