namespace ConsoleApp1;

public static class ConsoleEx
{
    private static void PrintLine(string message, ConsoleColor colorText)
    {
        Console.ForegroundColor = colorText;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintInfo(string message)
    {
        PrintLine(message, ConsoleColor.Blue);
    }

    public static void PrintTextCustomColor(string message, ConsoleColor colorText)
    {
        PrintLine(message, colorText);
    }
}