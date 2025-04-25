using System.Text;

namespace GMI24H_Labb_4
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            
            // Använd Visualize = true för att lägga till och ta bort personer en och en
            // Använd Vizualize = false för att istället ta lägga till alla direkt och sedan ta bort alla i ett steg
            // time är hur fort animationen ska gå, 200 är läsbart
            bool visualize = false;
            int time = 100;
            int index = 1;
            
            // ________________________OBS!!__________________________________________
            // LÄGG TILL DIN SÖKVÄG FÖR Names.csv
            
            string file = "/Users/tedpettersson/Desktop/Skola/GMI24H/GMI24H_Labb_4/Names.csv";
            
            // instansierar  ListReferenceBased, dvs skapar en länkad lista 
            ListReferenceBased list = new ListReferenceBased();
            
            Person personToAdd = new Person("w2", 0501, "Modulo & Ovveride ansvarig");
            
            
            foreach (var line in File.ReadLines(file))
            {
                var values = line.Split(',');
                if (values.Length == 3)
                {
                    if (visualize)
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
           
            bool check = list.IsEmpty();
            Console.WriteLine("IsEmpty returnerar: " + check);
            int size = list.Size();
            Console.WriteLine("Listans storlek: " + size + "\n");
            
            object node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            object node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            object node3 = list.Get(3);
            Console.WriteLine(node3.ToString());

            Console.WriteLine("\nVi tar bort personen på plats 2\n");
            list.Remove(2);

            node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            node3 = list.Get(3);
            Console.WriteLine(node3.ToString());

            Console.WriteLine("\nVi lägger till w2 på plats 99\n");
            
            list.Add(100, personToAdd);
            
            node2 = list.Get(98);
            Console.WriteLine(node2.ToString());
            
            object node4 = list.Get(99);
            node3 = list.Get(100);
            Console.WriteLine(node3.ToString());
            Console.WriteLine(node4.ToString());
            int temp = list.Size();
            if (!visualize)
            {
                list.RemoveAll();
                Console.WriteLine("\nIsEmpty returnerar: " + check);
                Console.WriteLine("Listans storlek: " + list.Size() + "\n");  
            }
            else
            {
                while (list.Size() > 0)
                {
                    Random rnd = new Random();
                    int rand = rnd.Next(1, temp);
                    Console.Clear();
                    Console.WriteLine("Plockar bort...");
                    Console.WriteLine(list.Get(rand));
                    list.Remove(rand);
                    Console.WriteLine("På plats: " + rand + "/" + (list.Size()+1));
                    temp--;
                    Thread.Sleep(time);
                }
                
            }

            bool comparison = true;
            while (comparison)
            {


                Console.WriteLine("Vill du utvärdera tidsåtgång i vår länkade lista jämförelse med en Array?\n" +
                                  "Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.WriteLine("Kul!");
                    // göra något smart här
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