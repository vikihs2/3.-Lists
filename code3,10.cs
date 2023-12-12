List <int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
list.RemoveAll(n => n < 0);
if (list.Count == 0)
{
    Console.WriteLine("Empty");
}
else
{
   Console.WriteLine(String.Join(" ", list));
}