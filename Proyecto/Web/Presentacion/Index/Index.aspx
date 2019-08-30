<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Master/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="col-lg-12">
        <div class="card">
        <div class="card-body card-block">
            <form action="Index.aspx" method="post" runat="server">
                <div class="row form-group">
                    <div class="col col-md-1">
                        <label for="text-input" class=" form-control-label">Fecha</label>
                    </div>
                   <div class="col-4 col-md-1">
                        <asp:Label ID="Label1" runat="server" Text="---"></asp:Label>
                    </div>
                </div>
            </form>
        </div>
    </div>
    </div>

</asp:Content>
