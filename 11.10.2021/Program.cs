using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToUpperCasenew toUpperCasenew = new ToUpperCasenew();
            StringBuilderTest stringBuilderTest = new StringBuilderTest();
        }
    }
    class StringBuilderTest
    {
        public StringBuilderTest()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 20000000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb);
            Console.ReadLine();
        }

    }
    class ToUpperCasenew
    {
        public ToUpperCasenew()
        {
            bool uppercase = false;
            char[] separators = {'<','>'};
            string p = "He's a <upcase>real nowhere man</upcase>, sitting in his land.";
            string[] field = p.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == "/upcase")
                {
                    uppercase = false;
                    field[i] = "";
                }
                if (uppercase == true)
                {
                    field[i] = field[i].ToUpper();
                }
                if (field[i] == "upcase")
                {
                    uppercase = true;
                    field[i] = "";
                }
            }
            for (int i = 0; i < field.Length; i++)
            {
                Console.Write(field[i]);
            }
            Console.ReadLine();
        }
    }
}
