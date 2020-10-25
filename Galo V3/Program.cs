using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Galo_V3
{
    class Jogador
    {
        public string Nome { get; set; }
        public int  Idade { get; set; }
        public int Vitorias { get; set; }
    }
    class Program
    {
       static bool Jogou = false;
       static int Rondas = 0;
       static char[,] Matrix = GeraArray();

        static char[,] GeraArray()
        {
            char[,] Matrix = new char[,]
        {
                //      0   1   2   
               /*0*/ { '7','8','9' },
               /*1*/ { '4','5','6' },
               /*2*/ { '1','2','3' }
        };
            return Matrix;
        }

            static void Main()
        {
            Console.Title = "Tic Tac Toe";
            Rondas = 0;
            Jogou = false;
            char Player1 = 'O';
            char Player2 = 'X';
            char Player = ' ';


            Jogador Jogador1 = new Jogador();
            Jogador Jogador2 = new Jogador();

            Jogador1.Vitorias = 0; 
            Jogador2.Vitorias = 0;

            Console.WriteLine("Jogador 1 escreve o teu nome");
            Jogador1.Nome = Console.ReadLine();
            //Console.WriteLine("Jogador 1 escreve o tua idade");
            //Jogador1.Idade = Convert.ToInt16(Console.ReadLine());
            // int.TryParse(Console.ReadLine(), out Jogador1.Idade);
            Console.WriteLine("Jogador 2 escreve o teu nome");
            Jogador2.Nome = Console.ReadLine();
            //Console.WriteLine("Jogador 2 escreve o tua idade");
            //Jogador2.Idade = Convert.ToInt16(Console.ReadLine());





            // GameEnd(Matrix, Player, Rondas) == 0

            while (true)
            {
                
                Player = (Rondas % 2 == 0) ? Player1 : Player2;
                PrintBoard(Matrix);
                int.TryParse(Console.ReadLine(), out int Opcoes);
                UserImput(Opcoes, Matrix, Player);
                PrintBoard(Matrix);

                if (Jogou == true)
                {
                    Rondas++;
                }
                if (GameEnd(Matrix, Player, Rondas) == 1)
                {
                    if (Player == Player1)
                    {
                        Jogador1.Vitorias++;
                        Console.WriteLine("{0} ganhou o jogo e já tem {1} vitorias no total enquanto {2} tem no total {3} vitorias!!!", Jogador1.Nome, Jogador1.Vitorias, Jogador2.Nome, Jogador2.Vitorias);
                    }
                    if (Player == Player2)
                    {
                        Jogador2.Vitorias++;
                        Console.WriteLine("{0} ganhou o jogo e já tem {1} vitorias no total enquanto {2} tem no total {3} vitorias!!!", Jogador2.Nome, Jogador2.Vitorias, Jogador1.Nome, Jogador1.Vitorias);
                    }
                    Matrix = GeraArray();
                    JogarNovamente(Matrix);
                }
                if (GameEnd(Matrix, Player, Rondas) == 2)
                {
                    Console.WriteLine("Jogo Empatado !!!");
                    Matrix = GeraArray();
                    JogarNovamente(Matrix);

                }
            }


                
        }

        static void JogarNovamente(char[,] Matrix) 
        {
            Console.WriteLine("Quer jogar novamente ?");
            Console.WriteLine("1 - Yes | 2 - Exit");
            int Opcoes = Convert.ToInt16(Console.ReadLine());
            if (Opcoes == 1)
            {
                    Rondas = 0;
                }
            if (Opcoes == 2)
            {
                Environment.Exit(0);
            }
        }



        static void PrintBoard(char[,] Matrix)
        {
            Console.Clear();
            Console.WriteLine("-------------");
            for (int Linha = 0; Linha < Matrix.GetLength(0); Linha++)
            {
                for (int Coluna = 0; Coluna < Matrix.GetLength(1); Coluna++)
                {
                    Console.Write(String.Format("| {0} ", Matrix[Linha, Coluna]));
                }
                Console.WriteLine("|");
                Console.WriteLine("-------------");
            }

        }
        static void UserImput(int Opcoes, char[,] Matrix, char Player)
        {
            switch (Opcoes)
            {
                case 1:
                    if (Matrix[2, 0] == (char)Opcoes + '0')
                    {
                        Matrix[2, 0] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 2:
                    if (Matrix[2, 1] == (char)Opcoes + '0')
                    {
                        Matrix[2, 1] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 3:
                    if (Matrix[2, 2] == (char)Opcoes + '0')
                    {
                        Matrix[2, 2] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 4:
                    if (Matrix[1, 0] == (char)Opcoes + '0')
                    {
                        Matrix[1, 0] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 5:
                    if (Matrix[1, 1] == (char)Opcoes + '0')
                    {
                        Matrix[1, 1] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 6:
                    if (Matrix[1, 2] == (char)Opcoes + '0')
                    {
                        Matrix[1, 2] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 7:
                    if (Matrix[0, 0] == (char)Opcoes + '0')
                    {
                        Matrix[0, 0] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 8:
                    if (Matrix[0, 1] == (char)Opcoes + '0')
                    {
                        Matrix[0, 1] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                case 9:
                    if (Matrix[0, 2] == (char)Opcoes + '0')
                    {
                        Matrix[0, 2] = Player;
                        Jogou = true;
                    }
                    else
                    {
                        Jogou = false;
                    }
                    break;
                default:
                    Jogou = false;
                    break;

            }


        }



        static int GameEnd(char[,] Matrix, char Player, int Rondas)
        {

            if
                (Matrix[0, 0] == Player && Matrix[0, 1] == Player && Matrix[0, 2] == Player ||
                 Matrix[1, 0] == Player && Matrix[1, 1] == Player && Matrix[1, 2] == Player ||
                 Matrix[2, 0] == Player && Matrix[2, 1] == Player && Matrix[2, 2] == Player ||
                 Matrix[0, 0] == Player && Matrix[1, 0] == Player && Matrix[2, 0] == Player ||
                 Matrix[0, 1] == Player && Matrix[1, 1] == Player && Matrix[2, 1] == Player ||
                 Matrix[0, 2] == Player && Matrix[1, 2] == Player && Matrix[2, 2] == Player ||
                 Matrix[0, 0] == Player && Matrix[1, 1] == Player && Matrix[2, 2] == Player ||
                 Matrix[0, 2] == Player && Matrix[1, 1] == Player && Matrix[2, 0] == Player)
            {
                return 1;
            }
            if (Rondas == 9)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}

