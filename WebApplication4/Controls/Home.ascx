<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Home.ascx.cs" Inherits="WebApplication4.Controls._default" %>
<div>
    <h2>Kullanıcı Bilgileri</h2>
    <div>
        <label for="Name">Ad:</label>
        <asp:Label ID="Name" runat="server"></asp:Label>
    </div>
    <div>
        <label for="Surname">Soyad:</label>
        <asp:Label ID="Surname" runat="server"></asp:Label>
    </div>
    <div>
        <label for="Email">E-posta:</label>
        <asp:Label ID="Email" runat="server"></asp:Label>
    </div>
</div>