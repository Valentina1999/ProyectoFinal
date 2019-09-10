using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clFases
    {
        public int IdFase { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public string Duracion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public int IdEtapas { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select * From Fase";
            DataSet dsFase = new DataSet();
            clConexion objConexion = new clConexion();
            dsFase = objConexion.mtdDesconectado(consulta);

            return dsFase;
        }

        public int mtdEditarFase(clFases objFase)
        {
            string consulta = "update Fase set FechaInicio='"+objFase.FechaInicio+"', FechaFinal='"+objFase.FechaFinal+"' where IdFase='"+objFase.IdFase+"'";

            clConexion objConexion = new clConexion();

            int resultado = objConexion.mtdConectado(consulta);

            return resultado;
        }
        //select top 1 FechaInicio, FechaFinal from Fase where FechaInicio Is Not NULL
        
        public DataSet mtdfecha()
        {
            string consulta = "select FechaFinal from Fase where IdFase = 7;";
            DataSet dsFase = new DataSet();
            clConexion objConexion = new clConexion();
            dsFase = objConexion.mtdDesconectado(consulta);

            return dsFase;
        }

    }
}