<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="index" %>

<%@ Register Src="controles/usrEncabezado.ascx" TagName="usrEncabezado" TagPrefix="uc1" %>

<%@ Register Src="controles/usrPie.ascx" TagName="usrPie" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bienvenidos al Bosque Virtual</title>
    <link href="estilos/comunes.css" rel="stylesheet" type="text/css" />
    <link href="estilos/styles.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<style type="text/css">
body,td,th {
	font-family: Tahoma, Arial, "Microsoft Sans Serif";
}
body {
	background-color: #ECEBE7;
}
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnacceder">
    <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
                <uc1:usrEncabezado ID="usrEncabezado2" runat="server" />
    </div>
    
    <table class="tablita">
        <tr>
            <td style="width: 866px">
                <div>
                    <div>
                            <table bgcolor="#FFFFFF" border="0" cellpadding="5" cellspacing="0" style="border-width: thin;
                                        width: 619px; background-color: #FFFFFF; height: 273px; margin-left: 169px;" 
                                align="center">
                                <tr bgcolor="#72614D">
                                    <td bgcolor="#FFFFFF" rowspan="1" 
                                        style="color: #82ae1d; font-size: small;
                                                font-family: Arial, Helvetica, sans-serif; background-color: #FFFFFF;">
                                        <br />
                                        Consideraciones</td>
                                    <td bgcolor="#FFFFFF" class="Titulo" style="width: 43%; color: #82ae1d; font-family: Arial, Helvetica, sans-serif;
                                                font-size: small; background-color: #FFFFFF;">
                                        INICIO DE SESION
                                    </td>
                                </tr>
                                <tr bgcolor="#72614D">
                                    <td bgcolor="#FFFFFF" style="color: #82ae1d; font-size: small; font-family: Arial, Helvetica, sans-serif;
                                                background-color: #FFFFFF;">
                                        <table bgcolor="#FFFFFF" style="width: 77%; font-family: Calibri; color: #72614D;
                                                    margin-left: 0px; height: 240px;">
                                            <tr>
                                                <td align="left" bgcolor="#FFFFFF" 
                                                    
                                                    style="color: #72614D; font-size: 9px; font-style: normal; width: auto; text-align: justify;">
                                                    <br />
                                                    Estimado asociado:&nbsp;<br />
                                                    <br />
                                                    Bienvenido a la sección Servicios al Asociado, a través de la cual Ud. podrá 
                                                    realizar sus operaciones en línea mediante el nuevo sistema web del Country Club 
                                                    El Bosque.
                                                    <br />
                                                    <br />
                                                    Es importante tener en cuenta que:
                                                    <br />
                                                    <br />
                                                    - El acceso al sistema es personal.
                                                    <br />
                                                    <br />
                                                    - Por motivos de seguridad, le recomendamos cambiar su contraseña en la sección 
                                                    DATOS PERSONALES.
                                                    <br />
                                                    <br />
                                                    - Es total responsabilidad del asociado la modificación de la información que se 
                                                    encuentra en el sistema.
                                                    <br />
                                                    <br />
                                                    - La sesión se cerrará automáticamente al quedar inactiva por 15 minutos. <br />
                                                    <br />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td bgcolor="#FFFFFF" style="color: #82ae1d; font-family: Arial, Helvetica, sans-serif;
                                                font-size: small; background-color: #FFFFFF;">
                                        <table style="width: 90%; background-color: #FFFFFF;">
                                            <tr>
                                                <td align="left" style="color: #72614D">
                                                    &nbsp;</td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" 
                                                    style="font-size: small; font-family: Arial, Helvetica, sans-serif; color: #82AE1D;">
                                                    <strong>Usuario</strong></td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="left" style="color: #72614D">
                                                    <asp:TextBox ID="txtUsuario" runat="server" Font-Bold="False" 
                                                        ForeColor="#72614D" TabIndex="1" Width="180px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:ImageButton ID="btnAcceder" runat="server" 
                                                        ImageUrl="~/imagenes/botones/acceder.jpg" TabIndex="3" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" 
                                                    style="font-size: small; font-family: Arial, Helvetica, sans-serif;">
                                                    <strong>Contraseña</strong></td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2" style="font-family: Calibri">
                                                    <asp:TextBox ID="txtClave" runat="server" TabIndex="2" TextMode="Password" 
                                                        Width="180px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2" style="font-family: Calibri">
                                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" 
                                                        Text="Label" Width="181px"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2" 
                                                    style="font-family: Arial, Helvetica, sans-serif; font-size: x-small; font-weight: bold;" 
                                                    valign="bottom">
                                                    <a class="Ntooltip" href="#">
                                                    ¿Aún no tiene contraseña?
                                                    <span>
                                                    Para obtener su CONTRASEÑA comuníquese con nuestro servicio Helpdesk, a los 
                                                    siguientes números: 2070680, 2070681 o 2070682, de lunes a viernes de 
                                                    8:00 a 20:00 horas.
                                                    </span>
                                                    </a>
                                                    &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
                                                        Font-Names="Arial" Font-Size="X-Small" ForeColor="#82AE1D" 
                                                        NavigateUrl="~/frmRecuperarContrasena.aspx" Target="_self">Recuperar contraseña</asp:HyperLink>&nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </td>
                                </tr>
                                <tr bgcolor="#72614D">
                                    <td bgcolor="#FFFFFF" colspan="2" style="border-color: #7B5228; color: #72614D; font-size: 10px; font-family: Arial, Helvetica, sans-serif;
                                                background-color: #FFFFFF; font-style: normal;" align="left">
                                        <a href="http://www.visanet.com.pe" target="_blank">
                                        <asp:Image ID="Image4" runat="server" 
                                            ImageUrl="~/imagenes/logos/NVO.visa-logo.jpg" />
                                        </a>&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://www.visanet.com.pe/visa.htm" 
                                            onclick="window.open(this.href, this.target, 'width=606,height=402'); return false;" 
                                            style="text-decoration: none" target="_blank"><asp:Image ID="Image2" 
                                            runat="server" 
                                            ImageUrl="~/imagenes/logos/V_byVBM_FC.jpg" />
                                        </a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <a href="http://www.visanet.com.pe/promovbv/bancos.html" target="_blank"><asp:Image 
                                            ID="Image5" runat="server" 
                                            ImageUrl="~/imagenes/logos/boton afiliate a tu banco.gif" />
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image8" runat="server" 
                                            ImageUrl="~/imagenes/logos/mc_accpt_065_gif.gif" />
                                        &nbsp; &nbsp;&nbsp;
                                        <a href="http://www.mastercardbusiness.com/mcbiz/index.jsp?template=/orphans&amp;content=securecodepopup" 
                                            target="_blank">
                                        <asp:Image ID="Image6" runat="server" 
                                            ImageUrl="~/imagenes/logos/sclogolearn_86x47.gif" />
                                        </a>
                                        <br />
                                        <br />
                                        &nbsp;Esta tienda está autorizada por Visa para realizar transacciones electrónicas
                                        <br />
                                        <br />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <a href="ayuda.aspx" target="_blank">
                                        <asp:Image ID="Image7" runat="server" Height="22px" 
                                            ImageUrl="~/imagenes/logos/ayuda.gif" Width="29px" />
                                        </a>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                            <%--<table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                                <tr>
                                    <td>--%>
                                      
                                    <%--</td>
                                </tr>
                            </table>--%>
                      <%--  </div>--%>
                    </div>
            </td>
        </tr>
         
    </table>
   
      <uc2:usrPie ID="UsrPie1" runat="server" />
        </ContentTemplate>
        </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
