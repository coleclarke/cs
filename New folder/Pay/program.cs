Console.WriteLine("How many hours:"); 
int hours = Int32.Parse(Console.ReadLine());
Console.WriteLine("How much per hour:"); 
int rate = Int32.Parse(Console.ReadLine());
double pay;
if(hours > 40){
    pay = (40 * rate) + ((hours - 40) * (rate * 1.5));
}
else{
    pay = hours * rate;
}
Console.WriteLine(pay);
