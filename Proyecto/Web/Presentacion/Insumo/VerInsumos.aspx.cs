using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Insumo
{
    public partial class VerInsumos : System.Web.UI.Page
    {

        ServicioUsuario.WebService1SoapClient ServicioZ = new ServicioUsuario.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            mtdListarInsumos();
        }

        protected void mtdListarInsumos()
        {
            DataSet dsInsumos = new DataSet();
            dsInsumos = ServicioZ.mtdListarInsumos();
            repeater1.DataSource = dsInsumos;
            repeater1.DataBind();
        }
    }
}