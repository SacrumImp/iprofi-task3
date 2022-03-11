using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Abstractions.Data.Input;
using System.Threading.Tasks;
using System.Linq;
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


        [HttpPost]
        public IActionResult AddPromo([FromBody] PromoInput promo)
        {
            Promotion newPromo = new Promotion() { name = promo.Name, description = promo?.Description };
            _context.Promotion.Add(newPromo);
            _context.SaveChanges();
            int id = newPromo.id;
            return Ok(id);
        }

        [HttpGet]
        public IActionResult GetPromotions()
        {
            var promotions = _context.Promotion.Select(prom => prom);
            return Ok(promotions);
        }

        [HttpGet("{id?}")]
        public IActionResult GetPromotion([FromRoute] int? id)
        {
            var promo = _context.Promotion.Where(prom => prom.id == id).Select(prom => new
            {
                id = prom.id,
                name = prom.name,
                description = prom.description,
                prizes = _context.Prize.Where(prize => _context.Promo_Prize.Where(prom_prize => (prom_prize.promo == prom.id) && (prom_prize.prize == prize.id)).AsEnumerable() != null),
                participants = _context.Participant.Where(participant => _context.Promo_Participant.Where(prom_participant => (prom_participant.promo == prom.id) && (prom_participant.participant == participant.id)).AsEnumerable() != null)
            }
            );

            return Ok(promo);
        }

        [HttpPut("{id?}")]
        public IActionResult UpdatePromotion([FromRoute] int? id, [FromBody] PromoInput promo)
        {
            var promotion = _context.Promotion.Where(prom => prom.id == id).FirstOrDefault();
            promotion.name = promo.Name;
            promotion.description = promo.Description;
            _context.SaveChanges();
            return Ok();
        }
    }
}
