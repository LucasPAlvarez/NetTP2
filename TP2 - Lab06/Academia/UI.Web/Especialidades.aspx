<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
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
        <asp:Label ID="lblEspecialidad" runat="server" Text="Descripcion de la especialidad:"></asp:Label>
        <br />
        <asp:TextBox ID="tbNombre" runat="server" Width="435px" Height="56px"></asp:TextBox>
        <br />
        <asp:Panel ID="Panel4" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
