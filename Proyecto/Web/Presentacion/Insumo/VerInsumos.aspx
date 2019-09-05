<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="VerInsumos.aspx.cs" Inherits="Web.Presentacion.Insumo.VerInsumos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col col-12">
        <form action="" method="post" class="form-control" runat="server">
            <div class="row form-group">
                <div class="col col-9">
                    <h3><strong>INSUMOS</strong></h3>
                    <br />
                </div>
                <div>
                    <button id="btnNuevo" class="btn btn-success">Nuevo Insumo</button>
                </div>
            </div>
            <div class="table-responsive table--no-card m-b-30">
                <table class="table table-borderless table-striped table-earning">
                    <thead>
                        <tr>
                            <th hidden="hidden">Id</th>
                            <th>Nombre</th>
                            <th>Foto</th>
                            <th>Descripción</th>
                            <th>Tipo</th>
                            <th>Editar</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td hidden="hidden"><label id="idInsumo" runat="server"></label></td>
                            <td><label id="Nombre" runat="server"></label></td>
                            <td><label id="Foto" runat="server"></label></td>
                            <td><label id="Descripcion" runat="server"></label></td>
                            <td><label id="TipoInsu" runat="server"></label></td>
                            <td align="center" id="Editar" runat="server">
                                <div>
                                    <button type="button" id="btnEditar" name="btnEditar" runat="server" class="btn btn-secondary btn-sm"> 
                                        <i class="fa fa-pencil-square-o"></i>
                                    </button>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </form>
    </div>
</asp:Content>
