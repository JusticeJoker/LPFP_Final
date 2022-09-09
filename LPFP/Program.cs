using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPFP.Entities;
using LPFP.API;
using LPFP.API.Exceptions;

namespace LPFP
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criar as Listas para os jogadores e competições
            ListaJogadores jogadores = new ListaJogadores();
            ListaCompeticoes competicaos = new ListaCompeticoes();
            
            //Variaveis
            string lerOpcao, lerCompeticao;
            bool ciclo = true;
            bool cicloCompeticao = true;


            try
            {
                // Adiciona alguns jogadores
                jogadores.Add(new Jogador("Shoya", "Nakajima", new DateTime(1994, 8, 23), 10, 82.3, 1.64, Escolaridade.Secundario, Clubes.FCPorto, true, new DateTime(2020, 1, 12), new DateTime(2020, 11, 8), "\n\n Primeira Liga\n Taça de Portugal", "\n\n Al Duhail\n Portimonense\n FC Tokyo"));
                jogadores.Add(new Jogador("Bruno", "Fernandes", new DateTime(1994, 9, 8), 8, 90.4, 1.83, Escolaridade.Licenciatura, Clubes.Sporting, false, new DateTime(2020, 1, 4), new DateTime(2020, 3, 12), "\n\n Primeira Liga\n Taça da Liga", "\n\n UC Sampdoria\n Udinese Calcio\n Novara Calcio"));
                jogadores.Add(new Jogador("Rúben", "Fonseca", new DateTime(2000, 2, 24), 29, 78.5, 1.88, Escolaridade.Secundario, Clubes.CDTondela, false, new DateTime(2020, 1, 25), new DateTime(2020, 5, 25), "\n\n Primeira Liga\n Taça de Portugal", "\n\n Tondela Sub19\n Feirense Sub19\n Feirense Sub17"));
                jogadores.Add(new Jogador("Adel", "Taarabt", new DateTime(1989, 5, 24), 49, 72.8, 1.80, Escolaridade.Outra, Clubes.SLBenfica, false, new DateTime(2020, 1, 22), new DateTime(2021, 5, 30), "\n\n Primeira Liga\n Taça da Liga", "\n\n Génova\n Queens Park Rangers\n AC Millan"));
                jogadores.Add(new Jogador("Képlar", "Ferreira aka Pepe", new DateTime(1983, 2, 26), 3, 92.3, 1.87, Escolaridade.Outra, Clubes.FCPorto, false, new DateTime(2020, 1, 3), new DateTime(2022, 7, 4), "\n\n Primeira Liga\n Taça de Portugal\n Allianz Cup", "\n\n Besiktas\n Real Madrid\n FCPorto"));
                jogadores.Add(new Jogador("Mohamed", "Diaby", new DateTime(1996, 9, 3), 24, 88.4, 1.88, Escolaridade.Secundario, Clubes.PacosDeFerreira, true, new DateTime(2020, 1, 27), new DateTime(2020, 2, 27), "\n\n Primeira Liga\n Allianz Cup", "\n\n Paços De Ferreira B\n CD Santa Clara\n SC Ideal"));
                jogadores.Add(new Jogador("André", "André", new DateTime(1989, 8, 26), 78, 92.7, 1.74, Escolaridade.Mestrado, Clubes.Guimaraes, true, new DateTime(2020, 1, 2), new DateTime(2023, 10, 15), "\n\n Primeira Liga\n", "\n\n FCPorto\n Vitória Guimaraes\n Varzim"));
                //jogadores.Add(new Jogador("André", "André", new DateTime(1989, 8, 26), 78, 92.7, 1.74, Escolaridade.Mestrado, Clubes.Guimaraes, true, new DateTime(2020, 1, 2), new DateTime(2023, 10, 15), "\n\n Primeira Liga\n", "\n\n FCPorto\n, Vitória Guimaraes\n, Varzim"));
                jogadores.Add(new Jogador("Rubén", "del Campo", new DateTime(2000, 2, 22), 99, 75.8, 1.85, Escolaridade.Secundario, Clubes.FCFamalicao, false, new DateTime(2020, 1, 7), new DateTime(2025, 9, 11), "\n\n Primeira Liga\n Taça de Portugal\n", "\n\n Atletico Madrid B\n Atletico Madrid U19\n, Atletico Madrileño"));
            }
            catch (JogadorJaExisteException) 
            {

                Console.Write("O Jogador que estas a criar ja existe");
                throw;
            
            }

            // Lista de competições
            competicaos.Add(new Competicao(1001, "Liga Portuguesa"));
            competicaos.Add(new Competicao(1002, "Taça de Portugal"));
            competicaos.Add(new Competicao(1003, "Taça da Liga"));
            competicaos.Add(new Competicao(1004, "Supertaça"));
            competicaos.Add(new Competicao(1005, "Allianz Cup"));

            
            // Equipas com os respetivos pontos, vitorias e derrotas consoante a Competição
            competicaos.Get(1001).AdicionarEquipa(new InformacaoEquipa(Clubes.FCPorto, 4, 0, 12));
            competicaos.Get(1001).AdicionarEquipa(new InformacaoEquipa(Clubes.SLBenfica, 2, 2, 6));
            competicaos.Get(1001).AdicionarEquipa(new InformacaoEquipa(Clubes.Maritimo, 2, 2, 6));
            competicaos.Get(1001).AdicionarEquipa(new InformacaoEquipa(Clubes.FCFamalicao, 3, 1, 9));
            competicaos.Get(1001).AdicionarEquipa(new InformacaoEquipa(Clubes.PacosDeFerreira, 0, 4, 0));
            
            
            competicaos.Get(1002).AdicionarEquipa(new InformacaoEquipa(Clubes.FCFamalicao, 6, 1, 18));
            competicaos.Get(1002).AdicionarEquipa(new InformacaoEquipa(Clubes.SCBraga, 3, 4, 9));
            competicaos.Get(1002).AdicionarEquipa(new InformacaoEquipa(Clubes.GilVicente, 3, 4, 9));
            competicaos.Get(1002).AdicionarEquipa(new InformacaoEquipa(Clubes.CDTondela, 1, 6, 3));
            competicaos.Get(1002).AdicionarEquipa(new InformacaoEquipa(Clubes.CDAves, 0, 7, 0));

            competicaos.Get(1003).AdicionarEquipa(new InformacaoEquipa(Clubes.Sporting, 2, 1, 6));
            competicaos.Get(1003).AdicionarEquipa(new InformacaoEquipa(Clubes.SLBenfica, 2, 1, 6));
            competicaos.Get(1003).AdicionarEquipa(new InformacaoEquipa(Clubes.Maritimo, 1, 2, 3));
            competicaos.Get(1003).AdicionarEquipa(new InformacaoEquipa(Clubes.Moreirense, 0, 2, 0));
            competicaos.Get(1003).AdicionarEquipa(new InformacaoEquipa(Clubes.SantaClara, 0, 2, 0));

            competicaos.Get(1004).AdicionarEquipa(new InformacaoEquipa(Clubes.RioAve, 7, 1, 21));
            competicaos.Get(1004).AdicionarEquipa(new InformacaoEquipa(Clubes.SCBraga, 5, 3, 15));
            competicaos.Get(1004).AdicionarEquipa(new InformacaoEquipa(Clubes.VitoriaSetubal, 3, 4, 9));
            competicaos.Get(1004).AdicionarEquipa(new InformacaoEquipa(Clubes.Boavista, 2, 6, 6));
            competicaos.Get(1004).AdicionarEquipa(new InformacaoEquipa(Clubes.Belenenses, 0, 8, 0));

            competicaos.Get(1005).AdicionarEquipa(new InformacaoEquipa(Clubes.FCPorto, 12, 3, 36));
            competicaos.Get(1005).AdicionarEquipa(new InformacaoEquipa(Clubes.SLBenfica, 9, 6, 27));
            competicaos.Get(1005).AdicionarEquipa(new InformacaoEquipa(Clubes.SCBraga, 7, 8, 21));
            competicaos.Get(1005).AdicionarEquipa(new InformacaoEquipa(Clubes.PacosDeFerreira, 6, 9, 18));
            competicaos.Get(1005).AdicionarEquipa(new InformacaoEquipa(Clubes.Portimonense, 2, 13, 6));
            
            // Menu Inicial da Consola
            while (ciclo)
            {
                //Mostra ao utilizador as opções válidas que pode selecionar
                Console.WriteLine(" -----------------------------");
                Console.WriteLine("\tLista de opcoes\n\n [1] Jogadores\n [2] Lista Contrato Acabar\n [3] Lista Lesionados\n [4] Lista de Jogadores sujeitos a teste Anti-Doping\n [5] Lista de Equipas\n [6] Competições\n [s] Sair do Programa\n");
                Console.WriteLine(" Insira uma opcao: ");
                lerOpcao = Console.ReadLine();
                Console.Clear();
                switch (lerOpcao)
                {
                    case "1":
                        //Escreve na consola todos os Jogadores
                        Console.WriteLine(" ---------------------------------------");
                        Console.WriteLine("\t\t Jogadores \t\t");
                        //Chama a função Mostra 
                        Mostra(jogadores);
                        break;

                    case "2":

                        //Chama a função que mostra os jogadores com o contrato a acabar
                        MostraContratoAcabar(jogadores);
                        break;

                    case "3":

                        //Chama a função que mostra os jogadores lesionados
                        EscreveLesionado(jogadores);
                        break;

                    case "4":

                        //Chama a função que mostra os jogadores que precisam de fazer o teste de anti doping
                        MostraDoping(jogadores);
                        break;

                    case "5":

                        //Chama a função que mostra as equipas
                        MostraEquipas();
                        break;
                    case "6":

                        //Chama a função que mostra a lista de competições
                        MostraListaCompeticoes(competicaos);
                        Console.WriteLine("\n");
                        //Mostra as opçoes que o utilizador pode escolher
                        Console.WriteLine("Insira Uma opcao: \n 1- Liga Portuguesa\n 2- Taça de Portugal\n 3- Taça da Liga\n 4- Supertaça\n 5- Allianz Cup\n v- Voltar para tras\n\n");
                        Console.WriteLine(" Insira uma opcao: ");
                        lerCompeticao = Console.ReadLine();
                  
                            switch (lerCompeticao)
                            {
                               
                                case "1":

                                    Console.WriteLine(" ---------------------------------------------------------");
                                    Console.WriteLine(" |------------------------Tabela-------------------------|");
                                    //Chama a função para mostrar a tabela da Liga Portuguesa
                                    MostraCompeticao1(competicaos);
                                    break;

                                case "2":

                                    Console.WriteLine(" ---------------------------------------------------------");
                                    Console.WriteLine(" |------------------------Tabela-------------------------|");
                                    //Chama a função para mostrar a tabela da Taça de Portugal
                                    MostraCompeticao2(competicaos);
                                    break;

                                case "3":

                                    Console.WriteLine(" ---------------------------------------------------------");
                                    Console.WriteLine(" |------------------------Tabela-------------------------|");
                                    //Chama a função para mostrar a tabela da Taça da Liga
                                    MostraCompeticao3(competicaos);
                                    break;
                                
                                case "4":

                                    Console.WriteLine(" ---------------------------------------------------------");
                                    Console.WriteLine(" |------------------------Tabela-------------------------|");
                                    //Chama a função para mostrar a tabela da SuperTaça
                                    MostraCompeticao4(competicaos);
                                    break;

                                 case "5":

                                    Console.WriteLine(" ---------------------------------------------------------");
                                    Console.WriteLine(" |------------------------Tabela-------------------------|");
                                    //Chama a função para mostrar a tabela Allianz Cup
                                    MostraCompeticao5(competicaos);
                                    break;

                                 case "v":

                                Console.WriteLine("\n Clique Enter para sair do menu\n");
                                //Sai do ciclo e volta para o menu anterior
                                cicloCompeticao = false;
                                    break;

                                default:
                                    //Se for seleciona uma opção inválida
                                    Console.WriteLine("----Opcao invalida----");
                                    break;
                            }
                    
                        break;

                    case "s":

                        Console.WriteLine("\n Clique Enter para sair do Programa\n");
                        //Sai do programa
                        ciclo = false;
                        break;

                    default:
                        //Se for seleciona uma opção inválida
                        Console.WriteLine("----Opcao invalida----");
                        break;
                   
                }

                //Pausa
                Console.ReadKey();
            }

            //Esta função imprime a lista de jogadores
            static void Mostra(ListaJogadores jogadores)
            {
                foreach (Jogador jogador in jogadores)
                {
                    
                        Console.WriteLine(" ---------------------------------------");
                        Console.WriteLine(jogador);
                    
                }   
            }

            //Esta função imprime os jogadores que tem o contrato a acabar nos proximos 6 meses
            static void MostraContratoAcabar(ListaJogadores jogadores)
            {
                foreach (Jogador jogador in jogadores)
                {
                    if (jogador.DataDeContrato <= 6 && jogador.MesFimContratacao.Year - DateTime.Now.Year == 0 && jogador.MesFimContratacao.Month - DateTime.Now.Month <= 6)
                    {
                        Console.WriteLine(" ---------------------------------------");
                        Console.WriteLine(" -----Contrato Acaba em 6 Meses!!!------");
                        Console.WriteLine(jogador);
                        Console.WriteLine("\n ---------------------------------------");
                    }
                }


            }

            //Esta função imprime a lista de clubes
            static void MostraEquipas()
            {
                Console.WriteLine(" --------------------------------------- ");
                Console.WriteLine($" Equipa: \n");
                foreach (string equipas in Enum.GetNames(typeof(Clubes)))
                {
                    Console.WriteLine(equipas);
                }

                Console.WriteLine(" --------------------------------------- ");
                Console.WriteLine(" Clique Enter para sair da lista de equipas\n");
                
            }

            //Esta função imprime a lista de jogadores lesionados
            static void EscreveLesionado(ListaJogadores jogadores)
            {
                foreach (Jogador jogador in jogadores)
                {
                    if(jogador.Lesionado)
                    {
                        Console.WriteLine(" ---------------------------------------");
                        Console.WriteLine(jogador);
                    }                                                                          
                }
            }

            //Esta função imprime a lista de competições
            static void MostraListaCompeticoes(ListaCompeticoes competicaos)
            {
                foreach (Competicao competicao in competicaos)
                {
                    Console.WriteLine(competicao);
                }

            }

            //Esta função imprime a tabela com as Equipas na Liga Portuguesa
            static void MostraCompeticao1(ListaCompeticoes competicaos)
            {
                Console.WriteLine(" |---------------------Liga Portuguesa-------------------|");
                Console.WriteLine(" |-------------------------------------------------------|");

                foreach (Competicao competicao in competicaos)
                {
                    if (competicao.IdCompeticao == 1001)
                    {
                        foreach (InformacaoEquipa informacaoEquipa in competicao.GetInformacaoEquipas())
                        {
                            Console.Write($" { informacaoEquipa }\n");
                        }
                    }
                }

                Console.WriteLine(" ---------------------------------------------------------\n");
                Console.WriteLine(" Clique Enter para sair da tabela\n");

            }

            //Esta função imprime a tabela com as Equipas na Taça de Portugal
            static void MostraCompeticao2(ListaCompeticoes competicaos)
            {
                Console.WriteLine(" |---------------------Taça de Portugal------------------|");
                Console.WriteLine(" |-------------------------------------------------------|");

                foreach (Competicao competicao in competicaos)
                {
                    if (competicao.IdCompeticao == 1002)
                    {
                        foreach (InformacaoEquipa informacaoEquipa in competicao.GetInformacaoEquipas())
                        {
                            Console.Write($" { informacaoEquipa }\n");
                        }
                    }
                }

                Console.WriteLine(" ---------------------------------------------------------\n");
                Console.WriteLine(" Clique Enter para sair da tabela\n");

            }

            //Esta função imprime a tabela com as Equipas na Taça de Portugal
            static void MostraCompeticao3(ListaCompeticoes competicaos)
            {
                Console.WriteLine(" |-----------------------Taça da Liga--------------------|");
                Console.WriteLine(" |-------------------------------------------------------|");

                foreach (Competicao competicao in competicaos)
                {
                    if (competicao.IdCompeticao == 1003)
                    {
                        foreach (InformacaoEquipa informacaoEquipa in competicao.GetInformacaoEquipas())
                        {
                            Console.Write($" { informacaoEquipa }\n");
                        }
                    }
                }

                Console.WriteLine(" ---------------------------------------------------------\n");
                Console.WriteLine(" Clique Enter para sair da tabela\n");

            }

            //Esta função imprime a tabela com as Equipas na SuperTaça
            static void MostraCompeticao4(ListaCompeticoes competicaos)
            {
                Console.WriteLine(" |------------------------SuperTaça----------------------|");
                Console.WriteLine(" |-------------------------------------------------------|");

                foreach (Competicao competicao in competicaos)
                {
                    if (competicao.IdCompeticao == 1004)
                    {
                        foreach (InformacaoEquipa informacaoEquipa in competicao.GetInformacaoEquipas())
                        {
                            Console.Write($" { informacaoEquipa }\n");
                        }
                    }
                }

                Console.WriteLine(" ---------------------------------------------------------\n");
                Console.WriteLine(" Clique Enter para sair da tabela\n");

            }

            //Esta função imprime a tabela com as Equipas na Allianz Cup
            static void MostraCompeticao5(ListaCompeticoes competicaos)
            {
                Console.WriteLine(" |-----------------------Allianz Cup---------------------|");
                Console.WriteLine(" |-------------------------------------------------------|");

                foreach (Competicao competicao in competicaos)
                {
                    if (competicao.IdCompeticao == 1005)
                    {
                        foreach (InformacaoEquipa informacaoEquipa in competicao.GetInformacaoEquipas())
                        {
                            Console.Write($" { informacaoEquipa }\n");
                        }
                    }
                }

                Console.WriteLine(" ---------------------------------------------------------\n");
                Console.WriteLine(" Clique Enter para sair da tabela\n");

            }

            //Esta função imprime a lista de jogadores que precisam de fazer o teste anti-doping
            static void MostraDoping(ListaJogadores jogadores)
            {
                foreach (Jogador jogador in jogadores)
                {

                    //Se a ultima data que fez o teste anti-doping for maior ou igual a 6 dias e a ultima data que fez o teste anti-doping for menor ou igual a 16 dias 
                    //O jogador necessita de apenas fazer um teste de doping de rotina
                    if (jogador.UltimaDataDoping >= 6 && jogador.UltimaDataDoping <= 16 && !jogador.Lesionado)
                    {

                         Console.WriteLine(" -----------------------------------------");
                         Console.WriteLine(" -Jogador Necessita de Teste Anti-Doping- ");
                         Console.WriteLine(jogador);
                         Console.WriteLine("\n ---------------------------------------");
                    }
                    //Se o jogador nao fez o de anti-doping á mais ou igual a 16 dias deve urgentemente fazer o teste anti-doping
                    else if (jogador.UltimaDataDoping >= 16)
                    {
                        Console.WriteLine("\n ---------------------------------------");
                        Console.WriteLine("\n --------------AVISO!!!!----------------");
                        Console.WriteLine("\n -----Jogador Necessita fazer Exame-----");
                        Console.WriteLine("\n ------Anti-Doping urgentemente---------");
                        Console.WriteLine(jogador);
                        Console.WriteLine("\n ---------------------------------------");
                    }
                    //Se estiver lesionado o jogador apenas deve fazer o teste quando estiver outra vez recuperado e pront a jogar
                    if (jogador.Lesionado)
                    {
                        Console.WriteLine(" -----------------------------------------");
                        Console.WriteLine(" -Jogador Necessita de Teste Anti-Doping- ");
                        Console.WriteLine(" -------Quando voltar a puder jogar-------");
                        Console.WriteLine(jogador);
                        Console.WriteLine("\n ---------------------------------------");
                    }

                }
            }
        }
    }
}
