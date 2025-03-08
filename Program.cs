namespace Reg_System
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Welcome to the school registration system");

            while (true)    
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Register as new student");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Exit");
                string choice= Console .ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterStudent(students);
                        break;
                    case "2":
                        ViewAllStudents(students);
                        break;
                    case "3":
                        Console.WriteLine("Exiting system");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Pleaaase try again");
                        break;
                }
               
            }
        }static void RegisterStudent(List<Student> students)
        {
            Console.WriteLine("\nEnter student name:");
            string name= Console .ReadLine();

            Console.WriteLine( "Enter student ID:");
            int studentId=int.Parse(Console .ReadLine());

            Console.WriteLine("Enter course name");
            string course= Console .ReadLine();

            Student student =new Student(name, studentId, course);
            students.Add(student);

            Console.WriteLine("student registered successfully!");

        }private static void ViewAllStudents(List<Student> students)
        {
            Console.WriteLine("\nlist of all registered students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
