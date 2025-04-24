namespace GMI24H_Labb_4;

public class ListReferenceBased : ListInterface
{

    private Node head;
    private int _numItems;

    public void Add(int index, object item)
    {
        if (index < 0 || index > _numItems)
        {
            throw new ListIndexOutOfBoundsException();
        }

        Node newNode = new Node(head, item);
        head = newNode;
        _numItems++;
    }

    public object Get(int index)
    {

        if (index < 0 || index > _numItems)
        {
            throw new ListIndexOutOfBoundsException();
        }
        Node target = Find(index);
        return target.Item;
    }

    // lånat från kursrum, [ListReferenceBased].png
    private Node Find(int index)
    {
        Node curr = head;
        for (int skip = 1; skip < index; skip++)
        {
            curr = curr.Next;
        }
        return curr;
    }


    public bool IsEmpty()
    {
        if (head == null)
        {
            return true;
        }

        return false;
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
        return _numItems;
    }

}