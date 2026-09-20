
using Sandbox;

Console.WriteLine("Card picker game");

    Console.Write("Enter the number of cards to pick: ");

    string? line = Console.ReadLine();

if (int.TryParse(line, out int numCards))
{
    foreach (string card in CardPicker.PickSomeCards(numCards))
    {
        Console.WriteLine(card);
    }
}
else
{
    Console.WriteLine("Invalid input");
}
