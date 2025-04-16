namespace GMI24H_Labb_4;

public class ListReferenceBased : ListInterface
{   
    
    private Node head;
    private int numItems;
    
    public void add(int index, object item)
    {
        
    }

    public object get(int index)
    {
        throw new NotImplementedException();
    }

    public bool isEmpty()
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

    public void remove(int index)
    {
        // if n == index
        // prev.next = curr.next;
        
    }

    public void removeAll()
    {
        head = null;
    }

    public int size()
    {
        return numItems;
    }
    
}