namespace _50_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(); //First in first out FIFO

            queue.Enqueue("Eren");
            queue.Enqueue("Yaşar");
            queue.Enqueue("Mert");
            queue.Enqueue("Larissa");

            /*foreach (var item in queue) her bir item'ı görmek için for veya foreach loop kullanılabilir.
            {
                Console.WriteLine(item);
            }
            
            for (int i = 0; i < queue.Count; i++)
            {
                ConsoleWriteLine(queue.ElementAt(i));
            }

             */

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek()); //does not remove item from the queue just shows it
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("--------------------------");

            Stack<string> stack = new Stack<string>(); //Last in First out LIFO

            stack.Push("Eren");
            stack.Push("Murat");
            stack.Push("Mert");
            stack.Push("Larissa");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek()); //does not remove item from stack just shows it.
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}