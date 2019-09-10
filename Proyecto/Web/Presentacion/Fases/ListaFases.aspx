<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListaFases.aspx.cs" Inherits="Web.Presentacion.Fases.ListaFases" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <form action="ListaFases.aspx" method="post" runat="server">
            <%--<div id="f0" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/Caracteristicas.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id0" name="id0" runat="server" placeholder="Id" hidden></h5>
                            <h2 id="Titulo0" name="Titulo0" runat="server"></h2>
                            <p id="des0" name="des0" runat="server"></p>
                            <br />
                            <input id="Etapa0" runat="server" name="Etapa0" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>--%>
            <div id="f1" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <%--<img class="card-img-top" src="../../images/FENOLOGIA/151.jpg" height="90">--%>
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input id="id1" name="id1" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo1" name="Titulo1" runat="server"></h2>
                            <p id="des1" name="des1" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio1" runat="server" name="fechaInicio1" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar1" type="submit" onserverclick="mtdEditarFase1" runat="server" name="Editar1" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa1" runat="server" name="Etapa1" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f2" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/153.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id2" id="id2" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo2" name="Titulo2" runat="server"></h2>
                            <p id="des2" name="des2" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio2" name="fechaInicio2" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar2" type="submit" runat="server" onserverclick="mtdEditarFase2" name="Editar2" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa2" runat="server" name="Etapa2" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f3" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/155.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id3" id="id3" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo3" name="Titulo3" runat="server"></h2>
                            <p id="des3" name="des3" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" runat="server" id="fechaInicio3" name="fechaInicio3" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar3" type="submit" runat="server" onserverclick="mtdEditarFase3" name="Editar3" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa3" runat="server" name="Etapa3" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f4" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/159.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id4" id="id4" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo4" name="Titulo4" runat="server"></h2>
                            <p id="des4" name="des4" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio4" name="fechaInicio4" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar4" type="submit" runat="server" onserverclick="mtdEditarFase4" name="Editar4" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa4" runat="server" name="Etapa4" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f5" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                     <%--   <img class="card-img-top" src="../../images/FENOLOGIA/301.jpg" height="90">--%>
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id5" id="id5" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo5" name="Titulo5" runat="server"></h2>
                            <p id="des5" name="des5" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio5" name="fechaInicio5" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar5" type="submit" runat="server" name="Editar5" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente5" type="button" runat="server" name="siguiente5" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa5" runat="server" name="Etapa5" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f6" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                       <%-- <img class="card-img-top" src="../../images/FENOLOGIA/305.jpg" height="90">--%>
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id6" id="id6" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo6" name="Titulo6" runat="server"></h2>
                            <p id="des6" name="des6" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio6" name="fechaInicio6" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar6" type="submit" runat="server" onserverclick="mtdEditarFase6" name="Editar6" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa6" runat="server" name="Etapa6" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f7" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
<%--                        <img class="card-img-top" src="../../images/FENOLOGIA/309.jpg" height="90">--%>
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id7" id="id7" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo7" name="Titulo7" runat="server"></h2>
                            <p id="des7" name="des7" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio7" name="fechaInicio7" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar7" type="submit" runat="server" onserverclick="mtdEditarFase7" name="Editar7" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa7" runat="server" name="Etapa7" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f8" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/500.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id8" id="id8" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo8" name="Titulo8" runat="server"></h2>
                            <p id="des8" name="des8" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio8" name="fechaInicio8" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar8" type="submit" runat="server" onserverclick="mtdEditarFase8" name="Editar8" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente8" type="button" runat="server" name="siguiente8" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa8" runat="server" name="Etapa8" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f9" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
