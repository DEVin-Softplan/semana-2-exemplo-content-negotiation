using System.Collections.Generic;
using content_negotiation.Models;

namespace content_negotiation.Repositories
{

    public static class UsuarioRepository
    {

        public static List<UsuarioModel> _usuarios = new List<UsuarioModel>
        {
           new UsuarioModel(1, "Joao"),
           new UsuarioModel(2, "Maria"),
           new UsuarioModel(3, "Fernanda"),
        };

        public static List<UsuarioModel> Listar()
        {
            return _usuarios;
        }

        public static void Adicionar(UsuarioModel model)
        {
            _usuarios.Add(model);
        }

    }

}