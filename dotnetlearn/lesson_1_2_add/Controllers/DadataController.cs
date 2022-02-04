using Microsoft.AspNetCore.Mvc;
using Dadata;
using Dadata.Model;

namespace lesson_1_2_add.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadataController : Controller
    {
        private readonly string token = "2dee0cdd0703e88bd28fd6b064629ee65d7fb225";
        private readonly string secret = "638e0c0799ce0d1fcd992ac7000b336aa7a93f65";
        
        [HttpGet]
        
        public string Get()
        {
            var api = new SuggestClient(token);
            var response =  api.FindParty("6165216796");
            var partyName = response.suggestions[0].value;
            return partyName;
        }

         
    }
}
