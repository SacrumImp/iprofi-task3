using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Abstractions.Data.Input;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Entity;
using Entity.Entities;

namespace task1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Promo : ControllerBase
    {
        private readonly ILogger<Promo> _logger;
        private DbSqlContext _context;

        public Promo(ILogger<Promo> logger, DbSqlContext context)
        {
            _logger = logger;
            _context = context;
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        public async Task<IActionResult> AddPromo([FromBody] PomoInput promo)
        {
            Promotion newPromo = new Promotion() { name = promo.Name, description = promo?.Description };
            _context.Promotion.Add(newPromo);
            _context.SaveChanges();
            int id = newPromo.id;
            return Ok(id);
        }
    }
}
