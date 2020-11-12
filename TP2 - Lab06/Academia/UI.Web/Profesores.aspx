<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="UI.Web.Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
        <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="Fec_Nac" HeaderText="Fecha Nacimiento" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>

        <asp:Panel ID="Panel2" runat="server">
            <asp:LinkButton ID="lbEditar" runat="server">Editar</asp:LinkButton>
            <asp:LinkButton ID="lbEliminar" runat="server">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="lbNuevo" runat="server">Nuevo</asp:LinkButton>
    </asp:Panel>

    </asp:Panel>
    
    <asp:Panel ID="Panel3" runat="server">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="tbNombre" runat="server" Width="157px"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="tbApellido" runat="server" Width="190px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDir" runat="server" Text="Direction:"></asp:Label>
        <asp:TextBox ID="tbDir" runat="server" Width="252px"></asp:TextBox>
        <br />
        <asp:Label ID="lblMail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="tbMail" runat="server" Width="273px"></asp:TextBox>
        <br />
        <asp:Label ID="lblTel" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="tbTel" runat="server" Width="273px"></asp:TextBox>
        <br />
        <asp:Label ID="lblFecNac" runat="server" Text="Fecha de nacimiento:"></asp:Label>
        <asp:TextBox ID="tbDia" runat="server" Height="19px" Width="41px"></asp:TextBox>
        <asp:Label ID="separador1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="/"></asp:Label>
        <asp:TextBox ID="tbMes" runat="server" Height="19px" Width="41px"></asp:TextBox>
        <asp:Label ID="separador2" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="/"></asp:Label>
        <asp:TextBox ID="tbAnio" runat="server" Height="19px" Width="64px"></asp:TextBox>
        <br />
        <asp:Label ID="lblLegajo" runat="server" Text="Legajo:"></asp:Label>
        <asp:TextBox ID="tbLegajo" runat="server" Width="130px"></asp:TextBox>
        <asp:Panel ID="Panel4" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
    
</asp:Content>
