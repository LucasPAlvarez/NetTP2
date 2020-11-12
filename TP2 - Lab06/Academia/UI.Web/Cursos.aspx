<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Materia" HeaderText="Materia" />
                <asp:BoundField DataField="Comision" HeaderText="Comision" />
                <asp:BoundField DataField="Anio_calendario" HeaderText="Año" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
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
        <asp:Label ID="lblMateria" runat="server" Text="Materia:"></asp:Label>
        <asp:TextBox ID="tbMateria" runat="server" Width="254px"></asp:TextBox>
        <br />
        <asp:Label ID="lblComision" runat="server" Text="Comision"></asp:Label>
        <asp:TextBox ID="tbComision" runat="server" Width="252px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAnio" runat="server" Text="Año:"></asp:Label>
        <asp:TextBox ID="tbAnio" runat="server" Width="92px"></asp:TextBox>
        <asp:Label ID="lblCupo" runat="server" Text="Cupo:"></asp:Label>
        <asp:TextBox ID="tbCupo" runat="server" Width="91px"></asp:TextBox>
        <br />
        <asp:Panel ID="Panel4" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
