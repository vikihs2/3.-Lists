int n = int.Parse(Console.ReadLine());
List<string> names = new List<string>();
for (int i = 0; i < n; i++)
{
    string currentProduct = Console.ReadLine();
    names.Add(currentProduct);
}
names.Sort();
for (int i = 0; i < names.Count; i++)
    Console.WriteLine($"{names[i]}");