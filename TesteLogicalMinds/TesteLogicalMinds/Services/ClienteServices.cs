using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TesteLogicalMinds.Contexts;
using TesteLogicalMinds.Models;
using TesteLogicalMinds.Repositories;
using TesteLogicalMinds.Services.Interfaces;

namespace TesteLogicalMinds.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly BancoContext _context;

        public ClienteServices()
        {
        }

        public ClienteServices(BancoContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        { 
            return await new ClienteRepository(_context)
                .GetClientes();
        }
        
    }
}
