using System;
using System.Collections.Generic;


namespace LISPchecker
{
    class Program
    {
            Stack<char> charStack = new Stack<char>();
            char top;

        public bool checkParens(String s)
        {
            char[] arrVal = s.ToCharArray();
            
            //Console.WriteLine(GetLength(arrVal));
            foreach(char c in arrVal)
            {
                if(c.Equals('('))
                {
                    charStack.Push(c);
                    Console.WriteLine("Pushed: "+c);
             
                }
                else if(c.Equals(')'))
                {
                    if(charStack.Count == 0)
                    {
                        Console.WriteLine("Out of order");
                        return false;
                    }
                    top = charStack.Peek();                    
                    charStack.Pop();
                    Console.WriteLine("Popped: "+top);
                }

            }
        Console.WriteLine(charStack.Count == 0);
        return charStack.Count == 0;

        }
        static void Main(string[] args)
        {
// (list 1 2 (quote foo))
//)())
//()list 1 2 (quote foo)(9)()

            Console.Write("Enter LISP code: ");
            String val = Console.ReadLine();

            Program p = new Program();
            
            p.checkParens(val);


        }

    }
}
