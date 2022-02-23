using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace TodoList

{

    class Character
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Health { get; set; }
        public string Tur { get; set; }


        public Character(string name, string strength, string health, string tur)
        {
            Name = name;
            Strength = strength;
            Health = health;
            Tur = tur;
        }
    }

    class Program

    {

        static void Main(string[] args)

        {

            bool showMenu = true;

            while (showMenu)

            {

                showMenu = MainMenu();

            }

        }

        public static bool MainMenu()

        {
            Console.Clear();

            Console.WriteLine("Välj vilken funktionalitet som ska köras:");

            Console.WriteLine("0) Stänga ner");

            Console.WriteLine("1) Funktion som skriver ut ”Hello World” i konsolen");

            Console.WriteLine("2) Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder) och sedan skriver ut dessa i konsolen");

            Console.WriteLine("3) Funktion som ändrar färgen på texten i konsolen (och ändrar tillbaka om man använder funktionen igen");

            Console.WriteLine("4) Funktion för att skriva ut dagens datum");

            Console.WriteLine("5) Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.");

            Console.WriteLine("6) Funktion som genererar att slumpmässigt tal mellan 1 och 100. Användaren ska sedan gissa talet. Gissar användaren rätt så ska ett meddelande sägadetta, samt hur många försök det tog. Gissar användaren fel ska ett meddelande visas som informerar ifall talet var för stort eller för litet");

            Console.WriteLine("7) Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken");

            Console.WriteLine("8) Funktion där en fil läses in från hårddisken (för enkelhetens skull kan man använda filen från uppgift 7)");

            Console.WriteLine("9) Funktion där användaren skickar in ett decimaltal och får tillbakaroten ur, upphöjt till 2 och upphöjt till 10");

            Console.WriteLine("10) Funktion där programmet skriver ut en multiplikationstabell från 1 till 10. En ”tabb”ska läggas in efter varje nummer. Försöka att ställa upp det så det blir relativt läsbart.");

            Console.WriteLine("11) Funktion som skapar två arrayer. Den första fylls med slumpmässiga tal. Den andra fylls med talen från den första i stigande ordning.Array.Sort() får EJ användas.");

            Console.WriteLine("12) Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom (alltså samma ord från båda håll, såsom Anna eller radar.");

            Console.WriteLine("13) Funktion som tar två inputs från användaren och skriver sedan ut alla siffror som är mellan de två inputsen.");

            Console.WriteLine("14) Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan sorteras och skrivs ut efter udda och jämna värden. ");

            Console.WriteLine("15) Funktion där användaren skriver in ett antal värden(komma-separerade siffor) som sedan adderas och skrivs ut.");

            Console.WriteLine("16) Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare. Funktionenskall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som sparas i en instans av en klass.");

            Console.Write("\r\nVälj ett alternativ: ");

            switch (Console.ReadLine())

            {

                case "1":

                    Hello_World();

                    return true;

                case "2":

                    Personal_data();

                    return true;
                case "3":

                    Change_color();

                    return true;
                case "4":

                    Todays_date();

                    return true;
                case "5":

                    Which_is_largest();

                    return true;
                case "6":

                    Guess_number();

                    return true;
                case "7":

                    Save_txtfile();

                    return true;
                case "8":

                    Read_txtfile();

                    return true;
                case "9":

                    Get_root();

                    return true;
                case "10":

                    Multiplication_table();

                    return true;
                case "11":

                    Sort_array();

                    return true;
                case "12":

                    Check_palindrome();

                    return true;
                case "13":

                    Print_all_numbers();

                    return true;
                case "14":

                    Odd_even_values();

                    return true;
                case "15":

                    Add_and_print();

                    return true;
                case "16":

                    Add_random_values_health_strength_luck();

                    return true;

                case "0":

                    return false;

                default:

                    return true;
            }
        }


        public static string Hello_World()
        {
            Console.WriteLine("\r\nHello World!");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Personal_data()
        {
            Console.Clear();
            Console.Write("\r\nAnge Förnamn: ");
            string fisrtName = CaptureInput();
            Console.Write("\r\nAnge Efternamn: ");
            string lastname = CaptureInput();
            Console.Write("\r\nAnge Ålder: ");
            int age = Int16.Parse(CaptureInput());
            Console.Write("\r\nPersonal data: \r\nFörnamn:" + fisrtName + "\r\nEfternamn: " + lastname + "\r\nÅlder: " + age + "\r\n");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Change_color()
        {
            Console.Clear();
            Console.Write("\r\nAnge Text: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string enterText = CaptureInput();
            Console.ResetColor();
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Todays_date()
        {
            Console.Clear();
            var todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine("\r\nToday is: " + todayDate);
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Which_is_largest()
        {
            Console.Clear();
            Console.Write("\r\nAnge första nummer: ");

            int number1 = Int32.Parse(GetNumber());
            Console.Write("\r\nAnge andra nummer: ");
            int number2 = Int32.Parse(GetNumber());

            if (number1 > number2)
            {
                Console.Write("\r\nStörst nummer är: " + number1);
            }
            else Console.Write("\r\nStörst nummer är: " + number2);
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }

        public static string Guess_number()
        {
            Console.Clear();
            int count = 1;
            int randomNumber = RandomNumber();
            Console.Write("\r\nGissa talet mellan 1 och 100:  ");
            int number = Int16.Parse(GetNumber());

            while (randomNumber != number)
            {
                if (number > randomNumber)
                {
                    count++;
                    Console.Write("\r\nTalet var för stort Gissa talet igen:  ");
                    number = Int16.Parse(GetNumber());
                    continue;

                }
                else if (number < randomNumber)
                {
                    count++;
                    Console.Write("\r\nTalet var för litet Gissa talet igen:  ");
                    number = Int16.Parse(GetNumber());
                    continue;
                }

                Console.Write("\r\ncount: " + count);
            }

            Console.Write("\r\nGrattis! Du har gissat talet");
            Console.Write("\r\nDu hade " + count + " försök");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Save_txtfile()
        {
            Console.Clear();
            Console.Write("\r\nSkriv in texten du vill spara i filen! När du är klar trycker du på enter\r\n");
            string text = CaptureInput();
            using (StreamWriter sw = new StreamWriter("sample.txt", false, Encoding.UTF8, 65536))
            {
                sw.WriteLine(text);
            }
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }

        public static string Read_txtfile()
        {
            Console.Clear();
            string text = System.IO.File.ReadAllText(@"sample.txt");
            System.Console.WriteLine("\r\nInnehåll av filen: \r\n{0}", text);
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Get_root()
        {
            Console.Clear();
            Console.Write("Ange ett decimaltal: ");
            double value = double.Parse(Console.ReadLine());
            decimal root = (decimal)Math.Sqrt((double)value);
            decimal raisedTo2 = (decimal)Math.Pow(value, 2);
            decimal raisedTo10 = (decimal)Math.Pow(value, 10);

            Console.WriteLine("Roten tal: " + root);
            Console.WriteLine("Upphöjt till 2: " + raisedTo2);
            Console.WriteLine("Upphöjt till 10: " + raisedTo10);
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Multiplication_table()
        {
            Console.Clear();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + " * " + i + " = " + j * i + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Sort_array()
        {
            Console.Clear();
            int listLength = 0;
            Console.Write("\r\nAnge längden på listan: ");
            listLength = Int16.Parse(CaptureInput());
            int[] randomizeList = new int[listLength];
            int i, j;
            Console.Write("\r\nSlumpmässiga array: ");

            for (i = 0; i < listLength; i++)
            {
                randomizeList[i] = RandomNumber();
                Console.Write(" " + randomizeList[i]);
            }

            Console.Write("\r\nArray efter sort: ");
            int temp = 0;
            int[] sortList = randomizeList;

            for (i = 0; i < sortList.Length - 1; i++)
            {
                for (j = i + 1; j > 0; j--)
                {
                    if (sortList[j - 1] > sortList[j])
                    {
                        temp = sortList[j - 1];
                        sortList[j - 1] = sortList[j];
                        sortList[j] = temp;
                    }
                }
            }
            foreach (int p in sortList)
                Console.Write(p + " ");
            Console.Read();
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Check_palindrome()
        {
            Console.Clear();
            string user, radar;
            Console.Write("User:");
            user = Console.ReadLine();
            Console.Write("Radar:");
            radar = Console.ReadLine();
            if (user == radar)
            {
                Console.WriteLine("\r\n Palindrom:");
            }
            else Console.WriteLine("\r\n Inte palindrom:");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Print_all_numbers()
        {
            Console.Clear();
            string user1, user2;

            Console.Write("User1:");
            user1 = Console.ReadLine();

            Console.Write("User2:");
            user2 = Console.ReadLine();

            foreach (int p in GetNumbersFromString(user1))
                Console.Write(p + " ");

            foreach (int p in GetNumbersFromString(user2))
                Console.Write(p + " ");

            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Odd_even_values()
        {
            Console.Clear();

            List<int> numberList = new List<int>(GetNumbersFromList(CommaSeparatedDigits(ListLength())));
            Console.Write("Jämna Nummer är: ");
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    Console.Write(numberList[i] + " ");
                }
            }
            Console.Write("\r\n" + "Udda Nummer är: ");
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 1)
                {
                    Console.Write(numberList[i] + " ");
                }
            }
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Add_and_print()
        {
            Console.Clear();
            List<int> numberList = new List<int>(GetNumbersFromList(CommaSeparatedDigits(ListLength())));

            int sum = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                sum += numberList[i];
            }

            Console.Write("Adderas nummer: " + sum);
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();
        }

        public static string Add_random_values_health_strength_luck()
        {
            Console.Clear();
            Console.Write("Ange första karaktär: ");
            Character Charchter1 = new Character(GetCharchterName(), GetStrength(), GetHealth(), GetTur());
            Console.Write("Ange Andra karaktär: ");

            Character Charchter2 = new Character(GetCharchterName(), GetStrength(), GetHealth(), GetTur());
            Console.WriteLine(Charchter1.Name + ", Styrka:" + Charchter1.Strength + ", Hälsa:" + Charchter1.Health + ", Tur:" + Charchter1.Tur);
            Console.WriteLine(Charchter2.Name + ", Styrka:" + Charchter2.Strength + ", Hälsa:" + Charchter2.Health + ", Tur:" + Charchter2.Tur);

            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");

            return Console.ReadLine();

        }


        public static string GetCharchterName()
        {
            return Console.ReadLine();
        }

        public static string RandomChar()
        {
            Random rnd = new Random();
            string randomChar = "";
            for (int i = 1; i <= 3; i++)
            {
                randomChar += (char)rnd.Next('X', 'Z');
            }
            return randomChar;
        }

        public static string GetStrength()
        {

            return RandomChar();
        }

        public static string GetHealth()
        {

            return RandomChar();
        }

        public static string GetTur()
        {

            return RandomChar();
        }


        public static string CaptureInput()
        {
            return Console.ReadLine();
        }

        public static string GetNumber()
        {
            return Console.ReadLine();
        }

        public static int RandomNumber()
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 101);
            return randomnumber;
        }



        public static List<int> GetNumbersFromString(string user)
        {
            var listOfNumbers = new List<int>();

            for (int i = 0; i < user.Length; i++)
            {
                if (Char.IsNumber(user[i]))
                {
                    listOfNumbers.Add(int.Parse(user[i].ToString()));
                }
            }
            return listOfNumbers;
        }

        public static int ListLength()
        {
            int listLength = 0;
            Console.Write("\r\nAnge längden på nummer listan: ");
            listLength = Int16.Parse(CaptureInput());
            return listLength;
        }

        public static string CommaSeparatedDigits(int listLength)
        {
            string numberList = "";
            Console.WriteLine("Ange numbers:");

            for (int i = 1; i <= listLength; i++)
            {
                if (i < listLength)
                {
                    numberList += Console.ReadLine() + ", ";
                }
                else
                {
                    numberList += Console.ReadLine() + " ";
                }
            }
            Console.WriteLine("Siffrorna du angav:" + numberList);
            return numberList;
        }

        public static List<int> GetNumbersFromList(string user)
        {
            var listOfNumbers = new List<int>();
            string value = "";
            for (int i = 0; i < user.Length; i++)
            {
                if (Char.IsNumber(user[i]))
                {
                    value += user[i];
                }
                else if ((Char.IsWhiteSpace(user[i])) || (Char.IsSymbol(user[i])))
                {
                    listOfNumbers.Add(int.Parse(value.ToString()));
                    value = "";
                }
            }
            return listOfNumbers;
        }
    }


}