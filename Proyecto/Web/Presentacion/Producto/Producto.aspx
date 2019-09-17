<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Web.Presentacion.Producto.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-12">
    <div class="card">
        <div class="card-header">
            <strong>PRODUCTOS</strong>
        </div>
        <div class="card-body card-block">
            <form action="Producto.aspx" method="post" runat="server">

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
                        <label for="text-input" class="form-control-label">Cantidad</label>
                    </div>
                    <div class="col-12 col-md-4">
                        <input id="txtC" type="number" name="txtC" runat="server" class="form-control"/>
                    </div>

                </div>

                <div class="row form-group">
                    <div class="col col-md-2">
                        <button type="button" id="btnRegistrar" name="btnRegistrar" class="btn btn-success btn-sm" runat="server" onserverclick="btnRegistrar_ServerClick">
                            <i class="fa fa-check-square"> Registrar</i>
                        </button>
                    </div>
                    
                </div>
            </form>
        </div>
    </div>
</div>
</asp:Content>
