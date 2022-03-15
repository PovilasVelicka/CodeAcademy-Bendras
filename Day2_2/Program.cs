using System;

namespace Day2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example_1();
            //Example_2();
            //Example_3();
            //Example_4();
            //Example_5();
            //Example_5_1();
            //Example_6();
            //Example_7();
            //Example_8();

            //Recursija_1();//naudojant rekursija print array
            //Recursija_2();//naudojant rekursija sum array
            //Recursija_3();//naudojant rekursija gauti sum all char
        }
        static void Example_1()
        {
            Console.WriteLine("Įveskite du skaičius, o aš sukeisiu juos vietomis");
            Console.Write("\r\nX = ");

            decimal.TryParse(Console.ReadLine(), out decimal x);

            Console.Write("\r\nY = ");

            decimal.TryParse(Console.ReadLine(), out decimal y);

            decimal temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"\r\nDabar \r\nX = {x}");
            Console.WriteLine($"\r\nY = {y}");

            Console.ReadKey();
            Console.Clear();
        }
        static void Example_2()
        {
            
            DateTime ddd;
            ddd = DateTime.Now;
            ddd = ddd.Date;


            string mokykla = "Code Academy";
            string kursas = "C# PAGRINDAI";
            int studentai = 19;
            DateTime siandien = DateTime.Today;

            Console.WriteLine($"Mokyklos pavadinimas: {mokykla}\r\nKurso pavadinimas: {kursas}\r\nStudentų skaičius: {studentai.ToString()}\r\nŠiandinen: {siandien.ToShortDateString()}");
            Console.ReadKey();
            Console.Clear();
        }
        static void Example_3()
        {
            //naudojant ToString grąžinamas 
        


            DateTime pradzia = new DateTime(2022, 03, 01);
            DateTime pabaiga = new DateTime(2022, 10, 25);
            TimeSpan skirtumas = pabaiga.Subtract(pradzia);          


            Console.WriteLine($"Skirtumas tarp pradžios ir pabaigos (dienomis) = {skirtumas.TotalDays }");
            Console.WriteLine($"Skirtumas tarp pradžios ir pabaigos (savaičių) = {new DateAndTime().DateDiff(DateAndTime.Interval.Weeks, pradzia, pabaiga).ToString()}");
            Console.WriteLine($"Skirtumas tarp pradžios ir pabaigos (darbo dienomis) = { new DateAndTime().DateDiff(DateAndTime.Interval.WorkDays , pradzia, pabaiga).ToString ()}");
            Console.WriteLine($"Skirtumas tarp pradžios ir pabaigos (išeiginės) = { new DateAndTime().DateDiff(DateAndTime.Interval.WeekEndDays, pradzia, pabaiga).ToString()}");
            Console.WriteLine($"Skirtumas tarp pradžios ir pabaigos (metai) = { new DateAndTime().DateDiff(DateAndTime.Interval.Years, pradzia, pabaiga).ToString()}");

            Console.ReadKey();
            Console.Clear();
        }
        static void Example_4() {
            Console.WriteLine("Paprašysiu įvesti dvi reikšmes, o aš jas sulyginsiu.");
            Console.Write("\r\nReikšmė A: ");
            string A_4 = Console.ReadLine();
            Console.Write("\r\nReikšmė B: ");
            string B_4 = Console.ReadLine();
            if (A_4 == B_4)
            {
                Console.WriteLine("ATSAKYMAS: A = B");
            }
            else {

                Console.WriteLine("ATSAKYMAS: A <> B");

            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Example_5()
        {
            Console.WriteLine("Parašykite du skaičius. Aš prie A pridėsiu 1, o B sumažinsiu 1 naudojant komnadas ++ / --");

            int A_5;
            do
            {
                Console.Write("\r\nĮveskite skaičių A: ");
            } while (int.TryParse(Console.ReadLine(), out A_5) == false);

            int B_5;
            do
            {
                Console.Write("\r\nĮveskite skaičių B: ");
            } while (int.TryParse(Console.ReadLine(), out B_5) == false);

            Console.WriteLine($"\r\nPo operacijos ++ A = {++A_5}, o -- B = {--B_5}");

            Console.ReadKey();
            Console.Clear();
        }
        static void Example_5_1()
        {
            Console.WriteLine("Parašykite du skaičius. Aš išpradžių pridėsiu 1, o paskui sumažinsiu 1 naudojant komnadas ++ / --");
            decimal A_5;
            do
            {
                Console.Write("\r\nĮveskite skaičių A: ");
            } while (decimal.TryParse(Console.ReadLine(), out A_5) == false);

            decimal B_5;
            do
            {
                Console.Write("\r\nĮveskite skaičių B: ");
            } while (decimal.TryParse(Console.ReadLine(), out B_5) == false);

            Console.WriteLine($"\r\nPo operacijos ++ A = {Incr(A_5)}, o B = {Incr(B_5)}");  
            Console.WriteLine($"\r\nPo operacijos -- A = {Decr(A_5)}, o B = {Decr(B_5)}");

            decimal Incr(decimal value)
            {
                return ++value;
            }
            decimal Decr(decimal value)
            {               
                return --value;
            }

            Console.ReadKey();
            Console.Clear();
        }
        static void Example_6()
        {
            Console.WriteLine("Įveskite arba tiesiog paspauskit ENTER ir aš parašysiu ar įvedėt tekstą");
            string readetText = Console.ReadLine();
            if (readetText == string.Empty)
            {
                Console.WriteLine("HA! Jus nieko neįvedėt :)!!");
            }
            else {
                Console.WriteLine($"Jus įvedėt: {readetText}");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Example_7()
        {
            Console.WriteLine("Paprašysiu Jūsų įvesti skaičių, o aš parašysiu ar jis mažesnis už nulį '0'");
            Console.Write("\r\nJūsų skaičius :");
            int.TryParse(Console.ReadLine (), out int A_7);
            if(A_7 < 0)
            {
                Console.WriteLine($"Jūsų skaičius mažesnis < už nulį {A_7.ToString() } < 0");
            }
            else
            {
                Console.WriteLine($"Jūsų skaičius mažesnis arba lygus >= nuliui {A_7.ToString() } >= 0");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Example_8()
        {
            Console.WriteLine("Parašykite savo Vardą ir Pavardę, o aš jas palyginsiu");
            string userName;
            string userLastName;

            do
            {
                Console.Write("\r\nJūsų vardas: ");
                userName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(userName));

            do
            {
                Console.Write("\r\nJūsų pavardė: ");
                userLastName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(userLastName));
           
            Console.WriteLine($"\r\nJūsų (case insensitive) vardas ir pavardė : {ToName(userName)} {ToName(userLastName)}");
            Console.ReadKey();
            Console.Clear();
            string ToName(string value)
            {
                return value.Substring(0, 1).ToUpper() + "" + value.Substring(1, value.Length - 1).ToLower();
            }
        }
        static void Recursija_1()
        {
            string[] myArray= { "ff g"};
            int position = myArray.Length - 1;
            PrintArray(myArray, ref position);
            Console.ReadKey();
            static void PrintArray(string[] myArray, ref int position)
            {
                Console.WriteLine(myArray[position]);
                position--;
                if (position >= 0)
                {
                    PrintArray(myArray, ref position);
                }
            }
        }        
        static void Recursija_2()
        {
            int[] MyArray = { 12, 5, 12};

            int position = MyArray.Length ;
            int total = Suma(MyArray, ref position);
            Console.WriteLine(total.ToString());
            Console.ReadKey();
            int Suma(int [] myArr, ref int position)
            {
                position--;
                int result = myArr[position];
                if (position > 0) 
                {
                    return result + Suma(myArr, ref position);
                }
                else
                {
                    return result;
                }
            }
         
                
        }
        static void Recursija_3()
        {
            int val = 2125;
            char[] MyArray = val.ToString().ToCharArray();


            int position = MyArray.Length;
            int total = Suma(MyArray, ref position);
            Console.WriteLine(total.ToString());
            Console.ReadKey();
            int Suma(char[] myArr, ref int position)
            {
                position--;
                int result = int.Parse( myArr[position].ToString ());
                if (position > 0)
                {
                    return result + Suma(myArr, ref position);
                }
                else
                {
                    return result;
                }
            }


        }
    }
    class DateAndTime
    {
        public enum Interval
        {
            Days,
            Weeks,
            Month,
            WorkDays,
            WeekEndDays,
            Years
            
        }
        public  double  DateDiff(Interval i, DateTime from, DateTime to)
        {
            double counter = 0;
            switch (i)
            {
                case Interval.Days:
                    counter= (to - from).Days+1 ;
                    break;
                case Interval.Month:
                    for (DateTime x = from; x < to; x = x.AddMonths(1))
                    {
                        counter++;
                    }
                    break;
                case Interval.WorkDays:
                    for (DateTime x = from; x < to; x = x.AddDays (1))
                    {
                        if(
                            x.DayOfWeek != DayOfWeek.Saturday &&
                            x.DayOfWeek != DayOfWeek.Sunday &&
                            x.DayOfWeek != DayOfWeek.Friday )
                        {
                        counter++;
                        }
      
                    }
                    break;
                case Interval.WeekEndDays:
                    for (DateTime x = from; x < to; x = x.AddDays (1))
                    {
                        if (x.DayOfWeek == DayOfWeek.Saturday ||
                            x.DayOfWeek == DayOfWeek.Sunday)
                        {
                            counter++;
                        }
                    
                    }
                    break;
                case Interval.Weeks:
                    for (DateTime x = from; x <= to; x = x.AddDays(1))
                    {

                        if (x.DayOfWeek == DayOfWeek.Sunday)
                        {
                            counter++;
                        }
                    }
                    break;
                case Interval.Years:

                    for (DateTime x = from.AddDays(1); x <= to; x = x.AddDays(1))
                    {

                        if (x.Day == 1 && x.Month == 1)
                        {
                            counter++;
                        }
                    }
                    break;
            }

        
            return counter;

        }
    }

}
