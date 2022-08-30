<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
           
        <div style="text-align:center">
            <asp:Label ID="Label2" runat="server" Font-Names="Catamaran" Font-Size="50pt" ForeColor="White" Text="Welcome to Medi"></asp:Label>
&nbsp;<br />
            <asp:Label ID="Label3" runat="server" Font-Names="Catamaran" Font-Size="16pt" ForeColor="White" Text="Your own personalized minimalic medical assistant!"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <div style="text-align:center">
            <asp:Button ID="Button1" runat="server" Height="100px" OnClick="Button1_Click" Text="Start" Width="250px" CSSclass="btn btn-primary btn-lg" BackColor="#C34848" BorderColor="#DC5353" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="30pt" ForeColor="White" BorderWidth="5px" />
        </div>
        <br />
           
    </div>

</asp:Content>
