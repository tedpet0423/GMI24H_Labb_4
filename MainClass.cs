namespace GMI24H_Labb_4
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person("ted", 0423, "certified Felkod 60");
            Person person2 = new Person("w2", 0501, "Modulo & Ovveride ansvarig");
            ListReferenceBased list = new ListReferenceBased();
            list.Add(0, person);
            list.Add(1, person2);
            bool check = list.IsEmpty();
            Console.WriteLine(check);
            int size = list.Size();
            Console.WriteLine(size);
            object node = list.Get(1);
            Console.WriteLine(node.ToString());
            object node2 = list.Get(2);
            Console.WriteLine(node2.ToString());

        }
    }
}