<%--                        <img class="card-img-top" src="../../images/FENOLOGIA/501.jpg" height="90">--%>
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id9" id="id9" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo9" name="Titulo9" runat="server"></h2>
                            <p id="des9" name="des9" runat="server"></p>

                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio9" name="fechaInicio9" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar9" type="submit" runat="server" onserverclick="mtdEditarFase9" name="Editar9" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa9" runat="server" name="Etapa9" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f10" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/503.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id10" id="id10" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo10" name="Titulo0" runat="server"></h2>
                            <p id="des10" name="des10" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio10" name="fechaInicio10" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar10" type="submit" runat="server" onserverclick="mtdEditarFase10" name="Editar10" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente10" type="button" runat="server" name="siguiente10" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa10" runat="server" name="Etapa10" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f11" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/505.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id11" id="id11" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo11" name="Titulo11" runat="server"></h2>
                            <p id="des11" name="des11" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio11" name="fechaInicio11" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar11" type="submit" runat="server" onserverclick="mtdEditarFase11" name="Editar11" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar fecha</button>
                                </div>
                            </div>
                            <input id="Etapa11" runat="server" name="Etapa11" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f12" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                    <%--    <img class="card-img-top" src="../../images/FENOLOGIA/509.jpg" height="90">--%>
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id12" id="id12" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo12" name="Titulo12" runat="server"></h2>
                            <p id="des12" name="des12" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio12" name="fechaInicio12" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar12" type="submit" runat="server" onserverclick="mtdEditarFase12" name="Editar12" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                            </div>
                            <input id="Etapa12" runat="server" name="Etapa12" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f13" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/601.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id13" id="id13" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo13" name="Titulo13" runat="server"></h2>
                            <p id="des13" name="des13" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio13" name="fechaInicio13" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar13" type="submit" runat="server" onserverclick="mtdEditarFase13" name="Editar13" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente13" type="button" runat="server" name="siguiente13" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa13" runat="server" name="Etapa13" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
