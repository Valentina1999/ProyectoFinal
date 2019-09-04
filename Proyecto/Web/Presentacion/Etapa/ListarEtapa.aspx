<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListarEtapa.aspx.cs" Inherits="Web.Presentacion.Master.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        #ico{
            float:left;
        }

        #cont{
            align:"center";
        }
    </style>

    <div class="col-lg-8" id="cont">
        <div>
            <h3><strong>Lista de Etapas</strong></h3>
            <br/>
        </div>
        <div class="table-responsive table--no-card m-b-30">
            <table class="table table-borderless table-striped table-earning">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Ver</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Prueba</td>
                        <td >
                            <div class="table-data-feature" id="ico">
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
