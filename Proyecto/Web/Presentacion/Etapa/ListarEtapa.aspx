<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="ListarEtapa.aspx.cs" Inherits="Web.Presentacion.Master.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

    <style>
        #ico{
            float:left;
        }

        #cont{
            align:"center";
        }
        .auto-style1 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -ms-flex: 0 0 66.666667%;
            flex: 0 0 66.666667%;
            max-width: 66.666667%;
            left: 0px;
            top: 0px;
            height: 180px;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style2 {
            width: 637px;
            height: 26px;
        }
        .auto-style3 {
            position: absolute;
            left: 122px;
            top: 69px;
        }
    </style>

    <div class="auto-style1" id="cont">
        <div class="auto-style2">
            <h3><strong>Lista de Etapas</strong></h3>
            <asp:DetailsView ID="dvListarEtapas" runat="server" CssClass="auto-style3" Height="93px" Width="248px">
            </asp:DetailsView>
            <br/>
        </div>
    </div>
    </form>
</asp:Content>
