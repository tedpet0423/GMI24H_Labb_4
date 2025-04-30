namespace GMI24H_Labb_4;

// I Node.cs definierar vi själva noden. Varje nod är en låda med ett värde och pekare vidare.
public class Node
{
    private Node _next;
    private Object _item;


    public Node(Node next, Object item)
    {
       _item = item;
       _next = next;
    }

    public Node GetNext()
    {
        return _next;
    }

    public void SetNext(Node next)
    {
        _next = next;
    }

    public Object GetItem()
    {
        return _item;
    }
}