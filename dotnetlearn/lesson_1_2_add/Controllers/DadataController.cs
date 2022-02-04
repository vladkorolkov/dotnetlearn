using Microsoft.AspNetCore.Mvc;
using Dadata;
using Dadata.Model;

namespace lesson_1_2_add.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadataController : Controller
    {
        private readonly string Token = "2dee0cdd0703e88bd28fd6b064629ee65d7fb225";
        private readonly string Secret = "638e0c0799ce0d1fcd992ac7000b336aa7a93f65";
      
        
        [HttpGet]
        public string Get([FromQuery] string query)
        {
            var api = new SuggestClient(Token);
            string partyName = api.FindParty(query).suggestions[0].value; ;
            return partyName;
        }
        [HttpPost]
        public string Post([FromQuery] string query)
        {
            var api = new SuggestClient(Token);
            string partyName = api.FindParty(query).suggestions[0].value; ;
            return partyName;
            
        }
         
    }
}
