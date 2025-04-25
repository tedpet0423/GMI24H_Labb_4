using System.Diagnostics.Contracts;

namespace GMI24H_Labb_4;

public class ListReferenceBased : ListInterface
{

    private Node _head = null!;
    private int _numItems;
    

    public void Add(int index, object item)
    {
        if ((index >= 1) && (index <= _numItems + 1))
        {
            if (index == 1)
            {
                _head = new Node(_head, item);
            }
            else
            {
                Node prev = Find(index - 1);
                Node newNode = new Node(prev.GetNext(), item);
                prev.SetNext(newNode);
            }
            _numItems++;
        }
        else
        {
            throw new ListIndexOutOfBoundsException();
        }

    }

    public Object Get(int index)
    {
        if ((index >= 1) && (index <= _numItems))
        {
            Node curr = Find(index);
            Object dataItem = curr.GetItem();
            return dataItem;
        }
        else
        {
            throw new ListIndexOutOfBoundsException();
        }


    }
    // lånat från kursrum, [ListReferenceBased].png
    private Node Find(int index)
    {
        Node curr = _head;
        for (int skip = 1; skip < index; skip++)
        {
            curr = curr.GetNext();
        }
        return curr;
    }

    // Metod som checkar om det finns element i listan, om head = Null så finns inga element i listan
    public bool IsEmpty()
    {
        if (_head == null)
        {
            return true;
        }

        return false;
    }

    public void Remove(int index)
    {
        // if n == index
        // prev.next = curr.next;
        if ((index >= 1) && (index <= _numItems))
        {
            Node prev = Find(index - 1);
            Node next = Find(index + 1);
            prev.SetNext(next);
            _numItems--;
        }
        else
        {
            throw new ListIndexOutOfBoundsException();
        }

    }

    public void RemoveAll()
    {
        _head = null;
        _numItems = 0;
    }

    public int Size()
    {
        return _numItems;
    }

}