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

        int Id;
        ServicioUsuario.WebService1SoapClient Servicio = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clTerreno obj = new ServicioUsuario.clTerreno();

        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
        protected void btnRedir_Click(object sender, EventArgs e)
        {
            Response.Write("<script> window.open('tblrangos.aspx ','_blank'); </script>");
        }



        protected void Page_Init(object sender, EventArgs e) {

            mtdCargarTerreno();
            mtdCargarTipoSuelo();
        }
       
        public void mtdCargarTerreno()
        {
            Id = int.Parse(Application["IdUsuario"].ToString());
            DataSet enviar = Servicio.mtdEnviarID(Id);
            DataSet listar = new DataSet();
            listar = enviar;
            Terreno.DataSource = listar.Tables["tblDatos"];
            Terreno.DataTextField = "NombreTerreno";
            Terreno.DataValueField = "IdTerreno";
            Terreno.DataBind();
        }

        public void mtdCargarTipoSuelo()
        {
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
            objSuelos.IdCultivo = 1;
            objSuelos.IdTerreno = int.Parse(Terreno.SelectedValue);


            int resultado = ServicioJ.mtdRegistrarSuelos(objSuelos);

            if (objSuelos.AcidezOalcalinidad == 5.5 && 5.5 <= 5.9)
            {
                if (objSuelos.Aluminio < 0.2)
                {
                    if (objSuelos.Nitrógeno == 2.1 && 2.1 <= 2.4)
                    {
                        if (objSuelos.Potasio == 0.03 && 0.03 <= 0.80)
                        {
                            if (objSuelos.Fósforo == 15 && 15 <= 20)
                            {
                                if (objSuelos.Calcio == 0.10 && 0.10 <= 0.30)
                                {
                                    if (objSuelos.Magnesio == 0.05 && 0.05 <= 0.20)
                                    {
                                        if (objSuelos.Azufre == 20 && 20 <= 80)
                                        {
                                            if (objSuelos.Cobre == 3 && 3 <= 20)
                                            {
                                                if (objSuelos.Cinc == 6 && 6 <= 36)
                                                {
                                                    if (objSuelos.Manganeso == 60 && 60 <= 100)
                                                    {
                                                        if (objSuelos.Boro == 1.2 && 1.2 <= 5.73)
                                                        {
                                                            if (resultado == 1)
                                                            {
                                                                string script = @"<script type='text/javascript'>
                                                                alert('Se ha Registrado Exitosamente El Suelo');
                                                                </script>";

                                                                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                                                            }
                                                        }
                                                        else {RBoro.Visible = true; RBoro.Text = "El nivel de Boro debe comprender valores de 1.2meq/100g a 5.73meq/100g para iniciar con el proceso";
                                                        }
                                                    }
                                                    else { RManganeso.Text = "El nivel de Manganeso debe comprender valores de 60ppm a 100ppm para iniciar con el proceso"; }
                                                 }
                                                else { RCinc.Text = "El nivel de Cinc debe comprender valores de 6ppm a 36ppm para iniciar con el proceso"; }
                                            }
                                            else { RCobre.Text = "El nivel de Cobre debe comprender valores de 3ppm a 20ppm para iniciar con el proceso"; }
                                        }
                                        else { RAzufre.Text = "El nivel de Azufre debe comprender valores de 20ppm a 80ppm para iniciar con el proceso"; }
                                    }
                                    else { RMagnesion.Text = "El nivel de Magnesio debe comprender valores de 60ppm a 100ppm para iniciar con el proceso"; }
                                }
                                else { RCalcio.Text = "El nivel de Calcio debe comprender valores de 0.10meq/100g a 0.30ppm para iniciar con el proceso"; }
                            }
                            else
                            { RFosforo.Text = "El nivel de Fosforo debe comprender valores de 15ppm a 20ppm para iniciar con el proceso"; }
                        }
                        else
                        { RPotasion.Text = "El nivel de Potasio debe comprender valores de 0,3meq/100g a 80meq/100 para iniciar con el proceso"; }  
                    }
                    else
                    { RNitrogeno.Text = "El nivel de Nitrogeno debe comprender valores de 2.1N a 2.4N para iniciar con el proceso"; }
                }
                else
                { RAluminio.Text = "El nivel de Aluminio debe comprender valores de <0.2 meq/100g para iniciar con el proceso"; }
            }
            else
            { RAcidezAl.Text = "El nivel de Aluminio debe comprender valores de 5.5 PH a 5.9 PH para iniciar con el proceso"; }
                    
        }

        
    }
}