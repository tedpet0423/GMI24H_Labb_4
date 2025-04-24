namespace GMI24H_Labb_4;

public class Node
{
    private Node _next;
    private Object _item;


    public Node(Node next, Object item)
    {
       _item = item;
       _next = next;
    }

    public Node getNext()
    {
        return _next;
    }

    public void setNext(Node next)
    {
        _next = next;
    }

    public Object getItem()
    {
        return _item;
    }
}