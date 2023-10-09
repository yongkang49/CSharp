using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*********************************
            bool[] b = new bool[] { true, true, true, true, true, true, true, true, true };
            Console.WriteLine(Convert_Binario_To_Intero(b));
            //*********************************
            int[] dp = new int[] { 10, 10 };
            Console.WriteLine(Convert_Decimale_Puntato_To_Intero(dp));
            //*********************************
            int[] dp1 = Convert_Binario_To_Decimale_Puntato(b);
            foreach (int item in dp1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //********************************
            bool[] b1 = Convert_Decimale_Puntato_To_Binario(dp);
            foreach (bool item in b1)
            {
                Console.Write(Convert.ToInt16(item));
            }
            Console.WriteLine();
            //********************************
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(dp));
            //********************************
            int[] dp2 = Convert_Numero_Decimale_To_Decimale_Puntato(300);
            foreach (int item in dp2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //********************************
            bool[] b2 = Convert_Numero_Decimale_To_Binario(300);
            foreach (bool item in b2)
            {
                Console.Write(Convert.ToInt16(item));
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(bool[] b)
        {

            int decimale = 0;
            for (int i = 0; i < b.Length; i++)
            {
                decimale += Convert.ToUInt16(b[b.Length - i - 1]) * (int)Math.Pow(2, i);
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Intero(int[] dp)
        {
            int decimale = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale += dp[dp.Length - i - 1] * (int)Math.Pow(256, i);
            }
            return decimale;
        }
        static int[] Convert_Binario_To_Decimale_Puntato(bool[] b)
        {
            int[] dp = new int[4];
            int len = 0;
            int decimale = 0;
            for (int i = 0; i < b.Length / 8 + 1; i++)
            {
                if (b.Length % 8 != 0 && b.Length / 8 == i)
                {
                    len = b.Length % 8;
                }
                else
                {
                    len = 8;
                }
                if (i <= b.Length / 8)
                {
                    for (int j = 0; j < len; j++)
                    {
                        decimale += Convert.ToUInt16(b[b.Length - j - 1]) * (int)Math.Pow(2, j);
                    }
                    dp[dp.Length - 1 - i] = decimale;
                    decimale = 0;
                }
            }
            return dp;
        }
        static bool[] Convert_Decimale_Puntato_To_Binario(int[] dp)
        {
            bool[] b = new bool[32];
            int resto;
            int parti;
            Array.Reverse(dp);
            for (int i = 0; i < dp.Length; i++)
            {
                parti = dp[i];
                for (int j = 0; j < 8; j++)
                {
                    resto = parti % 2;
                    parti = parti / 2;
                    b[j + i * 8] = Convert.ToBoolean(resto);
                }
            }
            Array.Reverse(b);
            return b;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int dec = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                dec += dp[dp.Length - i - 1] * (int)Math.Pow(256, i);
            }
            return dec;
        }
        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(long decimale)
        {
            int[] dp = new int[4];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[dp.Length - 1 - i] = (int)(decimale % 256);
                decimale = decimale / 256;
            }
            return dp;
        }
        static bool[] Convert_Numero_Decimale_To_Binario(long decimale)
        {
            bool[] b = new bool[32];
            for (int i = 0; i < b.Length && decimale > 0; i++)
            {
                b[b.Length - 1 - i] = Convert.ToBoolean(decimale % 2);
                decimale = decimale / 2;
            }
            return b;
        }
    }
}
