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
           

            DataSet enviar = Servicio.mtdEnviarID(Id);

            DataSet listar = new DataSet();
            listar = enviar;
            Terreno.DataSource = listar.Tables["tblDatos"];
            Terreno.DataTextField = "NombreTerreno";
            Terreno.DataValueField = "IdTerreno";
            Terreno.DataBind();

            DataSet listarT = new DataSet();
            listarT = ServicioJ.mtdListarSuelo();
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
            objSuelos.IdTerreno = 4;/*int.Parse(Terreno.SelectedValue)*/


            //int VarPotacio = int.Parse(TipoSuelo.SelectedValue);
            //int var1m = 0;
            //int var1M = 0;

            //if (VarPotacio == 1)
            //{
            //    var1m = 294;
            //    var1M = 350;
            //}
            //else if (VarPotacio == 2)
            //{
            //    var1m = 252;
            //    var1M = 308;
            //}
            //else if (VarPotacio == 3)
            //{
            //    var1m = 168;
            //    var1M = 280;
            //}
            //else if (VarPotacio == 4)
            //{
            //    var1m = 366;
            //    var1M = 420;
            //}
            //else if (VarPotacio == 5)
            //{
            //    var1m = 420;
            //    var1M = 504;
            //}

            //int VarFosforo = int.Parse(TipoSuelo.SelectedValue);
            //int var2m = 0;
            //int var2M = 0;

            //if (VarFosforo == 1)
            //{
            //    var2m = 77;
            //    var2M = 98;
            //}
            //else if (VarFosforo == 2)
            //{
            //    var2m = 105;
            //    var2M = 140;
            //}
            //else if (VarFosforo == 3)
            //{
            //    var2m = 56;
            //    var2M = 98;
            //}
            //else if (VarFosforo == 4)
            //{
            //    var2m = 70;
            //    var2M = 98;
            //}
            //else if (VarFosforo == 5)
            //{
            //    var2m = 56;
            //    var2M = 84;
            //}

            int resultado = ServicioJ.mtdRegistrarSuelos(objSuelos);

            if (objSuelos.AcidezOalcalinidad == 5.5 && 5.5 <= 5.9)
            {
                if (objSuelos.Aluminio < 0.2)
                {
                    if (objSuelos.Nitrógeno >= 2.1 && 2.1 <= 2.4)
                    {
                        if (objSuelos.Potasio >= 0.03 && 0.03 <= 0.80)
                        {
                            if (objSuelos.Fósforo >= 2.30 && 2.30 <= 28.70)
                            {
                                if (objSuelos.Calcio >= 0.10 && 0.10 <= 0.30)
                                {
                                    if (objSuelos.Magnesio >= 0.05 && 0.05 <= 0.20)
                                    {
                                        if (objSuelos.Azufre >= 20 && 20 <= 80)
                                        {
                                            if (objSuelos.Cobre >= 3 && 3 <= 20)
                                            {
                                                if (objSuelos.Cinc >= 6 && 6 <= 30)
                                                {
                                                    if (objSuelos.Boro >= 1.2 && 1.2 <= 5.73)
                                                    {
                                                        if (resultado == 1)
                                                        {
                                                            string script = @"<script type='text/javascript'>
                                                            alert('Se ha Registrado Exitosamente El Suelo');
                                                            </script>";

                                                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                                                        }
                                                    }
                                                    else { }
                                                }
                                                else { }
                                            }
                                            else { }
                                        }
                                        else { }
                                    }
                                    else { }
                                }
                                else { }
                            }
                            else
                            { }
                        }
                        else { }
                        
                    }
                    else { }
                }
                else { }
            }
            else { }
                    
        }
    }
}