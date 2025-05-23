﻿using System.Diagnostics;
using System.Text;

namespace GMI24H_Labb_4
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Generic Stack Parenthesis Check\n" +
                              "Press 2 for LinkedList Stack Parenthesis Check");
            string userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                StackClass stackClass = new StackClass();
                stackClass.CountParenthesis(1);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else if (userInput == "2")
            { 
                StackClass stackClass = new StackClass();
                stackClass.CountParenthesis(2);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            
            

            // Använd addRemoveOneByOne = true för att lägga till och ta bort personer en och en
            // Använd addRemoveOneByOne = false för att istället ta lägga till alla direkt och sedan ta bort alla i ett steg
            // time är hur fort animationen ska gå.
            // addRemoveOneByOne = false;
            bool addRemoveOneByOne = true;
            int time = 50;
            int index = 1;

            // ________________________OBS!!__________________________________________
            // LÄGG TILL DIN SÖKVÄG FÖR Names.csv
            // Måste ligga lokalt
            
            string file = "/Users/williamekbladh/Desktop/Names.csv";

            // string file = "C:\\Users\\Ted\\Documents\\GitHub\\GMI24H_Labb_4\\Names.csv";

            // instansierar ListReferenceBased, dvs skapar en länkad lista
            ListReferenceBased list = new ListReferenceBased();

            Person personToAdd = new Person("w2", 0501, "Modulo & Ovveride ansvarig");

            // loop för att fylla LL med värden från csv-fil
            foreach (var line in File.ReadLines(file))
            {
                var values = line.Split(',');
                if (values.Length == 3)
                {
                    if (addRemoveOneByOne)
                    {
                        Console.Clear();
                        Console.WriteLine("Lägger till...");
                        string name = values[0];
                        int id = int.Parse(values[1])+1000;
                        string occuaption = values[2];
                        Console.WriteLine(name + "," + id + "," + occuaption);
                        Thread.Sleep(time);
                        Person person = new Person(name,id,occuaption);
                        list.Add(index,person);
                        index++;
                    }
                    else
                    {
                        string name = values[0];
                        int id = int.Parse(values[1]);
                        string occuaption = values[2];
                        Person person = new Person(name,id,occuaption);
                        list.Add(index,person);
                        index++;
                    }
                    
                }

            }

            // kontroll för att se att LL fungerar
            bool check = list.IsEmpty();
            Console.WriteLine("IsEmpty returnerar: " + check);
            int size = list.Size();
            Console.WriteLine("Listans storlek: " + size + "\n");

            // hämtar några värden och skriver ut dem
            object node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            object node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            object node3 = list.Get(3);
            Console.WriteLine(node3.ToString());

            // tar bort en person från LL
            Console.WriteLine("\nVi tar bort personen på plats 2\n");
            list.Remove(2);

            // Skriver ut de tre första noderna i listan, här ser vi att Zlatan har försvunnit
            node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            node3 = list.Get(3);
            Console.WriteLine(node3.ToString());

            // Lägger till en person på plats 100(sist) i LL
            Console.WriteLine("\nVi lägger till w2 på plats 100\n");
            list.Add(100, personToAdd);

            node1 = list.Get(98);
            node2 = list.Get(99);
            node3 = list.Get(100);

            Console.WriteLine(node1.ToString());
            Console.WriteLine(node2.ToString());
            Console.WriteLine(node3.ToString());

            // Loop som kan ta bort alla personer på en gång eller en och en
            int temp = list.Size();
            if (!addRemoveOneByOne)
            {   Console.WriteLine("Plockar bort alla element.");
                list.RemoveAll();
                check = list.IsEmpty();
                Console.WriteLine("\nIsEmpty returnerar: " + check);
                Console.WriteLine("Listans storlek: " + list.Size() + "\n");
            }
            else
            {
                while (list.Size() > 1)
                {
                    Console.Clear();
                    Random rnd = new Random();
                    int rand = rnd.Next(1, temp);
                    Console.WriteLine("Plockar bort...");
                    Console.WriteLine(list.Get(rand));
                    list.Remove(rand);
                    Console.WriteLine("På index: " + rand + "/" + (list.Size()));
                    temp--;
                    Thread.Sleep(time);
                }

            }

            // Loop för att låta användaren välja om tidtagning ska ske
            bool comparison = true;
            while (comparison)
            {


                Console.WriteLine("Vill du utvärdera tidsåtgång i vår länkade lista jämförelse med en Array?\n" +
                                  "Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.Clear();
                    ComparisonClass compare = new ComparisonClass();
                    compare.CompareLlToArray();
                    comparison = false;

                }
                else if (input.ToLower() == "n")
                {
                    Console.WriteLine("Exit...");
                    Thread.Sleep(1000);
                    comparison = false;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du skrev: " + input + " ,det är inte Y eller N\n\n" +
                                      "Försök igen!");
                }
            }
        }
    }
}