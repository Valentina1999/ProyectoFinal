<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Interno.aspx.cs" Inherits="Web.Presentacion.Interno.Interno" %>
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
        <form action="Interno.aspx" method="post" runat="server">
            
    <div class="col-lg-12" id="cont">
        <div>
            <h3><strong>Procesos</strong></h3>
            <br/>
        </div>
        <div class="table-responsive table--no-card m-b-30">
            <table class="table table-borderless table-striped table-earning">
               
                <thead>
                    <tr>
                        <th>Etapa</th>
                        <th>Fase</th>
                        <th>Dias</th>
                        <th>¿Realizado?</th>
                        <th>Guardar</th>
                        
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server"
                     OnItemCommand="Repeater1_ItemCommand" OnItemDataBound="Repeater1_ItemDataBound">
                <ItemTemplate>
                   
                <tbody>
                    <tr>
                        <td class="property-title"   >
                     <asp:Label ID="Etapa" Text='<%# Eval("IdEtapa") %>' runat="server"/>
                               
                        
                         <th >
                             <asp:Label ID="Label2" Text='<%# Eval("Fase") %>' runat="server"/>

                              </th>
                        
                            
                               
                        
                         <th >
                             <asp:Label ID="Label1" Text='<%# Eval("Dias") %>' runat="server"/>

                              </th>

                         <th >
                             <asp:CheckBox ID="check"  Text='<%# Eval("chec") %>' runat="server"/>

                              </th>
                        <th >
                             <asp:Button type="Button"  ID="btn" CommandName="Click"  CommandArgument='<%# Eval("IdInterno") %>' Text="Guardar" class="btn btn-success btn-sm" runat="server"/>

                              </th>
                            
                            </div>
                        </td>
                    </tr>
                </tbody>
                </ItemTemplate>
                    </asp:Repeater>
            </table>
        </div>
    </div>
            <div class="table-data-feature" id="ico">
                            
            <asp:Button ID="fases" Text="Devolver" OnClick="fases_Click" class="btn btn-success btn-sm" runat="server"> </asp:Button>
          </div>
     </form>

</asp:Content>
