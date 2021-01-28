using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TesteLogicalMinds.Contexts;
using TesteLogicalMinds.Models;

namespace TesteLogicalMinds.Repositories
{
    public class ClienteRepository
    {
        private readonly BancoContext _context;

        public ClienteRepository()
        {
        }

        public ClienteRepository(BancoContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

    }
}
