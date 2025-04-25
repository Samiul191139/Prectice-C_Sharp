using System;

interface IFileOperations
{
    void ReadFile();
    void WriteFile();
}
abstract class FileHandler : IFileOperations
{
    public abstract void ReadFile();
    public abstract void WriteFile();
}
class CSVFileHandler : FileHandler
{
    public override void ReadFile()
    {
        Console.WriteLine("Reading data from CSV file...");
    }

    public override void WriteFile()
    {
        Console.WriteLine("Writing data to CSV file...");
    }
}
class XMLFileHandler : FileHandler
{
    public override void ReadFile()
    {
        Console.WriteLine("Reading data from XML file...");
    }

    public override void WriteFile()
    {
        Console.WriteLine("Writing data to XML file...");
    }

    public void ValidateSchema()
    {
        Console.WriteLine("Validating XML schema...");
    }
}

class FileManagementSystem
{
    static void Main()
    {
        Console.WriteLine("CSV File Operations:");
        CSVFileHandler csv = new CSVFileHandler();
        csv.ReadFile();
        csv.WriteFile();

        Console.WriteLine();

        Console.WriteLine("XML File Operations:");
        XMLFileHandler xml = new XMLFileHandler();
        xml.ReadFile();
        xml.WriteFile();
        xml.ValidateSchema();
    }
}
