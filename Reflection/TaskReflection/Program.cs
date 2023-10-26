using System.Text.Json;

var link = "https://jsonplaceholder.typicode.com/posts";

var client = new HttpClient();

var arr = await client.GetAsync(link);
var body = await arr.Content.ReadAsStringAsync();

var des = JsonSerializer.Deserialize<List<Class1>>(body);
var ser = JsonSerializer.Serialize(des); 

File.WriteAllText("file.txt",ser);

public class Class1
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
}