public class Program
{
    public static void Main(string[] args)
    {
        printResponseAsync("https://google.com");
        printResponseAsync("https://ya.ru");
        printResponseAsync("https://time100.com");
    }

    public static void printResponseAsync(string url)
    {
        Task<string> responseTask = getHttpResponse(url);
        responseTask.Wait();
        Console.WriteLine(responseTask.Result);
    }

    public async static Task<string> getHttpResponse(string url)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }
}