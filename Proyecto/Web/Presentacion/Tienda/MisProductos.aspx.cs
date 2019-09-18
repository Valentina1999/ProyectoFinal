using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Tienda
{
    public partial class MisProductos : System.Web.UI.Page
    {
        int id;
        ServicioUsuario.WebService1SoapClient servi = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clProducto objp = new ServicioUsuario.clProducto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            mtdCargarP();

        }

        protected void mtdCargarP()
        {
            id = int.Parse(Application["IdUsuario"].ToString());
            objp.IdUsuario = id;
            DataSet dsListarP = new DataSet();
            dsListarP = servi.mtdProductosUsuarios(objp);
            prod.DataSource = dsListarP;
            prod.DataBind();
        }

        protected void EditarProducto()
        {
            objp.IdProducto = int.Parse(somedata);

            int resultado = servi.mtdEditarProducto(objp);
        }

        //protected void pro_ItemDataBound1(object sender, RepeaterItemEventArgs e)
        //{
        //    Button btn = e.Item.FindControl("btnNose") as Button;
        //    btn.OnClientClick = String.Format("showValue('{0}');", btn.CommandArgument);
        //}

        public static string somedata;

        protected void prod_ItemCommand(object source, DataListCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Click":
                    //get command argument here
                    somedata = e.CommandArgument.ToString();
                    break;
            }
            EditarProducto();
            mtdCargarP();
            //Response.Redirect("/Presentacion/Tienda/MisProductos.aspx");
        }

        protected void prod_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Button btn = e.Item.FindControl("btnNose") as Button;
            btn.OnClientClick = String.Format("showValue('{0}');", btn.CommandArgument);
        }

        //protected void pro_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    switch (e.CommandName)
        //    {
        //        case "Click":
        //            //get command argument here
        //            somedata = e.CommandArgument.ToString();
        //            break;
        //    }
        //    EditarProducto();
        //    Response.Redirect("/Presentacion/Tienda/MisProductos.aspx");

        //}

        //protected void pro_ItemCommand1(object source, RepeaterCommandEventArgs e)
        //{
        //    switch (e.CommandName)
        //    {
        //        case "Click":
        //            //get command argument here
        //            somedata = e.CommandArgument.ToString();
        //            EditarProducto();
        //            Response.Redirect("/Presentacion/Tienda/MisProductos.aspx");
        //            break;
        //    }
        //}


    }
}