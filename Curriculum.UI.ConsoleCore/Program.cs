﻿using System;

namespace Curriculum.UI.ConsoleCore
{
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //-----------------------------------------//



            string isim = "mustafa kemâl";
            string[] isimler = { "can", "evrim", "muh4mmed", "emre", "hüseyin"};


            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }

            for (int i = 0; i < isim.Length; i++)
            {
                Console.Write(isim[i]);
            }



            Console.ReadKey();
        }
    }
}