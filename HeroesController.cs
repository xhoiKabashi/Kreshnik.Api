using Kreshnik.Api.Data;
using Kreshnik.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreshnik.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly GameDbContext _context;

        public HeroesController(GameDbContext context)
        {
            _context = context;
        }

        // POST: api/Heroes/FetchOrCreate
        [HttpPost("FetchOrCreate")]
        public async Task<ActionResult<Hero>> FetchOrCreateHero([FromBody] HeroLoginRequest loginRequest)
        {
            var hero = await _context.Heroes.FirstOrDefaultAsync(h => h.Name == loginRequest.PlayerName);

            if (hero != null)
            {
                if (hero.UserPin == loginRequest.Password)
                {
                    return Ok(hero);
                }
                else
                {
                    return Unauthorized("Incorrect PIN.");
                }
            }

            hero = new Hero
            {
                Name = loginRequest.PlayerName,
                Hp = 100,
                Dmg = 20,
                Armor = 5,
                Speed = 5,
                Level = 1,
                Points = 5,
                Exp = 0,
                ExpThreshold = 100,
                HeavyCrashLevel = 0,
                TearHealLevel = 0,
                MilkRegeLevel = 0,
                Wins = 0,
                HeavyCrashDmg = 0,
                TearHealHp = 0,
                MilkRegeStats = 0,
                UserId = loginRequest.PlayerName,
                UserPin = loginRequest.Password
            };

            _context.Heroes.Add(hero);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHero), new { id = hero.Id }, hero);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hero>>> GetHeroes()
        {
            return await _context.Heroes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> GetHero(int id)
        {
            var hero = await _context.Heroes.FindAsync(id);

            if (hero == null)
            {
                return NotFound();
            }

            return hero;
        }

        [HttpPost]
        public async Task<ActionResult<Hero>> PostHero(Hero hero)
        {
            _context.Heroes.Add(hero);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHero), new { id = hero.Id }, hero);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            var hero = await _context.Heroes.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }

            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHero(int id, Hero hero)
        {
            if (id != hero.Id)
            {
                return BadRequest();
            }

            _context.Entry(hero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool HeroExists(int id)
        {
            return _context.Heroes.Any(e => e.Id == id);
        }

    }
}
