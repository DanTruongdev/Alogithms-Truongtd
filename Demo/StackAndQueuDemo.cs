using Algorithm.Objects;
namespace Algorithm.Demo
{
    public class StackAndQueuDemo
    {
        public void StackDemo()
        {
            Objects.Stack<int> stack = new Objects.Stack<int>();   
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            Console.WriteLine(stack.Get());
            Console.WriteLine(stack.Get());
            Console.WriteLine(stack.Get());
            Console.WriteLine(stack.Get());
            Console.WriteLine(stack.Get());
        }

        public void QueuDemo()
        {
            Objects.Queue<int> queu = new Objects.Queue<int>();
            queu.Push(1);
            queu.Push(2);
            queu.Push(3);
            queu.Push(4);
            queu.Push(5);
            queu.Push(6);
            queu.Push(7);
            queu.Push(8);
            queu.Push(9);
            queu.Push(10);
            Console.WriteLine(queu.Get());
            Console.WriteLine(queu.Get());
            Console.WriteLine(queu.Get());
            Console.WriteLine(queu.Get());
            Console.WriteLine(queu.Get());
        }
    }
}
