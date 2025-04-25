namespace GMI24H_Labb_4;

public class ComparisonClass
{
    private ListReferenceBased lList = new ListReferenceBased();
    private int[] arr = new [100]{};
    
    public void CompareLlToArray()
    {
        
        
    }

    private void MakeListLl()
    {
        for (int i = 0; i < 100; i++)
        {
            lList.Add(i,i);
        }
    }

    private void AddStartLl()
    {
        for (int i = 0; i < 100; i++)
        {
            lList.Add(1,i);
        }
    }

    private void AddMidLl()
    {
        for (int i = 0; i < 100; i++)
        {
            int size = lList.Size() / 2;
            lList.Add(size,i);
        }
    }

    private void AddEndLl()
    {
        for (int i = 0; i < 100; i++)
        {
            int size = lList.Size();
            lList.Add(size,i);
        }
    }

    private void makeArr()
    {
        for (int i = 0; i < 100; i++)
        {
            int[] newArr = new int[100];
            arr.CopyTo(newArr,0);
            newArr[arr.Length] = i;
            arr = newArr;

        }
    }

    private void AddStartA()
    {
        for (int i = 0; i < 100; i++)
        {
            int[] newArr = new int[arr.Length+1];
            arr.CopyTo(newArr,0);
            newArr[0] = i;
            arr = newArr;

        }
        
    }

    private void AddMidA()
    {
        for (int i = 0; i < 100; i++)
        {
            int length = arr.Length / 2;
            int[] newArr = new int[arr.Length+1];
            arr.CopyTo(newArr,0);
            newArr[length] = i;
            arr = newArr;

        }
        
    }

    private void AddEndA()
    {
        for (int i = 0; i < 100; i++)
        {
            int[] newArr = new int[arr.Length+1];
            arr.CopyTo(newArr,0);
            newArr[arr.Length] = i;
            arr = newArr;

        }
        
    }
}