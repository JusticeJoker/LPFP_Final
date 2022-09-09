using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFP.Entities
{
    public class InformacaoEquipa
    {
        //Construtor da Informação da Equipa
        public InformacaoEquipa(Clubes clube, int vitorias, int derrotas, int pontos)
        {
            this.Clube = clube;
            this.Vitorias = vitorias;
            this.Derrotas = derrotas;
            this.Pontos = pontos;
        }

        /// <summary>
        /// Esta propriedade define e obtem o clube
        /// </summary>
        public Clubes Clube { get; set; }

        /// <summary>
        /// Esta propriedade define e obtem o numero de vitorias
        /// </summary>
        public int Vitorias { get; set; }

        /// <summary>
        /// Esta propriedade define e obtem o numero de derrotas
        /// </summary>
        public int Derrotas { get; set; }

        /// <summary>
        /// Esta propriedade define e obtem o numero de pontos
        /// </summary>
        public int Pontos { get; set; }

        /// <summary>
        /// Este método serve para alterar a mensagem apresentada no ecra da consola
        /// </summary>
        /// <returns>String com a informação da equipa</returns>
        public override string ToString()
        {
            return $"| Clube: {this.Clube} | Vitorias: {this.Vitorias} | Derrotas: {this.Derrotas} | Pontos: {this.Pontos}|";
        }


    }
}
