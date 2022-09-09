using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFP.Entities
{
    public class Competicao
    {
        //variaveis
        List<InformacaoEquipa> informacaoEquipas = new List<InformacaoEquipa>();

        /// <summary>
        /// Contrutor da Competição
        /// </summary>
        /// <param name="idCompeticao">Id da competição</param>
        /// <param name="nomeCompeticao">Nome da competição</param>
        public Competicao(int idCompeticao, string nomeCompeticao)
        {
            this.IdCompeticao = idCompeticao;
            this.NomeCompeticao = nomeCompeticao;
        }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o ID da competição
        /// </summary>
        public int IdCompeticao { get; set; }

        /// <summary>
        /// Esta propriedade serve para definir ou obter o Nome da Competição
        /// </summary>
        public string NomeCompeticao { get; set; }

        /// <summary>
        /// Adicionar informação a lista das Equipas
        /// </summary>
        /// <param name="informacaoEquipa">objeto informacaoEquipa</param>
        public void AdicionarEquipa(InformacaoEquipa informacaoEquipa)
        {
            informacaoEquipas.Add(informacaoEquipa);
        }

        /// <summary>
        /// Retorna a lista de informação da equipa
        /// </summary>
        /// <returns></returns>
        public List<InformacaoEquipa> GetInformacaoEquipas()
        {
            return informacaoEquipas;
        }

        /// <summary>
        /// Este método serve para alterar a mensagem apresentada no ecra da consola
        /// </summary>
        /// <returns>String com a informação da competição</returns>
        public override string ToString()
        {
            return $"\n Nome da Conpeticao:\n {this.NomeCompeticao}\n ";
        }


    }
}
