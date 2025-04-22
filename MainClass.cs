namespace GMI24H_Labb_4
{

    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person("ted", 0423, "certified Felkod 60");
            ListReferenceBased list = new ListReferenceBased();
            list.Add(1, person);

        }
    }
}