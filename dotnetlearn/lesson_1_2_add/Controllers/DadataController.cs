using Microsoft.AspNetCore.Mvc;
using Dadata;
using lesson_1_2_add;

namespace lesson_1_2_add.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadataController : Controller
    {
       
        //private readonly string Secret = "638e0c0799ce0d1fcd992ac7000b336aa7a93f65";
       
        
        [HttpGet]
        public string Get([FromQuery] string query)
        {
            var api = new Handler();
            string partyName = api.GetNameInn(query);
   
            return partyName;

        }
        [HttpPost]
        public string Post([FromQuery] string query)
        {
            var api = new Handler();
            string partyName = api.GetNameInn(query); 
            return partyName;
            
        }
         
    }
}
