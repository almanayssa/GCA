<%@ Page Title="Bienvenida" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaBosque.Master" CodeBehind="inicio.aspx.vb" Inherits="inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="tablitaDatosSocio">
        <tr>
            <td>
                <div class="DatosSocio" 
                    style="height: 370px; width: 380px; text-align: justify;">
                    <%--<div class="DatosSocio">--%>
                    <br />
                    <br />
                    <br />
                    <br />
                    Estimado asociado:
                    <asp:Label ID="lblApellidosNombre" runat="server" Font-Bold="True" BackColor="White"
                        CssClass="lblmarron"></asp:Label>
                    <br />
                    <br />
                    <br />
                    1. El Country Club El Bosque le da la más cordial bienvenida a su sistema web de 
                    operaciones en línea a través del cual Ud. podrá:
                    <br />
                    <br />
                    a) Actualizar sus datos.
                    <br />
                    <br />
                    b) Consultar y o pagar sus cuotas on line a través de Visa y Mastercard.
                    <br />
                    <br />
                    c) Registrar y pagar el ingreso de sus invitados (aplica a los invitados a pasar 
                    el día, no a los invitados a pernoctar).
                    <br />
                    <br />
                    d) Reservar y pagar el servicio de alojamiento en Bungalows Chosica 
                    (Próximamente se iniciará con el servicio de Alojamientos en Sede Playa).
                    <br />
                    <br />
                    2. Por motivos de seguridad, le recomendamos cambiar su contraseña en la sección 
                    DATOS PERSONALES.
                    <br />
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
