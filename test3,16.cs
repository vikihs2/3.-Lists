int totalStudents = int.Parse(Console.ReadLine());
List<string> missingStudents = new List<string>();
for (int i = 0; i < totalStudents; i++)
{
    string input = Console.ReadLine();
    string[] inputParts = input.Split(' ');
    string name = inputParts[0];
    string action = inputParts[2];
    if (action == "is")
    {
        if (missingStudents.Contains(name))
        {
            missingStudents.Remove(name);
            Console.WriteLine($"{name} is in class!");
        }
    }
    else if (action == "not")
    {
        if (missingStudents.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            missingStudents.Add(name);
        }
    }
}
foreach (string student in missingStudents)
{
    Console.WriteLine(student);
}