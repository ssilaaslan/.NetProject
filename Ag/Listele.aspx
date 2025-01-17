<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="Listele.aspx.cs" Inherits="Ağ.Listele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow" CssClass="row">
            <ItemTemplate>
                <div class="col-md-6 mb-4">  <!-- Change col-md-4 to col-md-6 -->
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title font-weight-bold">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("UlkeAdi") %>'></asp:Label>
                            </h4>
                            <h5 class="card-subtitle mb-2 text-muted font-weight-bold">
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Sehir") %>'></asp:Label>
                            </h5>
                            <p class="card-text">
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Aciklama") %>'></asp:Label>
                            </p>
                            <p class="card-text text-end">
                                <strong>Bütçe: </strong>
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("Butce") %>'></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>


