using Servicio.Datos;
using System;
using System.Collections.Generic;
using System.Data;
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
        ServicioUsuario.WebService1SoapClient Servicio = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clTerreno ObjclTerreno = new ServicioUsuario.clTerreno();
        string Ancho;
        string Largo;

        protected void Page_Load(object sender, EventArgs e)
        {

            Ancho = Request.Form["Ancho"];
            Largo = Request.Form["Largo"];
        }

        protected void BtnCalculo_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                alerta.Visible = true;
            }

        }



        protected void btnRegistrarTerreno(object sender, EventArgs e)
        {
           /* try
            {*/
                int IdUsuario = int.Parse(Application["IdUsuario"].ToString());
                objclTerreno.NombreTerreno = Request.Form["NombreTerreno"];
                objclTerreno.Ancho = double.Parse(Request.Form["Ancho"]);
                objclTerreno.Largo = double.Parse(Request.Form["Largo"]);
                objclTerreno.IdUsuario = IdUsuario;

                int resultado = servicio.mtdRegistrarTerreno(objclTerreno);
                mtdCargar();
                if (resultado == 1)
                {
                    alert.Visible = true;


                    //string script = @"<script type='text/javascript'>
                    //            alert('Se ha Registrado Exitosamente');
                    //        </script>";

                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
                else
                {
                    danger.Visible = true;
                    
                }
            /*}
            catch (Exception)
            {
                danger.Visible = true;
                //string script = @"<script type='text/javascript'>
                //            alert('Hubo un error en el Registro');
                //        </script>";

                //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            */
        }

        int Id;
        public void mtdCargar()
        {
            Id = int.Parse(Application["IdUsuario"].ToString());
            DataSet enviar = Servicio.mtdEtapaTerreno(Id);
             IdT.Value = enviar.Tables["tblDatos"].Rows[0]["Id"].ToString();

            ObjclTerreno.IdTerreno = int.Parse(IdT.Value);
            
            int Re = Servicio.mtdTerrenoEtapas(ObjclTerreno);
            if (Re == 1)
            {
                string hola = " funciono";
            }
        }


        protected void editarT_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("EditarTerreno.aspx");
        }
    }
}