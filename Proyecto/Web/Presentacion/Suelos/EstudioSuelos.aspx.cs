using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Suelos
{
    public partial class EstudioSuelos : System.Web.UI.Page
    {

        int Id = 0;
        ServicioUsuario.WebService1SoapClient Servicio = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clTerreno obj = new ServicioUsuario.clTerreno();

        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Application["IdUsuario"].ToString());
            obj.IdUsuario = Id;

            DataSet enviar = Servicio.mtdEnviarID(Id);

            DataSet listar = new DataSet();
            listar = enviar;
            Terreno.DataSource = listar.Tables["tblDatos"];
            Terreno.DataTextField = "NombreTerreno";
            Terreno.DataValueField = "IdTerreno";
            Terreno.DataBind();

            DataSet listarT = new DataSet();
            
            TipoSuelo.DataSource = listarT.Tables["tblDatos"];
            TipoSuelo.DataTextField = "TipoSuelo";
            TipoSuelo.DataValueField = "IdtipoSuelo";
            TipoSuelo.DataBind();


        }


        
        ServicioUsuario.WebService1SoapClient ServicioJ = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clSuelos objSuelos = new ServicioUsuario.clSuelos();

        protected void btnRegistrarSuelos(object sender, EventArgs e)
        {
            objSuelos.AcidezOalcalinidad = double.Parse(Request.Form["AcidezAl"]);
            objSuelos.Aluminio = double.Parse(Request.Form["Aluminio"]);
            objSuelos.Nitrógeno = double.Parse(Request.Form["Nitrogeno"]);
            objSuelos.Potasio = double.Parse(Request.Form["Potasio"]);
            objSuelos.Fósforo = double.Parse(Request.Form["Fosforo"]);
            objSuelos.Calcio = double.Parse(Request.Form["Calcio"]);
            objSuelos.Magnesio = double.Parse(Request.Form["Magnesio"]);
            objSuelos.Azufre = double.Parse(Request.Form["Azufre"]);
            objSuelos.Cobre = double.Parse(Request.Form["Cobre"]);
            objSuelos.Cinc = double.Parse(Request.Form["Cinc"]);
            objSuelos.Manganeso = double.Parse(Request.Form["Manganeso"]);
            objSuelos.Boro = double.Parse(Request.Form["Boro"]);
            objSuelos.IdTipoSuelo = int.Parse(TipoSuelo.SelectedValue);
            objSuelos.IdCultivo = 2;
            //objSuelos.IdTerreno = int.Parse(Terreno.SelectedValue);




                int resultado = ServicioJ.mtdRegistrarSuelos(objSuelos);

            if (objSuelos.AcidezOalcalinidad == 5.5 && 5.5 <= 5.9)
            {
                if (objSuelos.Aluminio < 0.2)
                {
                    if (objSuelos.Nitrógeno == 60 )// traer los datos de terreno
                    {
                        //if (objSuelos.Potasio)
                        //{

                        //}
                    }
                }
            }else


            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha Registrado Exitosamente');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }



        }
    }
}