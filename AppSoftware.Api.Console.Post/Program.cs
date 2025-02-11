// See https://aka.ms/new-console-template for more information
using AppSoftware.Api.Core;
using System.Net.Http.Json;

Console.WriteLine("Hello, Http Post request!");

string url = "http://localhost:3000/api/questions";

using(HttpClient client = new HttpClient())
{
    Question question = new Question
    {
        Title = "My super dooper question",
        Tags = "super, dooper"
    };

    try
    {
        client.DefaultRequestHeaders.Add("X-API-KEY", "letmein");
        HttpResponseMessage response = await client.PostAsJsonAsync(url, question);
        response.EnsureSuccessStatusCode();
    }
    catch(HttpRequestException ex)
    {
        Console.WriteLine("http request error: " + ex.Message);
    }
    catch (Exception ex) {
        Console.WriteLine("other error (json parse?): " + ex.Message);
    }
}