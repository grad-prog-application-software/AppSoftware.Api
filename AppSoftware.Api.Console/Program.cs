// See https://aka.ms/new-console-template for more information
using AppSoftware.Api.Console;
using AppSoftware.Api.Core;

//using Newtonsoft.Json;
using System.Net;
using System.Text.Json;

Console.WriteLine("Hello, Chuck Norris!");

string url = "https://api.chucknorris.io/jokes/random";

using (WebClient client = new WebClient())
{
    try
    {
        string response = client.DownloadString(url);
        Joke joke = JsonSerializer.Deserialize<Joke>(response);
        Console.WriteLine(joke.Value);
    }
    catch (WebException ex)
    {
        Console.WriteLine("error in code: " + ex.Message);
    }
    catch (Exception ex) { 
    
    }
}
