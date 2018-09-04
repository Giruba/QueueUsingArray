using System;
using System.Collections.Generic;
using System.Text;

namespace QueueArrayImplementation
{
    class Queue
    {
        private int[] array;
        private int front;
        private int rear;
        private int capacity;
        private int size;

        private Queue() { }

        public Queue(int size) {
            capacity = size;
            array = new int[size];
            front = 0;
            rear = 0;
        }

        private void displayQueue(int optional=0) {
            if (size == 0)
            {
                Console.WriteLine("Queue Contents:0");
            }
            else
            {
                Console.WriteLine("Queue Contents");
                Console.WriteLine("--------------");

                for (int i = optional; i < rear; i++)
                {
                    if (i == rear - 1)
                    {
                        Console.Write(array[i]);
                    }
                    else
                    {
                        Console.Write(array[i] + "->");
                    }
                }
            }

        }

        public void Enqueue(int element) {

            if (rear == capacity - 1)
            {
                Console.WriteLine("Queue is full!Cannot insert right now!");
            }
            else
            {
                array[rear++] = element;
                size++;
                displayQueue();
            }
        }


        public int Dequeue() {
            if (size == 0)
            {
                front = rear = 0;
                Console.WriteLine("Queue is empty! Cannot dequeue!");
                return -1;
            }
            size--;
            displayQueue(front+1);
            return array[front++];
        }
    }
}
