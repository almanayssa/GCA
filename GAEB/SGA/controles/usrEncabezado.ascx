<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="usrEncabezado.ascx.vb" Inherits="controles_usrEncabezado" %>
<%@ Register Assembly="skmMenu" Namespace="skmMenu" TagPrefix="cc1" %>

<table border="0" cellpadding="0" cellspacing="0" style="width: 100%" 
    bgcolor="#ECEBE7">
    <tr>
        <td style="color: #ffffff; background-color: #142d13; height: 30px;" colspan="2">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 41px; margin-bottom: 0px;" 
                bgcolor="#72614D">
                <tr>
                    <td style="width: 20%">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 30px">
                            <tr>
                                <td style="width: 10%">
                                </td>
                                <td style="width: 1px">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/botones/icoHome.gif" /></td>
                                <td style="width: 40%">
                                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
                                        Font-Names="Arial" Font-Size="X-Small" ForeColor="#82AE1D" NavigateUrl="http://www.elbosque.org.pe">Home</asp:HyperLink></td>
                                <td style="width: 1%">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/botones/icoContactenos.gif" /></td>
                                <td style="width: 50%">
                                    <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" 
                                        Font-Names="Arial" Font-Size="X-Small" ForeColor="#82AE1D" 
                                        NavigateUrl="#">Contáctenos</asp:HyperLink></td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 20%">
                    </td>
                    <td style="width: 60%">
                        <table border="0" cellpadding="3" cellspacing="2" 
                            style="width: 99%; height: 30px">
                            <tr>
                                <td align="center" style="width: 80%" bgcolor="#72614D">
                                    <asp:Label ID="lblUsuario" runat="server" CssClass="EnlaceCabecera" 
                                        Font-Bold="True" Font-Names="Arial" Font-Size="X-Small" ForeColor="#82AE1D"></asp:Label>
                                    </td>
                                <td style="width: 1%; color: #82ae1d;" class="EnlaceCabecera">
                                    &nbsp;</td>
                               <td align="center" style="width: 80%">
                                    <asp:Label ID="lblaccion" runat="server" CssClass="EnlaceCabecera" 
                                        Font-Bold="True" Font-Names="Arial" Font-Size="X-Small" ForeColor="#82AE1D"></asp:Label>
                                    </td>
                                <td style="width: 1%; color: #82ae1d;" class="EnlaceCabecera">
                                    &nbsp;</td>
                                <td align="center" style="width: 20%">
                                    <asp:HyperLink ID="lnkSalir" runat="server" CssClass="EnlaceCabecera" 
                                        NavigateUrl="~/logoff.aspx" Font-Bold="True" Font-Names="Arial" 
                                        Font-Size="X-Small" ForeColor="#82AE1D">Salir</asp:HyperLink></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                  <td bgcolor="#ECEBE7" colspan="3" style="border-color: #72614F" dir="ltr"></td>
              </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="width: 90%">
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                <tr>
                    <td bgcolor="#ECEBE7">
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            ImageUrl="~/imagenes/logos/nuevo_logo.jpg" PostBackUrl="~/inicio.aspx" /></td>
                </tr>
            </table>
        </td>
        
  </tr>
    <tr>
        <td style="height: 41px">
            <table border="0" cellpadding="0" cellspacing="0" style="background-image: url('imagenes/botones/barra.jpg');
                width: 850px; height: 41px">
                <tr>
                    <td valign="top">
                        <table border="0" cellpadding="3" cellspacing="2" style="width: 114%">
                            <tr>
                                <td style="cursor:pointer">
                                   <cc1:menu id="Menu1" ffont-names="Microsoft Sans Serif" Layout="Horizontal" 
                                        cursor="Pointer" HighlightTopMenu="False" ItemPadding="5" runat="server" 
                                        SubMenuCssClass="submenu" BackColor="#72614D" Font-Bold="True" 
                                        Font-Size="8.5pt" ForeColor="White" Font-Names="Arial">
                                        <SelectedMenuItemStyle BackColor="#69A603"></SelectedMenuItemStyle>
                                    </cc1:menu>
               </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
<table border="0" cellpadding="0" cellspacing="0" 
    style="width: 100%; height: 9px;" bgcolor="#ECEBE7">
</table>