<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="mail.asd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="color: #FFFFFF; background-color: #0099FF">
    <form id="form1" runat="server">
    <div>
        <asp:Table runat="server" Width="810" HorizontalAlign="Center">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>
                    <asp:Image BorderStyle="None" runat="server" ImageUrl="~/kep/logokorfix.jpg" />
                </asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign ="Center">
                        <h1>Kedves Látogató!</h1> 
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Itt kérdezheted szakértőinket és fiatal kortárssegítőket. Hogy kinek szeretnél írni Te döntöd el, az alábbiakban olvashatod segítőink bemutatkozását. Ha kiválasztottad a Neked leginkább megfelelő, szimpatikus szakértőt, és ha szeretnél írni neki, akkor kattints az e-mail küldés feliratra a bemutatkozása alatt.
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Amit garantálunk:
                    <ul>
                        <li>
                            Üzeneted mindig képzett szakember, vagy képzett kortárssegítő fogadja (választásod szerint, akinek írsz), és arra 72 órán belül válaszol.
                        </li>
                        <li>
                            Az internetes tanácsadásunk teljesen ingyenes.
                        </li>
                        <li>
                            Internetes tanácsadásunk anonim, nem szükséges neved felfedned. Ha utalsz nemedre, életkorodra, akkor segíted a szakértőnket, hogy minél személyre szabottabb tanácsot adjon, de természetesen ez sem kötelező. Próbáld minél pontosabban megfogalmazni kérdésed, problémádat, így segítőnk jobb tanácsot tud adni Neked.
                        </li>
                        <li>
                            Fordulj szakértőinkhez bátran, tőlük olyat is kérdezhetsz, amit mástól nem mersz. Segítőink nagy tapasztalattal rendelkező, gyakorló szakemberek. A levelezésetek nem nyilvános, minden amit leírtok kettőtök között marad, az e-maileket bizalmasan kezeljük.
                        </li>

                    </ul>
                 </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center"><asp:Button runat="server" ID="tovabb" OnClick="tovabb_Click" Visible="true" Text="Tovább!"></asp:Button></asp:TableCell>
            </asp:TableRow>
        </asp:Table>


    </div>
    </form>
</body>
</html>
