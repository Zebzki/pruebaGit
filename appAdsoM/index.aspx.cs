using appAdsoM.entidades;
using appAdsoM.logica;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appAdsoM
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

            ClUsuarioL objusuarioL = new ClUsuarioL();
            bool resul = objusuarioL.mtdIngresar(user, pass);
            if (resul)
            {
                Response.Redirect("vista/ingreso.aspx");
            }
            else
            {
                lblVer.Text = "no existe el usuario";

            }
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MostrarMensaje("por favor ingrese su correo electronico");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MostrarMensaje("por favor ingrese su Clave");
                return;
            }

            ClUsuarioE objusuarioE = new ClUsuarioE();
            objusuarioE.email = txtUsuario.Text;
            objusuarioE.clave = txtPassword.Text;

            ClUsuarioL objusuario = new ClUsuarioL();
          ClUsuarioE oUser = objusuario.mtdIngreso(objusuarioE);
            if (oUser !=null)
            {
                Session["email"]=oUser.email;
                Session["usuario"] = oUser.nombres + " " + oUser.apellidos;
                Response.Redirect("vista/dashboard.aspx");

            }
            else
            {
                MostrarMensaje("usuario o contraseña incorrectos");
            }



         
        }
      
        private void MostrarMensaje(string mensaje)
        {
            string script = "alert('" + mensaje + "');";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", script, true);
        }

        protected void btnIngresoSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MostrarMensaje("por favor ingrese su correo electronico");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MostrarMensaje("por favor ingrese su Clave");
                return;
            }

            ClUsuarioE objusuarioE = new ClUsuarioE();
            objusuarioE.email = txtUsuario.Text;
            objusuarioE.clave = txtPassword.Text;

            ClUsuarioL objusuario = new ClUsuarioL();
            ClUsuarioE oUser = objusuario.mtdIngresoStorageProcedure(objusuarioE);
            if (oUser != null)
            {
                Session["email"] = oUser.email;
                Session["usuario"] = oUser.nombres + " " + oUser.apellidos;

                Response.Redirect("vista/dashboard.aspx");

            }
            else
            {
                MostrarMensaje("usuario o contraseña incorrectos");
            }

        }
    }
}