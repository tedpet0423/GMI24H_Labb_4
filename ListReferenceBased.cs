using System.Diagnostics.Contracts;

namespace GMI24H_Labb_4;

public class ListReferenceBased : IListInterface
{

    // definerar klassvariabler
    private Node _head = null!;
    private int _numItems;
    
// metod för operationen add. Vi tittar på om indexet är större eller lika med 1 eller om indexet ligger mellan 1 och värdet för _numItems, dvs listans storlek.
// Om inte kastas exception
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

    // Villkoren för våra operationer är densamma som innan. 
    // Är vi inom listan så hämtar vi objectet (datan) för noden.
    // annars kastas exception
    public Object Get(int index)
    {
        if ((index >= 1) && (index <= _numItems))
        {
            Node curr = Find(index);
            Object item = curr.GetItem();
            return item;
        }
        else
        {
            throw new ListIndexOutOfBoundsException();
        }


    }
    // lånat från kursrum,modifierat med exception [ListReferenceBased].png
    // Metod för att hitta nod på index med hantering av värden utanför listan.
    private Node Find(int index)
    {
        if ((index >= 0) && (index <= _numItems))
        {
            Node curr = _head;
            for (int skip = 1; skip < index; skip++)
            {
                curr = curr.GetNext();
            }

            return curr;
        }
        else
        {
            throw new ListIndexOutOfBoundsException();
        }
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

    // Samma grundvillkor som tidigare gäller även för Remove.
    // Vi flytar pekaren från det föregående nod till efterföjande nod
    public void Remove(int index)
    {
       
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

    // Metod för att ta bort alla noder ifrån listan genom att sätta _head till null och uppdatera _numItems
    public void RemoveAll()
    {
        _head = null;
        _numItems = 0;
    }
    
    // metoden för att returnera storleken på listan

    public int Size()
    {
        return _numItems;
    }

}