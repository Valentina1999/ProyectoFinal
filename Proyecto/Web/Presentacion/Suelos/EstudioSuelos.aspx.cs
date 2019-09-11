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

        bool a;
        bool b;
        bool c;
        bool d;
        bool f;
        bool g;
        bool h;
        bool i;
        bool j;
        bool k;
        bool l;
        bool m;

        ServicioUsuario.WebService1SoapClient Servicio = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clTerreno obj = new ServicioUsuario.clTerreno();

        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void btnRedir_Click(object sender, EventArgs e)
        {
            Response.Write("<script> window.open('tblRangos.aspx ','_blank'); </script>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {

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



            if (objSuelos.AcidezOalcalinidad == 5.5 || objSuelos.AcidezOalcalinidad <= 5.9)
            {
                a = true;
            }
            else
            {
                RAcidezAl.Visible = true;
                RAcidezAl.Text = "Nivel de Acidez o Alcalinidad Erroneo";
            }


            if (objSuelos.Aluminio < 0.2)
            {
                b = true;
            }
            else
            {
                RAluminio.Visible = true;
                RAluminio.Text = "Nivel de Aluminio Erroneo ";
            }


            if (objSuelos.Nitrógeno == 2.1 || objSuelos.Nitrógeno <= 2.4)
            {

                c = true;
            }
            else
            {
                RNitrogeno.Visible = true;
                RNitrogeno.Text = "Nivel de Nitrogeno Erroneo";
            }


            if (objSuelos.Potasio == 0.03 || objSuelos.Potasio <= 0.80)
            {
                d = true;
            }
            else
            {
                RPotasion.Visible = true;
                RPotasion.Text = "Nivel de Potasio Erroneo";
            }


            if (objSuelos.Fósforo == 15 || objSuelos.Fósforo <= 20)
            {
                f = true;
            }
            else
            {
                RFosforo.Visible = true;
                RFosforo.Text = "Nivel de Fosforo Erroneo";
            }


            if (objSuelos.Calcio == 0.10 || objSuelos.Calcio <= 0.30)
            {
                g = true;
            }
            else
            {
                RCalcio.Visible = true;
                RCalcio.Text = "Nivel de Calcio Erroneo";
            }


            if (objSuelos.Magnesio >= 0.05 || objSuelos.Magnesio <= 0.20)
            {
                h = true;
            }
            else
            {
                RMagnesion.Visible = true;
                RMagnesion.Text = "Nivel de Magnesio Erroneo";
            }


            if (objSuelos.Azufre == 20 || objSuelos.Azufre <= 80)
            {
                i = true;

            }
            else
            {
                RAzufre.Visible = true;
                RAzufre.Text = "Nivel de Azufre Erroneo";
            }


            if (objSuelos.Cobre == 3 || objSuelos.Cobre <= 20)
            {
                j = true;
            }
            else
            {
                RCobre.Visible = true;
                RCobre.Text = "Nivel de Cobre Erroneo";
            }


            if (objSuelos.Cinc == 6 || objSuelos.Cinc <= 36)
            {
                k = true;
            }
            else
            {
                RCinc.Visible = true;
                RCinc.Text = "Nivel de Cinc Erroneo";
            }


            if (objSuelos.Manganeso == 60 || objSuelos.Manganeso <= 100)
            {
                l = true;
            }
            else
            {
                RManganeso.Visible = true;
                RManganeso.Text = "Nivel de Manganeso Erroneo";
            }


            if (objSuelos.Boro == 1.2 || objSuelos.Boro <= 5.73)
            {
                m = true;
            }
            else
            {
                RBoro.Visible = true;
                RBoro.Text = "Nivel de Boro Erroneo";
            }
            string script;

            if (a == true && b == true && c == true && d == true && f == true && g == true && h == true && i == true && j == true && k == true && l == true && m == true)
            {
                int resultado = ServicioJ.mtdRegistrarSuelos(objSuelos);



                if (resultado == 1)
                {
                    script = @"<script type='text/javascript'>
                                                                alert('Se ha Registrado Exitosamente El Suelo');
                                                                </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }

            }
            else
            {
                script = @"<script type='text/javascript'>
                                                                alert('Error de registro datos Incorrectos');
                                                                </script>";

            }


        }

    }
 }
