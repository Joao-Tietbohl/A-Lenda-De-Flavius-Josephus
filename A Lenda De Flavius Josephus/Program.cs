using System;

namespace A_Lenda_De_Flavius_Josephus
{
    internal class Program
    {
        
        //SEQUENCIA DE SUICIDIOS COMEÇA SEMPRE PELA PESSOA DE NUMERO 1
        //SE NUMERO DO SALTO FOR MULTIPLO DE PESSOAS O PROGRAMA ENTRARÁ EM LOOP
        static void Main(string[] args)
        {
            Console.WriteLine("numero de casos: ");
            int nc = Int32.Parse(Console.ReadLine());

            //Do While para repetir o programa conforme input nc
            int contadorNC = 0;
            do
            {
                //inputs do usuário
                Console.WriteLine("Digite a quantidade de pessoas: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tamanho do salto: ");
                int salto = Int32.Parse(Console.ReadLine());


                //Inicia Vetor
                int[] pessoas = new int[n];
               

               //Inicializa numeração de pessoas

                int inicializador = 1;
                for (int i = 0; i < n; i++)
                {
                    pessoas[i] = inicializador;
                    inicializador++;
                }



                int posicaoAtual = 0;
                int pessoaViva = 0;

                //Condição para resolver todo o problema
                while (pessoaViva == 0)
                {

                    //pessoa zerada = morta
                    //Zera posição atual e da o pulo
                    pessoas[posicaoAtual] = 0;
                    posicaoAtual += salto;

                    //Checagem para ver se resta apenas 1 pessoa viva (1 unica posição não nula)
                    int contadorDeZeros = 0;
                    for (int i = 0; i < pessoas.Length; i++)
                    {
                        if (pessoas[i] == 0)
                        {
                            contadorDeZeros++;
                        }

                        if (contadorDeZeros == pessoas.Length - 1)
                        {
                            for (int j = 0; j < pessoas.Length; j++)
                            {
                                if (pessoas[j] != 0)
                                {
                                    pessoaViva = pessoas[j];
                                }
                            }
                        }
                    }

                    //Utiliza excesso do pulo para poder continuar pulando sem exceder tamanho do vetor
                    if (posicaoAtual >= pessoas.Length)
                    {
                       int restanteNumeroQueExcedeuTamanhoPesssoas = 0;
                       restanteNumeroQueExcedeuTamanhoPesssoas = posicaoAtual - pessoas.Length;     //Restante do salto que excedeu o tamanho do vetor

                        pessoas[restanteNumeroQueExcedeuTamanhoPesssoas] = 0;
                        posicaoAtual = restanteNumeroQueExcedeuTamanhoPesssoas;
                    }
                }


                
                Console.WriteLine("Posição do sobrevivente: " + pessoaViva);
                Console.WriteLine();
                Console.WriteLine();

                contadorNC++;
            } while (contadorNC != nc);
        }
       }
    }

