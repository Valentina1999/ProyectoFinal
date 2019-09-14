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
                   <div runat="server"> 
                <a href="https://drive.google.com/file/d/1Blku3GYRegTGSP42YHAcSFnLPHHicBYY/view?usp=sharing" class="alert-link">Como aumentar o disminuir los valores? has click aqui</a>
            </div>
                    
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Acidez y Alcanidad</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="AcidezAl" name="AcidezAl"  class="form-control" step="Any" required>
                        </div>
                         <div class="col-18 col-md-4">
                         <asp:TextBox ID="RAcidezAl" runat="server" CssClass="form-control" Visible="false" ReadOnly="true"></asp:TextBox>                      
                    </div>
                    </div>

                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Aluminio</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Aluminio" name="Aluminio" step="Any" class="form-control" required>
                        </div>
                        <div class="col-18 col-md-4">
                        <asp:TextBox ID="RAluminio" runat="server" CssClass="form-control" Visible="False" ReadOnly="True" ValidationGroup="N2"></asp:TextBox>
                            <%-- <asp:RequiredFieldValidator ID="Val2" runat="server" ErrorMessage="Valor Numerico Requerido" ControlToValidate="RAluminio" CssClass="mensajeError" ValidationGroup="N2"></asp:RequiredFieldValidator>--%>
                       
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Nitrogeno</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Nitrogeno" name="Nitrogeno" step="Any" class="form-control" required>
                        </div>
                             <div class="col-18 col-md-4">
                             <asp:TextBox ID="RNitrogeno" runat="server" CssClass="form-control" Visible="False" ReadOnly="True" ValidationGroup="N3"></asp:TextBox>
                                 <%--<asp:RequiredFieldValidator ID="Val3" runat="server" ErrorMessage="Valor Numerico Requerido" ControlToValidate="RNitrogeno" CssClass="mensajeError" ValidationGroup="N3"></asp:RequiredFieldValidator>--%>
                       
                    </div>
                    </div>
                    
                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Potasio</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Potasio" name="Potasio" placeholder="" step="Any" class="form-control" required>
                        </div>
                        <div class="col-18 col-md-4">
                        <asp:TextBox ID="RPotasion" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                        
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Fosforo</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Fosforo" name="Fosforo" placeholder="" step="Any" class="form-control" required>
                        </div>
                             <div class="col-18 col-md-4">
                        <asp:TextBox ID="RFosforo" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                        
                    </div>
                    </div>
                    
                    <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Calcio</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Calcio" name="Calcio" placeholder="" step="Any" class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <asp:TextBox ID="RCalcio" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                        
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Magnesio</label>
                        </div>
                         <div class="col-20 col-md-4">
                            <input type="number" id="Magnesio" name="Magnesio" placeholder="" step="Any" class="form-control" required>
                        </div>
                              <div class="col-18 col-md-4">
                        <asp:TextBox ID="RMagnesion" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                        
                    </div>
                         </div>


                    <div class="row form-group">
                        <div class="col col-md-1">
                            <label for="text-input" class=" form-control-label">Azufre</label>
                        </div>
                        <div class="col-12 col-md-4">
                            <input type="number" id="Azufre" name="Azufre" placeholder="" step="Any" class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <asp:TextBox ID="RAzufre" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                       
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Cobre</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Cobre" name="Cobre" placeholder="" step="Any" class="form-control" required>
                        </div>
                              <div class="col-18 col-md-4">
                        <asp:TextBox ID="RCobre" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                       
                    </div>
                    </div>
                    
                    <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Cinc</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Cinc" name="Cinc" placeholder="" step="Any" class="form-control" required>
                        </div>
                         <div class="col-18 col-md-4">
                        <asp:TextBox ID="RCinc" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                        
                    </div>
                        </div>

                         <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Manganeso</label>
                        </div>
                         <div class="col-20 col-md-4">
                            <input type="number" id="Manganeso" name="Manganeso" placeholder="" step="Any" class="form-control" required>
                        </div>
                              <div class="col-18 col-md-4">
                        <asp:TextBox ID="RManganeso" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                        
                    </div>
                        </div>
                        <div class="row form-group">
                        <div class="col-13 col-md-1">
                            <label for="text-input" class=" form-control-label">Boro</label>
                        </div>
                        <div class="col-20 col-md-4">
                            <input type="number" id="Boro" name="Boro" placeholder="" step="Any" class="form-control" required>
                        </div>
                                <div class="col-18 col-md-4">
                        <asp:TextBox ID="RBoro" runat="server" CssClass="form-control" Visible="False" ReadOnly="True"></asp:TextBox>
                       
                    </div>
                        </div>
                              <div class=" row form-group">
                                    <div class="col-13 col-md-1">
                                      <label for="text-input" class=" form-control-label">Terreno</label>
                                  </div>
                                  <div class="col-20 col-md-4">
                                      <asp:DropDownList class="au-input au-input--full" ID="Terreno" runat="server" Height="40px" Width="300px">
                                      </asp:DropDownList>
                                  </div>
                                </div>

                             <div class="row form-group">
                                    <div class="col-13 col-md-1">
                                     <label for="text-input" class=" form-control-label">Suelo</label>
                                 </div>
                                 <div class="col-20 col-md-4">
                                     <asp:DropDownList class="au-input au-input--full" ID="TipoSuelo" runat="server" Height="40px" Width="300px">
                                     </asp:DropDownList>
                                 </div>
                                </div>

                        <div class="row form-group">
                        <div class="col-18 col-md-4">
                        <input type="text" id="IdTerreno" name="IdTerreno" class="form-control" hidden/>
                    </div>
                   

                    <div class="card-footer">
                <button type="button" id="btnRegistrar" name="btnRegistrar" class="btn btn-primary btn-sm" runat="server" onserverclick="btnRegistrarSuelos">
                    <i class="fa fa-dot-circle-o"></i> Registrar
                </button>

                        
                <button type="button" id="btnRendir" name="btnRendir" class="btn btn-danger btn-sm" runat="server" onserverclick="btnRedir_Click">
                    <i class="fa fa-dot-circle-o"></i>Rangos
                </button>

            </div>
                    <div id="alert" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-success alert-dismissible fade show">
                        <span class="badge badge-pill badge-success">Corrrecto</span>
                        Su terreno ha sido registrado correctamente.
						<button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                </div>
                <div id="danger" runat="server" visible="false">
                    <div class="sufee-alert alert with-close alert-danger alert-dismissible fade show">
                        <span class="badge badge-pill badge-danger">Error</span>
                        No se pudo registrar su terreno. Vuelve a intentar.
						    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                    </div>
                </div>
                
                </form>
            </div>
        </div>
</asp:Content>
