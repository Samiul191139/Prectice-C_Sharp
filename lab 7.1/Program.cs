using System;

delegate string PrintMessage(string message);

class MessagePrinter
{
    public static string DisplayMessage(string message)
    {
        Console.WriteLine("Message: " + message);
        return message;
    }

    static void Main()
    {
        PrintMessage printer = DisplayMessage;
        printer("IDK what to write, Please help!");
    }
}
