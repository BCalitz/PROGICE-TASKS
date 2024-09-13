using Ice4;

Console.WriteLine(""" 
Hospital Queue Simulator

This program simulates a hospital queue.
Enter a patients name and priority (higher the number -> higher the priority)

Enter next to go to the next patient
Enter q to exit

""");


HospitalQueue hospitalQueue = new HospitalQueue();

while (true)
{
    Console.WriteLine("Enter an Patient Name: ");
    string? name = Console.ReadLine();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Invalid input. Please enter an Name.\n\n");
        continue;
    }
    else if (name == "next")
    {
        Patient? patient = hospitalQueue.Next();
        if (patient == null)
        {
            Console.WriteLine("Where is everyone ...\n\n");
            continue;
        }
        else
        {
            Console.WriteLine($"{patient.Name} please come through.\n\n");
            continue;
        }
    }
    else if (name == "q") break;


    Console.WriteLine("Enter a Priority: ");
    if (!int.TryParse(Console.ReadLine(), out int priority))
    {
        Console.WriteLine("Invalid input. Please enter an integer.\n\n");
        continue;
    }


    hospitalQueue.Add(name, priority);
    Console.WriteLine($"{name} has been added to the queue.\n\n");
}
