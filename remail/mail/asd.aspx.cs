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
        "Kedves látogató! Eszter vagyok, harmadéves pszichológia szakos hallgató. Sajnos én \n is észrevettem, hogy ebben a rohanó világban a legnagyobb probléma, hogy az \n embereknek nincs idejük egymásra, nincs idejük beszélgetni. Nekem viszont van, \n és szívesen megosztom veled! Ha szeretnél tanácsot kérni, beszélgetni, vagy csak arra \n vágysz, hogy valaki meghallgasson, keress meg bátran!",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9"};

        protected void Page_Load(object sender, EventArgs e)
        {
            bemutatkozas.Text = segitok.SelectedIndex.ToString();
        }

        protected void kuld_Click(object sender, EventArgs e)
        {
            SendSimpleMessage(Tnev.Text,mailcim.Text, segitok.SelectedValue);
        }
        public static void SendSimpleMessage(string nev, string cim, string segito)
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
            request.AddParameter("subject", nev+" segítségre vár!");
            request.AddParameter("text", "Testing some Mailgun awesomness!");
            request.Method = Method.POST;
            client.Execute(request);
        }

        protected void segitok_SelectedIndexChanged(object sender, EventArgs e)
        {
            bemutatkozas.Text = bemutatkozok[segitok.SelectedIndex];
        }

    }
}