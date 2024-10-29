Console.WriteLine("Enter a number: ");

int num = Int32.Parse(Console.ReadLine());

num = num % 2;

if (num == 1)
{
    Console.WriteLine("The number is odd");
}
else
{
    Console.WriteLine("The number is even");
};