<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListarEtapa.aspx.cs" Inherits="Web.Presentacion.Master.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <div>
            <h3><strong>Lista de Etapas</strong></h3>
            <br/>
        </div>
        <div class="table-responsive table--no-card m-b-30">
            <table class="table table-borderless table-striped table-earning">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Descripcion</th>
                        <th>Foto</th>
                        <th>Duracion</th>
                        <th>Opciones</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Prueba</td>
                        <td>Prueba</td>
                        <td>foto.jpg</td>
                        <td>4 meses</td>
                        <td>
                            <div class="table-data-feature">
                                <button class="item" data-toggle="tooltip" data-placement="top" title="Seleccionar">
                                    <i class="fa fa-hand-o-up">
                                    </i>
                                </button>
                                <a class="item" data-toggle="tooltip" href="VerEtapa.aspx" data-placement="top" title="Ver">
                                    <i class="fa fa-eye">
                                    </i>
                                </a>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
