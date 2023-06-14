using Microsoft.AspNetCore.Mvc;

namespace MercaExpress.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Obtenemos todos los products";
        }

        [HttpPost]
        public string Post([FromBody] string value)
        {
            return $"Creamos el product: {value}";
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return $"Actualizamos el product: {value}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Eliminamos el product: {id}";
        }
    }
}