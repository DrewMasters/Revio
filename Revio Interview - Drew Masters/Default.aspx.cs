using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    JToken weather;
    JObject forecast, simpleforecast, dateouter, avewind;
    JObject day1, day2, day3, day4;
    JArray forecastday;
    string date1, conditions1, mphwind1, icon_url1;
    string date2, conditions2, mphwind2, icon_url2;
    string date3, conditions3, mphwind3, icon_url3;
    string date4, conditions4, mphwind4, icon_url4;
    string city, state;
    private static string apicall = "http://api.wunderground.com/api/1cff1d23f9e63f4e/forecast/q/";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void clear_page()
    {
        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = "";
        Label4.Text = "";
        Label5.Text = "";
        Label6.Text = "";
        Label7.Text = "";
        Label8.Text = "";
        Label9.Text = "";
        Label10.Text = "";
        Label11.Text = "";
        Label12.Text = "";
        Label13.Text = "";
        Image1.ImageUrl = "";
        Image2.ImageUrl = "";
        Image3.ImageUrl = "";
        Image4.ImageUrl = "";
    }

    protected async void Button1_Click(object sender, EventArgs e)
    {
        clear_page();
        string u, month, day, year;
        int j, k, l, m;
        city = TextBox1.Text;
        state = TextBox2.Text;
        city = city.Replace(" ", "_");

        u = apicall + state + "/" + city + ".json";

        HttpClient client = new HttpClient(new HttpClientHandler());
        HttpResponseMessage response = client.GetAsync(u).Result;

        if (response.IsSuccessStatusCode)
        {
            weather = JToken.Parse(await response.Content.ReadAsStringAsync());

            try
            {
                forecast = weather["forecast"].Value<JObject>();

                simpleforecast = forecast["simpleforecast"].Value<JObject>();
                forecastday = simpleforecast["forecastday"].Value<JArray>();

                day1 = forecastday[0].Value<JObject>();
                day2 = forecastday[1].Value<JObject>();
                day3 = forecastday[2].Value<JObject>();
                day4 = forecastday[3].Value<JObject>();

                dateouter = day1["date"].Value<JObject>();
                month = dateouter["monthname"].Value<String>();
                day = dateouter["day"].Value<String>();
                year = dateouter["year"].Value<String>();
                date1 = month + " " + day + ", " + year;
                icon_url1 = day1["icon_url"].Value<String>();
                conditions1 = day1["conditions"].Value<String>();
                avewind = day1["avewind"].Value<JObject>();
                mphwind1 = avewind["mph"].Value<String>();

                Label1.Text = date1;
                Label2.Text = conditions1;
                Image1.ImageUrl = icon_url1;
                Label3.Text = mphwind1 + " mph";

                dateouter = day2["date"].Value<JObject>();
                month = dateouter["monthname"].Value<String>();
                day = dateouter["day"].Value<String>();
                year = dateouter["year"].Value<String>();
                date2 = month + " " + day + ", " + year;
                icon_url2 = day1["icon_url"].Value<String>();
                conditions2 = day2["conditions"].Value<String>();
                avewind = day2["avewind"].Value<JObject>();
                mphwind2 = avewind["mph"].Value<String>();

                Label4.Text = date2;
                Label5.Text = conditions2;
                Image2.ImageUrl = icon_url2;
                Label6.Text = mphwind2 + " mph";

                dateouter = day3["date"].Value<JObject>();
                month = dateouter["monthname"].Value<String>();
                day = dateouter["day"].Value<String>();
                year = dateouter["year"].Value<String>();
                date3 = month + " " + day + ", " + year;
                icon_url3 = day3["icon_url"].Value<String>();
                conditions3 = day3["conditions"].Value<String>();
                avewind = day3["avewind"].Value<JObject>();
                mphwind3 = avewind["mph"].Value<String>();

                Label7.Text = date3;
                Label8.Text = conditions3;
                Image3.ImageUrl = icon_url3;
                Label9.Text = mphwind3 + " mph";

                dateouter = day4["date"].Value<JObject>();
                month = dateouter["monthname"].Value<String>();
                day = dateouter["day"].Value<String>();
                year = dateouter["year"].Value<String>();
                date4 = month + " " + day + ", " + year;
                icon_url4 = day4["icon_url"].Value<String>();
                conditions4 = day4["conditions"].Value<String>();
                avewind = day4["avewind"].Value<JObject>();
                mphwind4 = avewind["mph"].Value<String>();

                Label10.Text = date4;
                Label11.Text = conditions4;
                Image4.ImageUrl = icon_url4;
                Label12.Text = mphwind4 + " mph";
            }
            catch
            {
                Label13.Text = "There has been an error please check city and state spelling";
            }
        }
        else
        {
            Label1.Text = "ERROR";
            Label2.Text = "ERROR";
            Label3.Text = "ERROR";
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}