<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Tienda.aspx.cs" Inherits="Web.Presentacion.Tienda.Tienda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
            <h2>TIENDA</h2>
        </div>
    <form action="/" method="post" runat="server">    
        <asp:DataList ID="pr" runat="server" RepeatDirection="Horizontal" RepeatColumns="3">
            <ItemTemplate>
                <div class="col col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <div>
                                <img src="../../images/<%#Eval("Foto") %>" />
                            </div>
                        </div>
                        <div class="card-body">
                            <div>
                                <label>Nombre: </label>
                                <label><%#Eval("NombreP") %></label>
                            </div>
                            <div>
                                <label>Cantidad: </label>
                                <label><%#Eval("Cantidad") %> ton</label>
                            </div>
                            <div>
                                <label>Cultivador: </label>
                                <label><%#Eval ("Nombre") %> <%#Eval ("Apellido") %></label>
                                <br />
                                <label>Contacto: </label>
                                <label><%#Eval ("Numero") %></label>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
