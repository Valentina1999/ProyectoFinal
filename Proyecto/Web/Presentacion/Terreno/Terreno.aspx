<%@ Page Title="Terreno" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Terreno.aspx.cs" Inherits="Web.Formulario_web11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <div class="card">
            <div class="card-header">
                <strong>Terreno</strong>
            </div>
            <div class="card-body card-block">
                <form action="Terreno.aspx" method="post" runat="server">
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Nombre</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="text" id="NombreTerreno" name="NombreTerreno" class="form-control" required>
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Largo</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="text" id="Largo" name="Largo" class="form-control" required>
                        </div>
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Ancho</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="text" id="Ancho" name="Ancho" class="form-control" required>
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col col-md-6">
                            <label for="text-input" class=" form-control-label">Palmas a cultivar en funcion al tamaño del terreno:</label>
                        </div>
                        <div class="col-4 col-md-1">
                            <asp:Label ID="Label1" runat="server" Text="---"></asp:Label>
                        </div>
                        <div class="col-5 col-md-1">
                            <input type="text" id="IdUsuario" name="IdUsuario" class="form-control" hidden />
                        </div>
                    </div>
                    <div class="card-footer">
                        <button id="guardarT" onserverclick="btnRegistrarTerreno" runat="server" type="submit" class="btn btn-success btn-sm">
                            <i class="fa fa-check"></i>Guardar
                        </button>
                        <button id="editarT" name="editarT" type="button" class="btn btn-secondary btn-sm">
                            <i class="fa fa-pencil-square-o"></i>Editar
                        </button>
                        <button id="calcular" onserverclick="BtnCalculo_Click" runat="server" type="button" class="btn btn-primary btn-sm">
                            <i class="fa fa-calculator"></i>Calcular
                        </button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
