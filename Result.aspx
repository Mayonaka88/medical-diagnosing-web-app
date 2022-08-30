<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="WebApplication1.Result" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
           
        <div style="text-align:center">
            <asp:Label ID="Label2" runat="server" Font-Names="Catamaran" Font-Size="50pt" ForeColor="White" Text="Your diagnosis most likely to be..."></asp:Label>
&nbsp;<br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Names="Catamaran" Font-Size="70pt" ForeColor="White" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Names="Catamaran" Font-Size="25pt" ForeColor="White" Text="Contact your doctor at your earliest convenience!"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <div style="text-align:center">
            <asp:Button ID="Button1" runat="server" Height="100px" OnClick="Button1_Click" Text="Try Again?" Width="250px" CSSclass="btn btn-primary btn-lg" BackColor="#2c2c2c" BorderColor="#3d3d3d" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="30pt" ForeColor="White" BorderWidth="5px" />
        </div>
        </div>
        <br />
           
    </div>
</asp:Content>
