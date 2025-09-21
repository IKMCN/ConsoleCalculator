bool keepRunning = true;
while (keepRunning)
{
    string operation = ShowMenu();
    if (operation == "q")
        keepRunning = false;
    else
        MenuLogic(operation);
}


string ShowMenu()
{
    string menuInput="";
    do
    {
        Console.WriteLine("Welcome to Calculator App");
        Console.WriteLine("Menu:");
        Console.WriteLine("====");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Division");
        Console.WriteLine("4. Multiplication");
        Console.WriteLine("q - to quit");
        menuInput = Console.ReadLine();
    } while (menuInput != "1" && menuInput != "2" && menuInput != "3" && menuInput != "4" && menuInput != "q");
    return menuInput;
}



void MenuLogic(string operation)
{


    switch (operation)
    {
        case "1":
            Console.WriteLine(Addition());
            
            break;
        case "2":
            Console.WriteLine(Subtraction());
            
            break;
        case "3":
            Console.WriteLine(Multiplication());
            
            break;
        case "4":
            Console.WriteLine(Division());
            
            break;
        default:
            Console.WriteLine("Invalid operation");
            
            break;
    }
}

int Division()
{
    int result, value1, value2;
    Console.WriteLine("Enter value1:");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter value2:");
    value2 = Convert.ToInt32(Console.ReadLine());
    result = value1 / value2;
    
    return result;
}

int Multiplication()
{
    int result, value1, value2;
    Console.WriteLine("Enter value1:");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter value2:");
    value2 = Convert.ToInt32(Console.ReadLine());
    result = value1 * value2;

    return result;
}

int Subtraction()
{
    int result, value1, value2;
    Console.WriteLine("Enter value1:");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter value2:");
    value2 = Convert.ToInt32(Console.ReadLine());
    result = value1 - value2;
   
    return result;
}

int Addition()
{
    int result, value1, value2;
    Console.WriteLine("Enter value1:");
    value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter value2:");
    value2 = Convert.ToInt32(Console.ReadLine());
    result = value1 + value2;
    return result;
}