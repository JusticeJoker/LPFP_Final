using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPFP.Entities;

namespace LPFP.API
{
    public class ListaCompeticoes : List<Competicao>
    {
        
         List<Competicao> competicoes = new List<Competicao>();

         public new void Add(Competicao competicao)
         {
            if (this.Exists(c => c.IdCompeticao.Equals(competicao.IdCompeticao)))
                throw new Exception("Esta competição já existe");

            base.Add(competicao);
         }

         public new void Remove(Competicao competicao)
         {
            if (this.Exists(c => c.IdCompeticao.Equals(competicao.IdCompeticao)))
                 throw new Exception("Esta competição não existe");

         }

         public Competicao Get(int idCompeticao)
         {
             return this.FirstOrDefault(c => c.IdCompeticao == idCompeticao);
         }

         public List<Competicao> Get(string nomeCompeticao)
         {
             return this.Where(c => c.NomeCompeticao.Equals(nomeCompeticao)).ToList();
         }

        
    }
}
