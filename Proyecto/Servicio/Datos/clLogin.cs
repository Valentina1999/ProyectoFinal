using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clLogin
    {
        public string Correo { get; set; }
        public string Clave { get; set; }

            public int mtdContar(clLogin ObjLo)
            {
                String consulta = "Select Correo,Clave from Usuario where Correo = '"+ObjLo.Correo+"' and Clave = "+ObjLo.Clave+" ";
                clConexion objConexion = new clConexion();
                int Res = objConexion.mtdConectado(consulta);
                return Res;
            }

        }
}