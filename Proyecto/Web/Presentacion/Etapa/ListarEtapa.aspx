<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListarEtapa.aspx.cs"  EnableEventValidation="false" Inherits="Web.Presentacion.Master.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        #ico{
            float:left;
        }

        #cont{
            align="center";
        }
    </style>
        <form action="ListarEtapa.aspx" method="post" runat="server">
    <div class="col-lg-8" id="cont">
        <div>
            <h3><strong>Lista de Etapas</strong></h3>
            <br/>
        </div>
        <div class="table-responsive table--no-card m-b-30">
            <table class="table table-borderless table-striped table-earning">
               
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Ver</th>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server"   
                   OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="Repeater1_ItemDataBound">
                <ItemTemplate>
                   
                <tbody>
                    <tr>
                        <td class="property-title"   >
                     <asp:Label ID="Etapa" Text='<%# Eval("Etapa") %>' runat="server"/>
                                </td>
                        
                        <td >
                            <div class="table-data-feature" id="ico">
                            
            <asp:Button ID="btn" CommandName="Click" Text="ver" runat="server"
                        CommandArgument='<%# Eval("IdEtapa") %>' />
                        </button>               
                                    </i>
                                </a>
                            </div>
                        </td>
                    </tr>
                </tbody>
                </ItemTemplate>
                    </asp:Repeater>
            </table>
        </div>
    </div>
     </form>
</asp:Content>
