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

namespace Project8_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal dollar = 0;
        decimal euro = 0;
        decimal pound = 0;

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Dollar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "dec608136fmsh2ff91474c40100cp10d0aajsna19e83b2acc7" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var result = json["result"].ToString();
                lblDolarKuru.Text ="Dolar: "+ result;
                dollar = decimal.Parse(result);
                //Console.WriteLine(body);
            }
            #endregion

            #region Euro
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "dec608136fmsh2ff91474c40100cp10d0aajsna19e83b2acc7" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var result2 = json2["result"].ToString();
                lblEuroKuru.Text ="Euro: "+ result2;
                euro = decimal.Parse(result2);

            }
            #endregion

            #region Pound

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "dec608136fmsh2ff91474c40100cp10d0aajsna19e83b2acc7" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var result3 = json3["result"].ToString();
                lblSterlinKuru.Text = "Sterlin: " + result3;
                pound = decimal.Parse(result3);

            }
            #endregion

            txtTotalPrice.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            decimal totalPrice = 0;

            if (rdbDollar.Checked)
            {
                totalPrice = unitPrice * dollar;
            }
            if (rdbEuro.Checked)
            {
                totalPrice = unitPrice * euro;
            }
            if (rdbPound.Checked)
            {
                totalPrice = unitPrice * pound;
            }

            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
