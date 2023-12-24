<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KullaniciBilgileri.ascx.cs" Inherits="WebApplication4.KullaniciBilgileri" %>

<div>
    <h2>Kullanıcı Bilgileri</h2>
    <div>
        <label for="txtName">Ad:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="txtSurname">Soyad:</label>
        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="txtEmail">E-posta:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Kaydet" OnClick="UpdateButton_Click" />
    </div>
    <div>
        <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
    </div>
</div>
