using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                //string a = "povilas";
                //string b = "velicka";
                //reverse(a, out b);
                //void reverse(string a,out string b)
                //{
                //    b = a ;
                 
                //}
                //char[] arr = "čybis".ToCharArray();
                
                //Console.WriteLine($"Iki paketimo: {string.Join("",arr)}");
                //update_char(ref arr, arr);

                //void update_char(ref char[] val,char[]arr2)
                //{
                    
                //    val = null;
                //    arr2[0] = "?".ToCharArray()[0];
                //    val = arr;
                //}
                //Console.WriteLine($"Po paketimo: {string.Join("", arr)}");
                
                
                
                
                //Console.ReadKey();
                Console.Clear();
                Example_Palindrom();
            } while (Console.ReadKey().KeyChar.ToString ().ToLower () != "q");
            
        }
        static void Example_Palindrom()
        {
            //Console.WriteLine("Parašykite žodį, aš iš jo padarysiu Polindromą (apversiu)");
            //Console.Write("\nJūsų žodis: ");
            const string filePath = @"C:\Users\povvel\Desktop\tekstas to polindromas.txt";
            string[] fileBody = System.IO.File.ReadAllText(filePath).Split(" ");

            foreach(string xWord in fileBody)
            {
                string poligon = ToPolindrom(xWord);
                if (Array.Find(fileBody, x => x.ToLower().Equals(poligon) ) !=null) 
                {
                    
                    Console.WriteLine($"{xWord } ir {poligon  }");
                }
            }
            Console.WriteLine($"\nPolindromas: {ToPolindrom(Console.ReadLine())}");
            
          
            
        }
        static string ToPolindrom(in string val)
        {
            char[] tArr = new char[val.ToCharArray().Length];
            for (int i = 0; i < tArr.Length; i++)
            {
                tArr[i] = val.ToCharArray()[val.ToCharArray().Length - i - 1];
            }
            return string.Join("", tArr).ToLower();
        }
    }

}
