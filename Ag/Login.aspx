<%@ Page Title="Giriş Yap" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ağ.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-4">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title text-center">Giriş Yap</h4>
                            
                            <!-- Email alanı -->
                            <div class="form-group">
                                <label for="txtEmail">Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email adresinizi girin" />
                            </div>

                            <!-- Şifre alanı -->
                            <div class="form-group">
                                <label for="txtPassword">Şifre</label>
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Şifrenizi girin" />
                            </div>

                            <!-- Giriş yap butonu -->
                            <div class="form-group">
                                <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" CssClass="btn btn-primary form-control" OnClick="btnLogin_Click" />
                            </div>

                            <!-- Hata mesajı alanı -->
                            <asp:Label ID="lblErrorMessage" runat="server" CssClass="text-danger" Visible="false" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
