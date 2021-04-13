<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlEmpleados._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CONTROL DE ALUMNOS</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2> Universidades </h2>
            <p> 
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Mesoamericana</asp:ListItem>
                    <asp:ListItem>Landivar</asp:ListItem>
                    <asp:ListItem>Mariano Gálvez</asp:ListItem>
                    <asp:ListItem>Del Valle</asp:ListItem>
                    <asp:ListItem>Francisco Marroquín</asp:ListItem>
                    <asp:ListItem>USAC</asp:ListItem>
                    <asp:ListItem>Panamericana</asp:ListItem>
                    <asp:ListItem>Da Vinci</asp:ListItem>
                    <asp:ListItem>Rural</asp:ListItem>
                    <asp:ListItem>Istmo</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p> 
                &nbsp;</p>
            <p> 
                &nbsp;</p>
            <p> 
                &nbsp;</p>
            <h2> Alumnos </h2>
        </div>
    </div>
    <br />
    <br />
    <br />
    <asp:Button ID="ButtonUniversidad" runat="server" BackColor="#FF9966" BorderColor="#99FFCC" Font-Bold="True" Text="Agregar Universidad" OnClick="ButtonUniversidad_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Width="201px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonAdd" runat="server" BackColor="#FF9966" BorderColor="#3333CC" Font-Bold="True" OnClick="ButtonAdd_Click" Text="Agregar Alumno" />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
