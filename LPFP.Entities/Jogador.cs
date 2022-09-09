using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFP.Entities
{
    public class Jogador : Pessoa
    {
        //Contructor de Jogadores
        public Jogador(string primeiroNome, string ultimoNome, DateTime dataNascimento, int numeroJogador, double peso, double altura, Escolaridade escolaridade, Clubes clube, bool lesionado, DateTime testeDoping, DateTime mesFimContratacao, string competicao, string historicoContratacoes) : base(primeiroNome, ultimoNome, dataNascimento)
        {
            this.NumeroJogador = numeroJogador;
            this.Peso = peso;
            this.Altura = altura;
            this.Escolaridade = escolaridade;
            this.Lesionado = lesionado;
            this.HistoricoContratacoes = historicoContratacoes;
            this.MesFimContratacao = mesFimContratacao;
            this.TesteDoping = testeDoping;
            this.Competicao = competicao;
            this.Clube = clube;
        }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o peso do jogador
        /// </summary>
        public double Peso { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o número da camisola do jogador
        /// </summary>
        public int NumeroJogador { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter a altura do jogador
        /// </summary>
        public double Altura { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter a escolaridade do jogador
        /// </summary>
        public Escolaridade Escolaridade { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o clube do jogador
        /// </summary>
        public Clubes Clube { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter se o jogador esta lesionado
        /// </summary>
        public bool Lesionado { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o historico de contratações do jogador
        /// </summary>
        public string HistoricoContratacoes { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o tempo de contrato do jogador
        /// </summary>
        public DateTime MesFimContratacao { get; set; }
       
        /// <summary>
        /// Calcula o tempo de contrato que o jogador tem
        /// </summary>
        public int DataDeContrato
        {
            get
            {
                return this.MesFimContratacao.Month - DateTime.Now.Month;
            }
        }

        /// <summary>
        /// Esta propriedade serve para definir ou obter a ultima data que o jogador fez o teste de anti-doping
        /// </summary>
        public DateTime TesteDoping { get; set; }

        /// <summary>
        /// Calcula o numero de dias que o jogador já não faz o teste anti-doping
        /// </summary>
        public int UltimaDataDoping
        {
            get
            {
                return DateTime.Now.DayOfYear - this.TesteDoping.DayOfYear;
            }
        }

        /// <summary>
        /// Esta propriedade serve para definir ou obter as competições em que o jogador esta incrito
        /// </summary>
        public string Competicao { get; set; }

        /// <summary>
        /// Este método serve para alterar a mensagem apresentada no ecra da consola
        /// </summary>
        /// <returns>String com o perfil do jogador</returns>
        public override string ToString()
        {
            return $"\n Nome: {this.PrimeiroNome} {this.UltimoNome}\n Idade: {this.Idade} Anos\n Altura: {this.Altura} metros\n Peso: {this.Peso} Kg\n Numero de Jogador: {this.NumeroJogador}\n Escolaridade: {this.Escolaridade}\n Clube: {this.Clube}\n Tempo de contrato: {this.DataDeContrato} meses\n Lesionado: {this.Lesionado}\n Ultimo teste Doping: {this.UltimaDataDoping} dias\n Competicoes incritas: {this.Competicao}\n\n Historico de contratações: {this.HistoricoContratacoes}\n";
        }

    }
}
