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
            string txtFech = System.DateTime.Now.ToShortDateString();

            Label1.Text = txtFech;
            string a = Label1.Text;


            // Fertilizacion


        }


        ServicioUsuario.WebService1SoapClient miServicio = new ServicioUsuario.WebService1SoapClient();
        public void mtdfecha()
        {
            DataSet dsListar = new DataSet();
            ServicioUsuario.clFases objClFases = new ServicioUsuario.clFases();
            dsListar = miServicio.mtdfecha();
            Repeater.DataSource = dsListar;
            Repeater.DataBind();

        }
      

        public void mtdFertilizantes() {

            int año = 365;
            int semestre = año / 2;

            for (int i = 0; i <= año; i++)
            {
               
            }

        }
    }
}