using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Servicio.Datos;
namespace Servicio.Datos
{
    public class clTerreno
    {
        public int IdTerreno { get; set; }
        public string NombreTerreno { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public int IdUsuario { get; set; }

        

        clConexion objConexion = new clConexion();
       

        public int mtdRegistrarTerreno(clTerreno objTerreno)
        {
            string consulta = "Insert Into Terreno(NombreTerreno, Largo, Ancho, IdUsuario)values('"+objTerreno.NombreTerreno+"',"+objTerreno.Largo+","+objTerreno.Ancho+","+objTerreno.IdUsuario+")";
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

        public int mtdEditarTerreno(clTerreno objT)
        {
            string consulta = "Update Terreno set NombreTerreno = '" + objT.NombreTerreno + "', Largo = '" + objT.Largo + "', " +
                "Ancho = '" + objT.Ancho + "'where IdUsuario = '" + objT.IdUsuario + "'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }


        public DataSet mtdBuscar(clTerreno objTerreno)
        {
            string consulta = "Select NombreTerreno,Largo,Ancho From Terreno Where IdUsuario = '" + objTerreno.IdUsuario + "' and IdTerreno = '"+objTerreno.IdTerreno+"' ";
            DataSet dsTerreno = new DataSet();
            clConexion objConexion = new clConexion();
            dsTerreno = objConexion.mtdDesconectado(consulta);
            return dsTerreno;
        }
        int a = 1;
        // No tacar esto
        public int Etapas(clTerreno objTerreno)
        {
            string consulta = "Insert Into cultivo(IdTerreno, IdEtapa)values('" + objTerreno.IdTerreno + "'," + a + ")";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public DataSet EtapaTerreno(int x)
        {
            string consulta = "select Max(IdTerreno) as Id from Terreno inner join Usuario on Usuario.IdUsuario = Terreno.IdUsuario where Usuario.IdUsuario = '" + x + "'";
            DataSet dsTerreno = new DataSet();
            clConexion objConexion = new clConexion();
            dsTerreno = objConexion.mtdDesconectado(consulta);
            return dsTerreno;
        }
    }
}