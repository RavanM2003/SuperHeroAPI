using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI___DotNet8.Data;
using SuperHeroAPI___DotNet8.Entities;

namespace SuperHeroAPI___DotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var SuperHeroes = await _context.SuperHeroes.ToListAsync();
            return Ok(SuperHeroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var SuperHero = await _context.SuperHeroes.FindAsync(id);
            if (SuperHero == null) 
            {
                return NotFound("Hero not found ...");
            }
            return Ok(SuperHero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero Hero)
        {
            _context.SuperHeroes.Add(Hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> DeleteHero(int id)
        {
            var SuperHero = await _context.SuperHeroes.FindAsync(id);

            _context.SuperHeroes.Remove(SuperHero);
            await _context.SaveChangesAsync();
            return Ok(SuperHero);
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero Hero)
        {
            var SuperHero = await _context.SuperHeroes.FindAsync(Hero.Id);
            if (SuperHero == null)
            {
                return NotFound("Hero not found ...");
            }
            SuperHero.Name = Hero.Name;
            SuperHero.FirstName = Hero.FirstName;
            SuperHero.LastName = Hero.LastName;
            SuperHero.Place = Hero.Place;
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}
