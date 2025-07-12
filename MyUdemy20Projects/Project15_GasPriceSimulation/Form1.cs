using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dieselPrice = 0;
        double gasolinePrice = 0;
        double lpgPrice = 0;
        double gasAmout =0;
        double dieselAmout = 0;
        double lpgAmout = 0;
        double totalPrice =0;
        int count = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmout = Convert.ToDouble(txtGasAmount.Text);
            dieselAmout = Convert.ToDouble(txtGasAmount.Text);
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (rdbGasoline.Checked)
            {   count++;
                if(count <= gasAmout)
                {
                    totalPrice +=gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString();
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString();
                }

                    progressBar1.Value += 1;
                if (progressBar1.Value >= 99)
                {
                    timer1.Stop();
                    MessageBox.Show("Gasoline refueling completed!");
                }
            }

            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= dieselAmout)
                {
                    totalPrice +=dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString();
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString();
                }

                progressBar1.Value += 1;
                if (progressBar1.Value >= 99)
                {
                    timer1.Stop();
                    MessageBox.Show("Diesel refueling completed!");
                }
            }

            if (rdbLpg.Checked)
            {
                count++;
                if (count <= lpgAmout)
                {
                    totalPrice +=lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString("00.0");
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString("00.0");
                }

                progressBar1.Value += 1;
                if (progressBar1.Value >= 99)
                {
                    timer1.Stop();
                    MessageBox.Show("LPG refueling completed!");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CultureInfo tr = new CultureInfo("tr-TR");

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://gas-price.p.rapidapi.com/europeanCountries"),
                Headers =
    {
        { "x-rapidapi-key", "dec608136fmsh2ff91474c40100cp10d0aajsna19e83b2acc7" },
        { "x-rapidapi-host", "gas-price.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var lpg = json["results"][42]["lpg"];
                var gasoline = json["results"][42]["gasoline"];
                var diesel = json["results"][42]["diesel"];
                lpgPrice = Convert.ToDouble(lpg) * 47;
                gasolinePrice = Convert.ToDouble(gasoline) * 47;
                dieselPrice = Convert.ToDouble(diesel) * 47;
                txtDieselPrice.Text = dieselPrice.ToString("00.0");
                txtGasolinePrice.Text = gasolinePrice.ToString("00.0");
                txtLpgPrice.Text = lpgPrice.ToString("00.0");


            }
        }
    }
}
