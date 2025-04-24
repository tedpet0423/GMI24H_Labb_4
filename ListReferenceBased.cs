using System.Diagnostics.Contracts;

namespace GMI24H_Labb_4;

public class ListReferenceBased : ListInterface
{

    private Node head;
    private int _numItems;

    public void Add(int index, object item)
    {
        if (index < 0 || index > _numItems)
        {
            throw new ListIndexOutOfBoundsException("Index out of bounds");
        }

        if(_numItems == 0)
        {
            Node newNode = new Node(head, item);
            head = newNode;
            _numItems++;
            Console.WriteLine("String zero");
        }
        else
        {
            Node curr = head;
            for(int i = 0; i < index; i++)
            {
                curr = curr.Next;
            }
            Node newNode = new Node(curr, item);
            curr.Next = newNode;
        }
    }

    /* lägger in funktionalitet nedan som vi tittar på tillsammans

    public void Add(int index, object item)
    {
        if (index < 0 || index >= _numItems)
        {
            throw new ListIndexOutOfBoundsException("Index out of bounds");
        }
        if (index == 0)
            AddAtStartOfList(item);

        else if(index == _numItems)
        {
            AddAtEndOfList(item);
        }

        else
        {
            AddAfterGivenNode(index, item);
        }
    }

    public void AddAtStartOfList(object item)
    {
        // skapar upp en ny som pekar på gamla head
        head = new Node(head, item);
        _numItems++;
    }

    public void AddAtEndOfList(object item)
    {
        if (head == null)
        {
            head = new Node(null, item);
        }
        else
        {
            Node curr = head;
            // hittar den sistar noden
            while(curr.Next != null)
            {
                curr = curr.Next;
                curr.Next = new Node(null, item);
            }
        }
        _numItems++;
    }

    public void AddAfterGivenNode(int index, object item)
    {
        if (index < 0 || index >= _numItems)
        {
            throw new ListIndexOutOfBoundsException("Index out of bounds");
        }

        // Använder oss av find(index) för at hitta noden där vi ska lägga till efter.
        Node curr = Find(index);

        // Skapar upp en ny nod som pekar mot curr.Next
        Node newNode = new Node(curr.Next, item);

        // Vi pekar sedan curr till den nya noden
        curr.Next = newNode;

        _numItems++;
    }

*/

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