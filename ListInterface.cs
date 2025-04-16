namespace GMI24H_Labb_4;

public interface ListInterface
{
    // public void createList();
    public void add(int index, Object item);
    public Object get(int index);
    public bool isEmpty();
    public void remove(int index);
    public void removeAll();
    public int size();

}