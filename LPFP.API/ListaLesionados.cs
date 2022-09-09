using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPFP.Entities;
using LPFP.API.Exceptions;

namespace LPFP.API
{
    class ListaLesionados : List<Jogador>
    {
        List<Jogador> jogadoreslesionados = new List<Jogador>();

        public new void Add(Jogador jogador)
        {
            if (this.Exists(j => j.PrimeiroNome + j.UltimoNome == jogador.PrimeiroNome + jogador.UltimoNome))
                throw new JogadorJaExisteException();

            base.Add(jogador);
        }
    }
}
