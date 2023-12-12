List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int originalLength = numbers.Count;
for (int i = 0; i < originalLength / 2; i++)
{
    numbers[i] += numbers[numbers.Count - 1]; //sabira dadeniq element i s posledniq element i suhranqva otg v promenlivata numbers
    numbers.RemoveAt(numbers.Count - 1); // maha posledniq element za da se produlji smqtaneto
}
Console.WriteLine(string.Join(" ", numbers)); // otpechatva spetnatoto