<%@ Page Title="" Language="C#" MasterPageFile="./masterpage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="kstarbox.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="navbar">
            <ul>
                <li><a href="Default.aspx">HOME</a></li>
                <li><a href="Product.aspx">PRODUCTS</a></li>
                <li><a class="selected" href="About.aspx">ABOUT US</a></li>
                <li><a href="Contact.aspx">CONTACT US</a></li>
                <li><a href="Account.aspx">ACCOUNT</a></li>
            </ul>
        </div>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="aboutwrap">
     <h3>WELCOME TO KSTARZBOX</h3>
     <h3>A Home for K-POP Fans</h3>
     <p>Established since 2011 as an online personal shopper of K-POP Offcial Merchandise.<br />
         By 2013, Kstarzbox Brunei will fulfill your needs & wants for KPOP related items.<br />
         We aims to bring you all KPOP goods you're cravings for at an affordable price.</p>
     </div>
</asp:Content>
