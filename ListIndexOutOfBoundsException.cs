namespace GMI24H_Labb_4;

// klass för skräddarsydda exceptions

public class ListIndexOutOfBoundsException : Exception
{
    public ListIndexOutOfBoundsException()
    {

    }
    public ListIndexOutOfBoundsException(string message) : base(message)
    {

    }
    public ListIndexOutOfBoundsException(string message, Exception inner) : base(message, inner)
    {

    }
}