using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clEtapas
    {

        public int IdEtapa { get; set; }
        public int Etapa { get; set; }
        public int IdCultivo { get; set; }
        public int IdTerreno { get; set; }


        public DataSet mtdListar(int x)
        {
            string consulta = "Select Terreno.NombreTerreno, Etapa.Etapa, Etapa.Descripcion, Etapa.IdEtapa from Etapa inner join cultivo on cultivo.IdEtapa = Etapa.IdEtapa inner join Terreno on cultivo.IdTerreno = Terreno.IdTerreno inner join Usuario on Terreno.IdUsuario = Usuario.IdUsuario  where Usuario.IdUsuario = " + x + "";
            DataSet dsEtapa = new DataSet();
            clConexion objConexion = new clConexion();
            dsEtapa = objConexion.mtdDesconectado(consulta);

            return dsEtapa;
        }

    }
}