<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="QRCode._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table width="100%">
    <tr>
    <td valign="top" width="50%">
     输入需要生成二维码内容：<br />
     <asp:TextBox ID="TextBox1" runat="server" Height="60px" TextMode="MultiLine" 
         Width="281px"></asp:TextBox>
     <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="生成" onclick="Button1_Click" />
    <br />
        <asp:Label ID="Label1" ForeColor="Red" runat="server" Text=""></asp:Label>
    </td>
    
    <td align="center">
        <asp:Image ID="Image1" runat="server" />
    </td>
    </tr>
    </table>
    
</asp:Content>
