    using Servicio.Datos;
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
            int result = objUsuarios.mtdEditarUsuario(objUsu);
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

        [WebMethod]
        public DataSet mtdEnviarID(int x)
        {
            DataSet dsRol = new DataSet();
            clTerreno objRol = new clTerreno();
            dsRol = objRol.mtdListarT(x);
            return dsRol;
        }

        [WebMethod]
        public DataSet mtdBuscar(clUsuario objUsua)
        {
            DataSet dsUsuario = new DataSet();
            clUsuario objUsuario = new clUsuario();
            dsUsuario = objUsuario.mtdBuscar(objUsua);
            return dsUsuario;
        }

        [WebMethod]
        public int mtdRegistrarProducto(clProducto objPro)
        {
            clProducto objClProducto = new clProducto();
            int resul = objClProducto.mtdRegistrarProducto(objPro);
            return resul;
        }

        [WebMethod]
        public DataSet mtdListarFases()
        {
            DataSet dsFase = new DataSet();
            clFases objFase = new clFases();
            dsFase = objFase.mtdListar();
            return dsFase;
        }

        [WebMethod]
        public int mtdEditarFase(clFases objFas)
        {
            clFases objFase = new clFases();
            int result = objFase.mtdEditarFase(objFas);
            return result;
        }

        [WebMethod]
        public int mtdEditarTerreno(clTerreno objT)
        {
            clTerreno objTe = new clTerreno();
            int result = objTe.mtdEditarTerreno(objT);
            return result;
        }

        [WebMethod]
        public DataSet mtdBuscarTerreno(clTerreno objTerreno)
        {
            DataSet dsTerreno = new DataSet();
            clTerreno objTerr = new clTerreno();
            dsTerreno = objTerr.mtdBuscar(objTerreno);
            return dsTerreno;
        }
        [WebMethod]
        public DataSet mtdfecha()
        {
            DataSet dsFase = new DataSet();
            clFases objFase = new clFases();
            dsFase = objFase.mtdfecha();
            return dsFase;
        }

        [WebMethod]
        public DataSet mtdListarTipoInsumo()
        {
            DataSet dsTipo = new DataSet();
            clRol objTipo = new clRol();
            dsTipo = objTipo.mtdListarRol();
            return dsTipo;
        }

        [WebMethod]
        public int mtdRegistrarPregunta(clPregunta objPre)
        {
            clPregunta objPregunta = new clPregunta();
            int resultado = objPregunta.mtdRegistrarPregunta(objPre);
            return resultado;
        }

        [WebMethod]
        public DataSet mtdListarPregunta()
        {
            DataSet dsPregunta = new DataSet();
            clPregunta objPregunta = new clPregunta();
            dsPregunta = objPregunta.mtdListarPregunta();
            return dsPregunta;
        }

        [WebMethod]
        public int mtdRegistrarRespuesta(clRespuesta objRes)
        {
            clRespuesta objRespuesta = new clRespuesta();
            int resultado = objRespuesta.mtdRegistrarRespuesta(objRes);
            return resultado;
        }

        [WebMethod]
        public DataSet mtdListarEtapa()
        {
            DataSet dsEtapa = new DataSet();
            clEtapas objClEtapa = new clEtapas();
            dsEtapa = objClEtapa.mtdListar();
            return dsEtapa;
        }

    }
}
