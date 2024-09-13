Console.WriteLine(""" 
Fibonacci Calculator 

This program calculates the nth number in the Fibonacci sequence.
Enter -1 to exit

""");


while (true)
{
    Console.WriteLine("Enter a number: ");
    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Invalid input. Please enter an integer.");
        continue;
    }
    else
    {
        if (number < 0) break;
        Dictionary<int, int> memo = new Dictionary<int, int>();
        Console.Write("Answer: " + calculateFibonacci(number, memo));
        Console.WriteLine("\n\n");
    }


}



int calculateFibonacci(int seq, Dictionary<int, int> memo)
{
    if (seq <= 1) return seq;
    if (memo.ContainsKey(seq)) return memo[seq];

    memo[seq] = calculateFibonacci(seq - 1, memo) + calculateFibonacci(seq - 2, memo);
    return memo[seq];

}