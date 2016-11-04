using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            while (x != 999)
            {                
                Console.WriteLine(naturalARomano(x));
                x = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadKey();
        }

        private static string naturalARomano(int num)
        {
            string romano;

            if (num <= 0)
                return "";

            if(num == 1)
                return "I";

            if (num == 2)
                return "II";

            if (num == 3)
                return "III";

            if (num == 4)
                return "IV";

            if (num == 5)
                return "V";

            if (num == 6)
                return "VI";

            if (num == 7)
                return "VII";

            if (num == 8)
                return "VIII";

            if (num == 9)
                return "IX";

            if (num == 10)
                return "X";

            if (num >= 11 && num <= 19)
                return "X" + naturalARomano(num - 10);

            if (num == 20)
                return "XX";

            if (num >= 21 && num <= 29)
                return "XX" + naturalARomano(num - 20);

            if (num == 30)
                return "XXX";

            if (num >= 31 && num <= 39)
                return "XXX" + naturalARomano(num - 30);

            if (num == 40)
                return "XL";

            if (num >= 41 && num <= 49)
                return "XL" + naturalARomano(num - 40);

            return "";

            //switch(num)
            //{
            //case 1 : return "I";
            //case 2 : return "II";
            //case 3 : return "III";
            //case 4 : return "IV";
            //case 5 : return "V";
            //case 6 : return "VI";
            //case 7 : return "VII";
            //case 8 : return "VIII";
            //case 9 : return "lX";
            //case 10 : return "X";
            //case 11 : return "XI";
            //case 12 : return "XII";
            //case 13 : return "XIII";
            //case 14 : return "XIV";
            //case 15 : return "XV";            
            //    case (16) : return ("x" + naturalARomano(num - 10));
                
            //    case ( > 15 && num < 20) : return "X" + naturalARomano(num - 10)
            //case 20 : return "XX";
            //case Is < 30 : num = "XX" & num(value - 20)
            //case 30 : return "XXX";
            //case 40 : return "XI";
            //case 50 : return "L";
            //case 60 : return "LX";
            //case 70 : return "LXX";
            //case 80 : return "LXXX";
            //case 90 : return "XC";
            //case Is < 100 : num = num(Int(value \ 10) * 10) & "" & num(value Mod 10)
            //case 100 : return "C";
            //case Is < 200 : num = "C" & num(value - 100)
            //case 200, 300, 400, 600, 800 : num = num(Int(value \ 100)) & "C"
            //case 500 : return "D";
            //case 700 : return "DCC";
            //case 900 : return "CM";
            //case Is < 1000 : num = num(Int(value \ 100) * 100) & " " & num(value Mod 100)
            //case 1000 : return "M";
            //case Is < 2000 : num = "M" & num(value Mod 1000)
            //case Is < 1000000 : num = num(Int(value \ 1000)) & " M"
            //    If value Mod 1000 Then num = num & " " & num(value Mod 1000)
            //}

            //return romano;
        }
    }
}
