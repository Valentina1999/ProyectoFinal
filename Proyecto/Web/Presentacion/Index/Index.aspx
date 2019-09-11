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
                        <label for="text-input" hidden class=" form-control-label">Fecha</label>
                    </div>
                   <div class="col-4 col-md-1">
                        <asp:Label ID="lblFecha" Visible="false" runat="server" Text="---"></asp:Label>
                    </div>
                </div>
                <div class="row form-group">
                    <div class="col col-md-1">
                        <label for="text-input" hidden class=" form-control-label">--</label>
                    </div>
                   
                </div>
                  <div class="col-12 col-md-4">
                            <input type="text" id="FechaInicio" name="FechaInicio" class="form-control" required="required" runat="server" hidden>
                        </div>
                   
                <div class="col-12 col-md-4">
                            <input type="Text" id="FechaFinal" name="FechaFinal" class="form-control" required="required" runat="server" hidden>
                        </div> 

                

                 <div class="col-12 col-md-12">
                     <h2>RECUERDE</h2> 
                     <br>
                     
                <div class="col-4 col-md-12">
                        <asp:Label ID="Riego" runat="server" Text="---"></asp:Label>
                    </div>
                     </div>
                <br>
                 <div class="col-12 col-md-8">
                     <img class="card-img-top" src="../../images/FENOLOGIA/603.jpg" height="90">
                     </div>
            </form>
        </div>
    </div>
    </div>

</asp:Content>
