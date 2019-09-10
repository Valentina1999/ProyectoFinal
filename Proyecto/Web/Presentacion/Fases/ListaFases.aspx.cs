using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Presentacion.Etapa;


namespace Web.Presentacion.Fases
{
    public partial class ListaFases : System.Web.UI.Page
    {
        int IdE = int.Parse(ListarEtapa.somedata.ToString());
        ServicioUsuario.WebService1SoapClient servicioU = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clFases objFases = new ServicioUsuario.clFases();

        public string nombre;

        protected void Page_Load(object sender, EventArgs e)
        {
            listar();
            mostrarFase();
        }

        protected void mostrarFase()
        {
            try
            {
                if (IdE == 1)
                {
                    //f0.Visible = true;
                    f1.Visible = true;
                    f2.Visible = true;
                    f3.Visible = true;
                    f4.Visible = true;
                    f5.Visible = true;
                    f6.Visible = false;
                    f7.Visible = false;
                    f8.Visible = false;
                    f9.Visible = false;
                    f10.Visible = false;
                    f11.Visible = false;
                    f12.Visible = false;
                    f13.Visible = false;
                    //f14.Visible = false;
                    //f15.Visible = false;
                //    f16.Visible = false;
                //    f17.Visible = false;
                //    f18.Visible = false;
                //    f19.Visible = false;
                //    f20.Visible = false;
                //    f21.Visible = false;
                //    f22.Visible = false;
                //    f23.Visible = false;
                //    f24.Visible = false;
                //    f25.Visible = false;
                //    f26.Visible = false;
                }
                else if (IdE == 2)
                {
                    //f0.Visible = false;
                    f1.Visible = false;
                    f2.Visible = false;
                    f3.Visible = false;
                    f4.Visible = false;
                    f5.Visible = false;
                    f6.Visible = true;
                    f7.Visible = true;
                    f8.Visible = true;
                    f9.Visible = false;
                    f10.Visible = false;
                    f11.Visible = false;
                    f12.Visible = false;
                    f13.Visible = false;
                    //f14.Visible = false;
                    //f15.Visible = false;
                //    f16.Visible = false;
                //    f17.Visible = false;
                //    f18.Visible = false;
                //    f19.Visible = false;
                //    f20.Visible = false;
                //    f21.Visible = false;
                //    f22.Visible = false;
                //    f23.Visible = false;
                //    f24.Visible = false;
                //    f25.Visible = false;
                //    f26.Visible = false;
                }
                else if (IdE == 11)
                {
                    //f0.Visible = false;
                    f1.Visible = false;
                    f2.Visible = false;
                    f3.Visible = false;
                    f4.Visible = false;
                    f5.Visible = false;
                    f6.Visible = false;
                    f7.Visible = false;
                    f8.Visible = false;
                    f9.Visible = true;
                    f10.Visible = true;
                    f11.Visible = false;
                    f12.Visible = false;
                    f13.Visible = false;
                    //f14.Visible = false;
                    //f15.Visible = false;
                    ////f16.Visible = false;
                    //f17.Visible = false;
                    //f18.Visible = false;
                    //f19.Visible = false;
                    //f20.Visible = false;
                    //f21.Visible = false;
                    //f22.Visible = false;
                    //f23.Visible = false;
                    //f24.Visible = false;
                    //f25.Visible = false;
                    //f26.Visible = false;
                }
                else if (IdE == 13)
                {
                    //f0.Visible = false;
                    f1.Visible = false;
                    f2.Visible = false;
                    f3.Visible = false;
                    f4.Visible = false;
                    f5.Visible = false;
                    f6.Visible = false;
                    f7.Visible = false;
                    f8.Visible = false;
                    f9.Visible = false;
                    f10.Visible = false;
                    f11.Visible = true;
                    f12.Visible = true;
                    f13.Visible = true;
                    //f14.Visible = true;
                    //f15.Visible = true;
                    ////f16.Visible = false;
                    //f17.Visible = false;
                    //f18.Visible = false;
                    //f19.Visible = false;
                    //f20.Visible = false;
                    //f21.Visible = false;
                    //f22.Visible = false;
                    //f23.Visible = false;
                    //f24.Visible = false;
                    //f25.Visible = false;
                    //f26.Visible = false;
                //}
                //else if (IdE == 16)
                //{
                //    f0.Visible = false;
                //    f1.Visible = false;
                //    f2.Visible = false;
                //    f3.Visible = false;
                //    f4.Visible = false;
                //    f5.Visible = false;
                //    f6.Visible = false;
                //    f7.Visible = false;
                //    f8.Visible = false;
                //    f9.Visible = false;
                //    f10.Visible = false;
                //    f11.Visible = false;
                //    f12.Visible = false;
                //    f13.Visible = true;
                //    f14.Visible = true;
                //    f15.Visible = true;
                //    //f16.Visible = true;
                //    //f17.Visible = true;
                //    //f18.Visible = false;
                //    //f19.Visible = false;
                //    //f20.Visible = false;
                //    //f21.Visible = false;
                //    //f22.Visible = false;
                //    //f23.Visible = false;
                //    //f24.Visible = false;
                //    //f25.Visible = false;
                //    //f26.Visible = false;
                //}
                //else if (IdE == 17)
                //{
                //    f0.Visible = false;
                //    f1.Visible = false;
                //    f2.Visible = false;
                //    f3.Visible = false;
                //    f4.Visible = false;
                //    f5.Visible = false;
                //    f6.Visible = false;
                //    f7.Visible = false;
                //    f8.Visible = false;
                //    f9.Visible = false;
                //    f10.Visible = false;
                //    f11.Visible = false;
                //    f12.Visible = false;
                //    f13.Visible = false;
                //    f14.Visible = false;
                //    //f15.Visible = false;
                //    //f16.Visible = false;
                //    //f17.Visible = false;
                //    //f18.Visible = true;
                //    //f19.Visible = true;
                //    //f20.Visible = true;
                //    //f21.Visible = true;
                //    //f22.Visible = false;
                //    //f23.Visible = false;
                //    //f24.Visible = false;
                //    //f25.Visible = false;
                //    //f26.Visible = false;
                //}
                //else if (IdE == 18)
                //{
                //    f0.Visible = false;
                //    f1.Visible = false;
                //    f2.Visible = false;
                //    f3.Visible = false;
                //    f4.Visible = false;
                //    f5.Visible = false;
                //    f6.Visible = false;
                //    f7.Visible = false;
                //    f8.Visible = false;
                //    f9.Visible = false;
                //    f10.Visible = false;
                //    f11.Visible = false;
                //    f12.Visible = false;
                //    f13.Visible = false;
                //    f14.Visible = false;
                //    //f15.Visible = false;
                //    //f16.Visible = false;
                //    //f17.Visible = false;
                //    //f18.Visible = false;
                //    //f19.Visible = false;
                //    //f20.Visible = false;
                //    //f21.Visible = false;
                //    //f22.Visible = true;
                //    //f23.Visible = true;
                //    //f24.Visible = true;
                //    //f25.Visible = true;
                //    //f26.Visible = false;
                //}
                //else if (IdE == 19)
                //{
                //    f0.Visible = false;
                //    f1.Visible = false;
                //    f2.Visible = false;
                //    f3.Visible = false;
                //    f4.Visible = false;
                //    f5.Visible = false;
                //    f6.Visible = false;
                //    f7.Visible = false;
                //    f8.Visible = false;
                //    f9.Visible = false;
                //    f10.Visible = false;
                //    f11.Visible = false;
                //    f12.Visible = false;
                //    f13.Visible = false;
                //    f14.Visible = false;
                //    //f15.Visible = false;
                    //f16.Visible = false;
                    //f17.Visible = false;
                    //f18.Visible = false;
                    //f19.Visible = false;
                    //f20.Visible = false;
                    //f21.Visible = false;
                    //f22.Visible = false;
                    //f23.Visible = false;
                    //f24.Visible = false;
                    //f25.Visible = false;
                    //f26.Visible = true;
                }
            }
            catch (Exception)
            {
                Response.Redirect("../Index/Index.aspx");
            }
        }

