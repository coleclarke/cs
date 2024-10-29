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
Random random = new Random();
bool sorted = false;
int n;
int pivot;
int[] quick = [num1, num2, num3, num4, num5];
Console.WriteLine("[{0}]", string.Join(", ", quick));

while(sorted != true){
    pivot = quick[4];
    n = 4;
    while(quick[0] > quick[1] | quick[1] > quick[2] | quick[2] > quick[3] | quick[3] > quick[4]){
        
        //moves the highest value to the right

        if(quick[0] > pivot){
            quick = [quick[1] , quick[2], quick[3], quick[4], quick[0]];
            Console.WriteLine("[{0}]", string.Join(", ", quick));
        }
        else if(quick[1] > pivot){
            quick = [quick[0], quick[2], quick[3], quick[4], quick[1]];
            Console.WriteLine("[{0}]", string.Join(", ", quick));
        }
        else if(quick[2] > pivot){
            quick = [quick[0], quick[1], quick[3], quick[4], quick[2]];
            Console.WriteLine("[{0}]", string.Join(", ", quick));
        }
        else if(quick[3] > pivot){
            quick = [quick[0], quick[1] , quick[2], quick[4], quick[3]];
            Console.WriteLine("[{0}]", string.Join(", ", quick));
        }
        else if(quick[4] > pivot){
            quick = [quick[0], quick[1] , quick[2], quick[3], quick[4]];
            Console.WriteLine("[{0}]", string.Join(", ", quick));
        }
        
        //checks if any spot is out of order

        if(quick[4] > quick[3] & quick[4] > quick[2] & quick[4] > quick[1] & quick[4] > quick[0]){
            if(quick[3] > quick[2] & quick[3] > quick[1] & quick[3] > quick[0]){
                if(quick[2] > quick[1] & quick[2] > quick[0]){
                    if(quick[1] > quick[0]){
                        sorted = true;
                    }
                    else{
                        n = 1;
                    }
                }
                else{
                    n = 2;
                }
            }
            else{
                n = 3;
            }
        }
        else{
            n = 4;
        }
        pivot = quick[n];
    }
}
Console.Write("\n \n \n");
Console.WriteLine("sorted");
Console.WriteLine("[{0}]", string.Join(", ", quick));