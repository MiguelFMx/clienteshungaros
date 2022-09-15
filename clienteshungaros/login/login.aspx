﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="clienteshungaros.login.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <asp:Panel runat="server">
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lbluser" runat="server" Text="Usuario:" CssClass="form-label"></asp:Label>
                            <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:Label ID="lblPass" runat="server" Text="Password:" CssClass="form-label"></asp:Label>
                            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </asp:Panel>
                <asp:Label ID="lbltest" runat="server" Text="" ForeColor="#ff0000"></asp:Label>
            </div>
            <div class="col"></div>
        </div>
        <br />
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesion" CssClass="btn btn-success" OnClick="btnLogin_Click" />
            </div>
            <div class="col"></div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Scriptcontent" runat="server">
</asp:Content>
