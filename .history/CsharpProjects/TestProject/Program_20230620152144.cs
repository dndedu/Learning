string currentLine = "";

for (int i = 1; i <= 100; i++)
{

    currentLine = "" + i;
    if (i % 3 == 0 && i % 5 == 0)
        currentLine += " - FizzBuzz";
    else if (i % 3 == 0)
        currentLine += " - Fizz";
    else if (i % 5 == 0)
        currentLine += " - Buzz";

    Console.WriteLine(currentLine);
}