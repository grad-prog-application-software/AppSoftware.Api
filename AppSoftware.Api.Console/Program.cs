// See https://aka.ms/new-console-template for more information

using AppSoftware.Api.Core;

//using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

Console.WriteLine("Hello, Chuck Norris!");

string url = "https://api.chucknorris.io/jokes/random";

using (HttpClient client = new HttpClient())
{
    try
    {
        //HttpResponseMessage response = await client.GetAsync(url);
        //string jsonString = await response.Content.ReadAsStringAsync();
        //Joke joke = JsonSerializer.Deserialize<Joke>(jsonString);

        var joke = await client.GetFromJsonAsync<Joke>(url);
        Console.WriteLine(joke.Value);
    }
    catch (WebException ex)
    {
        Console.WriteLine("error in code: " + ex.Message);
    }
    catch (Exception ex) { 
    
    }
}
