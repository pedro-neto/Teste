using FagronTech.Context;
using FagronTech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FagronTech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context) { _context = context; }


        [HttpGet]
        public async Task<ActionResult<ClienteCompleto>> Get(int id)
        {
            var cliente = new ClienteCompleto();
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
        [HttpPost]
        public async Task<ActionResult<ClienteCompleto>> Post(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put(int id, ClienteCompleto cliente)
        {
           
            if(id != cliente.ID)
            {
                return BadRequest();
            }
            _context.Entry(cliente).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
