<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListaFases.aspx.cs" Inherits="Web.Presentacion.Fases.ListaFases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <asp:Repeater ID="repeater" runat="server">
            <ItemTemplate>
                <div class="card">
                    <div class="row form-group">
                        <div class="col-1 col-md-4">
                            <img class="card-img-top" src="../../images/bg-title-01.jpg">
                        </div>
                        <div class="col-4 col-md-8">
                        <div class="card-body">
                            <input id="id" name="id" hidden="hidden" value='<%#Eval("IdFase")%>' />
                            <h4><%#Eval("Nombre") %></h4>
                            <p class="card-text"><%#Eval("Descripcion") %></p>
                            <div class="row form-group">
                                <div class="col-4 col-md-4">
                                    <input class="form-control" type="date" id="fechaInicio"/>
                                </div>
                                <div class="col-8 col-md-4">
                                    <input class="form-control" type="date" id="fechaFinal"/>
                                </div>
                                <button id="Editar" type="button" name="Editar" class="btn btn-primary btn-sm">
                                    <i class="fa fa-check-square"></i> Editar</button>
                            </div>
                        </div>
                       </div>
                    </div>
                </div>
         </ItemTemplate>
      </asp:Repeater>
    </div>
    <%--<img id="img" src="../../images/FENOLOGIA/<%=nombre%>" alt=""/>--%>
</asp:Content>
