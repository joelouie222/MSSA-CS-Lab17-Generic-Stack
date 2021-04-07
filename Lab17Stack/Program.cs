using System;

namespace Lab17Stack
{
   class Program
   {
      static void Main(string[] args)
      {

            IntStack tenInts = new IntStack(10);
            bool mt = tenInts.IsEmpty();  // true
            bool full = tenInts.IsFull(); // false

            tenInts.Push(123);
            mt   = tenInts.IsEmpty(); // false
            full = tenInts.IsFull (); // false

            tenInts.Push(456);
            tenInts.Push(-1);

            int v1 = tenInts.Pop(); // -1
            int v2 = tenInts.Pop(); // 456
            tenInts.Pop();

            tenInts.Push(789);
            tenInts.Push(111);
            tenInts.Push(222);
            tenInts.Push(333);
            tenInts.Push(444);
            tenInts.Push(555);
            tenInts.Push(666);
            tenInts.Push(777);
            full = tenInts.IsFull(); // false

            tenInts.Push(888);
            full = tenInts.IsFull(); // true

            tenInts.Push(789);
            tenInts.Push(789);

            //String Stack
            StringStack reverseString = new StringStack(10);
            reverseString.Push("The ");
            reverseString.Push("car ");
            reverseString.Push("is ");
            reverseString.Push("a ");
            reverseString.Push("racecar ");
            reverseString.Push("!");
            Console.Write(reverseString.Pop());
            Console.Write(reverseString.Pop());
            Console.Write(reverseString.Pop());
            Console.Write(reverseString.Pop());
            Console.Write(reverseString.Pop());
            Console.Write(reverseString.Pop());

            //CharStack
            CharStack helloWorld = new CharStack(11);
            helloWorld.Push('H');
            helloWorld.Push('e');
            helloWorld.Push('l');
            helloWorld.Push('l');
            helloWorld.Push('o');
            helloWorld.Push(' ');
            helloWorld.Push('W');
            helloWorld.Push('o');
            helloWorld.Push('r');
            helloWorld.Push('l');
            helloWorld.Push('d');
            Console.WriteLine();
            while (!helloWorld.IsEmpty())
                Console.Write(helloWorld.Pop());


            //GenericStack
            Stack<double> newStack = new Stack<double>(5);
            newStack.Push(2.15485489);
            newStack.Push(3.34741);
            newStack.Push(1.43);
            newStack.Pop();
            Console.WriteLine();
            while (!newStack.IsEmpty())
                Console.WriteLine(newStack.Pop());


            Console.WriteLine();
        }
   }
}
