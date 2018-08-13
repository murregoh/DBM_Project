<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ExampleCnx.Administracion.AdminPage" %>

<asp:Content ContentPlaceHolderID="ContentBody" runat="server">
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Bienvenido</h1>
            <ol class="breadcrumb">
                <li><a>Hora Inicio de Sesión</a>
                    <asp:Label ID="fecha" runat="server" />
                </li>
            </ol>
        </section>
        <!-- Main content -->
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <ul class="timeline">
                        <li class="time-label">
                            <span class="bg-red">20 Mayo 2018</span>
                        </li>
                        <li>
                            <i class="fa fa-user bg-aqua"></i>
                            <div class="timeline-item">
                                <span class="time"><i class="fa fa-clock-o"></i>12:00</span>
                                <h3 class="timeline-header no-border"><a href="#">Juan Guillermo</a> acepto la amistad de <a href="#">Yuliana Mira</a></h3>
                            </div>
                        </li>
                        <li>
                            <i class="fa fa-comments bg-yellow"></i>
                            <div class="timeline-item">
                                <span class="time"><i class="fa fa-clock-o"></i>11:00</span>
                                <h3 class="timeline-header"><a href="#">Ivan Dario</a> hizo un comentario</h3>
                                <div class="timeline-body">
                                    Casi que no me crean el usuario
                                </div>
                                <div class="timeline-footer">
                                    <a class="btn btn-warning btn-flat btn-xs">Ver Comentario</a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <i class="fa fa-envelope bg-blue"></i>
                            <div class="timeline-item">
                                <span class="time"><i class="fa fa-clock-o"></i>12:05</span>
                                <h3 class="timeline-header"><a href="#">Yuliana Mira</a> Te envió un email</h3>
                                <div class="timeline-body">
                                    Que le creen el usuario a Ivan Dario
                                </div>
                                <div class="timeline-footer">
                                    <a class="btn btn-primary btn-xs">Leer</a>
                                    <a class="btn btn-danger btn-xs">Eliminar</a>
                                </div>
                            </div>
                        </li>
                        <li class="time-label">
                            <span class="bg-green">19 Mayo 2018</span>
                        </li>
                        <li>
                            <i class="fa fa-envelope bg-blue"></i>
                            <div class="timeline-item">
                                <span class="time"><i class="fa fa-clock-o"></i>10:00</span>
                                <h3 class="timeline-header"><a href="#">Juan Guillermo</a> Te envió un email</h3>
                                <div class="timeline-body">
                                    Buenas Noches
                                    <br />
                                    Realizamos ampliación de la sede de Medellin.
                                    <br />
                                    favor crear la sala S65Y con capacidad para 35 personas<br />
                                    Saludos
                                </div>
                                <div class="timeline-footer">
                                    <a class="btn btn-primary btn-xs">Leer</a>
                                    <a class="btn btn-danger btn-xs">Eliminar</a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <i class="fa fa-envelope bg-blue"></i>
                            <div class="timeline-item">
                                <span class="time"><i class="fa fa-clock-o"></i>8:05</span>
                                <h3 class="timeline-header"><a href="#">Yuliana Mira</a> Te envió un email</h3>

                                <div class="timeline-body">
                                    Crear Usuario para Ivan
                                </div>
                                <div class="timeline-footer">
                                    <a class="btn btn-primary btn-xs">Leer</a>
                                    <a class="btn btn-danger btn-xs">Eliminar</a>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
