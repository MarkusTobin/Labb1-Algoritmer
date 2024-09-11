Labb1();
static void Labb1()
{
    Console.WriteLine("Skriv in valfri sträng");
    string input = Console.ReadLine();
    UInt128 totalSum = 0;

    //string input = "29535123p48723487597645723645";

    for (int startIndex = 0; startIndex < input.Length; startIndex++)
    {
        if (char.IsDigit(input[startIndex]))
        {
            char startNumber = input[startIndex];
            for (int endIndex = startIndex + 1; endIndex < input.Length; endIndex++)
            {
                if (input[endIndex] == startNumber)
                {
                    bool onlyNumbers = true;
                    for (int i = startIndex + 1; i < endIndex; i++)
                    {
                        if (!char.IsDigit(input[i]))
                        {
                            onlyNumbers = false;
                            break;
                        }
                    }

                    if (onlyNumbers)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(input.Substring(0, startIndex));

                        Console.ForegroundColor = ConsoleColor.Red;
                        string redMarkedNumbers = (input.Substring(startIndex, endIndex - startIndex + 1));
                        Console.Write(redMarkedNumbers);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(input.Substring(endIndex + 1));

                        totalSum += UInt128.Parse(redMarkedNumbers);
                        break;
                    }
                }
            }
        }
    }
    Console.ResetColor();
    
    Console.WriteLine($"\n\nTotal sum of the highlighted numbers are:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(totalSum);
    Console.ResetColor();
}