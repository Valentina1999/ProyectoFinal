using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Fases
{
    public partial class ListaFases : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient servicioU = new ServicioUsuario.WebService1SoapClient();
        Servicio.Datos.clFases objFases = new Servicio.Datos.clFases();
        public string nombre;

        protected void Page_Load(object sender, EventArgs e)
        {
            listar();
        }
        
        protected void listar()
        {
            DataSet dsListar = new DataSet();
            dsListar = servicioU.mtdListarFases();

            id0.InnerText = dsListar.Tables["tblDatos"].Rows[0]["IdFase"].ToString();
            Titulo0.InnerText = dsListar.Tables["tblDatos"].Rows[0]["Nombre"].ToString();
            des0.InnerText = dsListar.Tables["tblDatos"].Rows[0]["Descripcion"].ToString();
            Etapa0.Value = dsListar.Tables["tblDatos"].Rows[0]["IdEtapa"].ToString();

            id1.InnerText = dsListar.Tables["tblDatos"].Rows[1]["IdFase"].ToString();
            Titulo1.InnerText = dsListar.Tables["tblDatos"].Rows[1]["Nombre"].ToString();
            des1.InnerText = dsListar.Tables["tblDatos"].Rows[1]["Descripcion"].ToString();
            Etapa1.Value = dsListar.Tables["tblDatos"].Rows[1]["IdEtapa"].ToString();

            id2.InnerText = dsListar.Tables["tblDatos"].Rows[2]["IdFase"].ToString();
            Titulo2.InnerText = dsListar.Tables["tblDatos"].Rows[2]["Nombre"].ToString();
            des2.InnerText = dsListar.Tables["tblDatos"].Rows[2]["Descripcion"].ToString();
            Etapa2.Value = dsListar.Tables["tblDatos"].Rows[2]["IdEtapa"].ToString();

            id3.InnerText = dsListar.Tables["tblDatos"].Rows[3]["IdFase"].ToString();
            Titulo3.InnerText = dsListar.Tables["tblDatos"].Rows[3]["Nombre"].ToString();
            des3.InnerText = dsListar.Tables["tblDatos"].Rows[3]["Descripcion"].ToString();
            Etapa3.Value = dsListar.Tables["tblDatos"].Rows[3]["IdEtapa"].ToString();

            id4.InnerText = dsListar.Tables["tblDatos"].Rows[4]["IdFase"].ToString();
            Titulo4.InnerText = dsListar.Tables["tblDatos"].Rows[4]["Nombre"].ToString();
            des4.InnerText = dsListar.Tables["tblDatos"].Rows[4]["Descripcion"].ToString();
            Etapa4.Value = dsListar.Tables["tblDatos"].Rows[4]["IdEtapa"].ToString();

            id5.InnerText = dsListar.Tables["tblDatos"].Rows[5]["IdFase"].ToString();
            Titulo5.InnerText = dsListar.Tables["tblDatos"].Rows[5]["Nombre"].ToString();
            des5.InnerText = dsListar.Tables["tblDatos"].Rows[5]["Descripcion"].ToString();
            Etapa5.Value = dsListar.Tables["tblDatos"].Rows[5]["IdEtapa"].ToString();

            id6.InnerText = dsListar.Tables["tblDatos"].Rows[6]["IdFase"].ToString();
            Titulo6.InnerText = dsListar.Tables["tblDatos"].Rows[6]["Nombre"].ToString();
            des6.InnerText = dsListar.Tables["tblDatos"].Rows[6]["Descripcion"].ToString();
            Etapa6.Value = dsListar.Tables["tblDatos"].Rows[6]["IdEtapa"].ToString();

            id7.InnerText = dsListar.Tables["tblDatos"].Rows[7]["IdFase"].ToString();
            Titulo7.InnerText = dsListar.Tables["tblDatos"].Rows[7]["Nombre"].ToString();
            des7.InnerText = dsListar.Tables["tblDatos"].Rows[7]["Descripcion"].ToString();
            Etapa7.Value = dsListar.Tables["tblDatos"].Rows[7]["IdEtapa"].ToString();

            id8.InnerText = dsListar.Tables["tblDatos"].Rows[8]["IdFase"].ToString();
            Titulo8.InnerText = dsListar.Tables["tblDatos"].Rows[8]["Nombre"].ToString();
            des8.InnerText = dsListar.Tables["tblDatos"].Rows[8]["Descripcion"].ToString();
            Etapa8.Value = dsListar.Tables["tblDatos"].Rows[8]["IdEtapa"].ToString();

            id9.InnerText = dsListar.Tables["tblDatos"].Rows[9]["IdFase"].ToString();
            Titulo9.InnerText = dsListar.Tables["tblDatos"].Rows[9]["Nombre"].ToString();
            des9.InnerText = dsListar.Tables["tblDatos"].Rows[9]["Descripcion"].ToString();
            Etapa9.Value = dsListar.Tables["tblDatos"].Rows[9]["IdEtapa"].ToString();

            id10.InnerText = dsListar.Tables["tblDatos"].Rows[10]["IdFase"].ToString();
            Titulo10.InnerText = dsListar.Tables["tblDatos"].Rows[10]["Nombre"].ToString();
            des10.InnerText = dsListar.Tables["tblDatos"].Rows[10]["Descripcion"].ToString();
            Etapa10.Value = dsListar.Tables["tblDatos"].Rows[10]["IdEtapa"].ToString();

            id11.InnerText = dsListar.Tables["tblDatos"].Rows[11]["IdFase"].ToString();
            Titulo11.InnerText = dsListar.Tables["tblDatos"].Rows[11]["Nombre"].ToString();
            des11.InnerText = dsListar.Tables["tblDatos"].Rows[11]["Descripcion"].ToString();
            Etapa11.Value = dsListar.Tables["tblDatos"].Rows[11]["IdEtapa"].ToString();

            id12.InnerText = dsListar.Tables["tblDatos"].Rows[12]["IdFase"].ToString();
            Titulo12.InnerText = dsListar.Tables["tblDatos"].Rows[12]["Nombre"].ToString();
            des12.InnerText = dsListar.Tables["tblDatos"].Rows[12]["Descripcion"].ToString();
            Etapa12.Value = dsListar.Tables["tblDatos"].Rows[12]["IdEtapa"].ToString();

            id13.InnerText = dsListar.Tables["tblDatos"].Rows[13]["IdFase"].ToString();
            Titulo13.InnerText = dsListar.Tables["tblDatos"].Rows[13]["Nombre"].ToString();
            des13.InnerText = dsListar.Tables["tblDatos"].Rows[13]["Descripcion"].ToString();
            Etapa13.Value = dsListar.Tables["tblDatos"].Rows[13]["IdEtapa"].ToString();

            id14.InnerText = dsListar.Tables["tblDatos"].Rows[14]["IdFase"].ToString();
            Titulo14.InnerText = dsListar.Tables["tblDatos"].Rows[14]["Nombre"].ToString();
            des14.InnerText = dsListar.Tables["tblDatos"].Rows[14]["Descripcion"].ToString();
            Etapa14.Value = dsListar.Tables["tblDatos"].Rows[14]["IdEtapa"].ToString();

            id15.InnerText = dsListar.Tables["tblDatos"].Rows[15]["IdFase"].ToString();
            Titulo15.InnerText = dsListar.Tables["tblDatos"].Rows[15]["Nombre"].ToString();
            des15.InnerText = dsListar.Tables["tblDatos"].Rows[15]["Descripcion"].ToString();
            Etapa15.Value = dsListar.Tables["tblDatos"].Rows[15]["IdEtapa"].ToString();

            id16.InnerText = dsListar.Tables["tblDatos"].Rows[16]["IdFase"].ToString();
            Titulo16.InnerText = dsListar.Tables["tblDatos"].Rows[16]["Nombre"].ToString();
            des16.InnerText = dsListar.Tables["tblDatos"].Rows[16]["Descripcion"].ToString();
            Etapa16.Value = dsListar.Tables["tblDatos"].Rows[16]["IdEtapa"].ToString();

            id17.InnerText = dsListar.Tables["tblDatos"].Rows[17]["IdFase"].ToString();
            Titulo17.InnerText = dsListar.Tables["tblDatos"].Rows[17]["Nombre"].ToString();
            des17.InnerText = dsListar.Tables["tblDatos"].Rows[17]["Descripcion"].ToString();
            Etapa17.Value = dsListar.Tables["tblDatos"].Rows[17]["IdEtapa"].ToString();

            id18.InnerText = dsListar.Tables["tblDatos"].Rows[18]["IdFase"].ToString();
            Titulo18.InnerText = dsListar.Tables["tblDatos"].Rows[18]["Nombre"].ToString();
            des18.InnerText = dsListar.Tables["tblDatos"].Rows[18]["Descripcion"].ToString();
            Etapa18.Value = dsListar.Tables["tblDatos"].Rows[18]["IdEtapa"].ToString();

            id19.InnerText = dsListar.Tables["tblDatos"].Rows[19]["IdFase"].ToString();
            Titulo19.InnerText = dsListar.Tables["tblDatos"].Rows[19]["Nombre"].ToString();
            des19.InnerText = dsListar.Tables["tblDatos"].Rows[19]["Descripcion"].ToString();
            Etapa19.Value = dsListar.Tables["tblDatos"].Rows[19]["IdEtapa"].ToString();

            id20.InnerText = dsListar.Tables["tblDatos"].Rows[20]["IdFase"].ToString();
            Titulo20.InnerText = dsListar.Tables["tblDatos"].Rows[20]["Nombre"].ToString();
            des20.InnerText = dsListar.Tables["tblDatos"].Rows[20]["Descripcion"].ToString();
            Etapa20.Value = dsListar.Tables["tblDatos"].Rows[20]["IdEtapa"].ToString();

            id21.InnerText = dsListar.Tables["tblDatos"].Rows[21]["IdFase"].ToString();
            Titulo21.InnerText = dsListar.Tables["tblDatos"].Rows[21]["Nombre"].ToString();
            des21.InnerText = dsListar.Tables["tblDatos"].Rows[21]["Descripcion"].ToString();
            Etapa21.Value = dsListar.Tables["tblDatos"].Rows[21]["IdEtapa"].ToString();

            id22.InnerText = dsListar.Tables["tblDatos"].Rows[22]["IdFase"].ToString();
            Titulo22.InnerText = dsListar.Tables["tblDatos"].Rows[22]["Nombre"].ToString();
            des22.InnerText = dsListar.Tables["tblDatos"].Rows[22]["Descripcion"].ToString();
            Etapa22.Value = dsListar.Tables["tblDatos"].Rows[22]["IdEtapa"].ToString();

            id23.InnerText = dsListar.Tables["tblDatos"].Rows[23]["IdFase"].ToString();
            Titulo23.InnerText = dsListar.Tables["tblDatos"].Rows[23]["Nombre"].ToString();
            des23.InnerText = dsListar.Tables["tblDatos"].Rows[23]["Descripcion"].ToString();
            Etapa23.Value = dsListar.Tables["tblDatos"].Rows[23]["IdEtapa"].ToString();

            id24.InnerText = dsListar.Tables["tblDatos"].Rows[24]["IdFase"].ToString();
            Titulo24.InnerText = dsListar.Tables["tblDatos"].Rows[24]["Nombre"].ToString();
            des24.InnerText = dsListar.Tables["tblDatos"].Rows[24]["Descripcion"].ToString();
            Etapa24.Value = dsListar.Tables["tblDatos"].Rows[24]["IdEtapa"].ToString();

            id25.InnerText = dsListar.Tables["tblDatos"].Rows[25]["IdFase"].ToString();
            Titulo25.InnerText = dsListar.Tables["tblDatos"].Rows[25]["Nombre"].ToString();
            des25.InnerText = dsListar.Tables["tblDatos"].Rows[25]["Descripcion"].ToString();
            Etapa25.Value = dsListar.Tables["tblDatos"].Rows[25]["IdEtapa"].ToString();

            id26.InnerText = dsListar.Tables["tblDatos"].Rows[26]["IdFase"].ToString();
            Titulo26.InnerText = dsListar.Tables["tblDatos"].Rows[26]["Nombre"].ToString();
            des26.InnerText = dsListar.Tables["tblDatos"].Rows[26]["Descripcion"].ToString();
            Etapa26.Value = dsListar.Tables["tblDatos"].Rows[26]["IdEtapa"].ToString();


            //foreach (FileInfo fi in ficheros)
            //{
            //    Response.Write(string.Format("<img src='../../images/FENOLOGIA/{0}' alt='Ver{0}' height='100' width='100'/>", fi.Name));
            //}





        }

    }
}