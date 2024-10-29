using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Core;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Xml.Serialization;

namespace LB5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Access_token;
        string UserID;
        public MainWindow()
        {
            InitializeComponent();
        }
        private string GET(string Url, string Method, string Token)
        {
            WebRequest req = WebRequest.Create(String.Format(Url, Method, Token));
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            return Out;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string appId = "51802718";
            var uriStr = @"https://oauth.vk.com/authorize?client_id=" + appId +
            @"&scope=offline&redirect_uri=https://oauth.vk.com/blank.html&display=page&v=5.6&response
_type=token";
            Browser.NavigateToString(uriStr);
            Browser.CoreWebView2.Navigate(uriStr);
            //Browser.Navigate(new Uri(uriStr));
        }


        private void WebView2_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.Uri.Contains(@"oauth.vk.com/blank.html"))
            {

                string url = e.Uri.Trim('#');
                url = new Uri(url).Fragment;
                Access_token = HttpUtility.ParseQueryString(url).Get("#access_token");
                NameValueCollection ts = HttpUtility.ParseQueryString(url);
                UserID = HttpUtility.ParseQueryString(url).Get("user_id");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Access_token != null)
            {
                string reqStrTemplate = "https://api.vk.com/method/{0}?access_token={1}&v=5.199";
                string method = "account.getProfileInfo";
                string f = GET(reqStrTemplate, method, Access_token);
                var user = JsonConvert.DeserializeObject<Response>(f);
                StringBuilder stroka = new StringBuilder();
                stroka.Append(user._user.LastName + " "
                + user._user.FirstName + " "
                + user._user.BDate + " "
                + user._user.Status + " ");
                textBox1.Text = stroka.ToString();
            }

        }
        public class Response
        {
            [JsonProperty("response")]
            public User _user { get; set; }
        }
        public class User
        {
            [JsonProperty("last_name")]
            public string LastName { get; set; }
            [JsonProperty("first_name")]
            public string FirstName { get; set; }
            [JsonProperty("bdate")]
            public string BDate { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Access_token != null)
            {
                string reqStrTemplate = "https://api.vk.com/method/{0}?access_token={1}&v=5.199&fields=first_name";
                string method = "friends.get";
                string f = GET(reqStrTemplate, method, Access_token);
                var friends = JsonConvert.DeserializeObject(f) as JObject;
                StringBuilder stroka = new StringBuilder();
                //   var list= user.ToObject<List<User>>();
                JArray arr = (JArray)friends["response"]["items"];
                for (int i = 0; i < arr.Count; i++)
                {
                    JObject element = (JObject)arr[i];
                    string first_name = (string)element["first_name"];
                    string last_name = (string)element["last_name"];
                    stroka.Append(first_name + " " + last_name + " \n");
                }
                // stroka.Append(arr["first_name"] + " "  + arr["last_name"] + " " );
                textBox1.Text = stroka.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Access_token != null)
            {
                string reqStrTemplate = "https://api.vk.com/method/{0}?access_token={1}&v=5.199&fields=name";
                string method = "groups.get";
                string f = GET(reqStrTemplate, method, Access_token);
                var groupsid = JsonConvert.DeserializeObject(f) as JObject;
                //   var list= user.ToObject<List<User>>();
                JArray idarr = (JArray)groupsid["response"]["items"];

                method = "groups.getById";
                StringBuilder stroka = new StringBuilder();
                for (int i = 0; i < idarr.Count; i++)
                {
                    reqStrTemplate = "https://api.vk.com/method/{0}?access_token={1}&v=5.199&fields=name&group_id=" + idarr[i].ToString();
                    f = GET(reqStrTemplate, method, Access_token);
                    var group = JsonConvert.DeserializeObject(f) as JObject;
                    JArray arr2 = (JArray)group["response"]["groups"];
                    string first_name = (string)arr2[0]["name"];
                    stroka.Append(first_name + "\n");
                    Thread.Sleep(300);
                    //   string last_name = (string)element["last_name"];
                }
                // stroka.Append(arr["first_name"] + " "  + arr["last_name"] + " " );
                textBox1.Text = stroka.ToString();
            }
        }
        public class Boardgame
        {
            [JsonProperty("gameid")]
            public string GameId { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("description")]
            public string Description { get; set; }
            [JsonProperty("rank")]
            public string Rank { get; set; }

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {

                string reqStrTemplate = "https://bgg-json.azurewebsites.net/thing/224517";
                WebRequest req = WebRequest.Create(reqStrTemplate);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.UTF8);
                string Out = sr.ReadToEnd();
                var game = JsonConvert.DeserializeObject<Boardgame>(Out);
                StringBuilder stroka = new StringBuilder();
                stroka.Append(game.Name );
                Thread.Sleep(200);
            }


        }
    }
}
