﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteLogicalMinds.Contexts;
using TesteLogicalMinds.Models;
using TesteLogicalMinds.Services;
using TesteLogicalMinds.Services.Interfaces;

namespace TesteLogicalMinds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly BancoContext _context;
        private readonly IClienteServices _cliente;

        public ClienteController(BancoContext context)
        {
            _context = context;
            _cliente = new ClienteServices(_context);
        }

        // GET: api/Cliente
        [HttpGet("all")]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            try
            {
                var result = _cliente.GetClientes().Result;
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // GET: api/Cliente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            try
            {
                var cliente = await _context.Clientes.FindAsync(id);

                if (cliente == null)
                {
                    return NotFound();
                }

                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // PUT: api/Cliente/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Clientes.Any(e => e.Id == id))
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

        // POST: api/Cliente
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("save")]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE: api/Cliente/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cliente>> DeleteCliente(int id)
        {
            try
            {
                var cliente = await _context.Clientes.FindAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }

                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();

                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
