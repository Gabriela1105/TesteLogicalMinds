using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLogicalMinds.Models;

namespace TesteLogicalMinds.Services.Interfaces
{
    public interface IClienteServices
    {
        Task<ActionResult<IEnumerable<Cliente>>> GetClientes();
    }
}
