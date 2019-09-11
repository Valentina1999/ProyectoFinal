using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Usuario
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            DataSet listarRol = new DataSet();

            listarRol = Servicioa.mtdListarRol();
            hola.DataSource = listarRol.Tables["tblDatos"];
            hola.DataTextField = "Rol";
            hola.DataValueField = "IdRol";
            hola.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }
        ServicioUsuario.WebService1SoapClient Servicioa = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clUsuario objclUsuario = new ServicioUsuario.clUsuario();

        protected void btnRegistrar(object sender, EventArgs e)
        {
            if (Request.Form["Documento"] != "" || Request.Form["Nombre"] != "" || Request.Form["Apellido"] != "" ||
                Request.Form["Correo"] != "" || Request.Form["Clave"] != "" || Request.Form["Telefono"] != "")
            {
                objclUsuario.Documento = Request.Form["Documento"];
                objclUsuario.Nombre = Request.Form["Nombre"];
                objclUsuario.Apellido = Request.Form["Apellido"];
                objclUsuario.Correo = Request.Form["Correo"];
                objclUsuario.Clave = Request.Form["Clave"];
                objclUsuario.Numero = Request.Form["Telefono"];
                objclUsuario.IdRol = int.Parse(hola.SelectedValue.ToString());
                int resultado = Servicioa.mtdRegistrarUsuario(objclUsuario);

                if (resultado == 1)
                {
                    Response.Redirect("../Index/Index.aspx");
                    //string script = @"<script type='text/javascript'>
                    //            alert('Se ha Registrado Exitosamente');
                    //        </script>";

                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
                else
                {
                    danger.Visible = true;
                }
            }
            else
            {
                danger.Visible = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}