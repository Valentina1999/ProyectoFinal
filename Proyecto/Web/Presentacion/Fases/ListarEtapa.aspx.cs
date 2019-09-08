﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Master
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient miServicio = new ServicioUsuario.WebService1SoapClient();
            Servicio.Datos.clEtapas objClEtapas = new Servicio.Datos.clEtapas();
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
            //int a = int.Parse(Request.Form["IdEtapa"]);
            //int x = a;
            //Control txtMiControl = (Label)this.Page.Master.FindControl("Content").FindControl("lblEtapa");



        }

        protected void Page_Init(object sender, EventArgs e)
        {
            DataSet dsListar = new DataSet();
            dsListar = miServicio.mtdListarEtapa();
            Repeater1.DataSource = dsListar;
            Repeater1.DataBind();
        }


            //protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
            //{

            //    switch (e.CommandName)
            //    {
            //        case "Click":
            //            string dato = e.Item.FindControl("Etapa").ToString();
            //            //get command argument here
            //            string somedata = e.CommandArgument.ToString();
            //            break;
            //    }
            //}

            //protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
            //{


            //    string dato = e.Item.FindControl("Etapa").ToString();
            //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            //    {
            //        Button btn = e.Item.FindControl("btn") as Button;
            //        btn.OnClientClick = String.Format("showValue('{0}');", btn.CommandArgument);
            //    }
            //}

            protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public static string somedata;
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Click":
                    //get command argument here
                    somedata = e.CommandArgument.ToString();
                    break;
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            Button btn = e.Item.FindControl("btn") as Button;
            Label lbldato = e.Item.FindControl("Etapa") as Label;
            string dato = lbldato.Text;
            btn.OnClientClick = String.Format("showValue('{0}');", btn.CommandArgument);

        }
    }
}