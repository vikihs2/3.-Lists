List<int> examinedStudents = new List<int>();
string input = Console.ReadLine();
string[] groups = input.Split('|');
for (int i = groups.Length - 1; i >= 0; i--)
{
    string[] numbers = groups[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

    foreach (string number in numbers)
    {
        int studentNumber = int.Parse(number);
        examinedStudents.Add(studentNumber);
    }
}
foreach (int studentNumber in examinedStudents)
{
    Console.Write(studentNumber + " ");
}