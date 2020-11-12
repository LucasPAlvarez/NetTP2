<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="Anio" HeaderText="Año" />
                <asp:BoundField DataField="Plan" HeaderText="Plan" />
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
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="tbDescripcion" runat="server" Width="254px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAnio" runat="server" Text="Año:"></asp:Label>
        <asp:TextBox ID="tbAnio" runat="server" Width="92px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPlan" runat="server" Text="Pan:"></asp:Label>
        <asp:TextBox ID="tbPlan" runat="server" Width="212px"></asp:TextBox>
        <br />
        <asp:Panel ID="Panel4" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
