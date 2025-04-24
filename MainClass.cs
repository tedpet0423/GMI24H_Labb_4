using System.Text;

namespace GMI24H_Labb_4
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            int time = 100;
            string file = "C:\\Users\\Ted\\Documents\\GitHub\\GMI24H_Labb_4\\Names.csv";
            Console.WriteLine("Hello, World!");
            ListReferenceBased list = new ListReferenceBased();
            int index = 1;
            foreach (var line in File.ReadLines(file))
            {
                var values = line.Split(',');
                if (values.Length == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Lägger till...");
                    string name = values[0];
                    int id = int.Parse(values[1]);
                    string occuaption = values[2];
                    Console.WriteLine(name + "," + id + "," + occuaption);
                    Thread.Sleep(time);
                    Person person = new Person(name,id,occuaption);
                    list.Add(index,person);
                    index++;
                }

            }
            //Person person = new Person("ted", 0423, "certified Felkod 60");
            Person person2 = new Person("w2", 0501, "Modulo & Ovveride ansvarig");
            //Person person3 = new Person("Jans", 1970, "Ogillar mac");
            //
            //list.Add(1, person);
            //list.Add(2, person2);
            //list.Add(3,person3);
            bool check = list.IsEmpty();
            Console.WriteLine(check);
            int size = list.Size();
            Console.WriteLine(size);
            object node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            object node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            object node3 = list.Get(3);
            Console.WriteLine(node3.ToString());

            Console.WriteLine("VI TAR BORT PERSON PÅ PLATS 2");
            list.Remove(2);

            node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            //node3 = list.Get(3);
            //Console.WriteLine(node3.ToString());

            Console.WriteLine("VI LÄGGER W2 PÅ SISTA INDEX");
            list.Add(100, person2);
            node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            node3 = list.Get(3);
            Console.WriteLine(node3.ToString());
            int temp = list.Size();

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
    }
}