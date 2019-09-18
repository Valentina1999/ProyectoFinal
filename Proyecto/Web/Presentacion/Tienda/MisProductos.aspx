<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="MisProductos.aspx.cs" Inherits="Web.Presentacion.Tienda.MisProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <h2>Mis Productos</h2>
    </div>
    <form action="MisProductos.aspx" method="post" runat="server">
        <asp:DataList ID="prod" runat="server" RepeatDirection="Horizontal" RepeatColumns="3" OnItemCommand="prod_ItemCommand" OnItemDataBound="prod_ItemDataBound">
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
                            <div>
                                <asp:Button ID="btnNose" CommandName="Click"  Text="Agotado" class="btn btn-danger btn-sm" runat="server" CommandArgument='<%# Eval("IdProducto") %>' />
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
