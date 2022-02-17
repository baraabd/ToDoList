﻿using System;



namespace TodoList

{

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

        private static bool MainMenu()

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

            Console.Write("\r\nSelect an option: ");


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
        private static string Personal_data()

        {

            Console.Write("\r\nPersonal_data: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Change_color()

        {

            Console.Write("\r\nChange_color ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Todays_date()

        {

            Console.Write("\r\nTodays_date: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Which_is_largest()

        {

            Console.Write("\r\nWhich_is_largest: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Guess_number()

        {

            Console.Write("\r\nGuess_number: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Save_txtfile()

        {

            Console.Write("\r\nSave_txtfile: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Read_txtfile()

        {

            Console.Write("\r\nRead_txtfile: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Get_root()

        {

            Console.Write("\r\nGet_root: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Multiplication_table()

        {

            Console.Write("\r\nMultiplication_table: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Sort_array()

        {

            Console.Write("\r\nSort_array: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Check_palindrome()

        {

            Console.Write("\r\nCheck_palindrome: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Print_all_numbers()

        {

            Console.Write("\r\nPrint_all_numbers: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Odd_even_values()

        {

            Console.Write("\r\nOdd_even_values: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Add_and_print()

        {

            Console.Write("\r\nAdd_and_print: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }
        private static string Add_random_values_health_strength_luck()

        {

            Console.Write("\r\nAdd_random_values_health_strength_luck: ");
            Console.Write("\r\nTryck på Enter för att återgå till huvudmenyn");
            return Console.ReadLine();

        }

    }

}