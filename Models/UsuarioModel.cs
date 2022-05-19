namespace content_negotiation.Models
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {

        }
        public UsuarioModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}