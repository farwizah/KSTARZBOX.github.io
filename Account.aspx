<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="kstarbox.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="navbar">
            <ul>
                <li><a href="Default.aspx">HOME</a></li>
                <li><a href="Product.aspx">PRODUCTS</a></li>
                <li><a href="About.aspx">ABOUT US</a></li>
                <li><a href="Contact.aspx">CONTACT US</a></li>
                <li><a class="selected" href="Account.aspx">ACCOUNT</a></li>
            </ul>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="acc"><h2>Welcome back </h2></div>
    <div class="accwrapper">
    <ul>
        <li>Check out our products <a href="Product.aspx" runat="server">here</a> </li>
        <li>Get in touch with us <a href="Contact.aspx" runat="server">here</a></li>
        <li><asp:HyperLink ID="adminlink" runat="server" NavigateUrl="~/admin/Admin.aspx">Admin access</asp:HyperLink></li>
    </ul>

    <p style="margin-left: 40px">
        <asp:Button ID="sOut" runat="server" OnClick="sOut_Click" Text="Sign out"  OnClientClick="window.open('../Default.aspx', 'Default')"/>
        <a href="Contact.aspx" runat="server">
        
        </a>
    </p>
        </div>
</asp:Content>
