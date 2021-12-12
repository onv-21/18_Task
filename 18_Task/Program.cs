
string s = "({][}(})]{)[";
char[] chars = s.ToCharArray();

foreach (char n in chars)
{
    Stack<char> myStack = new Stack<char>();
    switch (n)
    {
        case '(':
            myStack.Push(')');
            break;
        case '{':
            myStack.Push('}');
            break;
        case '[':
            myStack.Push(']');
            break;
        case ')':
            if (')' == myStack.Peek())
            {
                myStack.Pop();
            }

            break;
        case '}':
            if ('}' == myStack.Peek())
            {
                myStack.Pop();
            }
           
            break;
        case ']':
            if (']' == myStack.Peek())
            {
                myStack.Pop();
            }

            break;
    }
   
    Console.WriteLine(myStack);
}








