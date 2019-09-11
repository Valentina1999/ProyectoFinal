<%@ Page Title="Editar Usuario" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="Web.Presentacion.Master.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <div class="card">
            <div class="card-header">
                <strong>EDITAR USUARIO</strong>
            </div>
            <div class="card-body card-block">
                <div id="alert" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-success alert-dismissible fade show">
                        <span class="badge badge-pill badge-success">Corrrecto</span>
                        Su Datos han sido registrado correctamente.
						<button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                </div>
                
                <div id="danger" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-danger alert-dismissible fade show">
                        <span class="badge badge-pill badge-danger">Error</span>
                        No se pudo Editar sus Datos. Vuelve a intentar.
						    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                    </div>
                </div>

                <form action="EditarUsuario.aspx" method="post" runat="server">
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Documento</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="txtDocumento" name="txtDocumento" class="form-control" required="required" runat="server">
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Nombre</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="text" id="txtNombre" name="txtNombre" placeholder="" class="form-control" required="required" runat="server">
                        </div>
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Apellido</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="text" id="txtApellido" name="txtApellido" placeholder="" class="form-control" required="required" runat="server">
                        </div>
                    </div>

                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="email-input" class=" form-control-label">Correo</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="email" id="txtCorreo" name="txtCorreo" placeholder="" class="form-control" required="required" runat="server">
                        </div>
                        <div class="col-13 col-md-1">
                            <label for="password-input" class=" form-control-label">Contraseña</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="password" id="txtClave" name="txtClave" placeholder="" class="form-control" required runat="server">
                        </div>
                    </div>

                    <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Telefono</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="txtTelefono" name="txtTelefono" class="form-control" required="required" runat="server">
                        </div>
                        <div class="col-13 col-md-1">
                            <label for="select" class=" form-control-label">Rol</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="text" id="txtRol" name="txtRol" class="form-control" runat="server" readonly="readonly">
                        </div>
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
