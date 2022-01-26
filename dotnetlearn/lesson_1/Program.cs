using System.Text.Json;
using System.Text.Json.Serialization;
namespace lesson_1;
public class Program
{
    public static void Main()
    {
        var file = File.ReadAllText("all_deals.json");

        Deal[] deals = JsonSerializer.Deserialize<Deal[]>(file);

        var numdersOfDeals = GetNumbersOfDeal(deals);

    }

    public static List<string> GetNumbersOfDeal(Deal[] deals)
    {

        var q = (from d in deals
                 where d.Sum > 100
                 orderby d.Date, d.Sum
                 select d.Id).Take(5).ToList<string>();

        return q;
    }


}
