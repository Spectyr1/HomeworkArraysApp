

string[] names = new string[] { "Tim", "John", "Sue" };
int selection;
bool validNum;

do
{
    Console.Write("Please choose a number from 1 to 3: ");
    string? selectionText = Console.ReadLine();
    validNum = Int32.TryParse(selectionText, out selection);

    if (selection < 1 || selection > 3)
    {
        Console.WriteLine("You have entered an invalid option. Please try again.");
        validNum = false;
    }

} while (validNum != true);

Console.WriteLine($"You have chosen {names[selection - 1]}");