using System;

namespace Ice3;

public class CustomQueue<T>
{
    private List<T> queue = new List<T>();

    public void Add(T item)
    {
        queue.Add(item);
    }

    public T? Next()
    {
        if (queue.Count == 0) return default;
        T item = queue[0];
        queue.RemoveAt(0);
        return item;
    }

    public bool isEmpty()
    {
        return queue.Count == 0;
    }

    public T Peek()
    {
        return queue[0];
    }

    public void CreateNumOfObjects(T obj, int number)
    {
        for (int i = 0; i < number; i++)
        {
            queue.Add(obj);
        }
    }
}
