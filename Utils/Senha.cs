using System.Security.Cryptography;
using System.Text;

namespace AppBarganhaWEB.Utils
{
    public class Senha
    {
        public static string GeraHash(string senha)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                var senhaHash = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(senha));

                return Encoding.ASCII.GetString(senhaHash);
            }
        }
    }
}
