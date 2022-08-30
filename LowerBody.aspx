<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LowerBody.aspx.cs" Inherits="WebApplication1.LowerBody" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div style="text-align:center">
        <p>
    <br />
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label1" runat="server" Text="What part of the region does the pain come from?" ForeColor="White" Font-Names="Catamaran" Font-Size="25pt"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Stomach" Height="60px" Width="150px" CSSclass="btn btn-primary btn-lg" BackColor="#2c2c2c" BorderColor="#3d3d3d" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="15pt" ForeColor="White" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Liver" Height="60px" Width="150px" CSSclass="btn btn-primary btn-lg" BackColor="#2c2c2c" BorderColor="#3d3d3d" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="15pt" ForeColor="White" BorderWidth="5px"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Kidney" Height="60px" Width="150px" CSSclass="btn btn-primary btn-lg" BackColor="#2c2c2c" BorderColor="#3d3d3d" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="15pt" ForeColor="White" BorderWidth="5px"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Appendix" Height="60px" Width="150px" CSSclass="btn btn-primary btn-lg" BackColor="#2c2c2c" BorderColor="#3d3d3d" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="15pt" ForeColor="White" BorderWidth="5px"/>
        </p>
    </div>
</asp:Content>
