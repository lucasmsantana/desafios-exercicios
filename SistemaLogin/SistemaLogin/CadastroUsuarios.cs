using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {

        private static Usuario[] usuarios =
        {
            new Usuario()
            {
                Nome = "Gabriel",
                Senha = "abc123"
            },
            new Usuario()
            {
                Nome = "Lucas",
                Senha = "123abc"
            },
            new Usuario()
            {
                Nome = "Mel",
                Senha = "abcd"
            }
        };
        private static Usuario _userlogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userlogado; }
            private set { _userlogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)  
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
