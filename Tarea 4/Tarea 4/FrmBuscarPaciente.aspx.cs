using ConexionSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_4
{
    public partial class FrmBuscarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            string Sentencia = "SELECT * FROM dbo.RegistrosPacientes where Nombre="+TxtPaciente.Text;
            ClElementosConexionBdSqlServer Conexion = new ClElementosConexionBdSqlServer();
            GridView1.DataSource = Conexion.SeleccionarBd(Sentencia);
            GridView1.DataBind();
        }
        protected void Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMenu.aspx");
        }

    }
}