using Servicio.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {   
        ServicioOscar.WebService1SoapClient servicio = new ServicioOscar.WebService1SoapClient();
        ServicioOscar.clTerreno objclTerreno = new ServicioOscar.clTerreno();

        string Ancho;
        string Largo;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            Ancho = Request.Form["Ancho"];
            Largo = Request.Form["Largo"];
        }

        protected void BtnCalculo_Click(object sender, EventArgs e)
        {
            double ancho = double.Parse(Ancho.ToString());
            double largo = double.Parse(Largo.ToString());
            double distancia = 9;
            double callejuela = 7.8;

            double ResultAncho = ancho / callejuela;
            double ResultLargo = largo / distancia;

            double Result = ResultAncho * ResultLargo;

            int res = (int)Result;

            Label1.Text = res.ToString();
        }

       

        protected void btnRegistrarTerreno(object sender, EventArgs e)
        {
            int IdUsuario = int.Parse(Application["IdUsuario"].ToString());
            objclTerreno.NombreTerreno = Request.Form["NombreTerreno"];
            objclTerreno.Ancho = decimal.Parse(Request.Form["Largo"]);
            objclTerreno.Largo = decimal.Parse(Request.Form["Ancho"]);
            objclTerreno.IdUsuario = IdUsuario;
            
            int resultado = servicio.mtdRegistrarTerreno(objclTerreno);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha Registrado Exitosamente');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Hubo un error en el Registro');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }
    }
}