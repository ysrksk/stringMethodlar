using System;

namespace StringMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
            string degisken2 = "Csharp";

            //Length
            System.Console.WriteLine(degisken.Length);

            // ToUpper, ToLower
            System.Console.WriteLine(degisken.ToUpper());
            System.Console.WriteLine(degisken.ToLower());

            //Concat
            System.Console.WriteLine(string.Concat(degisken, "MErhaba!"));

            //Compare, CompareTo
            System.Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            System.Console.WriteLine(string.Compare(degisken, degisken2, true));
            System.Console.WriteLine(string.Compare(degisken, degisken2, false));

            //Contains
            System.Console.WriteLine(degisken.Contains(degisken2));
            System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            System.Console.WriteLine(degisken.StartsWith("MErhaba!"));

            //IndexOf
            System.Console.WriteLine(degisken.IndexOf("C5"));
            System.Console.WriteLine(degisken.IndexOf("Zikriye"));

            //Insert
            System.Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //Remove
            System.Console.WriteLine(degisken.Remove(10));
            System.Console.WriteLine(degisken.Remove(5,3));

            //Replace
            System.Console.WriteLine(degisken.Replace("Csharp", "C#"));
            // System.Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            System.Console.WriteLine(degisken.Split(" ")[1]);

            //Substring
            System.Console.WriteLine(degisken.Substring(4));






            





        }
    }
}
