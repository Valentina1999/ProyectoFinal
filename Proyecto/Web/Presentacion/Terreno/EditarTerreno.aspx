<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="EditarTerreno.aspx.cs" Inherits="Web.Presentacion.Terreno.EditarTerreno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-12">
        <div class="card">
            <div class="card-header">
                <strong>EDITAR TERRENO</strong>
            </div>
            <div class="card-body card-block">
                <form action="EditarTerreno.aspx" method="post" runat="server">

                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Nombre Terreno</label>
                        </div>
                        <div class="col-12 col-md-4">

                            <input type="text" id="txtNombreTerreno" name="txtNombreTerreno" class="form-control" required="required" runat="server">
                        </div>

                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Seleccione el Terreno a Editar</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <asp:DropDownList ID="TipoTerreno" runat="server" class="au-input au-input--full" AutoPostBack="true" OnSelectedIndexChanged="TipoTerreno_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>



                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Largo</label>
                        </div>
                        <div class="col-12 col-md-4">

                            <input type="number" id="txtLargo" name="txtLargo" class="form-control" required="required" runat="server">
                        </div>

                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Ancho</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="txtAncho" name="txtAncho" class="form-control" required="required" runat="server">
                        </div>
                    </div>

                    <div class="row form-group">
                        <div class="col col-md-6">
                            <label for="text-input" class=" form-control-label">Palmas a cultivar en funcion al tamaño del terreno:</label>
                        </div>
                        <div class="col-4 col-md-1">
                            <asp:Label ID="Label1" runat="server" Text="---"></asp:Label>
                        </div>
                    </div>


                    <div class="card-footer">
                        <button type="button" id="Editar" class="btn btn-primary btn-sm" onserverclick="btnEditarT" runat="server">
                            <i class="fa fa-dot-circle-o"></i>Editar
                        </button>
                        <button type="reset" id="btnCancelar" name="btnCancelar" class="btn btn-danger btn-sm">
                            <i class="fa fa-ban"></i>Cancelar
                        </button>
                        <button id="calcular" onserverclick="BtnCalculo_Click" runat="server" type="button" class="btn btn-primary btn-sm">
                            <i class="fa fa-calculator"></i>Calcular
                        </button>
                    </div>
                </form>
                <div id="alert" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-success alert-dismissible fade show">
                        <span class="badge badge-pill badge-success">Corrrecto</span>
                        Su terreno ha sido Editado correctamente.
						<button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                </div>
                <div id="danger" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-danger alert-dismissible fade show">
                        <span class="badge badge-pill badge-danger">Error</span>
                        No se pudo Editar los datos de su terreno. Vuelve a intentar.
						    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                    </div>
                </div>
                <div id="alerta" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-primary alert-dismissible fade show">
                        <span class="badge badge-pill badge-primary">Atención</span>
                            No se pudo realizar el calculo. Por favor intentelo de nuevo
					    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
