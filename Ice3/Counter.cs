using System;

namespace Ice3;

public abstract class Counter
{
    public bool Occupied { get; set; } = false;
    private int timer { get; set; } = 0;
    public abstract int ProcessTime { get; }
    public List<string> History { get; set; } = new List<string>();
    public void Process()
    {
        if (Occupied)
        {
            timer--;
            if (timer == 0)
            {
                Occupied = false;
            }
        }
    }

    public void NextInLine(string type)
    {
        timer = ProcessTime;
        Occupied = true;
        History.Add(type);
    }
}
