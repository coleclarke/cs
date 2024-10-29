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
int low;
int[] select = [num1, num2, num3, num4, num5];
int[] select2 = [num1, num2, num3, num4, num5];
Console.WriteLine("[{0}]", string.Join(", ", select));
while (sorted != true){
    if (select[0] <= select[1] & select[1] <= select[2] & select[2] <= select[3] & select[3] <= select[4]){
        sorted = true;
    }
    else{

        //The Painful sorting of the first number

        if(select[0] < select[1]){
            if(select[0] < select[2]){
                if(select[0] < select[3]){
                    if(select[0] < select[4]){
                        
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
                else{
                    if(select[3] < select[4]){
                        low = select[3];
                        select[3] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
            }
            else{
                if(select[2] < select[3]){
                    if(select[2] < select[4]){
                        low = select[2];
                        select[2] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
                else{
                    if(select[3] < select[4]){
                        low = select[3];
                        select[3] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
            }
        }

        // if the first number is higher than the second 

        else{
            if(select[1] < select[2]){
                if(select[1] < select[3]){
                    if(select[1] < select[4]){
                        low = select[1];
                        select[1] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
                else{
                    if(select[3] < select[4]){
                        low = select[3];
                        select[3] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    } 
                }
            }
            else{
                if(select[2] < select[3]){
                    if(select[2] < select[4]){
                        low = select[2];
                        select[2] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
                else{
                    if(select[3] < select[4]){
                        low = select[3];
                        select[3] = select[0];
                        select[0] = low;
                    }
                    else{
                        low = select[4];
                        select[4] = select[0];
                        select[0] = low;
                    }
                }
            }
        }
        Console.WriteLine("[{0}]", string.Join(", ", select));

        //Sorting to get the second number

        if(select[1] < select[2]){
            if(select[1] < select[3]){
                if(select[1] < select[4]){
                }
                else{
                    low = select[4];
                    select[4] = select[1];
                    select[1] = low;
                }
            }
            else{
                if(select[3] < select[4]){
                    low = select[3];
                    select[3] = select[1];
                    select[1] = low;
                }
                else{
                    low = select[4];
                    select[4] = select[1];
                    select[1] = low;
                } 
            }
        }

        //if the second number is higher than the third

        else{
            if(select[2] < select[3]){
                if(select[2] < select[4]){
                    low = select[2];
                    select[2] = select[1];
                    select[1] = low;
                }
                else{
                    low = select[4];
                    select[4] = select[1];
                    select[1] = low;
                }
            }
            else{
                if(select[3] < select[4]){
                    low = select[3];
                    select[3] = select[1];
                    select[1] = low;
                }
                else{
                    low = select[4];
                    select[4] = select[1];
                    select[1] = low;
                }
            }
        }
        Console.WriteLine("[{0}]", string.Join(", ", select));

        //sorting the third number

        if(select[2] < select[3]){
            if(select[2] < select[4]){
            }
            else{
                low = select[4];
                select[4] = select[2];
                select[2] = low;
            }
        }

        //if the third number is higher than the fourth

        else{
            if(select[3] < select[4]){
                low = select[3];
                select[3] = select[2];
                select[2] = low;
            }
            else{
                low = select[4];
                select[4] = select[2];
                select[2] = low;
            }
        }
        Console.WriteLine("[{0}]", string.Join(", ", select));

        //Sort the last two number

        if(select[3] < select[4]){
        }
        else{
            low = select[4];
            select[4] = select[3];
            select[3] = low;
        }
        Console.WriteLine(" ");
        Console.WriteLine("[{0}]", string.Join(", ", select));
        select2[0] = select[4]; select2[1] = select[3]; select2[2] = select[2]; select2[3] = select[1]; select2[4] = select[0];
        Console.WriteLine("[{0}]", string.Join(", ", select2));
        sorted = true;
    }
}
Console.WriteLine("Sorted");