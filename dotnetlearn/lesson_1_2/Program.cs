using Dadata;
using Dadata.Model;

var token = "2dee0cdd0703e88bd28fd6b064629ee65d7fb225";
var secret = "638e0c0799ce0d1fcd992ac7000b336aa7a93f65";
Console.WriteLine("Введите ИНН организации: ");
var query = Console.ReadLine();
GetInfo(query, token);

Console.ReadLine();

static async void GetInfo(string inn, string token)
{
    var api = new SuggestClientAsync(token);
    var response = await api.FindParty("7707083893");
    var partyName = response.suggestions[0].value;
    Console.WriteLine(partyName);
}