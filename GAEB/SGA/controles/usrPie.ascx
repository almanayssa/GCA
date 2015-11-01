<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="usrPie.ascx.vb" Inherits="controles_usrPie" %>

<style type="text/css">
    .style1
    {
        width: 791px;
    }
    .style2
    {
        width: 288px;
    }
</style>

<table border="0" cellpadding="0" cellspacing="0" 
    style="width: 100%; height: 9px;" bgcolor="#ECEBE7">
    <tr>
        <td></td>
        <td>
            </td>
        <td>
            </td>
        <td>
            </td>
        <td class="style1">
            </td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Image ID="Image4" runat="server" 
                ImageUrl="~/imagenes/botones/logo_marron.bmp" />
        </td>
    </tr>
    <tr>
        <td colspan="7" style="height: 20px;" >
            <hr style="color: #72614D; height: 5px; margin-bottom: 0px; margin-top: 0px;"/>
        </td>
    </tr>
    </table>
    
  <table border="0" cellpadding="0" cellspacing="0" 
    style="width: 100%; height: 32px;" bgcolor="#72614D">  
    <tr>
        <td style="width: 671px; height: 40px"></td>
        <td class="style2"></td>
        <td>&nbsp;</td>
        <td style="width: 671px; height: 40px">
            &nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" 
                Font-Size="8.5pt" ForeColor="White" 
                Text=":. Diseño y Desarrollo realizado por el Dpto. Sistemas ACC ELBOSQUE"></asp:Label>
        </td>
    </tr>
</table>