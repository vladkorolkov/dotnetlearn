using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace lesson_1;
public record SumByMonth(string Date, int Sum);


public class Program
{

    public static void Main()
    {
        Dictionary<int, string> monthNames = new Dictionary<int, string>()
        {
            { 1,"Январь" },
            { 2,"Февраль"},
            { 3,"Март" },
            { 4,"Апрель" },
            { 5,"Май" },
            { 6,"Июнь" },
            { 7,"Июль" },
            { 8,"Август"  },
            { 9,"Сентябрь"  },
            { 10,"Октябрь" },
            { 11,"Ноябрь" },
            { 12,"Декабрь" }
        };

        List<Deal> deals = JsonSerializer.Deserialize<List<Deal>>(File.ReadAllText("all_deals.json"));

        var numdersOfDeals = GetNumbersOfDeal(deals);
        var sumsByMonth = GetSumsByMonth(deals, monthNames);
        Console.WriteLine("Найдены id первых пяти сделок:\n");
        foreach (var deal in numdersOfDeals)
        {
            Console.WriteLine($"{deal}");
        }

        Console.WriteLine("\n\nСумма сделок помесячно:");
        var dealsByMonth = GetSumsByMonth(deals, monthNames);
        foreach (var date in dealsByMonth)
        {
            Console.WriteLine($"\n{date.Date} : {date.Sum}");
        }
        Console.ReadLine();

    }

    public static List<string> GetNumbersOfDeal(List<Deal> deals)
    {
        //var result = (from d in deals
        //              where d.Sum > 100
        //              orderby d.Date, d.Sum
        //              select d.Id).Take(5).ToList<string>();

        var result = deals
            .Where(d => d.Sum > 100)
            .OrderBy(d => d.Date)
            .ThenBy(d => d.Sum)
            .Select(d => d.Id)
            .Take(5)
            .ToList();
        return result;
    }


    public static List<SumByMonth> GetSumsByMonth(List<Deal> deals, Dictionary<int, string> MonthNames)
    {
        var q = deals
            .GroupBy(x => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.Date.Month))                         
            .Select(y => new SumByMonth(              
                y.Key,
                y.Select(s => s.Sum).Sum()));
        
        return q.ToList();
    }
}
