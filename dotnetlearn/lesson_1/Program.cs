using System.Text.Json;
using System.Text.Json.Serialization;
namespace lesson_1;
public class Program
{
    public static void Main()
    {
        var file = File.ReadAllText("all_deals.json");

        List<Deal> deals = JsonSerializer.Deserialize<List<Deal>>(file);

    }
}
