using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Project_13WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city?city=bursa&lang=EN"),
                Headers =
    {
        { "x-rapidapi-key", "dec608136fmsh2ff91474c40100cp10d0aajsna19e83b2acc7" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json =JObject.Parse(body);
                var value = json["main"]["temp"].ToString();
                var value2 = json["wind"]["speed"].ToString();
                var value3 = json["main"]["humidity"].ToString();
                lblFahrenheit.Text = value;
                lblWind.Text = value2;
                lblHumidity.Text = value3;
                decimal value4 = (decimal.Parse(value) - 32);
                decimal value5 = (decimal.Parse(value4.ToString()) * 5 / 9);
                lblCelsius.Text = value5.ToString("0.00");
                lblTime.Text = DateTime.Now.ToString("HH:mm");

                switch (json["weather"][0]["main"].ToString())
                {
                    case "Clear":
                        pictureBox1.Image = Properties.Resources.sun;
                        break;
                    case "Clouds":
                        pictureBox1.Image = Properties.Resources.clouds;
                        break;
                    case "Rain":
                        pictureBox1.Image = Properties.Resources.rain;
                        break;
                    case "Snow":
                        pictureBox1.Image = Properties.Resources.snowy;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