        protected void mtdEditarFase1(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id1.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio1.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal1.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase2(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id2.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio2.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal2.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase3(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id3.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio3.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal3.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase4(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id4.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio4.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal4.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase5(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id5.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio5.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal5.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase6(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id6.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio6.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal6.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase7(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id7.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio7.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal7.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase8(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id8.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio8.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal8.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase9(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id9.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio9.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal9.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase10(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id10.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio10.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal10.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase11(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id11.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio11.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal11.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase12(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id12.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio12.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal12.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        protected void mtdEditarFase13(object sender, EventArgs e)
        {
            objFases.IdFase = int.Parse(Request.Form[id13.UniqueID]);
            objFases.FechaInicio = Request.Form[fechaInicio13.UniqueID].ToString();
            //objFases.FechaFinal = Request.Form[fechaFinal13.UniqueID].ToString();

            int resultado = servicioU.mtdEditarFase(objFases);

            if (resultado == 1)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'ListaFases.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        //protected void mtdEditarFase14(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id14.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio14.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal14.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase15(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id15.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio15.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal15.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase16(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id16.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio16.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal16.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase17(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id17.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio17.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal17.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase18(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id18.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio18.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal18.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase19(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id19.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio19.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal19.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase20(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id20.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio20.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal20.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase21(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id21.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio21.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal21.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase22(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id22.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio22.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal22.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase23(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id23.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio23.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal23.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase24(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id24.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio24.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal24.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase25(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id25.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio25.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal25.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}

        //protected void mtdEditarFase26(object sender, EventArgs e)
        //{
        //    objFases.IdFase = int.Parse(Request.Form[id26.UniqueID]);
        //    objFases.FechaInicio = Request.Form[fechaInicio26.UniqueID].ToString();
        //    objFases.FechaFinal = Request.Form[fechaFinal26.UniqueID].ToString();

        //    int resultado = servicioU.mtdEditarFase(objFases);

        //    if (resultado == 1)
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Se ha editado Exitosamente');
        //                    window.location = 'ListaFases.aspx';
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

        //    }
        //    else
        //    {
        //        string script = @"<script type='text/javascript'>
        //                    alert('Error');
        //                </script>";

        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        //    }
        //}


        protected void listar()
        {
            DataSet dsListar = new DataSet();
            dsListar = servicioU.mtdListarFases();

            //id0.InnerText = dsListar.Tables["tblDatos"].Rows[0]["IdFase"].ToString();
            //Titulo0.InnerText = dsListar.Tables["tblDatos"].Rows[0]["Nombre"].ToString();
            //des0.InnerText = dsListar.Tables["tblDatos"].Rows[0]["Descripcion"].ToString();
            //Etapa0.Value = dsListar.Tables["tblDatos"].Rows[0]["IdEtapa"].ToString();

            id1.Value = dsListar.Tables["tblDatos"].Rows[1]["IdFase"].ToString();
            Titulo1.InnerText = dsListar.Tables["tblDatos"].Rows[1]["Nombre"].ToString();
            des1.InnerText = dsListar.Tables["tblDatos"].Rows[1]["Descripcion"].ToString();
            Etapa1.Value = dsListar.Tables["tblDatos"].Rows[1]["IdEtapa"].ToString();

            id2.Value = dsListar.Tables["tblDatos"].Rows[2]["IdFase"].ToString();
            Titulo2.InnerText = dsListar.Tables["tblDatos"].Rows[2]["Nombre"].ToString();
            des2.InnerText = dsListar.Tables["tblDatos"].Rows[2]["Descripcion"].ToString();
            Etapa2.Value = dsListar.Tables["tblDatos"].Rows[2]["IdEtapa"].ToString();

            id3.Value = dsListar.Tables["tblDatos"].Rows[3]["IdFase"].ToString();
            Titulo3.InnerText = dsListar.Tables["tblDatos"].Rows[3]["Nombre"].ToString();
            des3.InnerText = dsListar.Tables["tblDatos"].Rows[3]["Descripcion"].ToString();
            Etapa3.Value = dsListar.Tables["tblDatos"].Rows[3]["IdEtapa"].ToString();

            id4.Value = dsListar.Tables["tblDatos"].Rows[4]["IdFase"].ToString();
            Titulo4.InnerText = dsListar.Tables["tblDatos"].Rows[4]["Nombre"].ToString();
            des4.InnerText = dsListar.Tables["tblDatos"].Rows[4]["Descripcion"].ToString();
            Etapa4.Value = dsListar.Tables["tblDatos"].Rows[4]["IdEtapa"].ToString();

            id5.Value = dsListar.Tables["tblDatos"].Rows[5]["IdFase"].ToString();
            Titulo5.InnerText = dsListar.Tables["tblDatos"].Rows[5]["Nombre"].ToString();
            des5.InnerText = dsListar.Tables["tblDatos"].Rows[5]["Descripcion"].ToString();
            Etapa5.Value = dsListar.Tables["tblDatos"].Rows[5]["IdEtapa"].ToString();

            id6.Value = dsListar.Tables["tblDatos"].Rows[6]["IdFase"].ToString();
            Titulo6.InnerText = dsListar.Tables["tblDatos"].Rows[6]["Nombre"].ToString();
            des6.InnerText = dsListar.Tables["tblDatos"].Rows[6]["Descripcion"].ToString();
            Etapa6.Value = dsListar.Tables["tblDatos"].Rows[6]["IdEtapa"].ToString();

            id7.Value = dsListar.Tables["tblDatos"].Rows[7]["IdFase"].ToString();
            Titulo7.InnerText = dsListar.Tables["tblDatos"].Rows[7]["Nombre"].ToString();
            des7.InnerText = dsListar.Tables["tblDatos"].Rows[7]["Descripcion"].ToString();
            Etapa7.Value = dsListar.Tables["tblDatos"].Rows[7]["IdEtapa"].ToString();

            id8.Value = dsListar.Tables["tblDatos"].Rows[8]["IdFase"].ToString();
            Titulo8.InnerText = dsListar.Tables["tblDatos"].Rows[8]["Nombre"].ToString();
            des8.InnerText = dsListar.Tables["tblDatos"].Rows[8]["Descripcion"].ToString();
            Etapa8.Value = dsListar.Tables["tblDatos"].Rows[8]["IdEtapa"].ToString();

            id9.Value = dsListar.Tables["tblDatos"].Rows[9]["IdFase"].ToString();
            Titulo9.InnerText = dsListar.Tables["tblDatos"].Rows[9]["Nombre"].ToString();
            des9.InnerText = dsListar.Tables["tblDatos"].Rows[9]["Descripcion"].ToString();
            Etapa9.Value = dsListar.Tables["tblDatos"].Rows[9]["IdEtapa"].ToString();

            id10.Value = dsListar.Tables["tblDatos"].Rows[10]["IdFase"].ToString();
            Titulo10.InnerText = dsListar.Tables["tblDatos"].Rows[10]["Nombre"].ToString();
            des10.InnerText = dsListar.Tables["tblDatos"].Rows[10]["Descripcion"].ToString();
            Etapa10.Value = dsListar.Tables["tblDatos"].Rows[10]["IdEtapa"].ToString();

            id11.Value = dsListar.Tables["tblDatos"].Rows[11]["IdFase"].ToString();
            Titulo11.InnerText = dsListar.Tables["tblDatos"].Rows[11]["Nombre"].ToString();
            des11.InnerText = dsListar.Tables["tblDatos"].Rows[11]["Descripcion"].ToString();
            Etapa11.Value = dsListar.Tables["tblDatos"].Rows[11]["IdEtapa"].ToString();

            id12.Value = dsListar.Tables["tblDatos"].Rows[12]["IdFase"].ToString();
            Titulo12.InnerText = dsListar.Tables["tblDatos"].Rows[12]["Nombre"].ToString();
            des12.InnerText = dsListar.Tables["tblDatos"].Rows[12]["Descripcion"].ToString();
            Etapa12.Value = dsListar.Tables["tblDatos"].Rows[12]["IdEtapa"].ToString();

            id13.Value = dsListar.Tables["tblDatos"].Rows[13]["IdFase"].ToString();
            Titulo13.InnerText = dsListar.Tables["tblDatos"].Rows[13]["Nombre"].ToString();
            des13.InnerText = dsListar.Tables["tblDatos"].Rows[13]["Descripcion"].ToString();
            Etapa13.Value = dsListar.Tables["tblDatos"].Rows[13]["IdEtapa"].ToString();

            //id14.Value = dsListar.Tables["tblDatos"].Rows[14]["IdFase"].ToString();
            //Titulo14.InnerText = dsListar.Tables["tblDatos"].Rows[14]["Nombre"].ToString();
            //des14.InnerText = dsListar.Tables["tblDatos"].Rows[14]["Descripcion"].ToString();
            //Etapa14.Value = dsListar.Tables["tblDatos"].Rows[14]["IdEtapa"].ToString();

            //id15.Value = dsListar.Tables["tblDatos"].Rows[15]["IdFase"].ToString();
            //Titulo15.InnerText = dsListar.Tables["tblDatos"].Rows[15]["Nombre"].ToString();
            //des15.InnerText = dsListar.Tables["tblDatos"].Rows[15]["Descripcion"].ToString();
            //Etapa15.Value = dsListar.Tables["tblDatos"].Rows[15]["IdEtapa"].ToString();

            //id16.Value = dsListar.Tables["tblDatos"].Rows[16]["IdFase"].ToString();
            //Titulo16.InnerText = dsListar.Tables["tblDatos"].Rows[16]["Nombre"].ToString();
            //des16.InnerText = dsListar.Tables["tblDatos"].Rows[16]["Descripcion"].ToString();
            //Etapa16.Value = dsListar.Tables["tblDatos"].Rows[16]["IdEtapa"].ToString();

            //id17.Value = dsListar.Tables["tblDatos"].Rows[17]["IdFase"].ToString();
            //Titulo17.InnerText = dsListar.Tables["tblDatos"].Rows[17]["Nombre"].ToString();
            //des17.InnerText = dsListar.Tables["tblDatos"].Rows[17]["Descripcion"].ToString();
            //Etapa17.Value = dsListar.Tables["tblDatos"].Rows[17]["IdEtapa"].ToString();

            //id18.Value = dsListar.Tables["tblDatos"].Rows[18]["IdFase"].ToString();
            //Titulo18.InnerText = dsListar.Tables["tblDatos"].Rows[18]["Nombre"].ToString();
            //des18.InnerText = dsListar.Tables["tblDatos"].Rows[18]["Descripcion"].ToString();
            //Etapa18.Value = dsListar.Tables["tblDatos"].Rows[18]["IdEtapa"].ToString();

            //id19.Value = dsListar.Tables["tblDatos"].Rows[19]["IdFase"].ToString();
            //Titulo19.InnerText = dsListar.Tables["tblDatos"].Rows[19]["Nombre"].ToString();
            //des19.InnerText = dsListar.Tables["tblDatos"].Rows[19]["Descripcion"].ToString();
            //Etapa19.Value = dsListar.Tables["tblDatos"].Rows[19]["IdEtapa"].ToString();

            //id20.Value = dsListar.Tables["tblDatos"].Rows[20]["IdFase"].ToString();
            //Titulo20.InnerText = dsListar.Tables["tblDatos"].Rows[20]["Nombre"].ToString();
            //des20.InnerText = dsListar.Tables["tblDatos"].Rows[20]["Descripcion"].ToString();
            //Etapa20.Value = dsListar.Tables["tblDatos"].Rows[20]["IdEtapa"].ToString();

            //id21.Value = dsListar.Tables["tblDatos"].Rows[21]["IdFase"].ToString();
            //Titulo21.InnerText = dsListar.Tables["tblDatos"].Rows[21]["Nombre"].ToString();
            //des21.InnerText = dsListar.Tables["tblDatos"].Rows[21]["Descripcion"].ToString();
            //Etapa21.Value = dsListar.Tables["tblDatos"].Rows[21]["IdEtapa"].ToString();

            //id22.Value = dsListar.Tables["tblDatos"].Rows[22]["IdFase"].ToString();
            //Titulo22.InnerText = dsListar.Tables["tblDatos"].Rows[22]["Nombre"].ToString();
            //des22.InnerText = dsListar.Tables["tblDatos"].Rows[22]["Descripcion"].ToString();
            //Etapa22.Value = dsListar.Tables["tblDatos"].Rows[22]["IdEtapa"].ToString();

            //id23.Value = dsListar.Tables["tblDatos"].Rows[23]["IdFase"].ToString();
            //Titulo23.InnerText = dsListar.Tables["tblDatos"].Rows[23]["Nombre"].ToString();
            //des23.InnerText = dsListar.Tables["tblDatos"].Rows[23]["Descripcion"].ToString();
            //Etapa23.Value = dsListar.Tables["tblDatos"].Rows[23]["IdEtapa"].ToString();

            //id24.Value = dsListar.Tables["tblDatos"].Rows[24]["IdFase"].ToString();
            //Titulo24.InnerText = dsListar.Tables["tblDatos"].Rows[24]["Nombre"].ToString();
            //des24.InnerText = dsListar.Tables["tblDatos"].Rows[24]["Descripcion"].ToString();
            //Etapa24.Value = dsListar.Tables["tblDatos"].Rows[24]["IdEtapa"].ToString();

            //id25.Value = dsListar.Tables["tblDatos"].Rows[25]["IdFase"].ToString();
            //Titulo25.InnerText = dsListar.Tables["tblDatos"].Rows[25]["Nombre"].ToString();
            //des25.InnerText = dsListar.Tables["tblDatos"].Rows[25]["Descripcion"].ToString();
            //Etapa25.Value = dsListar.Tables["tblDatos"].Rows[25]["IdEtapa"].ToString();

            //id26.Value = dsListar.Tables["tblDatos"].Rows[26]["IdFase"].ToString();
            //Titulo26.InnerText = dsListar.Tables["tblDatos"].Rows[26]["Nombre"].ToString();
            //des26.InnerText = dsListar.Tables["tblDatos"].Rows[26]["Descripcion"].ToString();
            //Etapa26.Value = dsListar.Tables["tblDatos"].Rows[26]["IdEtapa"].ToString();


            //foreach (FileInfo fi in ficheros)
            //{
            //    Response.Write(string.Format("<img src='../../images/FENOLOGIA/{0}' alt='Ver{0}' height='100' width='100'/>", fi.Name));
            //}
        }
    }
}