using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;

namespace mail
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] bemutatkozok = new string[] 
        {
        "Kedves látogató! Eszter vagyok, harmadéves pszichológia szakos hallgató. Sajnos én \n is észrevettem, hogy ebben a rohanó világban a legnagyobb probléma, hogy az \n embereknek nincs idejük egymásra, nincs idejük beszélgetni. Nekem viszont van, \n és szívesen megosztom veled! Ha szeretnél tanácsot kérni, beszélgetni, vagy csak arra vágysz, \n hogy valaki meghallgasson, keress meg bátran!",
        "Szia! \n Noémi vagyok, harmadéves pszichológus hallgató. Az élet néha váratlan helyzetekbe \n sodor minket. Ha valami nyomja a lelked, s nem tudod kivel oszthatnád meg, a \n legnagyobb örömmel állok rendelkezésedre. De az is lehet, hogy \n egyszerűen csak jó lenne valakivel beszélgetni. Ha valami jól esik, az már éppen \n elegendő ok lehet. :) Keress bátran!",
        "Sziasztok! Kitti vagyok, a DE pszichológia szakos hallgatója. Lehetőséged van \n megosztani problémáid, bizonytalanságaid egy olyan diáktársaddal, \n aki nem ítélkezik feletted és nem adja tovább féltett titkaid. \n Ha szeretnéd, hogy Valaki meghallgasson, támaszt nyújtson Neked, akkor keress fel \n és beszéljünk róla! :)",
        "Szia! \n Márk vagyok. \n Szeretem, ha körülöttem zajlik az élet. Szeretek a félhomályban ücsörögni idehaza és a kedvenc zenéimet hallgatva elgondolkozni a közel- és régmúlt eseményein, elemezni, hogy mit csináltam jól, és mit rosszul. \n  Nekem is vannak problémáim, hiszen emberből vagyok, akárcsak Te.  \n Kortársak vagyunk, engedd, hogy segítsek! ",
        "Sziasztok! \n Szabi vagyok, harmadéves pszichológushallgató.  \n Az a tapasztalatom, hogy ha hirtelen nem is találunk megoldást a problémáinkra,  \n attól még nagy megkönnyebbülést jelenthet azokat megosztani valakivel.  \n Mi, kortárssegítők ezért vagyunk itt. Ha szeretnél beszélgetni arról, ami  \n nyomaszt a mindennapokban, akkor bátran keress meg minket",
        "Szia! Zsófia vagyok, pszichológus hallgató és kortárssegítő. Gyakran előfordul, hogy \n  olyan problémákkal találkozunk az életben, amelyekre hirtelen nem tudjuk a \n megoldást, vagy már régóta egy kényelmetlen helyzetben maradva élünk. Szeretnék \n segíteni abban, hogy a problémádat egy másik szemszögből is lásd. Ha szeretnél \n beszélgetni egy kicsit, ha egy kis támogatásra, segítségre van szükséged, írj bátran. \n Nem vagy egyedül :)",
        "Szia! \n Lilla vagyok, harmadéves pszichológia szakos hallgató. Mindannyiunk életében vannak \n olyan problémák, amelyekkel úgy érezzük, hogy nem tudunk megbirkózni. Ha ilyen \n helyzetbe kerülsz, vagy csak egyszerűen beszélgetni szeretnél valakivel, szeretettel \n várlak! Minden erőmmel azon leszek, hogy tanácsot adjak neked, és könnyebbé \n tegyem az életed.",
        "Szia! \n Zsuzsa vagyok, harmadéves pszichológushallgató. Szerintem mindenkinek vannak \n problémái, sokszor meglepőbbek, mint gondolnánk, csak mindig azt hisszük, hogy \n ilyen is csak velünk történhet… Ezért nem beszélünk róla, esetleg megpróbálunk úgy \n tenni, mintha nem is létezne, aztán mindig van egy pont, amikor rájövünk, hogy ez \n csak ront a helyzeten. Ilyenkor próbálunk meg segíteni magunkon, vagy segítséget \n keresni. Ha úgy gondolod, hogy beszélgetnél ezekről, vagy bármi másról, ami neked \n jól esik (mert beszélgetni mindig jó ), várom jelentkezésed!",
        "Sziasztok! Barbi vagyok, harmadéves pszichológushallgató. Életünkben bármikor \n akadhatnak olyan problémák, melyeket nem tudunk megoldani. Ilyenkor jól jöhet, ha \n van valaki, akivel megoszthatjuk gondjainkat, hiszen gyakran már az is segít, ha beszélhetünk a problémáról – legyen szó tanulásról, családról, barátokról, \n párkapcsolatról. Ha úgy érzed, szükséged van valakire, aki meghallgat, írj bátran!"};

        protected void Page_Load(object sender, EventArgs e)
        {
            bemutatkozas.Text = bemutatkozok[segitok.SelectedIndex];
        }

        protected void kuld_Click(object sender, EventArgs e)
        {
            SendSimpleMessage(Tnev.Text,mailcim.Text, segitok.SelectedValue,uzenet.Text);
        }
        public static void SendSimpleMessage(string nev, string cim, string segito, string szoveg)
        {
            RestClient client = new RestClient();
            client.BaseUrl = "https://api.mailgun.net/v2";
            client.Authenticator =
                    new HttpBasicAuthenticator("api",
                                               "key-01dodknzbg0c770cdh9hlcyhgqa0vjx9");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                 "happynet.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", nev+" <"+cim+">");
            request.AddParameter("to",segito);
            request.AddParameter("subject", nev+" a segítségre vár!");
            request.AddParameter("text", szoveg + "\n A RE-mail facebookos alkalmazással küldve");
            request.Method = Method.POST;
            client.Execute(request);
        }

        protected void segitok_SelectedIndexChanged(object sender, EventArgs e)
        {
            bemutatkozas.Text = bemutatkozok[segitok.SelectedIndex];
        }

    }
}