<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Body.aspx.cs" Inherits="WebApplication1.Body1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center">
        <asp:Label ID="Label1" runat="server" Text="Which region of the body do you feel pain in?" ForeColor="White" Font-Names="Catamaran" Font-Size="25pt"></asp:Label>
        <br />
        <br />
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/Images/Body.png" Height="500px" HotSpotMode="Navigate">
            <asp:PolygonHotSpot Coordinates="107,91,112,85,110,75,107,65,100,50,104,37,107,22,119,11,129,8,137,9,143,12,150,18,154,28,156,40,157,49,154,57,150,65,146,73,145,81,150,91" HotSpotMode="Navigate" NavigateUrl="~/Head.aspx" Target="_self" />
            <asp:PolygonHotSpot Coordinates="183,109,170,156,164,158,162,165,163,171,161,181,89,182,88,166,83,160,75,105,84,99,109,91,149,90,163,97,173,101" HotSpotMode="Navigate" NavigateUrl="~/UpperBody.aspx" Target="_self" />
            <asp:PolygonHotSpot Coordinates="92,181,82,236,117,272,123,269,128,274,170,233,160,180" HotSpotMode="Navigate" NavigateUrl="~/LowerBody.aspx" Target="_self" />
            <asp:PolygonHotSpot Coordinates="171,233,128,273,140,349,141,383,146,410,149,446,151,481,159,491,172,485,173,470,167,445,167,415,171,385,165,343,172,287" HotSpotMode="Navigate" NavigateUrl="~/Legs.aspx" Target="_self" />
            <asp:PolygonHotSpot Coordinates="82,235,117,272,112,307,109,340,105,361,105,381,100,414,98,455,98,479,90,491,79,489,74,475,80,451,80,424,75,383,80,353,81,322,77,307,76,288,78,257" HotSpotMode="Navigate" NavigateUrl="~/Legs.aspx" Target="_self" />
            <asp:PolygonHotSpot Coordinates="183,109,193,123,195,152,199,171,208,193,221,229,235,240,250,249,241,254,243,270,233,277,219,272,209,247,198,226,180,194,170,156" HotSpotMode="Navigate" NavigateUrl="~/Arms.aspx" Target="_self" />
            <asp:PolygonHotSpot Coordinates="75,104,83,160,77,184,68,205,42,236,35,260,26,271,12,280,4,260,6,244,25,229,43,193,55,163,63,120" HotSpotMode="Navigate" NavigateUrl="~/Arms.aspx" Target="_self" />
        </asp:ImageMap>
    </div>
</asp:Content>
