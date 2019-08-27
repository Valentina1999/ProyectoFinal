﻿using Servicio.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet mtdListarRol()
        {
            DataSet dsRol = new DataSet();
            clRol objRol = new clRol();
            dsRol = objRol.mtdListarRol();
            return dsRol;
        }

        [WebMethod]
        public int mtdRegistrarUsuario(clUsuario objUsu)
        {
            clUsuario objClUsuario = new clUsuario();
            int resul = objClUsuario.mtdRegistrarUsuario(objUsu);
            return resul;
        }

        [WebMethod]
        public int mtdEditarUsuarios(clUsuario objUsu)
        {
            clUsuario objUsuarios = new clUsuario();
            int result = objUsuarios.mtdEditarUsuario(objUsuarios);
            return result;
        }

        [WebMethod]
        public int mtdRegistrarTerreno(clTerreno objTerr)
        {
            clTerreno objTerreno = new clTerreno();
            int result = objTerreno.mtdRegistrarTerreno(objTerr);
            return result;
        }

        [WebMethod]
        public int mtdRegistrarSuelos(clSuelos objSuelos)
        {
            clSuelos objSuelo = new clSuelos();
            int result = objSuelo.mtdRegistrarSuelo(objSuelos);
            return result;
        }

        [WebMethod]
        public DataSet mtdListarSuelo()
        {
            DataSet dsSuelo = new DataSet();
            clTipoSuelo objTSuelo = new clTipoSuelo();
            dsSuelo = objTSuelo.mtdListarSuelo();
            return dsSuelo;
        }

        [WebMethod]
        public int mtdLogin(string Correo , string Clave)
        {
            clConexion objC = new clConexion();
            int result = objC.mtdLogin(Correo,Clave);
            return result;
        }
    }
}
