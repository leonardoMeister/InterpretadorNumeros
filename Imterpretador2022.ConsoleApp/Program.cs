using System;
using System.Collections.Generic;
using System.IO;

namespace Imterpretador2022.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letras = " _   __  __      __  __ __   __  __  __ \n" +
                            "  |  __| __||__||__ |__   | |__||__||  |\n" +
                            " _|_|__  __|   | __||__|  | |__| __||__|\n" +
                            "                                        \n" +
                            " _   __  __      __  __ __   __  __ \n" +
                            "  |  __| __||__||__ |__   | |__||__|\n" +
                            " _|_|__  __|   | __||__|  | |__| __|\n" +
                            "                                        \n" +
                            " _   __  __      __  __ __   __ \n" +
                            "  |  __| __||__||__ |__   | |__|\n" +
                            " _|_|__  __|   | __||__|  | |__|\n" +
                            "                                        \n" +
                            " _   __  __      __  __ __   __  __  __ \n" +
                            "  |  __| __||__||__ |__   | |__||__||  |\n" +
                            " _|_|__  __|   | __||__|  | |__| __||__|\n";


            StringReader reader = new StringReader(letras);
            List<string> listaLinhas = new List<string>();
            List<int> listaColunasPorLinhas = new List<int>();
            List<Numero> listaNumeros = new List<Numero>();
            int contadorLinhas = 0;
            int auxContFalhas = 0;

            //pegando os valores e passando para lista de manipulação do sistema
            while (reader.Peek() != -1)
            {
                contadorLinhas++;
                auxContFalhas++;

                if (auxContFalhas == 4)
                {
                    auxContFalhas = 0;
                    reader.ReadLine();
                    contadorLinhas--;
                    continue;
                }
                listaLinhas.Add(reader.ReadLine());
            }

            //Completando Variaveis restantes
            for (int x = 0; x < listaLinhas.Count / 3; x++) listaColunasPorLinhas.Add(listaLinhas[(((x) + 1) * 3) - 1].Length / 4);
            contadorLinhas = contadorLinhas / 3;

            #region Mostruario de valores de variaveis
            /*
            Console.WriteLine(contadorLinhas);
            for (int x = 0; x < listaColunasPorLinhas.Count; x++)
            {
                Console.WriteLine(listaColunasPorLinhas[x]);
            }
            for (int x = 0; x < listaLinhas.Count; x++)
            {
                Console.WriteLine(listaLinhas[x]);
            }*/
            #endregion


            //ATRIBUINDO PARTES PARA FORMAR O OBJETO CONTENDO NUMERO
            for (int x = 0; x < contadorLinhas; x++)
            {

                for (int z = 0; z < listaLinhas[((x) * 3)].Length; z += 4)
                {
                    string parte1 = "", parte2 = "", parte3 = "";

                    parte1 += listaLinhas[((x) * 3)].Substring(z, 4);
                    parte2 += listaLinhas[((x) * 3) + 1].Substring(z, 4);
                    parte3 += listaLinhas[((x) * 3) + 2].Substring(z, 4);
                    listaNumeros.Add(new Numero(parte1, parte2, parte3));
                }
            }

            //IMPRIMINDO OS NUMEROS 
            int contadorPosicoes = 0;
            for (int x = 0; x < contadorLinhas; x++)
            {
                for (int z = 0; z < listaColunasPorLinhas[x]; z++)
                {
                    Console.Write(listaNumeros[(contadorPosicoes)].PegarNumero());
                    contadorPosicoes++;
                }
                Console.WriteLine();
            }

        }
    }
}