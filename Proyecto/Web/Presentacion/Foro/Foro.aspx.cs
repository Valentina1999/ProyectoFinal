using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Web.Presentacion.Foro
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient ServicioZ = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clPregunta objPregunta = new ServicioUsuario.clPregunta();
        ServicioUsuario.clRespuesta objRespuesta = new ServicioUsuario.clRespuesta();

        protected void Page_Load(object sender, EventArgs e)
        {
            mtdListarPregunta();
        }

        protected void mtdRegistrarPregunta(object sender, EventArgs e)
        {
            string Fecha = System.DateTime.Now.ToShortDateString();
            int IdUsuario = int.Parse(Application["IdUsuario"].ToString());

            objPregunta.Pregunta = Request.Form["pregunta"];
            objPregunta.FechaP = Fecha;
            objPregunta.IdUsuario = IdUsuario;

            int resultado = ServicioZ.mtdRegistrarPregunta(objPregunta);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha Registrado Exitosamente');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                mtdListarPregunta();
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Hubo un error en el Registro');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdListarPregunta()
        {
            DataSet dsListar = new DataSet();
            dsListar = ServicioZ.mtdListarPregunta();
            repeater1.DataSource = dsListar;
            repeater1.DataBind();
        }

        protected void mtdRegistrarRespuesta(object sender, EventArgs e)
        {
            string Fecha = System.DateTime.Now.ToShortDateString();

            objRespuesta.Respuesta = Request.Form["respuesta"];
            objRespuesta.FechaR = Fecha;
            objRespuesta.IdPregunta =
        }
    }
}