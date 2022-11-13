using ConexionSqlServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Tarea_4
{
    public partial class FrmAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        { ClElementosConexionBdSqlServer Conexion = new ClElementosConexionBdSqlServer();
            string Sentencia = "";
            if (CheckBox1.Checked)
            {
             Sentencia = "insert into RegistrosPacientes values('"+TxtNombre.Text+ "','" + TxtEdad.Text + "',Hombre,'" + TxtDireccion.Text+ "','" + TxtTelefono.Text + "','"+CbSeguro.Checked+"')";
            Conexion.InsertarDatos(Sentencia);
            TxtNombre.Text = null;
            TxtEdad.Text = null;
            CheckBox1.Checked = false;  
            TxtDireccion.Text = null;
            TxtTelefono.Text = null;
            CbSeguro.Checked = false;
            }
            else
            {
                 Sentencia = "insert into RegistrosPacientes values('" + TxtNombre.Text + "','" + TxtEdad.Text + "',Mujer,'" + TxtDireccion.Text + "','" + TxtTelefono.Text + "','" + CbSeguro.Checked + "')";
                Conexion.InsertarDatos(Sentencia);
                TxtNombre.Text = null;
                TxtEdad.Text = null;
                CheckBox1.Checked = false;
                TxtDireccion.Text = null;
                TxtTelefono.Text = null;
                CbSeguro.Checked = false;

            }
           
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox2.Checked = false;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox1.Checked = false;

        }
        protected void Volver_Click(object sender, EventArgs e)
        {        
            Response.Redirect("FrmMenu.aspx");
        }
    }
}