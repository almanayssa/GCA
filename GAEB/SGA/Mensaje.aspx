<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaBosque.Master" CodeBehind="Mensaje.aspx.vb" Inherits=".Mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table border="0" cellpadding="0" cellspacing="0">
	<tr>
	    <td class="borderLeftL004">&nbsp;</td>	
	    <td valign="top" style="background-color:Transparent;">
	        <table border="0" cellpadding="0" cellspacing="0" class="zoneCenterWithoutMenu">
	            <tr>
	                <td valign="top" style="padding-top:15px;">
	                    <table border="0" cellpadding="0" cellspacing="0" style="background-color:Transparent; width:865px; height:400px;">
	                        <tr>
	                            <td align="left" valign="top" style="padding-left:52px;">
                                    <table border="0" cellpadding="0" cellspacing="0">
                                        <tr><td class="textTitleLeft" align="left"><asp:Label ID="lblMessagePage" runat="server"></asp:Label></td></tr>
                                    </table>
                                    <table border="0" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td class="formMessagePage"><asp:Label ID="lblMessageDescription" runat="server"></asp:Label><br /></td>
                                        </tr>
                                    </table><br />
                                    <table border="0" cellpadding="0" cellspacing="0">
                                        <tr><td align="left"><asp:ImageButton ID="ibtContinue" SkinID="ibtnContinue" runat="server" /></td></tr>
                                    </table>
	                            </td>
	                        </tr>
	                    </table>
	                </td>
	            </tr>
	        </table>
	    </td>
        <td class="borderRightL004">&nbsp;</td>	    
	</tr>
</table>
</asp:Content>
