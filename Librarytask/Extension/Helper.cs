using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Task1_20._10.Exceptions;
using Task1_20._10.models;

namespace Task1_20._10.Extension
{
    internal static class Helper
    {
        public static int GetPositiveNum()
        {
            bool isParsed = int.TryParse(Console.ReadLine(), out int catId);
            if (!isParsed || catId <0)
            {
                throw new WrongInputException ("Wrong input");
            }

            return catId;
        }

        public static string Check()
        {
            string name = Console.ReadLine();
            foreach(char c in name)
            {
                if (c == ' ' || char.IsDigit(c))
                {
                    throw new WrongInputException("Wrong input");
                }
            }

            Console.WriteLine($"{name.Substring(0,1).ToUpper() + name.Substring(1).ToLower()}");

            return name;

        }


        

    }




    }

