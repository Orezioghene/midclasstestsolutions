using Microsoft.AspNetCore.Mvc;
using midclasstestsoln.MockData;
using System.Linq;

namespace midclasstestsoln.Controllers
{
    public class wine_controller : ControllerBase
    {
        [HttpGet("wines")]

        public IActionResult Getwine()
        {
            var wines = Wine_collection.Wine_collections();
            return Ok(wines);
        }

        [HttpGet("{Name}")]

        public IActionResult GetSingleWine(string name)
        {
            var wine = Wine_collection.Wine_collections().Where(t => t.Name == name).FirstOrDefault();   
            return Ok(wine );
        }

        


    }
}
