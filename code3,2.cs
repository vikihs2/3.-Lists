int n = int.Parse(Console.ReadLine()); //kolko elementa shte ima
List<int> list = new List<int>(); // suzdava list
for (int i = 0; i < n; i++) // ne spira dokato ne stigne do n chisla
{
    int number = int.Parse(Console.ReadLine()); // chete samite elementi koito sa n na broj
    list.Add(number); // dobavq gi v lista
}