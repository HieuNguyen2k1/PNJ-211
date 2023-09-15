// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace EX1
{


    public static class Program
    {


        public static void inn()
        {
            Console.WriteLine("Hello, World!");
            //========================================  EX1 =============================================
            int i = 0;
            while (i < 3)
            {
                String pass = Console.ReadLine();

                if (pass.Equals("12345"))
                {
                    Console.WriteLine("Login successful!");
                    i = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("error login!");
                    i++;
                }
            }
            if (i == 3)
            {
                Console.WriteLine("accout disable!");
            }
        };
        public static void inn1()
        {
            //===============================================  EX2  ======================================
            int passs = 11;
            Random rand = new Random();
            int int_random = rand.Next(passs);
            Console.WriteLine(" random in the range 0 to 10 : " + int_random);


        }
        //=================================================  EX3  =========================================
        //private static Random Random = new Random();
        private const string Digits = "0123456789";
        private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialCharacters = "!@#$%^&*()_+-=[]{}|;':\",./<>?";



        public static string GeneratePassword(int length)
        {
            var random = new Random();
            var password = new StringBuilder();
            var characterSet = Digits + LowerCase + UpperCase + SpecialCharacters;
            for (var i = 0; i < length; i++)
            {
                var index = random.Next(characterSet.Length);
                password.Append(characterSet[index]);

            }
            return password.ToString();
        }
        public static void Main()
        {
            Console.WriteLine("Random password: {0}", GeneratePassword(6));
            inn();
            inn1();
        }
    }
}

