namespace GMI24H_Labb_4;

public interface ListInterface
{
    // public void createList();
    public void Add(int index, Object item);
    public Object Get(int index);
    public bool IsEmpty();
    public void Remove(int index);
    public void RemoveAll();
    public int Size();

}