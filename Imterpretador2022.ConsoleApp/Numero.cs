using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imterpretador2022.ConsoleApp
{
    public class Numero
    {
        private string parte1;
        private string parte2;
        private string parte3;
        private int numero;

        public Numero(string parte1, string parte2, string parte3)
        {
            Parte1 = parte1;
            Parte2 = parte2;
            Parte3 = parte3;
            numero = 0;
        }
        public int PegarNumero()
        {
            if (parte2 == "  | " && parte1 == " _  " && parte3 == " _|_") numero = 1;
            else if (parte1 == " __ " && parte2 == " __|" && parte3 == "|__ ") numero = 2;
            else if (parte1 == " __ " && parte2 == " __|" && parte3 == " __|") numero = 3;
            else if (parte1 == "    " && parte2 == "|__|" && parte3 == "   |") numero = 4;
            else if (parte1 == " __ " && parte2 == "|__ " && parte3 == " __|") numero = 5;
            else if (parte1 == " __ " && parte2 == "|__ " && parte3 == "|__|") numero = 6;
            else if (parte1 == "__  " && parte2 == "  | " && parte3 == "  | ") numero = 7;
            else if (parte2 == parte3) numero = 8;
            else if (parte1 == " __ " && parte2 == "|__|" && parte3 == " __|") numero = 9;
            else if (parte1 == " __ " && parte2 == "|  |" && parte3 == "|__|") numero = 0;

            return numero;
        }
        private void CarregarEscrita()
        {
            if (numero == 1)
            {
                parte2 = "  | "; parte1 = " _  "; parte3 = " _|_";
            }
            else if (numero == 2)
            {
                parte1 = " __ "; parte2 = " __|"; parte3 = "|__ ";
            }
            else if (numero == 3)
            {
                parte1 = " __ "; parte2 = " __|"; parte3 = " __|";
            }
            else if (numero == 4)
            {
                parte1 = "    "; parte2 = "|__|"; parte3 = "   |";
            }
            else if (numero == 5)
            {
                parte1 = " __ "; parte2 = "|__ "; parte3 = " __|";
            }
            else if (numero == 6)
            {
                parte1 = " __ "; parte2 = "|__ "; parte3 = "|__|";
            }
            else if (numero == 7)
            {
                parte1 = "__  "; parte2 = "  | "; parte3 = "  | ";
            }
            else if (numero == 8)
            {
                parte1 = " __ "; parte2 = "|__|"; parte3 = "|__|";
            }
            else if (numero == 9)
            {
                parte1 = " __ "; parte2 = "|__|"; parte3 = " __|";
            }
            else if (numero == 0)
            {
                parte1 = " __ "; parte2 = "|  |"; parte3 = "|__|";
            }
        }

        public string RetornarEscrita()
        {
            if (!(parte1 != null && parte1 != "")) if (numero > 0 && numero < 10) CarregarEscrita();

            string valor = "";
            valor += parte1 + "\n";
            valor += parte2 + "\n";
            valor += parte3;

            return valor;
        }

        public string Parte1 { get => parte1; set => parte1 = value; }
        public string Parte2 { get => parte2; set => parte2 = value; }
        public string Parte3 { get => parte3; set => parte3 = value; }
        public int NumeroObj { get => numero; set => numero = value; }
    }
}
