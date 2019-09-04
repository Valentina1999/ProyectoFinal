<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Foro.aspx.cs" Inherits="Web.Presentacion.Foro.WebForm19" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Foro</title>

    <link rel="stylesheet" href="cssForo/styleForo.css" />
    <link href="https://file.myfontastic.com/dVuqVG7WzfK89f2YnsE2wH/icons.css" rel="stylesheet" />
</head>

<body>
    <div class="background">
        <img src="ImagenesForo/fondo.jpg" alt="" />
        <div class="capa"></div>
    </div>
    <main>
        <h1 class="titulo">FORO
        </h1>
        <hr class="line" />
        <div class="botones">
            <button class="btn-comment-pregunta">Pregunta</button>
            <br />
            <br />
            <br />
            <a class="volver" href="../Index/Index.aspx">Volver</a>
        </div>
        <br />
        <br />
        <br />
        <asp:Repeater ID="repeater1" runat="server">
            <ItemTemplate>
                <div class="container-comments">
                    <div class="comments">
                        <div class="info-comments">
                            <div class="header">
                                <h4>Oscar Cruz</h4>
                                <h5>31-Agosto-2019</h5>
                            </div>
                            <p>
                                <%#Eval("Pregunta")%>
                            </p>
                            <div class="footer">
                                <h5 class="request">Responder</h5>
                                <label class="icon-heart"></label>
                            </div>
                        </div>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
        <div class="container-comments-request">
            <div class="comments-request">
                <div class="info-comments-request">
                    <div class="header">
                        <h4>Oscar Cruz</h4>
                        <h5>31-Agosto-2019</h5>
                    </div>
                    <p>
                        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Voluptatibus iste qui porro et, nihil
                        fugit dolores modi nisi animi illo quaerat blanditiis. Quia deserunt vitae deleniti quod ipsa,
                        animi fuga!
                    </p>
                </div>
            </div>
        </div>
    </main>

    <div class="capa-data"></div>

    <form action="Foro.aspx" runat="server" method="post">
        <div class="container-data">
            <strong>SUGERENCIAS</strong>
            <div class="photo-input">
                <input type="text" id="NombreP" name="NombreP" placeholder="Nombre" readonly="readonly" />
                <input type="text" id="FechaP" name="FechaP" hidden="hidden" />
            </div>
            <textarea class="mensaje" placeholder="Esciba su sugerencia al problema" name="respuesta" id="respuesta" cols="30" rows="10"></textarea>
            <button type="submit" id="enviarR" name="enviarP" class="btn-comment">Responder</button>
        </div>

        <div class="capa-pregunta"></div>

        <div class="container-pregunta">
            <strong>PREGUNTA</strong>
            <div class="photo-input">
                <input type="text" runat="server" name="nombreP" id="nombreP" placeholder="Nombre" readonly="readonly" />
                <input type="text" runat="server" name="id" id="id" hidden="hidden" />
                <input type="text" runat="server" name="fechaP" id="fechaP" value="" hidden="hidden" />
            </div>
            <textarea class="mensaje" placeholder="Esciba su Pregunta" runat="server" name="pregunta" id="pregunta" cols="30" rows="10"></textarea>
            <button type="button" runat="server" onserverclick="mtdRegistrarPregunta" id="btnpregunta" class="btn-comment">Publicar Pregunta</button>
        </div>
    </form>
    <script src="jsForo/jquery.js"></script>
    <script src="jsForo/script.js"></script>
</body>

</html>
