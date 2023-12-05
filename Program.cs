var todos = new List<string>();
Console.Title = "TODO List";
Console.WriteLine("TODO List");
Console.WriteLine();
Console.WriteLine("Hello!");

bool exit = false;
while(!exit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine()?.ToUpper();
    switch (userInput)
    {
        case "S":
            SeeAllTodos();
            break;
        case "A":
            AddTodo();
            break;
        case "R":
            RemoveTodo();
            break;
        case "E":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
    Console.Clear();
}
Console.WriteLine("Goodbye!");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

void AddTodo()
{
    bool isValidDescription = false;
    while(!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description:");
        var description = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("The description cannot be empty. Please try again.");
        }
        else if(todos.Contains(description))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            isValidDescription = true;
            todos.Add(description);
            Console.WriteLine($"TODO successfully added: {description}");
        }
    }
    HoldScreen();
}

void RemoveTodo()
{
    Console.WriteLine("Enter the index of the TODO to remove:");
    if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= todos.Count)
    {
        string removedTodo = todos[index - 1];
        todos.RemoveAt(index - 1);
        Console.WriteLine($"TODO '{removedTodo}' removed successfully.");
    }
    else
    {
        Console.WriteLine("Invalid index. Please try again.");
    }
    HoldScreen();
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    Console.WriteLine("No TODOs have been added yet.");
    string result = "";
    for (int i = 0; i < todos.Count; i++)
    {
        result += $"{(i + 1)}. {todos[i]}\n";
    }
    Console.WriteLine(result);
    HoldScreen();
}

void HoldScreen()
{
    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

// class Program
// {
//     static List<string> todos = new List<string>();

//     static void Main(string[] args)
//     {
//         Console.Title = "TODO List";
//         Console.WriteLine("TODO List");
//         Console.WriteLine();
//         Console.WriteLine("Hello!");
//         PrintOptions();
//         HandleUserInput();
//     }

    

//     static void PrintOptions()
//     {
//         Console.WriteLine("What do you want to do?");
//         Console.WriteLine("[S]ee all TODOs");
//         Console.WriteLine("[A]dd a TODO");
//         Console.WriteLine("[R]emove a TODO");
//         Console.WriteLine("[E]xit");
//     }
//     static void HandleUserInput()
//     {
//         string input = Console.ReadLine()!.ToUpper();
//         string output = input switch
//             {
//                 "S" => SeeAllTodos(),
//                 "A" => AddTodo(),
//                 "R" => RemoveTodo(),
//                 "E" => Exit(),
//                 _ => "Invalid option. Please try again."
//             };

//             Console.WriteLine(output);
//             PrintOptions();
//             HandleUserInput();
//     }

//     static string SeeAllTodos()
//     {
//         if (todos.Count == 0)
//         {
//             return "No TODOs have been added yet.";
//         }
//         string result = "";
//         for (int i = 0; i < todos.Count; i++)
//         {
//             result += $"{(i + 1)}. {todos[i]}\n";
//         }
//         return result;
//     }

//     static string AddTodo()
//     {
//         throw new NotImplementedException();
//     }

//     static string RemoveTodo()
//     {
//         throw new NotImplementedException();
//     }

//     static string Exit()
//     {
//         throw new NotImplementedException();
//     }
// }