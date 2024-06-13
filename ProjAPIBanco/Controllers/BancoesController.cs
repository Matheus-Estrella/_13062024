using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjAPIBanco.Data;
using ProjAPIBanco.Service;

namespace ProjAPIBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoesController : ControllerBase
    {
        private readonly ProjAPIBancoContext _context;
        private readonly BancoService _bancoService;

        public BancoesController(BancoService bs)
        {
            _bancoService = bs;
        }
        //}public BancoesController(ProjAPIBancoContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Bancoes

        [HttpGet]

        //public async Task<ActionResult<IEnumerable<Banco>>> GetBanco()
        //{
        //  if (_context.Banco == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.Banco.ToListAsync();
        //}

        public ActionResult<List<Banco>> GetBanco(Banco banco) => _bancoService.GetBanco();

        // GET: api/Bancoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Banco>> GetBanco(string id)
        {
          if (_context.Banco == null)
          {
              return NotFound();
          }
            var banco = await _context.Banco.FindAsync(id);

            if (banco == null)
            {
                return NotFound();
            }

            return banco;
        }

        // PUT: api/Bancoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBanco(string id, Banco banco)
        {
            if (id != banco.cnpj)
            {
                return BadRequest();
            }

            _context.Entry(banco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BancoExists(id))
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

        // POST: api/Bancoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]

        public ActionResult<Banco> PostBanco(Banco banco)
        {
            _bancoService.Create(banco);
            return Ok(banco);
        }

        //public async Task<ActionResult<Banco>> PostBanco(Banco banco)
        //{
        //  if (_context.Banco == null)
        //  {
        //      return Problem("Entity set 'ProjAPIBancoContext.Banco'  is null.");
        //  }
        //    _context.Banco.Add(banco);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (BancoExists(banco.cnpj))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetBanco", new { id = banco.cnpj }, banco);
        //}

        // DELETE: api/Bancoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBanco(string id)
        {
            if (_context.Banco == null)
            {
                return NotFound();
            }
            var banco = await _context.Banco.FindAsync(id);
            if (banco == null)
            {
                return NotFound();
            }

            _context.Banco.Remove(banco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BancoExists(string id)
        {
            return (_context.Banco?.Any(e => e.cnpj == id)).GetValueOrDefault();
        }
    }
}
