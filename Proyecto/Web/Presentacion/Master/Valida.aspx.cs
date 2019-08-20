using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Master
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        ServicioLogin.WebService1SoapClient miServicioLogin = new ServicioLogin.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
                 string script = "alert('Mi Respuesta');";

            
           
                //ServicioLogin.clLogin ObjL = new ServicioLogin.clLogin();

                DataLoginTableAdapters.UsuarioTableAdapter obj = new DataLoginTableAdapters.UsuarioTableAdapter();
                /*   ObjL.*/
                string Correo = Request.Form["email"];
                /* ObjL.*/
                string Clave = Request.Form["password"];

                String Usu = obj.Login(Correo, Clave);
                if (Usu != null)
                {
                    Session["Usuario"] = Usu;
                    Response.Redirect("../Index/Index.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
           
        }
    }
}