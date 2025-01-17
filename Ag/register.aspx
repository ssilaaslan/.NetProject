
<%@ Page Title="register" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Ağ.register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <h2>Kayıt Ol</h2>
            <div class="mb-3">
                <label for="email" class="form-label">E-posta</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Placeholder="E-posta adresinizi girin" type="email"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="password" class="form-label">Şifre</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" Placeholder="Şifrenizi girin" type="password"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnRegister" runat="server" Text="Kayıt Ol" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</asp:Content>

