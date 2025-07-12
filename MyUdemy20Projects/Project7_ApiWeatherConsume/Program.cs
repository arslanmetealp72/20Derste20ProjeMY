#region Menu_Başlangıcı

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1- Şehir Listesini Getir");
Console.WriteLine("2- Şehir ve Hava Durumu Listesini Getir");
Console.WriteLine("3- Yeni Şehir Ekle");
Console.WriteLine("4- Şehir Silme");
Console.WriteLine("5- Şehir Güncelleme");
Console.WriteLine("6- İd'ye Göre Şehir Getirme");
Console.WriteLine();

#endregion 

string number;

Console.Write("Tercihiniz: ");

number = Console.ReadLine();

if (number == "1")
{
    string url = "https://localhost:7023/api/Weathers\r\n";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach(var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir: {cityName}");
        }
    }
}
if (number == "2")
{
    string url = "https://localhost:7023/api/Weathers\r\n";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string weather = item["temp"].ToString();
            Console.WriteLine($"Şehir: {cityName}, Hava Durumu: {weather}°");
        }
    }
}
if (number == "3")
{
    Console.WriteLine("### Yeni Veri Girişi###");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.Write("Ülke: ");
    country = Console.ReadLine();

    Console.Write("Detay: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = Convert.ToDecimal(Console.ReadLine());


    string url = "https://localhost:7023/api/Weathers\r\n";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
}
if (number == "4")
{
    string url = "https://localhost:7023/api/Weathers?id=";

    Console.WriteLine("### Silmek İstediğiniz Şehrin İd'sini Giriniz ###");
    int id = Convert.ToInt32(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.DeleteAsync(url + id);
        response.EnsureSuccessStatusCode();
    }
}
if (number == "5")
{
    string url = "https://localhost:7023/api/Weathers\r\n";

    Console.WriteLine("### Yeni Veri Girişi###");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;
    int cityId;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.Write("Ülke: ");
    country = Console.ReadLine();

    Console.Write("Detay: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Şehir İd: ");
    cityId = Convert.ToInt32(Console.ReadLine());

    var updatedWeatherValues= new
    {
        CityId = cityId,
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(updatedWeatherValues);
        StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PutAsync("https://localhost:7023/api/Weathers", content);
        response.EnsureSuccessStatusCode();

    }

}
if (number == "6")
{
    string url = "https://localhost:7023/api/Weathers/GetWeatherCityById?id=";

    Console.WriteLine("Bilgini Almak İstediğiniz Şehir İd'sini Giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url + id); 
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject jObject = JObject.Parse(responseBody);
        string cityName = jObject["cityName"].ToString();
        string country = jObject["country"].ToString();
        string detail = jObject["detail"].ToString();
        decimal temp = Convert.ToDecimal(jObject["temp"]);
        Console.WriteLine($"Şehir: {cityName}, Ülke: {country}, Detay: {detail}, Sıcaklık: {temp}°");
    }
}
    Console.Read();
//https://localhost:7023/api/Weathers?id=
//https://localhost:7023/api/Weathers/GetWeatherCityById?id=