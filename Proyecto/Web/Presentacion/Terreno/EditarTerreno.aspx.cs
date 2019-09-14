using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Terreno
{
    public partial class EditarTerreno : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient SerT = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clTerreno objT = new ServicioUsuario.clTerreno();

        int Id;
        int IdTipoTerreno;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void mtdCargar()
        {
            Id = int.Parse(Application["IdUsuario"].ToString());
            DataSet enviar = SerT.mtdEnviarID(Id);
            DataSet listar = new DataSet();
            listar = enviar;

            TipoTerreno.DataSource = listar.Tables["tblDatos"];
            TipoTerreno.DataTextField = "NombreTerreno";
            TipoTerreno.DataValueField = "IdTerreno";
            TipoTerreno.DataBind();
        }

        protected void mtdCargarTerreno()
        {
            Id = int.Parse(Application["IdUsuario"].ToString());
            objT.IdUsuario = Id;

            objT.IdTerreno = IdTipoTerreno;

            DataSet dsDatos = new DataSet();
            dsDatos = SerT.mtdBuscarTerreno(objT);
            txtNombreTerreno.Value = dsDatos.Tables["tblDatos"].Rows[0]["NombreTerreno"].ToString();
            txtLargo.Value = dsDatos.Tables["tblDatos"].Rows[0]["Largo"].ToString();
            txtAncho.Value = dsDatos.Tables["tblDatos"].Rows[0]["Ancho"].ToString();
        }

        protected void BtnCalculo_Click(object sender, EventArgs e)
        {
            try
            {
                double ancho = double.Parse(Request.Form[txtAncho.UniqueID]);
                double largo = double.Parse(Request.Form[txtLargo.UniqueID]);
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


        protected void Page_Init(object sender, EventArgs e)
        {
            mtdCargar();
        }

        protected void btnEditarT(object sender, EventArgs e)
        {
            try
            {
                objT.NombreTerreno = Request.Form[txtNombreTerreno.UniqueID];
                objT.Largo = double.Parse(Request.Form[txtLargo.UniqueID]);
                objT.Ancho = double.Parse(Request.Form[txtAncho.UniqueID]);
                objT.IdUsuario = Id;

                int resultado = SerT.mtdEditarTerreno(objT);

                if (resultado > 0)
                {
                    alert.Visible = true;
                    //string script = @"<script type='text/javascript'>
                    //        alert('Se ha editado Exitosamente');
                    //        window.location = 'EditarUsuario.aspx';
                    //    </script>";

                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                }
                else
                {
                    danger.Visible = true;
                    //string script = @"<script type='text/javascript'>
                    //        alert('Error');
                    //    </script>";

                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            catch (Exception)
            {
                danger.Visible = true;
            }

        }



        protected void TipoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int var1 = int.Parse(TipoTerreno.SelectedValue);

            IdTipoTerreno = var1;

            mtdCargarTerreno();

            Label1.Text = "---";
        }
    }
}