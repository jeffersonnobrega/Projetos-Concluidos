using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SabioAPI.Model;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient { BaseAddress = new Uri("https://api.adviceslip.com/") };
        var response = await client.GetAsync("advice");
        var content = await response.Content.ReadAsStringAsync();

        var msg = JsonConvert.DeserializeObject<SabioAPI.Model.SlipContainer>(content);
        Console.WriteLine(msg.Slip.Advice);
        
    }


}





