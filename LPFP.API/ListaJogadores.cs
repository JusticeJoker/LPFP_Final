using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPFP.Entities;
using LPFP.API.Exceptions;

namespace LPFP.API
{
    public class ListaJogadores : List<Jogador>
    {

        List<Jogador> jogadores = new List<Jogador>();

        public new void Add(Jogador jogador)
        {

            if (this.Exists(j => j.PrimeiroNome + j.UltimoNome + j.NumeroJogador == jogador.PrimeiroNome + jogador.UltimoNome + jogador.NumeroJogador))
                throw new JogadorJaExisteException();

            base.Add(jogador);
        }

        
        public new void Remove(Jogador jogador)
        {
            if (this.Exists(j => j.PrimeiroNome + j.UltimoNome + j.NumeroJogador == jogador.PrimeiroNome + jogador.UltimoNome + jogador.NumeroJogador))
                throw new JogadorNaoExisteException();
            
        }

        public Jogador Get(int numeroJogador)
        {
            return this.FirstOrDefault(j => j.NumeroJogador == numeroJogador);
        }

        public List<Jogador> Get(string primeiroNome, string ultimoNome)
        {
            return this.Where(j => (j.PrimeiroNome.Contains(primeiroNome) && j.UltimoNome.Contains(ultimoNome))).ToList();
        }

        public List<Jogador> Get(Clubes clube)
        {
            return this.Where(j => j.Clube.Equals(clube)).ToList();
        }

        public List<Jogador> Get(Escolaridade escolaridade)
        {
            return this.Where(j => j.Escolaridade.Equals(escolaridade)).ToList();
        }


    }
}
