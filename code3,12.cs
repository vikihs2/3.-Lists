List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
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
        case "Delete":
            int wagonsToDel = int.Parse(elements[1]);
            wagons.RemoveAll(item => item == wagonsToDel);
            break;
        case "Insert":
            int wagonsToIns = int.Parse(elements[1]);
            int indexToIns = int.Parse(elements[2]);
            wagons.Insert(indexToIns, wagonsToIns);
            break;
    }
}
Console.WriteLine(String.Join(" ", wagons));