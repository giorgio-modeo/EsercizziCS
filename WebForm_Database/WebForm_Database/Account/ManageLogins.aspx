﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageLogins.aspx.cs" Inherits="WebForm_Database.Account.ManageLogins" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Gestire gli account di accesso esterni.</h2>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
                <p class="text-success"><%: SuccessMessage %></p>
            </asp:PlaceHolder>
        <div>
            <section id="externalLoginsForm">

                <asp:ListView runat="server"
                    ItemType="Microsoft.AspNet.Identity.UserLoginInfo"
                    SelectMethod="GetLogins" DeleteMethod="RemoveLogin" DataKeyNames="LoginProvider,ProviderKey">

                    <LayoutTemplate>
                        <h4>Account di accesso registrati</h4>
                        <table class="table">
                            <tbody>
                                <tr runat="server" id="itemPlaceholder"></tr>
                            </tbody>
                        </table>

                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#: Item.LoginProvider %></td>
                            <td>
                                <asp:Button runat="server" Text="Rimuovi" CommandName="Delete" CausesValidation="false"
                                    ToolTip='<%# "Rimuovere i dati " + Item.LoginProvider + " di accesso da account personale" %>'
                                    Visible="<%# CanRemoveExternalLogins %>" CssClass="btn btn-outline-dark" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>

            </section>
        </div>
        <div>
            <uc:OpenAuthProviders runat="server" ReturnUrl="~/Account/ManageLogins" />
        </div>
    </main>
</asp:Content>
