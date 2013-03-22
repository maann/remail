using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using RestSharp;

namespace mail
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static void SendSimpleMessage()
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
            request.AddParameter("from", "Excited User <daemon@happynet.mailgun.org>");
            request.AddParameter("to", "v.mark.mario@gmail.com");
            request.AddParameter("subject", "Hello");
            request.AddParameter("text", "Testing some Mailgun awesomness!");
            request.Method = Method.POST;
            client.Execute(request);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void kuld_Click(object sender, EventArgs e)
        {
            SendSimpleMessage();
        }
    }
}