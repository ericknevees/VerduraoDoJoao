using System;
using System.Text;

namespace VrduraoDoJoao.Melanciometro
{


    internal class Program
    {

        static void Main(string[] args)
        {
            int contadorTentativas = 0;
            string usuario, senha;
            int opcao = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===== Bem-vindo ao sistema de controle de caminhões =====");
            Console.ResetColor();
            do
            {
                Console.Write("Usuário: ");
                usuario = Console.ReadLine();

                Console.Write("Senha: ");
                senha = Console.ReadLine();

                if (usuario == "joão" && senha == "123")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nAutenticação realizada com sucesso!");
                    Console.ResetColor();
                    opcao = 0;
                    double valorMelanciaComum = 0;
                    double valorMelanciaBaby = 0;

                    double precoMelanciaComum = 5.50;
                    double precoMelanciaBaby = 8.54;

                    do
                    {
                        Console.WriteLine("\n===== MENU =====");
                        Console.WriteLine("1 - Registrar placa do caminhão");
                        Console.WriteLine("2 - Calcular valor das melancias");
                        Console.WriteLine("0 - Sair");

                        Console.Write("\nEscolha uma opção: ");
                        opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite a placa do caminhão: ");
                                string placa = Console.ReadLine();
                                Console.WriteLine($"Placa {placa} registrada com sucesso!");
                                break;

                            case 2:
                                Console.WriteLine("Digite o dia da semana (1 a 5):");

                                int diaSemana = int.Parse(Console.ReadLine());

                                switch (diaSemana)
                                {
                                    case 1: // Segunda-Feira
                                        Console.WriteLine("Hoje é segunda-feira, você tem 1% de desconto!");
                                        precoMelanciaComum *= 0.1;
                                        precoMelanciaBaby *= 0.1;
                                        break;
                                    case 2: // Terça-Feira
                                        Console.WriteLine("Hoje é terça-feira verde, você tem 15% de desconto!");
                                        precoMelanciaComum *= 0.15;
                                        precoMelanciaBaby *= 0.15;
                                        break;
                                    case 3: // Quarta-Feira
                                        Console.WriteLine("Hoje é quarta-feira verde, você tem 17% de desconto!");
                                        precoMelanciaComum *= 0.17;
                                        precoMelanciaBaby *= 0.17;
                                        break;
                                    case 4: // Quinta-Feira
                                        Console.WriteLine("Hoje é quinta-feira, você tem 2% de desconto!");
                                        precoMelanciaComum *= 0.2;
                                        precoMelanciaBaby *= 0.2;
                                        break;
                                    case 5: // Sexta-Feira
                                        Console.WriteLine("Hoje é sexta-feira, você tem 3% de desconto!");
                                        precoMelanciaComum *= 0.3;
                                        precoMelanciaBaby *= 0.3;
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Dia da semana inválido. Tente novamente."); 
                                        Console.ResetColor();
                                    continue;
                                }

                                Console.WriteLine("\n=== CÁLCULO DO VALOR DAS MELANCIAS ===");

                                Console.Write("Digite a quantidade de melancia comum em kg: ");
                                double quantidadeComum = double.Parse(Console.ReadLine());
                                valorMelanciaComum += (quantidadeComum * 5.50) / diaSemana;

                                Console.Write("Digite a quantidade de melancia baby em kg: ");
                                double quantidadeBaby = double.Parse(Console.ReadLine());
                                valorMelanciaBaby += (quantidadeBaby * 8.54) / diaSemana;

                                Console.WriteLine($"\nValor total da melancia comum: R$ {valorMelanciaComum}");
                                Console.WriteLine($"Valor total da melancia baby: R$ {valorMelanciaBaby}");
                                Console.WriteLine($"Valor total das melancias: R$ {(valorMelanciaComum + valorMelanciaBaby)}");
                                break;

                            case 0:
                                Console.WriteLine("\nObrigado por utilizar o programa!");
                                return;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nOpção inválida. Digite um número de opção válido.");
                                Console.ResetColor();

                                break;
                        }
                    } while (true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUsuário ou senha incorretos.");
                    Console.ResetColor();

                    contadorTentativas++;

                    if (contadorTentativas == 3)
                    {
                        Console.WriteLine("\nVocê excedeu o número máximo de tentativas.");
                        Console.ReadKey();
                        break;

                    }
                }
            } while (true);

        }
    }
}



