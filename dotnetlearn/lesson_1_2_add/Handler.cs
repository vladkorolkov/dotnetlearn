using Dadata;
namespace lesson_1_2_add
{
    public class Handler : IGetNameInn
    {
        //private readonly string Token = "2dee0cdd0703e88bd28fd6b064629ee65d7fb225";
        SuggestClient api;
        public Handler()
        {
            api = new SuggestClient("2dee0cdd0703e88bd28fd6b064629ee65d7fb225");
        }
        public string GetNameInn(string queryInn)
        {
            string result = api.FindParty(queryInn).suggestions[0].value;
            return result;
        }
    }
}
