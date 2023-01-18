namespace InterfaceSegregation;

//In this class the Fax and PrintDuplex methods
//are not required but it is still implementing these two methods. This is
//violating the Interface Segregation Principle as we are forcing the class to implement
//two methods that they don’t require.
public class BasicPrinter : IPrinterTasks
{
    public void Print(string printContent)
    {
        Console.WriteLine("Print Done");
    }

    public void Scan(string scanContent)
    {
        Console.WriteLine("Scan content");
    }
}