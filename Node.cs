namespace GMI24H_Labb_4;

public class Node
{
    public Node Next { get; }

    public Object Item { get; }


    public Node(Node next, Object item)
    {
       Item = item;
       Next = next;
    }

}