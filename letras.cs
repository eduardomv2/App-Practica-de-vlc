//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json.Linq;

//public class MusixmatchAPI
//{
//    private readonly string apiKey;
//    private readonly HttpClient client;

//    public MusixmatchAPI(string apiKey)
//    {
//        this.apiKey = apiKey;
//        this.client = new HttpClient();
//    }

//    public async Task<string> GetLyrics(string artist, string track)
//    {
//        string url = $"https://api.musixmatch.com/ws/1.1/matcher.lyrics.get?format=json&apikey={apiKey}&q_track={track}&q_artist={artist}";
//        HttpResponseMessage response = await client.GetAsync(url);
//        string responseBody = await response.Content.ReadAsStringAsync();

//        JObject json = JObject.Parse(responseBody);
//        string lyrics = json["message"]["body"]["lyrics"]["lyrics_body"].ToString();
//        return lyrics;
//    }
//}