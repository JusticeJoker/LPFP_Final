using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFP.API.Exceptions
{
    public class JogadorNaoExisteException : EntidadeNaoEncontradaExecption
    {

        public override string Message => "Este Jogador não existe na base de dados";
    }
}
