<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Insumos.aspx.cs" Inherits="Web.Presentacion.Insumos.Insumos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-lg-12">
    <div class="card">
        <div class="card-header">
            <strong>INSUMOS</strong>
        </div>
        <div class="card-body card-block">
            <form action="Insumos.aspx" method="post" runat="server">
                <div class="row form-group">
                    <div class="col col-md-2">
                        <label for="text-input" class="form-control-label">Nombre</label>
                    </div>
                    <div class="col-12 col-md-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col col-md-1">
                        <label for="text-input" class="form-control-label">Foto</label>
                    </div>
                    <div class="col-12 col-md-4">
                        <asp:FileUpload ID="FileImage" runat="server" accept=".jpg,.pnj" CssClass="form-control-file"/>
                    </div>
                </div>

                <div class="row form-group">
                    <div class="col col-md-2">
                        <label for="text-input" class="form-control-label">Descripcion</label>
                    </div>
                    <div class="col-12 col-md-4">
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="col col-md-1">
                        <label for="text-input" class="form-control-label">Tipo</label>
                    </div>
                    <div class="col-12 col-md-4">
                        <asp:DropDownList ID="ddlTipoInsumo" class="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>

                <div class="row form-group">
                    <div class="col col-md-2">
                        <button type="button" id="btnRegistrar" name="btnRegistrar" class="btn btn-success btn-sm" runat="server" onserverclick="BtnGuardar">
                            <i class="fa fa-check-square"> Registrar</i>
                        </button>
                    </div>
                    <div class="col col-md-1">
                        <button type="button" id="btnEditar" name="btnEditar" class="btn btn-primary btn-sm" runat="server">
                            <i class="fa fa-pencil-square"> Editar</i>
                        </button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
</asp:Content>
