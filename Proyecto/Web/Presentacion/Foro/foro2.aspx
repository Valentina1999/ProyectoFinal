<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="foro2.aspx.cs" Inherits="Web.Presentacion.Master.Formulario_web141" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <div class="card">
            <div class="card-header">
                <strong>Foro</strong>
            </div>
        </div>
        <div class="card-body card-block">
            <div class="fb-comments" data-href="http://localhost:50900/Presentacion/Foro/foro2.aspx" data-width="100%" data-numposts="1"></div>
        </div>
    </div>

</asp:Content>
