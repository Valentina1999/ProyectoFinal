<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="EstudioSuelos.aspx.cs" Inherits="Web.Presentacion.Suelos.EstudioSuelos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <div class="card">
            <div class="card-header">
                <strong>ESTUDIO DE SUELOS</strong> 
            </div>
            <div class="card-body card-block">
                <form action="" method="post" enctype="multipart/form-data" class="form-horizontal" runat="server">
                   
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Acidez y Alcanidad</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="AcidezAl" name="AcidezAl"  class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <input type="text" id="RAcidezAl" name="RAcidezAl" class="form-control" hidden/>
                    </div>
                    </div>

                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Aluminio</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Aluminio" name="Aluminio" class="form-control" required>
                        </div>
                        <div class="col-18 col-md-4">
                        <input type="text" id="RAluminio" name="RAluminio" class="form-control" hidden/>
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Nitrogeno</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Nitrogeno" name="Nitrogeno" placeholder="" class="form-control" required>
                        </div>
                             <div class="col-18 col-md-4">
                        <input type="text" id="RNitrogeno" name="RNitrogeno" class="form-control" hidden/>
                    </div>
                    </div>
                    
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Potasio</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Potasio" name="Potasio" placeholder="" class="form-control" required>
                        </div>
                        <div class="col-18 col-md-4">
                        <input type="text" id="RPotasion" name="RPotasion" class="form-control" hidden/>
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Fosforo</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Fosforo" name="Fosforo" placeholder="" class="form-control" required>
                        </div>
                             <div class="col-18 col-md-4">
                        <input type="text" id="RFosforo" name="RFosforo" class="form-control" hidden/>
                    </div>
                    </div>
                    
                    <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Calcio</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Calcio" name="Calcio" placeholder="" class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <input type="text" id="RCalcio" name="RCalcio" class="form-control" hidden/>
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Magnesio</label>
                        </div>
                         <div class="col-20 col-md-4">
                            <input type="number" id="Magnesio" name="Magnesio" placeholder="" class="form-control" required>
                        </div>
                              <div class="col-18 col-md-4">
                        <input type="text" id="RMagnesion" name="RMagnesio" class="form-control" hidden/>
                    </div>
                         </div>


                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Azufre</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Azufre" name="Azufre" placeholder="" class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <input type="text" id="RAzufre" name="RAzufre" class="form-control" hidden/>
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Cobre</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Cobre" name="Cobre" placeholder="" class="form-control" required>
                        </div>
                              <div class="col-18 col-md-4">
                        <input type="text" id="RCobre" name="RCobre" class="form-control" hidden/>
                    </div>
                    </div>
                    
                    <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Cinc</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Cinc" name="Cinc" placeholder="" class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <input type="text" id="RCinc" name="RCinc" class="form-control" hidden/>
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Manganeso</label>
                        </div>
                         <div class="col-20 col-md-4">
                            <input type="number" id="Manganeso" name="Manganeso" placeholder="" class="form-control" required>
                        </div>
                              <div class="col-18 col-md-4">
                        <input type="text" id="RManganeso" name="RManganeso" class="form-control" hidden/>
                    </div>
                        </div>
                        <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Boro</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Boro" name="Boro" placeholder="" class="form-control" required>
                        </div>
                                <div class="col-18 col-md-4">
                        <input type="text" id="RBoro" name="RBoro" class="form-control" hidden/>
                    </div>
                        </div>
                              <div class="form-group">
                                    <asp:DropDownList class="au-input au-input--full" ID="Terreno" Font-Names="Terreno" runat="server" Height="40px" Width="300px">
                                    </asp:DropDownList>
                                </div>
                             <div class="form-group">
                                    <asp:DropDownList class="au-input au-input--full" ID="TipoSuelo" Font-Names="TipoSuelo" runat="server" Height="40px" Width="300px">
                                    </asp:DropDownList>
                                </div>

                        <div class="row form-group">
                        <div class="col-18 col-md-4">
                        <input type="text" id="IdTerreno" name="IdTerreno" class="form-control" hidden/>
                    </div>
                        <div class="col-18 col-md-4">
                        <input type="text" id="IdCultivo" name="IdCultivo" class="form-control" hidden/>
                    </div>


                    <div class="card-footer">
                <button type="submit" id="btnRegistrar" name="btnRegistrar" class="btn btn-primary btn-sm" runat="server" onserverclick="btnRegistrarSuelos">
                    <i class="fa fa-dot-circle-o"></i> Registrar
                </button>
                <button type="reset" id="btnCalcular" name="btnCalcular" class="btn btn-danger btn-sm">
                    <i class="fa fa-ban"></i> Calcular
                </button>
            </div>
                </form>
            </div>
        </div>
</asp:Content>
