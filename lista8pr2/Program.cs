using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista8pr2
{
    internal class Program
    {
        public static void Exercicio1()
        {

            float quant, valor, valortotal = 0, quanttotal = 0;
            int i;

            do
            {
                Console.WriteLine("DIGITE A QUANTIDADE DE ITENS QUE VOCÊ PEGOU: ");
                quant = float.Parse(Console.ReadLine());
                if (quant == 0)
                {
                    break;
                }
                Console.WriteLine("DIGITE O VALOR DO ITEM: ");
                valor = float.Parse(Console.ReadLine());

                valortotal += quant * valor;
                quanttotal += quant;

                Console.WriteLine("A QUANTIDADE TOTAL DE TENS É: " + quanttotal);

                Console.WriteLine("O VALOR TOATAL É: " + valortotal);


            }while(quant > 0);
        }
        public static void Exercicio2()
        {
            string nomep, nomemenor = "", nomemaior = "";
            int numitens, parada = 2;
            float preco, menorinv, maiorinv;

            menorinv = float.MaxValue;
            maiorinv = float.MinValue;

            do
            {
                Console.WriteLine("INFORME O NOME DO PRODUTO: ");
                nomep = Console.ReadLine();

                Console.WriteLine("ENTRE COM A QUANTIDADE");
                numitens = int.Parse(Console.ReadLine());

                Console.WriteLine("ENTRE COM O PREÇO: ");
                preco = float.Parse(Console.ReadLine());

                float total = numitens * preco;
                if (total > maiorinv)
                {
                    maiorinv = total;
                    nomemaior = nomep;

                }

                if (total > menorinv)
                {
                    menorinv = total;
                    nomemenor = nomep;

                }



                Console.WriteLine("DIGITE 1 PARA SAIR OU 2 PARA CONTINUAR:");
                parada = int.Parse(Console.ReadLine());

            }while(parada != 1); 
            
            Console.WriteLine("A maior quantia investida é {0} no produto {1}", maiorinv, nomemaior);
            Console.WriteLine("A menor quantia investida é {0} no produto {1}", menorinv, nomemenor);

        }
        public static void Exercicio3()
        {
            float notas, totalpesos = 0;
            int avaliacao, i = 1;
            Console.WriteLine("Digite o total de avaliações: ");
            avaliacao = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite as notas : ");
                notas = float.Parse(Console.ReadLine());

                totalpesos = notas * avaliacao;
            
            } while (i <= avaliacao);

            if (totalpesos < 100)
                Console.WriteLine("Nota insuficiente");

            else if (totalpesos > 100)
                Console.WriteLine("Nota superior");

            else
                Console.WriteLine("Nota atingida");
        }
        public static void Exercicio4()
        {
            string estados;

            Console.WriteLine("==========MENU==========");
            Console.WriteLine("AC");
            Console.WriteLine("AL");
            Console.WriteLine("AP");
            Console.WriteLine("AM");
            Console.WriteLine("BA");
            Console.WriteLine("CE");
            Console.WriteLine("ES");
            Console.WriteLine("GO");
            Console.WriteLine("MA");
            Console.WriteLine("MT");
            Console.WriteLine("MS");
            Console.WriteLine("MG");
            Console.WriteLine("PA");
            Console.WriteLine("PB");
            Console.WriteLine("PR");
            Console.WriteLine("PE");
            Console.WriteLine("PI");
            Console.WriteLine("RJ");
            Console.WriteLine("RN");
            Console.WriteLine("RS");
            Console.WriteLine("RO");
            Console.WriteLine("RR");
            Console.WriteLine("SC");
            Console.WriteLine("SP");
            Console.WriteLine("SE");
            Console.WriteLine("TO");
            Console.WriteLine("DF");
            Console.WriteLine("=======================");

            Console.WriteLine("Escolha a sigla que você quer descobrir ");
            estados = Console.ReadLine();

            switch (estados)
            {
                case "AC":
                    Console.WriteLine("Acre");
                    break;

                case "AL":
                    Console.WriteLine("Alagoas");
                    break;

                case "AP":
                    Console.WriteLine("Amapá");
                    break;

                case "AM":
                    Console.WriteLine("Amazonas");
                    break;

                case "BA":
                    Console.WriteLine("Bahia");
                    break;

                case "CE":
                    Console.WriteLine("Ceará");
                    break;

                case "ES":
                    Console.WriteLine("Espírito Santo");
                    break;

                case "GO":
                    Console.WriteLine("Goiás");
                    break;

                case "MA":
                    Console.WriteLine("Maranhão");
                    break;

                case "MT":
                    Console.WriteLine("Mato Grosso");
                    break;

                case "MS":
                    Console.WriteLine("Mato Grosso do Sul");
                    break;

                case "MG":
                    Console.WriteLine("Minas Gerais");
                    break;

                case "PA":
                    Console.WriteLine("Pará");
                    break;

                case "PB":
                    Console.WriteLine("Paraíba");
                    break;

                case "PR":
                    Console.WriteLine("Paraná");
                    break;

                case "PE":
                    Console.WriteLine("Pernambuco");
                    break;

                case "PI":
                    Console.WriteLine("Piauí");
                    break;

                case "RJ":
                    Console.WriteLine("Rio de Janeiro");
                    break;

                case "RN":
                    Console.WriteLine("Rio Grande do Norte");
                    break;

                case "RS":
                    Console.WriteLine("Rio Grande do Sul");
                    break;

                case "RO":
                    Console.WriteLine("Rondônia");
                    break;

                case "RR":
                    Console.WriteLine("Roraima");
                    break;

                case "SC":
                    Console.WriteLine("Santa Catarina");
                    break;

                case "SP":
                    Console.WriteLine("São Paulo");
                    break;

                case "SE":
                    Console.WriteLine("Sergipe");
                    break;

                case "TO":
                    Console.WriteLine("Tocantins");
                    break;

                case "DF":
                    Console.WriteLine("Distrito Federal");
                    break;

                default:
                    Console.WriteLine("Opção Invalida");
                    break;

            }
        }
        public static void Exercicio5()
        {
            int MES, DIAS;

            Console.WriteLine("Digite um número entre 1 e 12: ");
            MES = int.Parse(Console.ReadLine());
            switch (MES)
            {
                case 1:
                    Console.WriteLine("A estação é verão");
                    break;

                case 2:
                    Console.WriteLine("A estação é verão");
                    break;

                case 3:
                    Console.WriteLine("me informe o dia:");
                    DIAS = int.Parse(Console.ReadLine());
                    if (DIAS >= 20)
                        Console.WriteLine("a estaçao é outono");
                    else
                        Console.WriteLine("A estação é verão");
                    break;

                case 4:
                    Console.WriteLine("A estação é outono");
                    break;

                case 5:
                    Console.WriteLine("A estação é outono");
                    break;

                case 6:
                    Console.WriteLine("me informe o dia:");
                    DIAS = int.Parse(Console.ReadLine());
                    if (DIAS >= 20)
                        Console.WriteLine("a estaçao é inverno");
                    else
                        Console.WriteLine("A estação é outono");
                    break;

                case 7:
                    Console.WriteLine("a estaçao é inverno");
                    break;

                case 8:
                    Console.WriteLine("a estaçao é inverno");
                    break;

                case 9:
                    Console.WriteLine("me informe o dia:");
                    DIAS = int.Parse(Console.ReadLine());
                    if (DIAS >= 22)
                        Console.WriteLine("a estaçao é primavera");
                    else
                        Console.WriteLine("A estação é inverno");
                    break;

                case 10:
                    Console.WriteLine("a estaçao é primavera");
                    break;

                case 11:
                    Console.WriteLine("a estaçao é primavera");
                    break;

                case 12:
                    Console.WriteLine("me informe o dia:");
                    DIAS = int.Parse(Console.ReadLine());
                    if (DIAS >= 21)
                        Console.WriteLine("a estaçao é verão");
                    else
                        Console.WriteLine("A estação é primavera");
                    break;
            }
        }
        public static void Exercicio6()
        {
            float PESO, ALTURA, IMC;

            Console.WriteLine("Digite o seu peso: ");
            PESO = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura em metros: ");
            ALTURA = float.Parse(Console.ReadLine());

            IMC = PESO / (ALTURA * ALTURA);

            if (IMC < 18.5)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("peso normal");
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine("sobre peso");
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                Console.WriteLine("obesidade grau 1");
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                Console.WriteLine("obesidade grau 2");
            }
            else if (IMC >= 40)
            {
                Console.WriteLine("obesidade grau 3 (mórbida).");
            }

        }
        public static void Exercicio7()
        {
            int NUMBER, i = 1;

            Console.WriteLine("digite um numero");
            NUMBER = int.Parse(Console.ReadLine());
            do
            {
                if (NUMBER % i == 0)
                    Console.WriteLine(i);
                else
                    i++;
            } while (i < NUMBER);
        }
        static void Main(string[] args)
        {
            int MENU;

            do
            {

                Console.WriteLine("==========MENU==========");
                Console.WriteLine("1- EXERCÍCIO 1");
                Console.WriteLine("2- EXERCÍCIO 2");
                Console.WriteLine("3- EXERCÍCIO 3");
                Console.WriteLine("4- EXERCÍCIO 4");
                Console.WriteLine("5- EXERCÍCIO 5");
                Console.WriteLine("6- EXERCÍCIO 6");
                Console.WriteLine("7- EXERCÍCIO 7");
                Console.WriteLine("=======================");

                MENU = int.Parse(Console.ReadLine());

                switch (MENU)
                {

                    case 1:
                        Exercicio1();
                        break;

                    
                    case 2:
                        Exercicio2(); 
                        break;

                   
                    case 3:
                        Exercicio3();
                        break;

                    
                    case 4:
                        Exercicio4();
                        break;

                    
                    case 5:
                        Exercicio5();
                        break;

                    
                    case 6:
                        Exercicio6();
                        break;

                    
                    case 7:
                        Exercicio7();
                        break;

                    
                    default:
                        Console.WriteLine("Número inválido");
                        break;



                }

                Console.ReadKey();

            } while (MENU != 0);
        }
    }
}
