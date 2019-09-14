using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clInterno
    {
        public int IdInterno { get; set; }
        public int IdEtapa { get; set; }
        public string Fase { get; set; }
        public int Dias { get; set; }
        public bool Check { get; set; }
        public bool ch = true;
        public int IdTerreno { get; set; }
        public int IdUsuario { get; set; }

        public int mtdCheckear(clInterno objInterno) {
            string consulta = "Update Interno set chec = 'true' where IdInterno = '" + objInterno.IdInterno + "'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
        public DataSet mtdListar(clInterno ObjInterno)
        {
            string consulta = "Select Interno.IdInterno, Etapa.IdEtapa, Interno.Fase, Dias, chec From Interno inner join Etapa on Interno.IdEtapa = Etapa.IdEtapa inner join cultivo on cultivo.IdEtapa = Etapa.IdEtapa inner Join Terreno on Terreno.IdTerreno = cultivo.IdTerreno inner join Usuario on Usuario.IdUsuario = Terreno.IdUsuario where Usuario.IdUsuario =" + ObjInterno.IdUsuario+"";
            DataSet dsInterno = new DataSet();
            clConexion objConexion = new clConexion();
            dsInterno = objConexion.mtdDesconectado(consulta);

            return dsInterno;
        }

        public DataSet InternoCultivo(int x)
        {
            string consulta = "Select Terreno.IdTerreno from Etapa inner join cultivo on cultivo.IdEtapa = Etapa.IdEtapa inner join Terreno on cultivo.IdTerreno = Terreno.IdTerreno inner join Usuario on Terreno.IdUsuario = Usuario.IdUsuario  where Etapa.IdEtapa = '" + x + "'";
            DataSet dsInterno = new DataSet();
            clConexion objConexion = new clConexion();
            dsInterno = objConexion.mtdDesconectado(consulta);
            return dsInterno;
        }


        int a = 1;
        // No tacar esto
        public int Etapas(clInterno objCultivo)
        {
            string consulta = "Insert Into cultivo(IdTerreno, IdEtapa)values('" + objCultivo.IdTerreno + "'," + objCultivo.IdEtapa + ")";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }


    }
}