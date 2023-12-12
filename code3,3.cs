string values = Console.ReadLine();
List<string> items = values.Split(' ').ToList();
List<int> nums = new List<int>();
for (int i = 0; i < items.Count; i++)
    nums.Add(int.Parse(items[i]));
chete list stojnosti ot 1 red example: 2 8 30 25 40 72 -2 44 56