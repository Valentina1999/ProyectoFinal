using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Master
{
    public partial class ValidaL : System.Web.UI.Page
    {
        public static string v;

        protected void Page_Load(object sender, EventArgs e)
        {
            DataLoginTableAdapters.UsuarioTableAdapter obj = new DataLoginTableAdapters.UsuarioTableAdapter();

            string Correo = Request.Form["email"];

            string Clave = Request.Form["password"];

            String Usu = obj.Login(Correo, Clave);

            if (Usu != null)
            {
                Session["Usuario"] = Usu;
                Response.Redirect("../Index/Index.aspx");
            }
            else
            {

                v = "Usuario y/o Contraseña incorrecta";
                //Application["msj"] = "Usuario y/o Contraseña incorrecta";

                Response.Redirect("../Login/Login.aspx");

            }

        }
    }
}