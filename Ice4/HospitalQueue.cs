using System;

namespace Ice4;

public class HospitalQueue
{
    private List<Patient> queue = new List<Patient>();

    public void Add(string name, int priority)
    {
        for (int i = queue.Count; i >= 1; i--)
        {
            if (queue[i - 1].Priority <= priority)
            {
                queue.Insert(i, new Patient { Name = name, Priority = priority });
                return;
            }
        }
    }

    public Patient? Next()
    {
        if (queue.Count == 0) return null;
        Patient item = queue[0];
        queue.RemoveAt(0);
        return item;
    }
}
