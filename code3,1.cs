List <string> names = new List<string>();
names.Add("Jo");
names.Add("Peter");
names.Add("David");
foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine(String.Join(", ", names));