using System.Net.Http.Headers;
using Newtonsoft.Json;

public static class Program {
    const string url = "https://raw.githubusercontent.com/ladyisatis/one-pace-metadata/refs/heads/v2/data.json";

    static void Main(string[] args) {
        HttpClient client = new HttpClient();
        
        client.DefaultRequestHeaders.Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var responseMsg = client.GetAsync(string.Format(url)).Result;
        responseMsg.EnsureSuccessStatusCode();

        string responseBody = responseMsg.Content.ReadAsStringAsync().GetAwaiter().GetResult();

        var metadata = JsonConvert.DeserializeObject<OnePaceMetadataJson>(responseBody);

        Console.WriteLine(metadata?.Arcs.Count);
    }
}