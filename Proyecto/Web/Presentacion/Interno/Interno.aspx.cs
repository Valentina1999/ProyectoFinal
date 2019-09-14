using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Presentacion.Etapa;

namespace Web.Presentacion.Interno
{
    public partial class Interno : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient miServicio = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clInterno objClInterno = new ServicioUsuario.clInterno();
        int Etapa = int.Parse(ListarEtapa.somedata.ToString());
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
       
        protected void Page_Init(object sender, EventArgs e)
        {
            recargar();
        }
        int Id;
        public void recargar() {
            Id = int.Parse(Application["IdUsuario"].ToString());

            objClInterno.IdUsuario = Id;
            DataSet dsListar = new DataSet();
            dsListar = miServicio.mtdListarInterno(objClInterno);
            Repeater1.DataSource = dsListar;
            Repeater1.DataBind();
        }
                
        public void mtdregistrar() {

            objClInterno.IdInterno = int.Parse(somedat);
            int resultado = miServicio.mtdRegistrarInterno(objClInterno);
            recargar();
        }
        public static string somedat;
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Click":
                    //get command argument here
                    somedat = e.CommandArgument.ToString();
                    break;
            }
            mtdregistrar();

            if (int.Parse(somedat) == 11)
            {
                mtdCargar();
            }
            else if (int.Parse(somedat) == 34)
            {
                mtdCargar2();
            }
            else if (int.Parse(somedat) == 111)
            {
                mtdCargar3();
            }


        }

        public void mtdCargar()
        {
           
            DataSet enviar = miServicio.mtdInternoCultivo(Etapa);
            IdE.Value = enviar.Tables["tblDatos"].Rows[0]["IdTerreno"].ToString();

            objClInterno.IdTerreno = int.Parse(IdE.Value);
            objClInterno.IdEtapa = 2;
            
            int Re = miServicio.mtdInternoC(objClInterno);
            if (Re == 1)
            {
                ListarEtapa.somedata = 2.ToString();
                Response.Redirect("/Presentacion/Fases/ListaFases.aspx");
            }
        }


        public void mtdCargar2()
        {

            DataSet enviar = miServicio.mtdInternoCultivo(Etapa);
            IdE.Value = enviar.Tables["tblDatos"].Rows[0]["IdTerreno"].ToString();

            objClInterno.IdTerreno = int.Parse(IdE.Value);
            objClInterno.IdEtapa = 11;

            int Re = miServicio.mtdInternoC(objClInterno);
            if (Re == 1)
            {
                ListarEtapa.somedata = 11.ToString();
                Response.Redirect("/Presentacion/Fases/ListaFases.aspx");
            }
        }


        public void mtdCargar3()
        {

            DataSet enviar = miServicio.mtdInternoCultivo(Etapa);
            IdE.Value = enviar.Tables["tblDatos"].Rows[0]["IdTerreno"].ToString();

            objClInterno.IdTerreno = int.Parse(IdE.Value);
            objClInterno.IdEtapa = 13;

            int Re = miServicio.mtdInternoC(objClInterno);
            if (Re == 1)
            {
                ListarEtapa.somedata = 13.ToString();
                Response.Redirect("/Presentacion/Fases/ListaFases.aspx");
            }
        }


        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Button btn = e.Item.FindControl("btn") as Button;
            btn.OnClientClick = String.Format("showValue('{0}');", btn.CommandArgument);

        }

        protected void fases_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Presentacion/Fases/ListaFases.aspx");
        }
    }
}