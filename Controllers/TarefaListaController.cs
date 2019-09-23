using System.Collections.Generic;
using System.Linq;
using api.DBContext;
using api.Dtos;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaListaController : ControllerBase
    {
        private readonly AppDBContext _context;

        public TarefaListaController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet("lista/{id_lista}")]
        public ActionResult <IEnumerable<TarefaLista>> Get(int id_lista)
        {
            IEnumerable<TarefaLista> tarefas = _context.Tarefas
                .Where(x => x.Lista.ID == id_lista)
                .ToList();

            return Ok(tarefas);
        }

        [HttpPost]
        public IActionResult Post(TarefaListaInsercaoDTO itemLista)
        {
            TarefaLista item = new TarefaLista();
            item.DataCriacao = itemLista.DataCriacao;
            item.DataFinalizacao = itemLista.DataFinalizacao;
            item.DataUltimaAtualizacao = itemLista.DataUltimaAtualizacao;
            item.Descricao = itemLista.Descricao;
            item.Finalizada = false;

            Lista lista = _context.Listas.Find(itemLista.IdLista);

            item.Lista = lista;

            _context.Tarefas.Add(item);
            _context.SaveChanges();

            return Ok(item);
        }
    }
}