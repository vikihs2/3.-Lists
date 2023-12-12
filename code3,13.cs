List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
while (true)
{ 
string input = Console.ReadLine();
    if (input == "End")
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
        case "Insert":
            int wagonsToIns = int.Parse(elements[1]);
            int indexToIns = int.Parse(elements[2]);
            wagons.Insert(indexToIns, wagonsToIns);
            break;
        case "Remove":
            int indexToRem = int.Parse(elements[1]);
            wagons.RemoveAt(indexToRem);
            break;
        case "Shift":
            int count = int.Parse(elements[2]);
            if (elements[1] == "left")
            {
                for (int i = 0; i < count % wagons.Count; i++)
                {
                    int first = wagons[0];
                    wagons.RemoveAt(0);
                    wagons.Add(first);
                }
            }
            else if (elements[1] == "right")
            {
                for (int i = 0; i < count % wagons.Count; i++)
                {
                    int last = wagons[wagons.Count - 1];
                    wagons.RemoveAt(wagons.Count - 1);
                    wagons.Insert(0, last);
               }
            }
            break;
    }
}
Console.WriteLine(String.Join(" ", wagons));