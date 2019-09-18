using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Tienda
{
    public partial class Tienda : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient Serv = new ServicioUsuario.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdCargarP();
        }

        protected void mtdCargarP()
        {
            DataSet dsListarP = new DataSet();
            dsListarP = Serv.mtdListarProductos();
            pr.DataSource = dsListarP;
            pr.DataBind();
        }
    }
}