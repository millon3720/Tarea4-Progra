using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_4
{
    public partial class FrmMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAgregar.aspx");
        }

        protected void BtnPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMostrarPacientes.aspx");

        }

        protected void BtnBuscarPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmBuscarPaciente.aspx");

        }

        protected void BtnEdad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmBuscarEdad.aspx");

        }

        protected void BtnGenero_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmGenero.aspx");
        }

        protected void BtnSeguro_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmSeguo.aspx");
        }
    }
}