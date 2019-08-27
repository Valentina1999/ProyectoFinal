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

        
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet listar = new DataSet();

            listar = ServicioJ.mtdListarSuelo();
            TipoSuelo.DataSource = listar.Tables["tblDatos"];
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
            objSuelos.IdTerreno = 3;




                int resultado = ServicioJ.mtdRegistrarSuelos(objSuelos);

            if (objSuelos.AcidezOalcalinidad == 5.5 && 5.5 <= 5.9)
            {
                if (objSuelos.Aluminio < 0.2)
                {
                    if (objSuelos.Nitrógeno == 60)
                    {
                       
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