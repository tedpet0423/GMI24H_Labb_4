namespace GMI24H_Labb_4
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person person = new Person("ted", 0423, "certified Felkod 60");
            Person person2 = new Person("w2", 0501, "Modulo & Ovveride ansvarig");
            Person person3 = new Person("Jans", 1970, "Ogillar mac");
            ListReferenceBased list = new ListReferenceBased();
            list.Add(1, person);
            list.Add(2, person2);
            list.Add(3,person3);
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

            Console.WriteLine("VI TAR BORT W2");
            list.Remove(2);

            node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            //node3 = list.Get(3);
            //Console.WriteLine(node3.ToString());

            Console.WriteLine("VI LÄGGER W2 SIST");
            list.Add(3, person2);
            node1 = list.Get(1);
            Console.WriteLine(node1.ToString());
            node2 = list.Get(2);
            Console.WriteLine(node2.ToString());
            node3 = list.Get(3);
            Console.WriteLine(node3.ToString());


        }
    }
}