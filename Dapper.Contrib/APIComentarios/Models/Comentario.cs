using Dapper.Contrib.Extensions;

namespace APIComentarios.Models
{
    [Table("dbo.Comentarios")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Mensagem { get; set; }
    }
}