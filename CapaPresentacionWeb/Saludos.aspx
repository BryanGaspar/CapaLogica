<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saludos.aspx.cs" Inherits="CapaPresentacionWeb.Saludos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 340px;
        }
        .auto-style4 {
            height: 23px;
            width: 340px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Ingresa tu nombre:</td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Ingresa el saldo:</td>
                    <td>
                        <asp:TextBox ID="txtSaldoInicial" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Ingresa el numero del mes:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNumMes" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Resultados:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtRes" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mes:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtnombreMes" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCalcular" runat="server" BorderStyle="Outset" OnClick="btnCalcular_Click" Text="Calcular" />
                    </td>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
