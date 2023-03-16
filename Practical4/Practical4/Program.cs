using System;
public class student
{
    public string Name;
    public decimal[] Marks = new decimal[] {90,90,90,90,80};
    static decimal AverageMarks;

    public decimal CalculateAverageMarks()
    {



        
        foreach (decimal i in Marks)
        {
            AverageMarks = AverageMarks + i;

        }
        AverageMarks = AverageMarks / Marks.Length;

        return AverageMarks;
        
    }
    public decimal min() { 
    
        return Marks.Min();
    }
    public decimal max() { 
    
        return Marks.Max();
    }
    
    public string ClaculateGarde()
    {

        //string[] grade=new string[5];
        string Grade;

        //int index = 0;

        switch (AverageMarks)
        {

            case > 90:
                Grade = "A";
                break;
            case > 80:
                Grade = "B";
                break;
            case > 70:
                Grade = "C";
                break;
            case > 60:
                Grade = "D";
                break;
            default:
                Grade = "F";
                break;



        }

        return Grade;

    }

    public enum Options
    {

        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4,
        Exit= 5
        
    }
    public static void Main()
    {

        //int op = (int)Options;
            bool iteration = true;
        string grade;
            int choice = 0;
        decimal Avgmarks;
        student objS= new student();    
        
        while (iteration) {


            Console.WriteLine("Press 1 For Aggregate");
            Console.WriteLine("Press 2 For Minimum Marks");
            Console.WriteLine("Press 3 For Maximum Marks");
            Console.WriteLine("Press 4 For Grade");
            Console.WriteLine("Press 5 For Exit");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
        {

            case (int)Options.Grade:
                    objS.CalculateAverageMarks();
                    grade =objS.ClaculateGarde();
                    
                Console.WriteLine($"Your  Average marks is {grade}"); 
                break;
            case (int)Options.Aggregate: 
                    Avgmarks=objS.CalculateAverageMarks();
                    Console.WriteLine($"Your  Average marks is {Avgmarks}"); 
                break;
            case (int)Options.MinMark:
                    Avgmarks=objS.min();
                    Console.WriteLine($"Your Minimum marks is {Avgmarks}"); 
                break;
            case (int)Options.MaximumMark: 
                    Avgmarks=objS.max();    
                    Console.WriteLine($"Your Minimum marks is {Avgmarks}"); 
                break;
            case (int)Options.Exit: 
                    iteration= false;   
                    Console.WriteLine("Thank you");
                    break;
            default:
                    Console.Clear();
                Console.WriteLine("Please Enter Between 1-5 Choices are given below");
                break;
        }
        }

    }




}



