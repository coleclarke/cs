Console.WriteLine("Please enter your first number: ");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter your second number: ");
int num2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter your third number: ");
int num3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter your fourth number: ");
int num4 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter your fith number: ");
int num5 = Int32.Parse(Console.ReadLine());

bool sorted = false;
int temp;
int i = 0;
int[] bubble = [num1, num2, num3, num4, num5];
Console.WriteLine("[{0}]", string.Join(", ", bubble));
while (sorted != true){
    if (bubble[0] <= bubble[1] & bubble[1] <= bubble[2] & bubble[2] <= bubble[3] & bubble[3] <= bubble[4]){
        sorted = true;
    }
    else{
        if (bubble[0] > bubble[1]){
            temp = bubble[0];
            bubble[0] = bubble[1];
            bubble[1] = temp;
            i++;
            Console.WriteLine("[{0}]", string.Join(", ", bubble));
        }
        if (bubble[1] > bubble[2]){
            temp = bubble[1];
            bubble[1] = bubble[2];
            bubble[2] = temp;
            i++;
            Console.WriteLine("[{0}]", string.Join(", ", bubble));
        }
        if (bubble[2] > bubble[3]){
            temp = bubble[2];
            bubble[2] = bubble[3];
            bubble[3] = temp;
            i++;
            Console.WriteLine("[{0}]", string.Join(", ", bubble));
        }
        if (bubble[3] > bubble[4]){
            temp = bubble[3];
            bubble[3] = bubble[4];
            bubble[4] = temp;
            i++;
            Console.WriteLine("[{0}]", string.Join(", ", bubble));
        }
    
    }
}

Console.WriteLine("Sorted in " + i + " moves");
Console.WriteLine("[{0}]", string.Join(", ", bubble));