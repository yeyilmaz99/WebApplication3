<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddUser.ascx.cs" Inherits="WebApplication4.Controls.AddUser" %>



<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-5">
            <h1 class="h3 mb-3 fw-normal">Register</h1>
            <div class="form-floating">
                <asp:TextBox ID="CompanyName" runat="server" CssClass="form-control mt-1" placeholder="CompanyName"></asp:TextBox>
                <asp:Label AssociatedControlID="CompanyName" Text="CompanyName" runat="server"></asp:Label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="ContactName" runat="server" CssClass="form-control mt-1" placeholder="ContactName"></asp:TextBox>
                <asp:Label AssociatedControlID="ContactName" Text="ContactName" runat="server"></asp:Label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="ContactTitle" runat="server" CssClass="form-control mt-1" placeholder="ContactTitle"></asp:TextBox>
                <asp:Label AssociatedControlID="ContactTitle" Text="Contact Title" runat="server"></asp:Label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="City" runat="server" CssClass="form-control mt-1" placeholder="City"></asp:TextBox>
                <asp:Label AssociatedControlID="City" Text="City" runat="server"></asp:Label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="PostalCode" runat="server" CssClass="form-control mt-1" placeholder="PostalCode"></asp:TextBox>
                <asp:Label AssociatedControlID="PostalCode" Text="PostalCode" runat="server"></asp:Label>
            </div>
            <div>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AddAltKullanici" />
            </div>
        </div>
    </div>
</div>






