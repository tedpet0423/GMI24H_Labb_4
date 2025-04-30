using System.Diagnostics;

namespace GMI24H_Labb_4;

public class ComparisonClass
{
    private ListReferenceBased _lList = new ListReferenceBased();
    private int[] _arr = new int[100];


    // tar tid och jämför LänkadLista vs Array
    public void CompareLlToArray()
    {
        MakeArr();
        MakeListLl();
        Stopwatch timer = new Stopwatch();
        TimeSpan timeSpan;

        timer.Start();
        AddStartLl();
        timer.Stop();
        timeSpan = timer.Elapsed;
        Console.WriteLine("Lägger till 100 värden i början av Länkad lista: " + timeSpan.TotalMicroseconds + " µs");
        timer.Reset();

        timer.Start();
        AddMidLl();
        timer.Stop();
        timeSpan = timer.Elapsed;
        Console.WriteLine("Lägger till 100 värden i mitten av Länkad lista: " + timeSpan.TotalMicroseconds + " µs");
        timer.Reset();

        timer.Start();
        AddEndLl();
        timer.Stop();
        timeSpan = timer.Elapsed;
        Console.WriteLine("Lägger till 100 värden i slutet av Länkad lista: " + timeSpan.TotalMicroseconds + " µs");
        timer.Reset();

        timer.Start();
        AddStartA();
        timer.Stop();
        timeSpan = timer.Elapsed;
        Console.WriteLine("Lägger till 100 värden i början av Array: " + timeSpan.TotalMicroseconds + " µs");
        timer.Reset();

        timer.Start();
        AddMidA();
        timer.Stop();
        timeSpan = timer.Elapsed;
        Console.WriteLine("Lägger till 100 värden i mitten av Array: " + timeSpan.TotalMicroseconds + " µs");
        timer.Reset();

        timer.Start();
        AddEndA();
        timer.Stop();
        timeSpan = timer.Elapsed;
        Console.WriteLine("Lägger till 100 värden i slutet av Array: " + timeSpan.TotalMicroseconds + " µs");


    }
    // fyller länkad lista med element
    private void MakeListLl()
    {
        for (int i = 1; i < 100; i++)
        {
            _lList.Add(i,i);
        }
    }
    // metod för att lägga till 100 element i början av en länkad lista
    private void AddStartLl()
    {
        for (int i = 1; i < 100; i++)
        {
            _lList.Add(1,i);
        }
    }
    // metod för att lägga till 100 element i mitten av en länkad lista
    private void AddMidLl()
    {
        for (int i = 1; i < 100; i++)
        {
            int size = _lList.Size() / 2;
            _lList.Add(size,i);
        }
    }
    // metod för att lägga till 100 element i slutet av en länkad lista
    private void AddEndLl()
    {
        for (int i = 0; i < 100; i++)
        {
            int size = _lList.Size();
            _lList.Add(size,i);
        }
    }
    // fyller en array  med värden
    private void MakeArr()
    {
        for (int i = 0; i < 100; i++)
        {
            int[] newArr = new int[100];
            _arr.CopyTo(newArr,0);
            newArr[_arr.Length-1] = i;
            _arr = newArr;

        }
    }

    // metod för att lägga till 100 element i början av en array
    private void AddStartA()
    {
        for (int i = 0; i < 100; i++)
        {
            int[] newArr = new int[_arr.Length+1];
            _arr.CopyTo(newArr,0);
            newArr[0] = i;
            _arr = newArr;

        }

    }

    // metod för att lägga till 100 element i mitten av en array
    private void AddMidA()
    {
        for (int i = 0; i < 100; i++)
        {
            int length = _arr.Length / 2;
            int[] newArr = new int[_arr.Length+1];
            _arr.CopyTo(newArr,0);
            newArr[length] = i;
            _arr = newArr;

        }

    }
    // metod för att lägga till 100 element i slutet av en array
    private void AddEndA()
    {
        for (int i = 0; i < 100; i++)
        {
            int[] newArr = new int[_arr.Length+1];
            _arr.CopyTo(newArr,0);
            newArr[_arr.Length] = i;
            _arr = newArr;

        }

    }
}