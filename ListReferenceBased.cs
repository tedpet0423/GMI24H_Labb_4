namespace GMI24H_Labb_4;

public class ListReferenceBased : ListInterface
{

    private Node head;
    private int numItems;

    public void Add(int index, object item)
    {
        Node node = new Node(null, item);
        // fortsätta med något smart här...
    }

    public object Get(int index)
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        if (head == null)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void Remove(int index)
    {
        // if n == index
        // prev.next = curr.next;

    }

    public void RemoveAll()
    {
        head = null;
    }

    public int Size()
    {
        return numItems;
    }

}