<%--<%--<%--            <div id="f14" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                   <%--     <img class="card-img-top" src="../../images/FENOLOGIA/602.jpg" height="90">
                   --%> </div>
                  <%--  <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id14" id="id14" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo14" name="Titulo14" runat="server"></h2>
                            <p id="des14" name="des14" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio14" name="fechaInicio14" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal14" name="fechaFinal14" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar14" type="submit" runat="server" onserverclick="mtdEditarFase14" name="Editar14" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente14" type="button" runat="server" name="siguiente14" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa14" runat="server" name="Etapa14" placeholder="Etapa" hidden />
                        </div>
                    </div>
             --%>  <%-- </div>
            </div>--%>
            <%--<div id="f15" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">--%>--%>--%>
                       <%-- <img class="card-img-top" src="../../images/FENOLOGIA/603.jpg" height="90">--%>
                    <%--</div>--%>
            --%>      <%--  <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id15" id="id15" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo15" name="Titulo15" runat="server"></h2>
                            <p id="des15" name="des15" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio15" name="fechaInicio15" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal15" name="fechaFinal15" />
                                </div>
                            </div>
                        </div>
                        <div class="row form-group">
                            <div class="col-4 col-md-4">
                                <button id="Editar15" type="submit" runat="server" onserverclick="mtdEditarFase15" name="Editar15" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Registrar Fecha</button>
                            </div>
                            <div class="col-4 col-md-4">
                                <button id="siguiente15" type="button" runat="server" name="siguiente15" class="btn btn-success btn-sm">
                                    Siguiente <i class="fa  fa-arrow-right"></i>
                                </button>
                            </div>
                        </div>
                        <input id="Etapa15" runat="server" name="Etapa15" placeholder="Etapa" hidden />
                    </div>
                </div>
            </div>--%>
           <%-- <div id="f16" runat="server" class="card">
           --%>    <%--<%-- <<%--div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/607.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id16" id="id16" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo16" name="Titulo16" runat="server"></h2>
                            <p id="des16" name="des16" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio16" name="fechaInicio16" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal16" name="fechaFinal16" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar16" type="submit" runat="server" onserverclick="mtdEditarFase16" name="Editar16" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente16" type="button" runat="server" name="siguiente16" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                 --%> --%>--%>          <%--<input id="Etapa16" runat="server" name="Etapa16" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f17" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/609.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id17" id="id17" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo17" name="Titulo17" runat="server"></h2>
                            <p id="des17" name="des17" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio17" name="fechaInicio17" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal17" name="fechaFinal17" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar17" type="submit" runat="server" onserverclick="mtdEditarFase17" name="Editar17" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente17" type="button" runat="server" name="siguiente17" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa17" runat="server" name="Etapa17" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f18" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/700.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id18" id="id18" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo18" name="Titulo18" runat="server"></h2>
                            <p id="des18" name="des18" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio18" name="fechaInicio18" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal18" name="fechaFinal18" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar18" type="submit" runat="server" onserverclick="mtdEditarFase18" name="Editar18" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente18" type="button" runat="server" name="siguiente18" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa18" runat="server" name="Etapa18" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f19" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/703.jpg" height="90">
                    </div>
                    <div>
                        <div class="card-body">
                            <input name="id19" id="id19" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo19" name="Titulo19" runat="server"></h2>
                            <p id="des19" name="des19" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio19" name="fechaInicio19" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal19" name="fechaFinal19" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar19" type="submit" runat="server" onserverclick="mtdEditarFase19" name="Editar19" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente19" type="button" runat="server" name="siguiente19" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa19" runat="server" name="Etapa19" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f20" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/708.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id20" id="id20" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo20" name="Titulo20" runat="server"></h2>
                            <p id="des20" name="des20" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio20" name="fechaInicio20" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal20" name="fechaFinal20" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar20" type="submit" runat="server" onserverclick="mtdEditarFase20" name="Editar20" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente20" type="button" runat="server" name="siguiente20" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa20" runat="server" name="Etapa20" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f21" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/709.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id21" id="id21" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo21" name="Titulo21" runat="server"></h2>
                            <p id="des21" name="des21" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio21" name="fechaInicio21" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal21" name="fechaFinal21" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar21" type="button" name="Editar21" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente21" type="button" runat="server" name="siguiente21" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa21" runat="server" name="Etapa21" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f22" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/800.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id22" id="id22" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo22" name="Titulo22" runat="server"></h2>
                            <p id="des22" name="des22" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio22" name="fechaInicio22" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal22" name="fechaFinal22" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar22" type="submit" runat="server" onserverclick="mtdEditarFase22" name="Editar22" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente22" type="button" runat="server" name="siguiente22" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa22" runat="server" name="Etapa22" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f23" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/805.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id23" id="id23" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo23" name="Titulo23" runat="server"></h2>
                            <p id="des23" name="des23" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio23" name="fechaInicio23" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal23" name="fechaFinal23" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar23" type="submit" runat="server" onserverclick="mtdEditarFase23" name="Editar23" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente23" type="button" runat="server" name="siguiente23" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa23" runat="server" name="Etapa23" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f24" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/807.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id24" id="id24" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo24" name="Titulo24" runat="server"></h2>
                            <p id="des24" name="des24" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio24" name="fechaInicio24" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal24" name="fechaFinal24" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar24" type="submit" runat="server" onserverclick="mtdEditarFase24" name="Editar24" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente24" type="button" runat="server" name="siguiente24" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa24" runat="server" name="Etapa24" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f25" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/809.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id25" id="id25" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo25" name="Titulo25" runat="server"></h2>
                            <p id="des25" name="des25" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio25" name="fechaInicio25" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal25" name="fechaFinal25" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar25" type="submit" runat="server" onserverclick="mtdEditarFase25" name="Editar25" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente25" type="button" runat="server" name="siguiente25" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa25" runat="server" name="Etapa22" placeholder="Etapa" hidden />
                        </div>
                    </div>
                </div>
            </div>
            <div id="f26" runat="server" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/909.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input name="id26" id="id26" runat="server" placeholder="Id" hidden />
                            <h2 id="Titulo26" name="Titulo26" runat="server"></h2>
                            <p id="des26" name="des26" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaInicio26" name="fechaInicio26" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" runat="server" type="date" id="fechaFinal26" name="fechaFinal26" />
                                </div>
                            </div>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <button id="Editar26" type="submit" runat="server" onserverclick="mtdEditarFase26" name="Editar26" class="btn btn-primary btn-sm">
                                        <i class="fa fa-check-square"></i>Registrar Fecha</button>
                                </div>
                                <div class="col-4 col-md-4">
                                    <button id="siguiente26" type="button" runat="server" name="siguiente26" class="btn btn-success btn-sm">
                                        Siguiente <i class="fa  fa-arrow-right"></i>
                                    </button>
                                </div>
                            </div>
                            <input id="Etapa26" runat="server" name="Etapa26" placeholder="Etapa" hidden/>
                        </div>
                    </div>
                </div>
            </div>--%>
        </form>
    </div>
</asp:Content>
