namespace GMI24H_Labb_4;

public class Node
{
    private Object _item;
    private Node _next;

    public Node(Node next, Object item )
    {
       _item = item;
        _next = next;
    }

}