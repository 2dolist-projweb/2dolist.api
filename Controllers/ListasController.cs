using System.Collections.Generic;
using System.Linq;
using api.DBContext;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ListasController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ListasController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Lista>> Get()
        {
            IEnumerable<Lista> listas = _context.Listas.ToList();
            
            return Ok(listas);
        }
    }
}