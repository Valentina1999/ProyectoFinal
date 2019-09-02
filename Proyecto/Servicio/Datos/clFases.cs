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
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int IdEtapas { get; set; }

        public DataSet mtdListar()
        {
            string consulta = "Select * From Fase";
            DataSet dsFase = new DataSet();
            clConexion objConexion = new clConexion();
            dsFase = objConexion.mtdDesconectado(consulta);

            return dsFase;
        }

    }
}