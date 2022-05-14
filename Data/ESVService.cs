namespace TestProj.Data;

public class ESVService
{
    string API_KEY = "f92debc6118841c5df9bceb0744674e36c0b2f21";
    public async Task<string> GetBibleInfo()
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", API_KEY);
        var response = await client.GetAsync("https://api.esv.org/v3/passage/text/?q=Genesis+1:1");
        string final;
        if(response.IsSuccessStatusCode)
        {
            final = await response.Content.ReadAsStringAsync();
        }
        else
        {
            final = response.StatusCode.ToString();
        }

        return final;
    }
}