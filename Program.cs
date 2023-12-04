using System;
using TeacherandStudent_salaryAndMarks;
public class Program
{
    public static void Main()
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher{Name="Abdus sattar",Id="11",Department="CSE",Faculty="FSIT",Age=45,Email="sattar.cse@diu.bd",Basic_Salary=80000,Designation="senior lectuer"},
            new Teacher{Name="John Doe", Id="22", Department="Math", Faculty="FSIT", Age=35, Email="john.doe@diu.bd", Basic_Salary=75000, Designation="lecturer"},
            new Teacher{Name="Alice Smith", Id="33", Department="Physics", Faculty="FSNS", Age=40, Email="alice.smith@diu.bd", Basic_Salary=82000, Designation="assistant professor"},
            new Teacher{Name="Bob Johnson", Id="44", Department="Chemistry", Faculty="FSNS", Age=38, Email="bob.johnson@diu.bd", Basic_Salary=78000, Designation="lecturer"},
            new Teacher{Name="Eva Williams", Id="55", Department="Biology", Faculty="FSNS", Age=42, Email="eva.williams@diu.bd", Basic_Salary=81000, Designation="senior lecturer"},
            new Teacher{Name="Mark Taylor", Id="66", Department="ECE", Faculty="FET", Age=37, Email="mark.taylor@diu.bd", Basic_Salary=79000, Designation="assistant professor"}
        };

        List<Student> students = new List<Student>
        {
            new Student{Name="Mafuj ahammad",Id="1",Department="CSE",Faculty="FSIT",CGPA=3.55,credit=139,Email=",mafuj@diu.edu.bd",Semester=11,},
            new Student{Name="Sarah Johnson", Id="2", Department="Electrical Eng.", Faculty="FET", CGPA=3.75, credit=120, Email="sarah@diu.edu.bd", Semester=10},
            new Student{Name="Alex Smith", Id="3", Department="Mechanical Eng.", Faculty="FET", CGPA=3.60, credit=130, Email="alex@diu.edu.bd", Semester=12},
            new Student{Name="Emily Davis", Id="4", Department="Civil Eng.", Faculty="FET", CGPA=3.80, credit=125, Email="emily@diu.edu.bd", Semester=9},
            new Student{Name="Daniel Brown", Id="5", Department="Business Admin.", Faculty="FBE", CGPA=3.90, credit=150, Email="daniel@diu.edu.bd", Semester=8},
            new Student{Name="Lily Martinez", Id="6", Department="Economics", Faculty="FBE", CGPA=3.65, credit=135, Email="lily@diu.edu.bd", Semester=11}
        };

        List<employe> employes = new List<employe>
        {
            new employe{Name="amin",Id="0",Designation="Receptionis",job_location="Asulia",Email="amin@yahoo.com",
                Basic_Salary=15000,Age=27 },
            new employe{Name="Sara", Id="1", Designation="Software Engineer", job_location="Dhaka", Email="sara@gmail.com", Basic_Salary=60000, Age=30},
            new employe{Name="John", Id="2", Designation="Accountant", job_location="Chittagong", Email="john@outlook.com", Basic_Salary=45000, Age=35},
            new employe{Name="Emily", Id="3", Designation="HR Manager", job_location="Khulna", Email="emily@hotmail.com", Basic_Salary=55000, Age=32},
            new employe{Name="Mike", Id="4", Designation="Marketing Executive", job_location="Rajshahi", Email="mike@diu.edu.bd", Basic_Salary=50000, Age=28},
            new employe{Name="Lily", Id="5", Designation="Graphic Designer", job_location="Barisal", Email="lily@gmail.com", Basic_Salary=48000, Age=25}
        };

        PrintMenu();

        int n= Convert.ToInt32( Console.ReadLine() );
        if (n==1)
        {
            foreach (var info in employes)
            {
                Console.WriteLine($"Name:{info.Name},Id:{info.Id},Email:{info.Email}");
                Console.WriteLine($"Designation:{info.Designation}");
                Console.WriteLine($"Basic Salary is:{info.Basic_Salary}");
                Console.WriteLine($"Total salary is:{info.Salary()}");
            }
        }
        else if (n==2)
        {
            foreach (var info in teachers)
            {
                Console.WriteLine($"Name:{info.Name},Id:{info.Id},Department:{info.Department},Email:{info.Email}");
                Console.WriteLine($"Designation:{info.Designation}");
                Console.WriteLine($"Basic Salary is:{info.Basic_Salary}");
                Console.WriteLine($"Total salary is:{info.Salary()}");
            }
        }
        else if (n==3)
        {
            foreach (var info in students)
            {
                Console.WriteLine($"Name:{info.Name},Id:{info.Id},Department:{info.Department},Email:{info.Email}");
                Console.WriteLine($"Designation:{info.Designation}");
            }
        }
    }

    public static void PrintMenu()
    {
        Console.WriteLine("Enter a number to select from teacher,Employe and student:");
        Console.WriteLine("1.Teacher.");
        Console.WriteLine("2.employe.");
        Console.WriteLine("3.Student");
    }
}