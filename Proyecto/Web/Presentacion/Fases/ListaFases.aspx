<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListaFases.aspx.cs" Inherits="Web.Presentacion.Fases.ListaFases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <form action="" method="post" runat="server">
            <div id="0" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/Caracteristicas.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id0" name="id0" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo0" name="Titulo0" runat="server"></h2>
                            <p id="des0" name="des0" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio0" runat="server" name="fechaInicio0" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal0" runat="server" name="fechaFinal0" />
                                </div>
                                <button id="Editar0" type="button" name="Editar0" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa0" runat="server" name="Etapa0" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="1" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/151.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id1" name="id1" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo1" name="Titulo1" runat="server"></h2>
                            <p id="des1" name="des1" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio1" runat="server" name="fechaInicio1" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal1" runat="server" name="fechaFinal1" />
                                </div>
                                <button id="Editar1" type="button" name="Editar1" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa1" runat="server" name="Etapa1" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="2" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/155.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id2" name="id2" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo2" name="Titulo2" runat="server"></h2>
                            <p id="des2" name="des2" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio2" name="fechaInicio2" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal2" name="fechaFinal2" />
                                </div>
                                <button id="Editar2" type="button" name="Editar2" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa2" runat="server" name="Etapa2" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="3" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/159.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id3" name="id3" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo3" name="Titulo3" runat="server"></h2>
                            <p id="des3" name="des3" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio3" name="fechaInicio3" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal3" name="fechaFinal3" />
                                </div>
                                <button id="Editar3" type="button" name="Editar3" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa3" runat="server" name="Etapa3" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="4" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/159.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id4" name="id4" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo4" name="Titulo4" runat="server"></h2>
                            <p id="des4" name="des4" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio4" name="fechaInicio4" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal4" name="fechaFinal4" />
                                </div>
                                <button id="Editar4" type="button" name="Editar4" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa4" runat="server" name="Etapa4" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="5" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/305.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id5" name="id5" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo5" name="Titulo5" runat="server"></h2>
                            <p id="des5" name="des5" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio5" name="fechaInicio5" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal5" name="fechaFinal5" />
                                </div>
                                <button id="Editar5" type="button" name="Editar5" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa5" runat="server" name="Etapa5" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="6" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/309.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id6" name="id6" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo6" name="Titulo6" runat="server"></h2>
                            <p id="des6" name="des6" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio6" name="fechaInicio6" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal6" name="fechaFinal6" />
                                </div>
                                <button id="Editar6" type="button" name="Editar6" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa6" runat="server" name="Etapa6" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="7" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/500.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id7" name="id7" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo7" name="Titulo7" runat="server"></h2>
                            <p id="des7" name="des7" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio7" name="fechaInicio7" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal7" name="fechaFinal7" />
                                </div>
                                <button id="Editar7" type="button" name="Editar7" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa7" runat="server" name="Etapa7" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="8" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/501.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id8" name="id8" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo8" name="Titulo8" runat="server"></h2>
                            <p id="des8" name="des8" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio8" name="fechaInicio8" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal8" name="fechaFinal8" />
                                </div>
                                <button id="Editar8" type="button" name="Editar8" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa8" runat="server" name="Etapa8" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="9" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/503.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id9" name="id9" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo9" name="Titulo9" runat="server"></h2>
                            <p id="des9" name="des9" runat="server"></p>

                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio9" name="fechaInicio9" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal9" name="fechaFinal9" />
                                </div>
                                <button id="Editar9" type="button" name="Editar9" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa9" runat="server" name="Etapa9" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="10" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/505.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id10" name="id10" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo10" name="Titulo0" runat="server"></h2>
                            <p id="des10" name="des10" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio10" name="fechaInicio10" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal10" name="fechaFinal10" />
                                </div>
                                <button id="Editar10" type="button" name="Editar10" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa10" runat="server" name="Etapa10" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="11" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/509.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id11" name="id11" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo11" name="Titulo11" runat="server"></h2>
                            <p id="des11" name="des11" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio11" name="fechaInicio11" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal11" name="fechaFinal11" />
                                </div>
                                <button id="Editar11" type="button" name="Editar11" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa11" runat="server" name="Etapa11" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="12" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/601.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id12" name="id12" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo12" name="Titulo12" runat="server"></h2>
                            <p id="des12" name="des12" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio12" name="fechaInicio12" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal12" name="fechaFinal12" />
                                </div>
                                <button id="Editar12" type="button" name="Editar12" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa12" runat="server" name="Etapa12" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="13" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/602.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id13" name="id13" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo13" name="Titulo13" runat="server"></h2>
                            <p id="des13" name="des13" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio13" name="fechaInicio13" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal13" name="fechaFinal13" />
                                </div>
                                <button id="Editar13" type="button" name="Editar13" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa13" runat="server" name="Etapa13" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="14" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/603.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id14" name="id14" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo14" name="Titulo14" runat="server"></h2>
                            <p id="des14" name="des14" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio14" name="fechaInicio14" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal14" name="fechaFinal14" />
                                </div>
                                <button id="Editar14" type="button" name="Editar14" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa14" runat="server" name="Etapa14" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="15" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/607.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id15" name="id15" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo15" name="Titulo15" runat="server"></h2>
                            <p id="des15" name="des15" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio15" name="fechaInicio15" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal15" name="fechaFinal15" />
                                </div>
                                <button id="Editar15" type="button" name="Editar15" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa15" runat="server" name="Etapa15" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="16" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/609.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id16" name="id16" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo16" name="Titulo16" runat="server"></h2>
                            <p id="des16" name="des16" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio16" name="fechaInicio16" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal16" name="fechaFinal16" />
                                </div>
                                <button id="Editar16" type="button" name="Editar16" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa16" runat="server" name="Etapa16" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="17" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/700.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id17" name="id17" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo17" name="Titulo17" runat="server"></h2>
                            <p id="des17" name="des17" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio17" name="fechaInicio17" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal17" name="fechaFinal17" />
                                </div>
                                <button id="Editar17" type="button" name="Editar17" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa17" runat="server" name="Etapa17" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="18" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/703.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id18" name="id18" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo18" name="Titulo18" runat="server"></h2>
                            <p id="des18" name="des18" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio18" name="fechaInicio18" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal18" name="fechaFinal18" />
                                </div>
                                <button id="Editar18" type="button" name="Editar18" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa18" runat="server" name="Etapa18" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="19" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/708.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id19" name="id19" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo19" name="Titulo19" runat="server"></h2>
                            <p id="des19" name="des19" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio19" name="fechaInicio19" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal19" name="fechaFinal19" />
                                </div>
                                <button id="Editar19" type="button" name="Editar19" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa19" runat="server" name="Etapa19" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="20" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/709.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id20" name="id20" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo20" name="Titulo20" runat="server"></h2>
                            <p id="des20" name="des20" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio20" name="fechaInicio20" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal20" name="fechaFinal20" />
                                </div>
                                <button id="Editar20" type="button" name="Editar20" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa20" runat="server" name="Etapa20" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="21" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/800.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id21" name="id21" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo21" name="Titulo21" runat="server"></h2>
                            <p id="des21" name="des21" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio21" name="fechaInicio21" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal21" name="fechaFinal21" />
                                </div>
                                <button id="Editar21" type="button" name="Editar21" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa21" runat="server" name="Etapa21" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="22" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/805.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id22" name="id22" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo22" name="Titulo22" runat="server"></h2>
                            <p id="des22" name="des22" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio22" name="fechaInicio22" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal22" name="fechaFinal22" />
                                </div>
                                <button id="Editar22" type="button" name="Editar22" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa22" runat="server" name="Etapa22" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="23" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/807.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id23" name="id23" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo23" name="Titulo23" runat="server"></h2>
                            <p id="des23" name="des23" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio23" name="fechaInicio23" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal23" name="fechaFinal23" />
                                </div>
                                <button id="Editar23" type="button" name="Editar23" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa23" runat="server" name="Etapa23" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="24" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/809.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id24" name="id24" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo24" name="Titulo24" runat="server"></h2>
                            <p id="des24" name="des24" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio24" name="fechaInicio24" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal24" name="fechaFinal24" />
                                </div>
                                <button id="Editar24" type="button" name="Editar24" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa24" runat="server" name="Etapa24" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="25" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                        <img class="card-img-top" src="../../images/FENOLOGIA/Caracteristicas.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id25" name="id25" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo25" name="Titulo25" runat="server"></h2>
                            <p id="des25" name="des25" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio25" name="fechaInicio25" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal25" name="fechaFinal25" />
                                </div>
                                <button id="Editar25" type="button" name="Editar25" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa25" runat="server" name="Etapa22" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
            <div id="26" class="card">
                <div class="row form-group">
                    <div class="col-1 col-lg-4 col-md-4">
                       <img class="card-img-top" src="../../images/FENOLOGIA/Caracteristicas.jpg" height="90">
                    </div>
                    <div class="col-4 col-md-8">
                        <div class="card-body">
                            <h5 id="id26" name="id26" runat="server" placeholder="Id"></h5>
                            <h2 id="Titulo26" name="Titulo26" runat="server"></h2>
                            <p id="des26" name="des26" runat="server"></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio26" name="fechaInicio26" />
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal26" name="fechaFinal26" />
                                </div>
                                <button id="Editar26" type="button" name="Editar26" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i>Editar</button>
                            </div>
                            <input id="Etapa26" runat="server" name="Etapa26" placeholder="Etapa" />
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
