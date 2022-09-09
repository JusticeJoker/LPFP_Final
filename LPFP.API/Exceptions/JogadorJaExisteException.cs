using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFP.API.Exceptions
{
    public class JogadorJaExisteException : EntidadeJaExisteException
    {

        public override string Message => "Este Jogador já existe na base de dados";

    }
}
