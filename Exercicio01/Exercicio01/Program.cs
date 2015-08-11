using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            //Questão 01

            int[] numeros = new int[10] { 1, 4, 8, 9, 3, 11, 0, 5, 22, 2 };

            for (int i = numeros.Length; i > 0; i--) {
                Console.WriteLine(numeros[i - 1]);
            }
            Console.WriteLine(numeros.Reverse().ToString());

            //------------------------------------------------------------------------------
            //Questão 02

            string mes = Console.ReadLine();

            switch (mes) {
                case "1":
                    Console.WriteLine("Janeiro");
                    break;
                case "2":
                    Console.WriteLine("Fevereiro");
                    break;
                case "3":
                    Console.WriteLine("Março");
                    break;
                case "4":
                    Console.WriteLine("Abril");
                    break;
                case "5":
                    Console.WriteLine("Maio");
                    break;
                case "6":
                    Console.WriteLine("Junho");
                    break;
                case "7":
                    Console.WriteLine("Julho");
                    break;
                case "8":
                    Console.WriteLine("Agosto");
                    break;
                case "9":
                    Console.WriteLine("Setembro");
                    break;
                case "10":
                    Console.WriteLine("Outubro");
                    break;
                case "11":
                    Console.WriteLine("Novembro");
                    break;
                case "12":
                    Console.WriteLine("Dezembro");
                    break;
            }
            //----------------------------------------------------------------------------
            //Questão03
            string[,] telefones = new string[10, 2] ;

            string telefone;

            for (int i = 0; i < 10; i++) {

                Console.WriteLine("Digite uma posição que você deseja adicionar um telefone");
                string posicao = Console.ReadLine();

                if (posicao.Equals("#01")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();

                    telefones[0, 1] = telefone;
                    

                }
                else if (posicao.Equals("#02")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[1, 1] = telefone;



                }
                else if (posicao.Equals("#03")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[2, 1] = telefone;


                }
                else if (posicao.Equals("#04")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[3, 1] = telefone;

                }
                else if (posicao.Equals("#05")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[4, 1] = telefone;

                }
                else if (posicao.Equals("#06")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[5, 1] = telefone;

                }
                else if (posicao.Equals("#07")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[6, 1] = telefone;

                }
                else if (posicao.Equals("#08")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[7, 1] = telefone;

                }
                else if (posicao.Equals("#09")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[8, 1] = telefone;


                }
                else if (posicao.Equals("#10")) {
                    Console.WriteLine("Digite o telefone");

                    telefone = Console.ReadLine();
                    telefones[9, 1] = telefone;

                }



            }


            Console.WriteLine("Qual codigo você deseja saber o numero de #01 - #10");
            string pesquisa = Console.ReadLine();

            switch (pesquisa) {

                case "#01":
                    Console.WriteLine(telefones[0,1]);
                    break;
                case "#02":
                    Console.WriteLine(telefones[1, 1]);
                    break;
                case "#03":
                    Console.WriteLine(telefones[2, 1]);
                    break;
                case "#04":
                    Console.WriteLine(telefones[3, 1]);
                    break;
                case "#05":
                    Console.WriteLine(telefones[4, 1]);
                    break;
                case "#06":
                    Console.WriteLine(telefones[5, 1]);
                    break;
                case "#07":
                    Console.WriteLine(telefones[6,1]);
                    break;
                case "#08":
                    Console.WriteLine(telefones[7, 1]);
                    break;
                case "#09":
                    Console.WriteLine(telefones[8, 1]);
                    break;
                case "#10":
                    Console.WriteLine(telefones[9, 1]);
                    break;


                default:
                    Console.WriteLine("Você digitou um codigo errado!!");
                    break;
            }







        }
    }
}
