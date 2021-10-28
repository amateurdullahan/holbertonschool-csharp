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

    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }
        string concat = "";
        Node temp = head;
        while (temp != null)
        {
            concat += temp.value;
            if (typeof(T) == typeof(string))
            {
                concat += " ";
            }
            temp = temp.next;
        }
        return concat;
    }
}
