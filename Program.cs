using BibliotecaDejogos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {

                Console.WriteLine("======BIBLIOTECA DE JOGOS======");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro.");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }
                        break;

                    case "3":
                        resultado = EditarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Editado!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao editar.");
                        }
                        break;

                    case "4":
                        resultado = RemoverJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Nada foi removido.");
                        }
                        break;


                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            String genero = Console.ReadLine();
            Console.Write("Máx. Jogadores: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());
            if (titulo == "") return false;
            if (ano < 1950) return false;

            Jogo novoJogo = new Jogo(titulo, ano, genero, maxJogadores, metacritic);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos(List<Jogo> listaJogos)
        {
            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            return true;
        }

         public static bool EditarJogos (List<Jogo> listaJogos)
        {
               
            foreach(Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

                Console.WriteLine("");
                Console.WriteLine("Digite o número do jogo que deseja editar:");
                Jogo jogoEscolhido = listaJogos[Convert.ToInt32(Console.ReadLine()) - 1];
                
                Console.WriteLine("O jogo escolhido foi: "+ jogoEscolhido.getTitulo());

            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            jogoEscolhido.setTitulo(titulo);
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            jogoEscolhido.setAno(ano);
            Console.Write("Gênero: ");
            String genero = Console.ReadLine();
            jogoEscolhido.setGenero(genero);
            Console.Write("Máx. Jogadores: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());
            jogoEscolhido.setMaxJogadores(maxJogadores);
            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());
            jogoEscolhido.setMetacritic(metacritic);
            Console.Read();



            return true;
        }
        public static bool RemoverJogos(List<Jogo> listaDeJogos)
        {

            Console.Clear();
            Console.Write("Titulo para remover: ");
            String titulo = Console.ReadLine();

            foreach (Jogo jogo in listaDeJogos)
            {

                if (jogo.getTitulo() == titulo)
                {
                    listaDeJogos.Remove(jogo);
                    Console.Beep();
                    Console.Clear();
                    break;
                }
                
            }
            return true;
        }
    }
}

