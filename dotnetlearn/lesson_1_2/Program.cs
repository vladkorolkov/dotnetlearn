using Dadata;
using Dadata.Model;

bool isWorking = true;
var token = "2dee0cdd0703e88bd28fd6b064629ee65d7fb225";
var secret = "638e0c0799ce0d1fcd992ac7000b336aa7a93f65";
Console.WriteLine("Введите ИНН организации: ");
while (isWorking)
{   
    var query = Console.ReadLine();  
    GetInfo(query, token);
}

static async void GetInfo(string query, string token)
{
    var api = new SuggestClientAsync(token);
    try
    {
        var response = await api.FindParty(query);
        var partyName = response.suggestions[0].value;
        Console.WriteLine("Найдено: "+partyName);
        Console.WriteLine("\nДля нового поиска нажмите любую клавишу");
    }
    catch 
    {
        Console.WriteLine("По вашему запросу ничего не найдено.\n");
        Console.WriteLine("Введите ИНН организации: ");
    }


}