<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="WebApplication1.Body" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center">
        <p>
    <br />
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Question" ForeColor="White" Font-Names="Catamaran" Font-Size="25pt"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yes" Height="100px" Width="250px" CSSclass="btn btn-primary btn-lg" BackColor="#75C868" BorderColor="#6AAA5F" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="30pt" ForeColor="White" BorderWidth="5px"/>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="No" Height="100px" Width="250px" CSSclass="btn btn-primary btn-lg" BackColor="#C34848" BorderColor="#DC5353" BorderStyle="Solid" Font-Names="Catamaran" Font-Size="30pt" ForeColor="White" BorderWidth="5px"/>
        </p>
    </div>

<p>
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
        </p>
<p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Change Score" Visible="False" />
        </p>
<p>
        <asp:Label ID="userScore" runat="server" Text="0" ForeColor="White" Visible="False"></asp:Label>
           
    </p>
</asp:Content>
