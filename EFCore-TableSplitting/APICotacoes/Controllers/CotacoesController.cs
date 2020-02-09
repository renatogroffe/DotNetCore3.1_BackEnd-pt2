using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APICotacoes.Data;
using APICotacoes.Models;

namespace APICotacoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotacoesController : ControllerBase
    {
        private MoedasContext _context;

        public CotacoesController(MoedasContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Cotacao Get(string id)
        {
            return _context.Cotacoes
                .Where(c => c.Sigla == id)
                .FirstOrDefault();
        }

        [HttpGet]
        public IEnumerable<Cotacao> GetAll()
        {
            return _context.Cotacoes;
        }
    }
}