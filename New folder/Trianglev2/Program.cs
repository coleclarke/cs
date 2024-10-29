string triangle = "";
for (int i = 0; i < 13; i++){
    if(i <= 6){
        triangle = "";
        for (int t = 6; t > i; t--){
            triangle += "*";
        }
        Console.WriteLine(triangle);
    }
    else{
        triangle = "";
        for (int t = 6; t < i; t++){
            triangle += "*";
        }
        Console.WriteLine(triangle);
    }
}