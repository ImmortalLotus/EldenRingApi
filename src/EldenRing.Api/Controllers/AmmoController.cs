using EldenRing.Domain.Entities;
using EldenRing.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EldenRing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmmoController : ControllerBase
    {
        private readonly EldenContext _eldenContext;
        public AmmoController(EldenContext eldenContext)
        {
            this._eldenContext = eldenContext;
        }

        [HttpGet(Name = "GetAmmos")]
        public IEnumerable<Ammo> GetAmmos()
        {
            Console.WriteLine(_eldenContext.Ammos.Select(x=>x).First().ToString());
            return _eldenContext.Ammos.ToList();
        }
    }
}
