public class Program
{
    public static void Main(string[] args)
    {
        printResponse("https://google.com");
        printResponse("https://ya.ru");
        printResponse("https://time100.com");
    }

    public static void printResponse(string url)
    {
        Console.WriteLine(getHttpResponse(url));
    }

    public static string getHttpResponse(string url)
    {
        HttpClient client = new HttpClient();
        Task<HttpResponseMessage> response = client.GetAsync(url);
        response.Wait();
        try
        {
            return new StreamReader(response.Result.Content.ReadAsStream()).ReadToEnd();
        } catch (Exception ex)
        {
            return "Could not read st due to exception: " + ex.GetType + "" + ex.Message;
        }
    }
}