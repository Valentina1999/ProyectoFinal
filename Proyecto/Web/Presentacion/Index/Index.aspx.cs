using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        int dia = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Fertilizacion

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            mtdfecha();
            mtdFertilizantes();

        }

        ServicioUsuario.WebService1SoapClient miServicio = new ServicioUsuario.WebService1SoapClient();
        public void mtdfecha()
        {
            DataSet dsListar = new DataSet();
            ServicioUsuario.clFases objClFases = new ServicioUsuario.clFases();
            dsListar = miServicio.mtdfecha();
            //FechaInicio.Value = dsListar.Tables["tblDatos"].Rows[0]["FechaInicio"].ToString();
            FechaFinal.Value = dsListar.Tables["tblDatos"].Rows[0]["FechaFinal"].ToString();


        }
        public void mtdFertilizantes()
        {



           DateTime Fecha = System.DateTime.Now;
           lblFecha.Text = Fecha.ToString();
            //DateTime fechaInicio = DateTime.Parse(FechaInicio.Value);
           DateTime fechaFinal = DateTime.Parse(FechaFinal.Value);


            Fecha = DateTime.Now;

            //// Difference in days, hours, and minutes.
            //TimeSpan ts = Fecha - fechaInicio;

            //// Difference in days.
            //int Dias = ts.Days;

            //DateTime v = fechaInicio;
            if (Fecha <=  fechaFinal)
            {
                string a = "hola";

                Riegoo.Text = a;
               
            }

            //int año = 365;
            //int semestre = año / 2;

            //for (int i = 0; i <= año; i++)
            //{

            //    if)

            //}
        }
    }
}