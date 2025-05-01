namespace GMI24H_Labb_4;


public class StackClass
{
    public void CountParenthesis(int n)
    {
        string[] inputs = new string[]
        {
            "(a(b(x)c*d(e)f)(g+h(i*(j)k)))",
            "(a(b(c)d)e)",
            "((a+b)",
            "a+b)",
            "(x)",
            "a*(b+c)-d/(e+f))"
        };

        Console.Clear();
        Console.WriteLine("{0,-40} {1}", "Input", "Result");
        Console.WriteLine(new string('-', 55));

        if (n == 1)
        {
            foreach (string input in inputs)
            {
                string result = CheckParenthesisStack(input) ? "Parenthesis is correct" : "Parenthesis is not correct";
                Console.WriteLine("{0,-40} {1}", input, result);
            }
        }

        else if (n == 2)
        {
            foreach (string input in inputs)
            {
                string result = CheckParenthesisLl(input) ? "Parenthesis is correct" : "Parenthesis is not correct";
                Console.WriteLine("{0,-40} {1}", input, result);
            }
        }
        else
        {
            throw new Exception("Invalid input mister");
        }
        
    }
    private bool CheckParenthesisStack(string input)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in input)
        {
            
            if (c == '(')
            { 
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                stack.Pop();
            }
        }
        if (stack.Count == 0)
        {
            return true;
        }
        return false;
    }

    private bool CheckParenthesisLl(string input)
    {
        ListReferenceBased _lList = new ListReferenceBased();

        foreach (char c in input)
        {
            if (c == '(')
            {
                _lList.Add(1, c); 
            }
            else if (c == ')')
            {
                if (_lList.IsEmpty())
                {
                    return false; 
                }

                _lList.Remove(1); 
            }
        }
        return _lList.IsEmpty();
    }

}