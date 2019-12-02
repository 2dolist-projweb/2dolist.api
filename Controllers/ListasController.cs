using System.Collections.Generic;
using System.Linq;
using api.DBContext;
using api.Dtos;
using api.Models;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("{id}", Name = "GetLista")]
        public ActionResult<Lista> Get(int id)
        {
            Lista lista = _context.Listas.Find(id);
            if (lista != null)
            {
                return Ok(lista);
            }

            return NotFound();            
        }
        
        [HttpPost]
        public IActionResult Post(ListaInsercaoDTO lista)
        {
            Lista dbLista = new Lista();
            dbLista.DataCriacao = lista.DataCriacao;
            dbLista.Prioridade = lista.Prioridade;
            dbLista.DataFinalizacao = lista.DataFinalizacao;
            dbLista.DataUltimaAtualizacao = lista.DataUltimaAtualizacao;
            dbLista.Descricao = lista.Descricao;
            dbLista.Finalizada = false;
            dbLista.Observacao = lista.Observacao;

            _context.Listas.Add(dbLista);
            _context.SaveChanges();


            return CreatedAtRoute("GetLista", new {controller = "listas", id = dbLista.ID}, dbLista);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Lista lista = _context.Listas.Find(id);
            if (lista == null)
            {
                return NotFound();
            }

            _context.Tarefas.RemoveRange(_context.Tarefas.Where(x => x.Lista.ID == id));
            _context.Listas.Remove(lista);
            
            _context.SaveChanges();

            return Ok();
        }
    }
}