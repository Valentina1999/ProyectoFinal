using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clTerreno
    {
        public int IdTerreno { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public int IdUsuario { get; set; }

        

        clConexion objConexion = new clConexion();

        public int mtdRegistrarTerreno(clTerreno objTerreno)
        {
            string consulta = "Insert Into Terreno(Largo, Ancho, IdUsuario)values("+objTerreno.Largo+","+objTerreno.Ancho+","+objTerreno.IdUsuario+")";
            int Resultado = objConexion.mtdConectado(consulta);
            return Resultado;
        }

        public DataSet mtdListarT(int x)
        {
            string consulta = "select * from Terreno where IdUsuario = '"+x+"'";
            DataSet ds = new DataSet();
            clConexion objConexion = new clConexion();
            ds = objConexion.mtdDesconectado(consulta);
            return ds;

        }
    }
}