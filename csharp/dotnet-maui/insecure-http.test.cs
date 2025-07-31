using System.Net.Http;
using System.Threading.Tasks;

public class ApiService {
    public async Task Fetch() {
        var client = new HttpClient();
        // ruleid: dotnet-maui-insecure-http
        var resp = await client.GetAsync("http://insecure.example.com/data");
    }
}
