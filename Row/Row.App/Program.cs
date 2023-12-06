using RowData;

LineOfPeople lineOfPeople = new LineOfPeople();

System.Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
System.Console.WriteLine("1) Add a person to the line");
System.Console.WriteLine("2) Print the line");
System.Console.WriteLine("3) Clear the line");  
System.Console.WriteLine("4) Exit");
System.Console.WriteLine();

while(true)
{
    System.Console.Write("Your choice: ");

    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D1:
            AddPersonToLine();
            break;

        case ConsoleKey.D2:
            PrintTheLine();
            break;

        case ConsoleKey.D3:
            ClearTheLine();
            break;

        case ConsoleKey.D4:
            return;

        default:
            PrintInputError();
            break;
    }

    System.Console.WriteLine();
}

void AddPersonToLine()
{
    System.Console.WriteLine("\n");

    Person person = new Person();

    System.Console.Write("First name: ");
    person.firstName = Console.ReadLine();

    System.Console.Write("Last name: ");
    person.lastName = Console.ReadLine();

    System.Console.Write("Height: ");
    person.height = GetNumber();

    lineOfPeople.AddToFront(person);
}

void PrintTheLine()
{
    System.Console.WriteLine("\n");

    Node? node = lineOfPeople.firstNode;
    bool printed = false;

    while(true)
    {
        if (node != null)
        {
            System.Console.WriteLine(node.person!.ToString());
            node = node.nextNode;
            printed = true;
        }
        else
        {
            if (!printed)
                System.Console.WriteLine("The line is empty");
                
            return;
        }
    }
}

void ClearTheLine()
{
    System.Console.WriteLine("\n");
    
    lineOfPeople.Clear();
    System.Console.WriteLine("The line has been cleared.");
}

int GetNumber()
{
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
            return number;
        else
            PrintInputError();
    }   
}

void PrintInputError()
{
    System.Console.Write("Invalid input! Try again: ");
}