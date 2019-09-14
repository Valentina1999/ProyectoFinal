using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clSuelos
    {

        public double AcidezOalcalinidad { get; set; }
        public double Aluminio { get; set; }
        public double Nitrógeno { get; set; }
        public double Potasio { get; set; }
        public double Fósforo { get; set; }
        public double Calcio { get; set; }
        public double Magnesio { get; set; }
        public double Azufre { get; set; }
        public double Cobre { get; set; }
        public double Cinc { get; set; }
        public double Manganeso { get; set; }
        public double Boro { get; set; }
        public int IdTipoSuelo { get; set; }
        public int IdCultivo { get; set; }
        public int IdTerreno { get; set; }


        public int mtdRegistrarSuelo(clSuelos objSuelos)
        {
            string consulta = "Insert Into Suelos(AcidezOAlcalinidad, Aluminio, Nitrógeno, Potasio, Fósforo, Calcio, Magnesio, Azufre, Cobre, Cinc, Manganeso, Boro, IdTipoSuelo, IdTerreno)values(" +objSuelos.AcidezOalcalinidad+ " , " +objSuelos.Aluminio+ " , " +objSuelos.Nitrógeno+ " , " +objSuelos.Potasio+ " , " +objSuelos.Fósforo+ " , " +objSuelos.Calcio+ " , " +objSuelos.Magnesio+ " , " +objSuelos.Azufre+ " , " +objSuelos.Cobre+ " , " +objSuelos.Cinc+ " , " +objSuelos.Manganeso+ " , " +objSuelos.Boro+ " , " +objSuelos.IdTipoSuelo+" , "+objSuelos.IdTerreno+ " )";
            clConexion clConexion = new clConexion();
            int resultado = clConexion.mtdConectado(consulta);
            return resultado;

        }
    }
}