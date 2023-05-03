
class Student
{
    public string? Name { get; set; }
    public decimal[]? Marks { get; set; } = new decimal[5];
    public static decimal AverageMarks { get; set; }

    enum Options
    {
        Aggregate = 1,

        MinMark = 2,

        MaximumMark = 3,

        Grade = 4
    }    

    public decimal CalculateAverageMarks()
    {
        AverageMarks = Marks.Sum() / Marks.Length;

        return AverageMarks;
    }

    public string CalculateGrade(decimal marks) => marks switch
    {
        >90 => "A",
        >80 => "B",
        >70 => "C",
        <=70 => "D",
    };
    

    public static void Main(string[] args)
    {
        Student student1 = new Student();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n ====================== Welcome Students =======================");
        Console.ResetColor();
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.Write("\n Enter Student Name : ");
        student1.Name = Console.ReadLine();
        Console.Write("\n Enter Student Marks : \n");
        for(int i=0;i<5;i++)
        {
            Console.Write($"\n Subject {i+1} Mark = ");
            student1.Marks[i] = Convert.ToDecimal(Console.ReadLine());
        }
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n ===============================================================");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n ==================== Choose Your Choices ======================\n");
        Console.WriteLine(" 1. Displays the Name & Average marks.");
        Console.WriteLine(" 2. Displays the minimum marks of the student.");
        Console.WriteLine(" 3. Displays the maximum marks of the student.");
        Console.WriteLine(" 4. Displays grade. ");

        Console.Write("\n Make your choice : ");

        int choice;
        
        if(int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case (int)Options.Aggregate:
                    Console.WriteLine("\n Name : " + student1.Name);
                    Console.WriteLine(" Average Marks is : " + student1.CalculateAverageMarks());
                    break;
                case (int)Options.MinMark:
                    Console.WriteLine("\n Minimum marks is " + student1.Marks?.Min());
                    break;
                case (int)Options.MaximumMark:
                    Console.WriteLine("\n Maximum marks is " + student1.Marks?.Max());
                    break;
                case (int)Options.Grade:
                    Console.WriteLine("\n Grade is : " + student1.CalculateGrade(Student.AverageMarks));
                    break;
                default:
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Opps! Invalid Choice.");
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n [Error :] Wrong choice, only number are valid!");
        }

        
        Console.ResetColor ();  
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n ==================================================================");
        Console.WriteLine("\n Thank You Have A Nice Day !");
        Console.ResetColor();
        Console.Read();
    }

}