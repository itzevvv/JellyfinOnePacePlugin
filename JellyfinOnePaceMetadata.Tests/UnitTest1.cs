using System.Net.Http.Headers;
using System.Threading.Tasks;
using JellyfinOnePaceMetadata.Model;
using Newtonsoft.Json;

namespace JellyfinOnePaceMetadata.Tests;

public class UnitTest1 {
    const string url = "https://raw.githubusercontent.com/ladyisatis/one-pace-metadata/refs/heads/v2/data.json";

    [Fact]
    public async Task Test1() {
         HttpClient client = new HttpClient();
        
        client.DefaultRequestHeaders.Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var responseMsg = await client.GetAsync(string.Format(url), TestContext.Current.CancellationToken);
        responseMsg.EnsureSuccessStatusCode();

        string responseBody = await responseMsg.Content.ReadAsStringAsync(TestContext.Current.CancellationToken);

        var metadata = JsonConvert.DeserializeObject<OnePaceMetadataJson>(responseBody);

        Console.WriteLine($"{metadata?.Episodes.Count} episodes!");
        Assert.True(true);
    }
}
