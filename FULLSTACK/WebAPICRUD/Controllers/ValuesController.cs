using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> names = new() { "Tom", "Alice", "Sam", "Kate" };
        [HttpGet]
        public IEnumerable<string> getValues()
        {
            return names;
        }
        [HttpGet("{index}")]
        public string getValue(int index)
        {
             return names[index];
        }
    }
}
