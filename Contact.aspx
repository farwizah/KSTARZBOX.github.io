<%@ Page Title="" Language="C#" MasterPageFile="masterpage.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="kstarbox.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="js/map.js"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="navbar">
            <ul>
                <li><a href="Default.aspx">HOME</a></li>
                <li><a href="Product.aspx">PRODUCTS</a></li>
                <li><a href="About.aspx">ABOUT US</a></li>
                <li><a class="selected" href="Contact.aspx">CONTACT US</a></li>
                <li><a href="Account.aspx">ACCOUNT</a></li>
            </ul>
        </div>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div id="formwrapper">
        <div class="contact"><h4>Contact us</h4> </div>
         <div class="loglabel"><asp:Label ID="name" runat="server" Text="First Name: " AssociatedControlID="nametxt"></asp:Label><asp:TextBox ID="nametxt" runat="server" Width="262px"></asp:TextBox></div>
         <div class="lit"><asp:Literal ID="nametxtError" runat="server" ValidateRequestMode="Enabled"></asp:Literal></div> 

         <div class="loglabel"><asp:Label ID="email" runat="server" Text="Email: " AssociatedControlID="emailtxt" ValidateRequestMode="Enabled"></asp:Label><asp:TextBox ID="emailtxt" runat="server" Width="262px"></asp:TextBox></div>
         <div class="lit"><asp:Literal ID="emailtxtError" runat="server" ValidateRequestMode="Enabled"></asp:Literal></div>   

         <div class="loglabel"><asp:Label ID="subject" runat="server" Text="Subject: " AssociatedControlID="subjecttxt" ValidateRequestMode="Enabled"></asp:Label><asp:TextBox ID="subjecttxt" runat="server" Width="262px"></asp:TextBox></div> 
         <div class="lit"><asp:Literal ID="subjttxtError" runat="server" ValidateRequestMode="Enabled"></asp:Literal></div>   

         <div class="loglabel"><asp:Label ID="message" runat="server" Text="Message: " AssociatedControlID="messagetxt"></asp:Label><asp:TextBox ID="messagetxt" runat="server" Height="51px" TextMode="MultiLine" Width="263px"></asp:TextBox></div>
         <div class="lit"> <asp:Literal ID="msgtxtError" runat="server" ValidateRequestMode="Enabled"></asp:Literal></div> 

         <div class="loginbutton"><asp:Button ID="sendButton" runat="server" Text="Send" OnClick="sendButton_Click" ValidateRequestMode="Enabled" /></div>
         <div class="lit"><asp:Literal ID="literalError" runat="server" ValidateRequestMode="Enabled"></asp:Literal></div>
         <div class="lit"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="nametxt" ErrorMessage="Numeric characters detected!" ValidationExpression="^[^\W\d_]+$" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator></div> 
   
    </div>

    <div class="address">
    <h3>WHERE TO FIND US?</h3>
    <address>
        KSTARZBOX BN<br />
        3rd Floor, The Mall Gadong<br />
        Bandar Seri Begawan,
        Negara Brunei Darussalam  
    </address>
    </div>

</asp:Content>
