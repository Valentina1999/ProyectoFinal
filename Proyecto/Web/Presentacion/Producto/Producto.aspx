<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Web.Presentacion.Producto.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <div class="card">
            <div class="card-header">
                <strong>Productos</strong>
            </div>
            <div class="card-body card-block">
                <form action="Producto.aspx" method="post" runat="server">
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Nombre del producto</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="text" id="txtNombreP" name="txtNombreP" class="form-control" required="required" runat="server">
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Cantidad</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="text" id="txtCantidad" name="txtCantidad" placeholder="" class="form-control" required="required" runat="server">
                        </div>
                    <div class="card-footer">
                        <button type="button" id="Editar" class="btn btn-primary btn-sm" onserverclick="btnEditar" runat="server">
                            <i class="fa fa-dot-circle-o"></i>Editar
                        </button>
                        <button type="reset" id="btnCancelar" name="btnCancelar" class="btn btn-danger btn-sm">
                            <i class="fa fa-ban"></i>Cancelar
                        </button>
                    </div>
                </form>
          </div>
        </div>
    </div>

</asp:Content>
