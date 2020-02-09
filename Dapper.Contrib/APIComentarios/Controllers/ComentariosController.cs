using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper.Contrib.Extensions;
using APIComentarios.Models;

namespace APIComentarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentariosController : ControllerBase
    {
        private IConfiguration _config;

        public ComentariosController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet("todos")]
        public IEnumerable<Comentario> GetComentarios()
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseComentarios")))
            {
                return conexao.GetAll<Comentario>();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Comentario> Get(int id)
        {
            Comentario comentario;
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseComentarios")))
            {
                comentario = conexao.Get<Comentario>(id);
            }

            if (comentario != null)
                return comentario;
            else
                return NotFound(
                    new { Mensagem = "Comentário não encontrado" });
        }

        [HttpPost]
        public ActionResult Post(Comentario comentario)
        {            
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("BaseComentarios")))
            {
                conexao.Insert<Comentario>(comentario);
            }

            return Ok();
        }
    }
}