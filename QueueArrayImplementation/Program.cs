using System;

namespace QueueArrayImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue implementation using Array!");
            Console.WriteLine("---------------------------------");

            Queue q = new Queue(100);
            int option = 0;
            do { 
            Console.WriteLine("Enter the option 1 to Enqueue or 2 to Dequeue and 3 to quit!");
            option = int.Parse(Console.ReadLine());            
            switch (option) {
                case 1:
                    Console.WriteLine("Enter the item to enqueue");
                    int element = int.Parse(Console.ReadLine());
                    q.Enqueue(element);
                    Console.WriteLine();
                    break;
                case 2:
                    int dequeuedElement = q.Dequeue();
                        if (dequeuedElement != -1)
                        {
                            Console.WriteLine("Dequeud element is " + dequeuedElement);
                        }
                    break;
                default:
                    break;
            }
            } while (option != 3);
        }
    }
}
