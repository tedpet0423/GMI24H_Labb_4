namespace GMI24H_Labb_4;


// ListInterface definerar kontraktet för vår lista. Här specifierar vi vilka operationer som finns. 
public interface IListInterface
{
    public void Add(int index, Object item);
    public Object Get(int index);
    public bool IsEmpty();
    public void Remove(int index);
    public void RemoveAll();
    public int Size();

}
