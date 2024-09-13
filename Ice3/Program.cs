using Ice3;

const int ECONOMY_PEOPLE = 100;
const int BUSINESS_PEOPLE = 20;

CustomQueue<string> economyQueue = new CustomQueue<string>();
CustomQueue<string> businessQueue = new CustomQueue<string>();

economyQueue.CreateNumOfObjects("Economy", ECONOMY_PEOPLE);
businessQueue.CreateNumOfObjects("Business", BUSINESS_PEOPLE);

List<Counter> counters = [
    new EconomyCounter(),
    new EconomyCounter(),
    new EconomyCounter(),
    new EconomyCounter(),
    new EconomyCounter(),
    new BusinessCounter(),
    new BusinessCounter(),
    new BusinessCounter(),
    new BusinessCounter(),
    new BusinessCounter(),
    ];


while (!economyQueue.isEmpty() || !businessQueue.isEmpty())
{
    foreach (Counter counter in counters)
    {
        if (counter.Occupied == false)
        {
            string? person = null;
            if (counter.GetType() == typeof(BusinessCounter))
            {
                if (!businessQueue.isEmpty())
                {
                    person = businessQueue.Next();
                }
            }
            // if (counter.GetType() == typeof(EconomyCounter))
            // {
            //     if (!economyQueue.isEmpty())
            //     {
            //         person = economyQueue.Next();
            //     }
            // }

            if (person == null)
            {
                person = economyQueue.Next();
            }

            if (person != null)
            {
                counter.NextInLine(person);
            }
        }

        counter.Process();
    }
}
int TotalTime = 0;
for (int i = 0; i < counters.Count; i++)
{
    Console.WriteLine("Counter " + i + ": " + counters[i].GetType());
    Console.WriteLine("Processed: " + counters[i].History.Count);
    TotalTime += counters[i].History.Count * counters[i].ProcessTime;
}

Console.WriteLine("Total Time: " + TotalTime);