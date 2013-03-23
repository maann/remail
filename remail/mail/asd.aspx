<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asd.aspx.cs" Inherits="mail.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="color: #FFFFFF; background-color: #0099FF">
    <form id="form1" runat="server">
   <asp:Table runat="server" Width="810">
       <asp:TableHeaderRow>
           <asp:TableHeaderCell HorizontalAlign="Left" Width="150">
               <h2>Segítőink</h2>
           </asp:TableHeaderCell>
           <asp:TableHeaderCell Width="400">
               <div></div>
           </asp:TableHeaderCell>
           <asp:TableHeaderCell Width="350">
               <h2>Bemutatkozás</h2>
           </asp:TableHeaderCell>
       </asp:TableHeaderRow>
       <asp:TableRow>
           <asp:TableCell Width="150" RowSpan="5">
              <asp:RadioButtonList ID="segitok" runat="server" AutoPostBack="true" OnSelectedIndexChanged="segitok_SelectedIndexChanged">
                  <asp:ListItem Value="eszter.hotelmental@gmail.com" Selected="true">Eszter</asp:ListItem>
                  <asp:ListItem Value="noemi.hotelmental@gmail.com">Noémi</asp:ListItem>
                  <asp:ListItem Value="kitti.hotelmental@gmail.com">Kitti</asp:ListItem>
                  <asp:ListItem Value="mark.mario.hotelmental@gmail.com">Márk</asp:ListItem>
                  <asp:ListItem Value="szabi.hotelmental@gmail.com">Szabi</asp:ListItem>
                  <asp:ListItem Value="zsofi.hotelmental@gmail.com">Zsófi</asp:ListItem>
                  <asp:ListItem Value="lilla.hotelmental@gmail.com">Lilla</asp:ListItem>
                  <asp:ListItem Value="ezsuzsa.hotelmental@gmail.com">Zsuzsa</asp:ListItem>
                  <asp:ListItem Value="barbi.hotelmental@gmail.com">Barbi</asp:ListItem>
             </asp:RadioButtonList>
           </asp:TableCell>
           <asp:TableCell Width="400" HorizontalAlign="Right">
             <asp:TextBox runat="server" ID="Tnev" Width="300" ></asp:TextBox>
           </asp:TableCell>
           <asp:TableCell HorizontalAlign="Left" Width="350" RowSpan="5">
             <asp:Label runat="server" ID="bemutatkozas" Text=""></asp:Label>
           </asp:TableCell>
     </asp:TableRow>
     <asp:TableRow>
         <asp:TableCell Width="400" HorizontalAlign="Right">
             <asp:TextBox runat="server" ID="mailcim" width="300"></asp:TextBox>
         </asp:TableCell>
     </asp:TableRow>
     <asp:TableRow>
         <asp:TableCell>
             <asp:TextBox runat="server" ID="uzenet"></asp:TextBox>
         </asp:TableCell>
     </asp:TableRow>
     <asp:TableRow>
         <asp:TableCell>

         </asp:TableCell>     </asp:TableRow>
     <asp:TableRow>
         <asp:TableCell>

         </asp:TableCell>
     </asp:TableRow>

   </asp:Table>
    <asp:Button runat="server" ID="kuld" Text="kuld" OnClick="kuld_Click" />
        </form>
</body>
</html>
