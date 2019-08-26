<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="VerEtapa.aspx.cs" Inherits="Web.Presentacion.Master.Formulario_web14" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card">
                <div class="card-header">
                    <strong>Etapa de Cultivo</strong>
                </div>
                <div class="card-body card-block">
                    <form  method="post" enctype="multipart/form-data" class="form-horizontal">
                        <div class="row form-group">
                            <div class="col col-md-3">
                                <label for="text-input" class=" form-control-label">Nombre</label>
                            </div>
                            <div class="col-12 col-md-9">
                                <input type="text" id="NombreEtapa" name="NombreEtapa" class="form-control" readonly>
                            </div>
                        </div>
                        <div class="row form-group">
                            <div class="col col-md-3">
                                <label for="textarea-input" class=" form-control-label">Descripcion</label>
                            </div>
                            <div class="col-12 col-md-9">
                                <textarea name="descripcion" id="descripcion" rows="5" class="form-control" readonly></textarea>
                            </div>
                        </div>
                        <div class="row form-group">
                            <div class="col col-md-3">
                                <label for="file-input" class=" form-control-label">Foto</label>
                            </div>
                            <div class="col-md-4">
                                <div class="card">
                                    <img class="card-img-top" src="../../images/bg-title-01.jpg" alt="Card image cap">
                                </div>
                            </div>
                        </div>
                        <div class="row form-group">
                            <div class="col col-md-3">
                                <label for="text-input" class=" form-control-label">Duracion</label>
                            </div>
                            <div class="col-12 col-md-9">
                                <input type="text" id="duracion" name="duracion" class="form-control" readonly>
                            </div>
                        </div>
                        <div class="row form-group">
                            <div class="col-12 col-md-9">
                                <input type="text" id="IdCultivo" name="IdCultivo" class="form-control" hidden>
                            </div>
                        </div>
                        <a href="ListarEtapa.aspx" class="btn btn-primary">
                            <i class="fa fa-reply"></i> Atras
                        </a>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
