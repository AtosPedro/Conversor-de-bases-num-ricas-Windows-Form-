using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeBases
{
    class NumberConverter
    {
        public static string Binary(string decimalNumber)
        {
            string binaryString = "";
            int auxNumber = Convert.ToInt32(decimalNumber);

            //divide o número decimal e adiciona os 1s e 0s a variável 'binaryString' dependendo do resultado da operaçção
            while (auxNumber != 0)
            {
                binaryString += auxNumber % 2 == 1 ? "1" : "0";
                auxNumber = auxNumber / 2;
            }
            //converte a variável 'binaryString' para um array de caracteres
            char[] binaryArray = binaryString.ToCharArray();
            //inverte a ordem do array
            Array.Reverse(binaryArray);
            //atribui um valor vazrio para a 'binaryString'
            binaryString = "";
            //percorre o array e preenche a 'binaryString' na ordem correta
            foreach (char c in binaryArray)
                binaryString += c;

            return binaryString;
        }
        public static string Hexadecimal (string decimalNumber)
        {
            //array com todas as possibilidades de caracteres hexadecimais
            string[] hexNumbers = new string[] { "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"};
            
            string hexString = "";
            //passa todos os caracteres decimais para maiúsculo
            decimalNumber = decimalNumber.ToUpper();
            int auxNumber = Convert.ToInt32(decimalNumber);

            while (auxNumber != 0)
            {
                hexString += hexNumbers[auxNumber % 16];
                auxNumber /= 16;
            }
            char[]hexArray = hexString.ToCharArray();
            Array.Reverse(hexArray);
            hexString = "";
            foreach (char c in hexArray)
                hexString += c;

            return hexString;
        }
        public static string Octal (string decimalNumber)
        {
            char[] octalArray;
            string octalString = "";
            int auxNumber = Convert.ToInt32(decimalNumber);

            while (auxNumber != 0)
            {
                octalString += auxNumber % 8;
                auxNumber /= 8;
            }
            octalArray = octalString.ToCharArray();
            Array.Reverse(octalArray);
            octalString = "";
            foreach (char c in octalArray)
                octalString += c;

            return octalString;
        }
        public static string BinaryToDecimal(string binary)
        {
            char[] binaryArray = binary.ToArray();
            string decimalNumber = "";
            double decimalInteger = 0;
            Array.Reverse(binaryArray);
            for (int i = 0; i < binaryArray.Length; i++)
            {
                if (binaryArray[i] == '1')
                {
                    double power = Math.Pow(2, i);
                    decimalInteger += power;
                }
            }
            decimalNumber = decimalInteger.ToString();
            return decimalNumber;
        }
        public static string HexToDecimal(string hexa)
        {
            hexa = hexa.ToUpper();
            char[] hexaArray = hexa.ToArray();
            string decimalNumber = "";
            double decimalInteger = 0;
            Array.Reverse(hexaArray);
            for (int i = 0; i < hexaArray.Length; i++)
            {
                double power = Math.Pow(16, i);
                switch (hexaArray[i])
                {
                    case '0':
                        decimalInteger += 0 * power;
                        break;
                    case '1':
                        decimalInteger += 1 * power;
                        break;
                    case '2':
                        decimalInteger += 2 * power;
                        break;
                    case '3':
                        decimalInteger += 3 * power;
                        break;
                    case '4':
                        decimalInteger += 4 * power;
                        break;
                    case '5':
                        decimalInteger += 5 * power;
                        break;
                    case '6':
                        decimalInteger += 6 * power;
                        break;
                    case '7':
                        decimalInteger += 7 * power;
                        break;
                    case '8':
                        decimalInteger += 8 * power;
                        break;
                    case '9':
                        decimalInteger += 9 * power;
                        break;
                    case 'A':
                        decimalInteger += 10 * power;
                        break;
                    case 'B':
                        decimalInteger += 11 * power;
                        break;
                    case 'C':
                        decimalInteger += 12 * power;
                        break;
                    case 'D':
                        decimalInteger += 13 * power;
                        break;
                    case 'E':
                        decimalInteger += 14 * power;
                        break;
                    case 'F':
                        decimalInteger += 15 * power;
                        break;
                }
            }
            decimalNumber = decimalInteger.ToString();
            return decimalNumber;
        }
        public static string OctalToDecimal(string Octal)
        {
            char[] octalArray = Octal.ToArray();
            string decimalNumber = "";
            double decimalInteger = 0;
            Array.Reverse(octalArray);
            for (int i = 0; i < octalArray.Length; i++)
            {
                double power = Math.Pow(8, i);
                decimalInteger += int.Parse(octalArray[i].ToString()) * power;
            }
            decimalNumber = decimalInteger.ToString();
            return decimalNumber;
        }
    }
}
