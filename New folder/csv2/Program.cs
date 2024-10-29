Console.WriteLine("Please enter your first name: ");
string Fname = Console.ReadLine();
Console.WriteLine("Please enter your last name: ");
string Lname = Console.ReadLine();
Console.WriteLine("Please enter your age: ");
string Age = Console.ReadLine();
Console.WriteLine("Please enter your Social Security Number");
string Soc = Console.ReadLine();

string csvw = Lname + ", " + Fname + ", " + Age + ", " + Soc + '\n';
string data;
string filePath = @"C:\Users\cole.clarke\Desktop\Sharpie C\REG c#\csv2\names.csv";

using (StreamReader reader = new StreamReader(filePath))
    {
        data = reader.ReadToEnd();
    }
using (StreamWriter writer = new StreamWriter(filePath))
    {
        csvw += data;
        writer.WriteLine(csvw);
    }