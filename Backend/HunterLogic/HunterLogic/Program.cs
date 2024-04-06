namespace HunterLogic;
using System.Net;
class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Sending request ...");
        CheckThis();
        Console.ReadKey();
    }

    private static async void CheckThis()
    {
        HttpClient client = new HttpClient();
        string APIString = "https://fxmarketapi.com/apilive?api_key=ujuSghNweo0JX72IvPmZ";
        string Response = await client.GetStringAsync(APIString);
        Console.WriteLine(Response);
    }
}

