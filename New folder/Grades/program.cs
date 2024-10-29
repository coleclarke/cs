static string name(){
    Console.WriteLine("Please enter the students name:");
    string Fname2 = Console.ReadLine();
    return Fname2;
}
static int[] grades(){
Console.WriteLine("Please enter Grade 1/5:");
int grade1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter Grade 2/5:");
int grade2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter Grade 3/5:");
int grade3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter Grade 4/5:");
int grade4 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter Grade 5/5:");
int grade5 = Int32.Parse(Console.ReadLine());
int[] gradeAra = [grade1, grade2, grade3, grade4, grade5];
return gradeAra;
}
static int gradeaverage(int[] grade){
int gradeav = (grade[0] + grade[1] + grade[2] + grade[3] + grade[4]) / 5;
return gradeav;
}
static string Lgrade(int gradeav){
string ltgrade;
if (gradeav >= 90){
     ltgrade = "A";
}
else if (gradeav >= 80){
     ltgrade = "B";
}
else if (gradeav >= 70){
     ltgrade = "C";
}
else if (gradeav >= 60){
     ltgrade = "D";
}
else{
     ltgrade = "F";
}
return ltgrade;
}
static void final(string Fname, int gradeav, string lettergrade){
Console.WriteLine(Fname + "'s Grade average is " + gradeav + " which is a " + lettergrade);
};
string Fname = name();
int[] grade = grades();
int gradeav = gradeaverage(grade);
string lettergrade = Lgrade(gradeav);
final(Fname, gradeav, lettergrade);