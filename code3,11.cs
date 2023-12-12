List <int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCap = int.Parse(Console.ReadLine());
while (true)
{ 
string input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }
    string[] elements = input.Split();
    string command = elements[0];
    switch (command)
    {
        case "Add":
            int wagonsToAdd = int.Parse(elements[1]);
            wagons.Add(wagonsToAdd);
            break;
        default:
            int passToPlace = int.Parse(command);
            for (int i = 0; i < wagons.Count; i++)
            { 
            int availableSPace = maxCap - wagons[i];
                if (availableSPace >= passToPlace)
                {
                    wagons[i] += passToPlace;
                    break;
                }
            }
            break;
    }
}
Console.WriteLine(String.Join(" ", wagons));