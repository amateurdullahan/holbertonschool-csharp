using System;

class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    public Type CheckType()
    {
        return (typeof(T));
    }

    public void Enqueue(T value)
    {
        if (count == 0)
        {
            head = new Node(value);
            tail = head;
        } else
        {
            tail.next = new Node(value);
            tail = tail.next;
        }
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = head.value;
        head = head.next;
        count--;
        return (value);
    }

    public class Node
    {
        public T value = default(T);
        public Node next;

        public Node (T newValue)
        {
            this.value = newValue;
        }
    }

    public int Count()
    {
        return (count);
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return (head.value);
    }
    
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }
    }
}
