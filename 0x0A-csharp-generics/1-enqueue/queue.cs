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

    public class Node
    {
        public T value = default(T);
        public Node next;

        public Node (T Value)
        {
            this.value = value;
        }
    }

    public int Count()
    {
        return (count);
    }
}
