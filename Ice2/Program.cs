Console.WriteLine(""" 
Mock Browser

This program mocks a browser by allowing a user to enter an address and navigate back at will
Enter q to exit

""");

BrowserStack browserStack = new BrowserStack();
while (true)
{
    Console.WriteLine("Enter an Address: ");
    string? address = Console.ReadLine();
    if (string.IsNullOrEmpty(address))
    {
        Console.WriteLine("Invalid input. Please enter an address.\n\n");
        continue;
    }
    else
    {
        if (address == "q") break;
        if (address == "back")
        {
            if (browserStack.Count > 0)
            {
                browserStack.Back();
                Console.Write("Navigated To: " + browserStack.CurrentUrl);
                Console.WriteLine("\n\n");
                continue;
            }
            else
            {
                Console.WriteLine("Nothing to go back to.\n\n");
                continue;
            }
        }

        browserStack.Navigate(address);

        Console.Write("Navigated To: " + browserStack.CurrentUrl);
        Console.WriteLine("\n\n");
    }


}
