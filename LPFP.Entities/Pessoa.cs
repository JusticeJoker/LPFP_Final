using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFP.Entities
{
    public abstract class Pessoa
    {
        /// <summary>
        /// Contrutor para pessoa
        /// </summary>
        /// <param name="primeiroNome">Primeiro Nome</param>
        /// <param name="ultimoNome">Ultimo Nome</param>
        /// <param name="dataNascimento">Data de Nascimento</param>
        public Pessoa (string primeiroNome, string ultimoNome, DateTime dataNascimento)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
            this.DataNascimento = dataNascimento;

        }

        /// <summary>
        /// primeiro nome
        /// </summary>
        public string PrimeiroNome { get; set; }

        /// <summary>
        /// ultimo nome
        /// </summary>
        public string UltimoNome { get; set; }

        /// <summary>
        /// Data para representar a data de nascimento 
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Esta propriedade calcula a idade da pessoa consoante a data de nascimento
        /// </summary>
        public int Idade
        {

            get
            {
                if ((DateTime.Now.Day >= this.DataNascimento.Day) && (DateTime.Now.Month >= this.DataNascimento.Month))
                    return DateTime.Now.Year - this.DataNascimento.Year;
                else
                    return DateTime.Now.Year - this.DataNascimento.Year - 1;
            }            
        }

    }
}
