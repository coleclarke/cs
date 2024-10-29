Random ran = new Random();
int num = ran.Next(0,100);
Console.WriteLine("Guess a number: ");
int guess = Int32.Parse(Console.ReadLine());
static void yes(int guess, int num){
if(guess < num)
{
Console.WriteLine("Too low guess a higher number: ");
guess = Int32.Parse(Console.ReadLine());
}
else if(guess > num)
{
Console.WriteLine("Too high guess a lower number: ");
guess = Int32.Parse(Console.ReadLine());
}
if(guess != num){
yes(guess,num);
}
}
if(guess != num){
    yes(guess, num);
}
 Console.WriteLine("You win ");