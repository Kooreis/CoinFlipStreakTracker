```CSharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int streak = 0;
        string lastFlip = "";

        while (true)
        {
            int flip = random.Next(0, 2);
            string result = flip == 0 ? "Heads" : "Tails";

            if (lastFlip == "")
            {
                lastFlip = result;
                streak = 1;
            }
            else if (lastFlip == result)
            {
                streak++;
            }
            else
            {
                Console.WriteLine("Streak of " + lastFlip + ": " + streak);
                lastFlip = result;
                streak = 1;
            }

            Console.WriteLine(result);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
```